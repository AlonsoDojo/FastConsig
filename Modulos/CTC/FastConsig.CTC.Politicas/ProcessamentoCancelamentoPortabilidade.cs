using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.ACTC900;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.CTC.Politicas
{
   public class ProcessamentoCancelamentoPortabilidade : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {

         /*Busca as Informações Necessárias para a Geração do Arquivo*/
         CTC.Model.ACTC900.ACTC900 arquivo = new Model.ACTC900.ACTC900();
         CTCDominioArquivo dominio = CTCService.GetInstance().BuscarArquivosDominio("ACTC900");

         ACTC900 aCTC900 = new ACTC900();

         string nomeArquivo = CTCService.GetInstance().GeraNomeArquivo("ACTC900", requisicao.DataCancelamento.Value.Date);

         CTCArquivos arquivoCTC = new CTCArquivos()
         {
            DataReferencia = requisicao.DataCancelamento.Value.Date,
            DataEntrada = DateTime.Now,
            DataHoraArquivo = (requisicao.DataCancelamento > DateTime.Now.Date ? requisicao.DataCancelamento.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now),
            DominioArquivo = dominio.Id,
            FluxoArquivo = "S",
            ISPBEmissor = dominio.ISPBEmissor,
            ISPBDestinatario = dominio.ISPBDestinatario,
            NomeArquivo = nomeArquivo,
            Status = "PROCESSANDO",
            SituacaoArquivo = 2, /*Processamento*/
            Identificador = requisicao.Id
         };

         CTCService.GetInstance().InserirArquivo(arquivoCTC);

         CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = arquivoCTC.Id, Requisicao = requisicao.Id });

         arquivoCTC.NumeroControleEmissor = DateTime.Now.Date.ToString("yyyyMMdd") + arquivoCTC.Id.ToString().PadLeft(12, '0');

         CTCService.GetInstance().AlterarArquivo(arquivoCTC);


         Model.ACTC900.BCARQComplexType bcarq = new Model.ACTC900.BCARQComplexType();
         Model.ACTC900.Grupo_SeqComplexType grupoBcArq = new Model.ACTC900.Grupo_SeqComplexType();
         bcarq.DtHrArq = (requisicao.DataCancelamento > DateTime.Now.Date ? requisicao.DataCancelamento.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now);
         bcarq.DtRef = requisicao.DataCancelamento.Value.Date;
         bcarq.ISPBEmissor = dominio.ISPBEmissor;
         bcarq.ISPBDestinatario = dominio.ISPBDestinatario;
         bcarq.NomArq = nomeArquivo;

         bcarq.NumCtrlEmis = arquivoCTC.NumeroControleEmissor;
         arquivo.BCARQ = bcarq;

         SISARQComplexType sisarq = new SISARQComplexType();
         Model.ACTC900.ACTC900ComplexType sisarqItem = new Model.ACTC900.ACTC900ComplexType();
         Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType itemItem = new Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType();

         itemItem.NUPortlddCTC = requisicao.NUPortabilidade;
         itemItem.IdentdPartAdmdo = dominio.ISPBEmissor;
         itemItem.MtvCanceltPortldd = requisicao.MotivoCancelamento;
         itemItem.DtCanceltPortldd = requisicao.DataCancelamento.Value.Date;

         Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType[] item = new Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType[1];
         item[0] = itemItem;
         sisarqItem.Grupo_ACTC900_CanceltPortldd = item;

         sisarq.Item = sisarqItem;
         arquivo.SISARQ = sisarq;

         Type typeBuilder = Type.GetType(dominio.Builder + ", BancoPaulista.CTC.Helpers");
         Type typeValidator = Type.GetType(dominio.Validator + ", BancoPaulista.CTC.Helpers");
         dynamic classeBuilder = Activator.CreateInstance(typeBuilder) as IACTCBuilder;
         dynamic classeValidator = Activator.CreateInstance(typeValidator) as IACTCValidator;
         var XML = classeBuilder.GetXML(arquivo);

         CTCService.GetInstance().AlterarRequesicao(requisicao);

         arquivoCTC.Conteudo = XML;
         string erro = "";
         bool validacao = classeValidator.Validate("ACTC900", XML, out erro);

         if (validacao)
         {
            arquivoCTC.Status = "AGUARDANDO ENVIO";
         }
         else
         {
            arquivoCTC.Mensagem = erro;
            arquivoCTC.Status = "COM ERRO";
         }
         CTCService.GetInstance().AlterarArquivo(arquivoCTC);

         if (!validacao)
         {
            LogService.GetInstance().GravarLogDebug("Falha na Validação do Arquivo de Envio a Nuclea Requisição: " + requisicao.Id + " - Mensagem: " + erro);
            throw new Exception("Falha na Validação do Arquivo de Envio a Nuclea " + erro);
         }
      }
   }
}
