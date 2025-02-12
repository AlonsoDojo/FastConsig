using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;

namespace FastConsig.CTC.Helpers.ACTC102
{
   public class ACTC102Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         //Busca o Parametro de Prazo de Expiração da Resposta de Retenção e Aceite
         int prazoRetencao = int.Parse(ConfiguracaoService.GetInstance().Obter("CTC.Dias.Retencao").Conteudo.ToString());
         int prazoAceite = int.Parse(ConfiguracaoService.GetInstance().Obter("CTC.Dias.Aceite").Conteudo.ToString());
         string tipoPrazo = ConfiguracaoService.GetInstance().Obter("CTC.Dias.Tipo").Conteudo.ToString();

         //Deserializa o Arquivo
         FastConsig.CTC.Model.ACTC102.ACTC102 obj = (FastConsig.CTC.Model.ACTC102.ACTC102)new ACTC102Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         foreach (var item in obj.SISARQ.Item.Grupo_ACTC102_Portldd)
         {
            DateTime dataRetencao = obj.BCARQ.DtRef;
            DateTime dataAceite = obj.BCARQ.DtRef;

            //Verificar dias úteis
            if (tipoPrazo == "U")
            {
               int contador = 0;
               while (contador < prazoRetencao)
               {
                  if (contador >= 0)
                  {
                     dataRetencao = dataRetencao.AddDays(1);
                  }

                  if (CTCService.GetInstance().DiaUtil(dataRetencao))
                  {
                     contador += 1;
                  }
               }

               contador = 0;
               while (contador < prazoAceite)
               {
                  if (contador >= 0)
                  {
                     dataAceite = dataAceite.AddDays(1);
                  }

                  if (CTCService.GetInstance().DiaUtil(dataAceite))
                  {
                     contador += 1;
                  }
               }
            }

            try
            {
               //Insere os dados na tabela de requisições
               CTCRequisicao requisicao = new CTCRequisicao
               {
                  IdentificacaoParticipanteAdministrado = item.IdentdPartAdmdo,
                  NUPortabilidade = item.NUPortlddCTC,
                  IFProponente = item.IdentdIFPropnt,
                  Contrato = item.Grupo_ACTC102_IdentdContrto.CodContrtoOr.Value,
                  CNPJBaseIFOriginadora = item.Grupo_ACTC102_IdentdContrto.CNPJBase_IFOrContrto.Value,
                  TipoContrato = item.Grupo_ACTC102_IdentdContrto.TpContrto.Value,
                  EnteConsignante = item.Grupo_ACTC102_IdentdContrto.TpEnteCons.Value,
                  CNPJCorrespondenteBancario = item.Grupo_ACTC102_IdentdContrto.CNPJCorrespBanc.Value,
                  TipoPessoa = item.Grupo_ACTC102_Cli.TpCli.Value.ToString(),
                  CpfCnpjCliente = item.Grupo_ACTC102_Cli.CNPJ_CPFCli.Value,
                  NomeCliente = item.Grupo_ACTC102_Cli.NomCli.Value,
                  Telefone = item.Grupo_ACTC102_Cli.TelCli.Value,
                  Email = item.Grupo_ACTC102_Cli.EmailCli?.Value,
                  Endereco = item.Grupo_ACTC102_Cli.LogradEndCli.Value,
                  Numero = item.Grupo_ACTC102_Cli.NumEndCli.Value,
                  Complemento = (item.Grupo_ACTC102_Cli.CompEndCli == null ? "" : item.Grupo_ACTC102_Cli.CompEndCli?.Value),
                  Cidade = item.Grupo_ACTC102_Cli.CidEndCli.Value,
                  UF = item.Grupo_ACTC102_Cli.UFEndCli.Value,
                  Cep = item.Grupo_ACTC102_Cli.CEPEndCli.Value,
                  DataReferenciaSaldo = item.Grupo_ACTC102_PropPortldd.DtRefSaldDevdrContb.Value,
                  SaldoDevedor = item.Grupo_ACTC102_PropPortldd.VlrSaldDevdrContb.Value,
                  JurosNominal = item.Grupo_ACTC102_PropPortldd.TxJurosNoml.Value,
                  JurosEfetivo = item.Grupo_ACTC102_PropPortldd.TxJurosEft.Value,
                  Cet = item.Grupo_ACTC102_PropPortldd.TxCET.Value,
                  Moeda = item.Grupo_ACTC102_PropPortldd.CodMoeda.Value,
                  IndiceRemuneracao = (item.Grupo_ACTC102_PropPortldd.IndRemun == null ? "99" : item.Grupo_ACTC102_PropPortldd.IndRemun.Value),
                  RegimeAmortizacao = item.Grupo_ACTC102_PropPortldd.RegmAmtzc.Value,
                  DataContrato = item.Grupo_ACTC102_PropPortldd.DtContrOp.Value,
                  QtdParcelasContrato = int.Parse(item.Grupo_ACTC102_PropPortldd.QtdTotParclContrto.Value),
                  ValorFaceParcela = item.Grupo_ACTC102_PropPortldd.VlrFaceParclContrto.Value,
                  DataVencimentoPrimeiraParcela = item.Grupo_ACTC102_PropPortldd.DtVencPrimParclContrto.Value,
                  DataVencimentoUltimaParcela = item.Grupo_ACTC102_PropPortldd.DtVencUltParclContrto.Value,
                  EnderecoCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.LogradEndCartaPortldd.Value,
                  NumeroCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.NumEndCartaPortldd.Value,
                  ComplementoCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.CompEndCartaPortldd?.Value,
                  CidadeCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.CidEndCartaPortldd.Value,
                  UFCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.UFEndCartaPortldd.Value,
                  CepCartaPortabilidade = item.Grupo_ACTC102_EndCartaPortldd.CEPEndCartaPortldd.Value,
                  SituacaoPortabilidade = "2",
                  DataReferencia = obj.BCARQ.DtRef,
                  DataVencimentoRetencao = dataRetencao,
                  DataVencimentoAceite = dataAceite,
                  Arquivo = arquivo.Id,
                  Fase = 1,
                  Status = "AGUARDANDO",
                  TipoArquivo = arquivo.DominioArquivo,
                  TipoFluxo = 1 /*Recepção*/
               };

               CTCService.GetInstance().InserirRequesicao(requisicao);

               CTCRequisicaoSimulacao simulacaoProponente = new CTCRequisicaoSimulacao()
               {
                  Requisicao = requisicao.Id,
                  Parcelas = requisicao.QtdParcelasContrato,
                  DataReferencia = requisicao.DataReferencia,
                  CET = requisicao.Cet,
                  PrimeiroVencimento = requisicao.DataVencimentoPrimeiraParcela,
                  SaldoDevedor = requisicao.SaldoDevedor,
                  Simulacao = -1, /*Tipo Proponente*/
                  Tabela = "0000",
                  Taxa = requisicao.JurosNominal,
                  Tipo = 2, /*Tipo Proponente*/
                  UltimoVencimento = requisicao.DataVencimentoUltimaParcela,
                  ValorParcela = requisicao.ValorFaceParcela
               };

               arquivo.Identificador = requisicao.Id;

               CTCService.GetInstance().InserirRequesicaoSimulacao(simulacaoProponente);

               CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Ocorrencia = 1, DataOcorrencia = DateTime.Now, Requisicao = requisicao.Id, Usuario = "System", Complemento = "Requisição Processada em " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") });

               CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = idArquivo, Requisicao = requisicao.Id });

               try
               {
                  CTCService.GetInstance().SubmeterRequisicao(requisicao);
               }
               catch (Exception exx)
               {
                  LogService.GetInstance().GravarLogErro(exx, "Falha ao Inserir os Dados da Requisição", requisicao);
                  throw new Exception(exx.Message, exx);
               }
            }
            catch (Exception ex)
            {
               LogService.GetInstance().GravarLogErro(ex, "Falha ao Inserir os Dados da Requisição", item);
            }
         }

         //Atualiza a Situação para Processado
         
         arquivo.Mensagem = "Processamento Concluído com Sucesso";
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}
