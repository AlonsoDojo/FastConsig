using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.ACTC103;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;

namespace FastConsig.CTC.Politicas
{
   public class ProcessamentoRetencaoPortabilidade : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         CTC.Model.ACTC103.ACTC103 arquivo = new Model.ACTC103.ACTC103();
         CTCDominioArquivo dominio = CTCService.GetInstance().BuscarArquivosDominio("ACTC103");

         ACTC103 aCTC103 = new ACTC103();

         if (requisicao.DataReferenciaSaldoResposta == null)
         {
            requisicao.DataReferenciaSaldoResposta = CTCService.GetInstance().BuscarDataResposta("ACTC103");
         }

         string nomeArquivo = CTCService.GetInstance().GeraNomeArquivo("ACTC103", requisicao.DataReferenciaSaldoResposta.Value.Date);

         CTCArquivos arquivoCTC = new CTCArquivos()
         {
            DataReferencia = requisicao.DataReferenciaSaldoResposta.Value.Date,
            DataEntrada = DateTime.Now,
            DataHoraArquivo = (requisicao.DataReferenciaSaldoResposta > DateTime.Now.Date ? requisicao.DataReferenciaSaldoResposta.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now),
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


         Model.ACTC103.BCARQComplexType bcarq = new Model.ACTC103.BCARQComplexType();
         Model.ACTC103.Grupo_SeqComplexType grupoBcArq = new Model.ACTC103.Grupo_SeqComplexType();
         bcarq.DtHrArq = (requisicao.DataReferenciaSaldoResposta > DateTime.Now.Date ? requisicao.DataReferenciaSaldoResposta.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now);
         bcarq.DtRef = requisicao.DataReferenciaSaldoResposta.Value.Date;
         bcarq.ISPBEmissor = dominio.ISPBEmissor;
         bcarq.ISPBDestinatario = dominio.ISPBDestinatario;
         bcarq.NomArq = nomeArquivo;

         bcarq.NumCtrlEmis = arquivoCTC.NumeroControleEmissor;
         arquivo.BCARQ = bcarq;

         SISARQComplexType sisarq = new SISARQComplexType();
         Model.ACTC103.ACTC103ComplexType sisarqItem = new Model.ACTC103.ACTC103ComplexType();
         Model.ACTC103.Grupo_ACTC103_PortlddComplexType itemItem = new Model.ACTC103.Grupo_ACTC103_PortlddComplexType();

         itemItem.NUPortlddCTC = requisicao.NUPortabilidade;
         itemItem.IdentdPartAdmdo = dominio.ISPBEmissor;
         itemItem.NumCtrlIF = arquivoCTC.NumeroControleEmissor;

         Grupo_PortlddRetd_ComplexType retencao = new Grupo_PortlddRetd_ComplexType();

         retencao.MtvRetenContrto = new MtvRetenContrto_CodErro() { Value = requisicao.MotivoRetencao.ToString() };
         retencao.DtRetenContrto = new Data_CodErro() { Value = requisicao.DataRetencao.Value };

         itemItem.Item = retencao;
         Model.ACTC103.Grupo_ACTC103_PortlddComplexType[] item = new Model.ACTC103.Grupo_ACTC103_PortlddComplexType[1];
         item[0] = itemItem;
         sisarqItem.Grupo_ACTC103_Portldd = item;

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
         bool validacao = classeValidator.Validate("ACTC103", XML, out erro);

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
