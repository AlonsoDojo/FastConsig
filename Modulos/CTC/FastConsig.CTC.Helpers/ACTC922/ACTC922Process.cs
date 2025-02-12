using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC922
{
   public class ACTC922Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC922.ACTC922 obj = (FastConsig.CTC.Model.ACTC922.ACTC922)new ACTC922Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTC922 ctc = new CTC922();

         ctc.DataReferencia = obj.BCARQ.DtRef;
         ctc.Arquivo = idArquivo;

         new CTC922Business().Incluir(ctc);

         if (obj.SISARQ.Item.Grupo_ACTC922_VisaoOrigdr != null)
         {
            foreach (var detalheArquivo in obj.SISARQ.Item.Grupo_ACTC922_VisaoOrigdr)
            {
               foreach (var detalhe in detalheArquivo.Grupo_ACTC922_DadVisaoOrigdr)
               {
                  foreach (var qtd in detalhe.Grupo_ACTC922_QtdSitPortlddOrigdr)
                  {
                     CTC922Detalhes arq = new CTC922Detalhes() { CTC922 = ctc.Id, TipoParte = 1, TipoContrato = detalhe.TpContrto, EnteConsignante = detalhe.TpEnteCons, SituacaoPortabilidade = qtd.SitPortlddCTC, QtdSituacaoPortabilidade = int.Parse(qtd.QtdSitPortlddCTC) };

                     if (qtd?.Grupo_ACTC922_QtdMtvCanceltOrigdr != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvCanceltOrigdr)
                        {
                           arq.MotivoCancelamento = cancelamento.MtvCanceltPortldd;
                           arq.QtdCancelamento = int.Parse(cancelamento.QtdMtvCanceltPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdDcrsoPrzOrigdr != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdDcrsoPrzOrigdr)
                        {
                           arq.MotivoDecursoPrazo = cancelamento.MtvDcrsoPrzPortldd;
                           arq.QtdDecursoPrazo = int.Parse(cancelamento.QtdMtvDcrsoPrzPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdMtvDevLiquidOrigdr != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvDevLiquidOrigdr)
                        {
                           arq.MotivoDevolucaoLiquidacao = cancelamento.MtvDevLiquidPortldd;
                           arq.QtdDevolucaoLiquidacao = int.Parse(cancelamento.QtdMtvDevLiquidPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdMtvRetenOrigdr != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvRetenOrigdr)
                        {
                           arq.MotivoRetencao = cancelamento.MtvRetenContrto;
                           arq.QtdRetencao = int.Parse(cancelamento.QtdMtvRetenContrto);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }
                  }
               }
            }
         }

         if (obj.SISARQ.Item.Grupo_ACTC922_VisaoPropnt != null)
         {
            foreach (var detalheArquivo in obj.SISARQ.Item.Grupo_ACTC922_VisaoPropnt)
            {
               foreach (var detalhe in detalheArquivo.Grupo_ACTC922_DadVisaoPropnt)
               {
                  foreach (var qtd in detalhe.Grupo_ACTC922_QtdSitPortlddPropnt)
                  {
                     CTC922Detalhes arq = new CTC922Detalhes() { CTC922 = ctc.Id, TipoParte = 2, TipoContrato = detalhe.TpContrto, EnteConsignante = detalhe.TpEnteCons, SituacaoPortabilidade = qtd.SitPortlddCTC, QtdSituacaoPortabilidade = int.Parse(qtd.QtdSitPortlddCTC) };

                     if (qtd?.Grupo_ACTC922_QtdMtvCanceltPropnt != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvCanceltPropnt)
                        {
                           arq.MotivoCancelamento = cancelamento.MtvCanceltPortldd;
                           arq.QtdCancelamento = int.Parse(cancelamento.QtdMtvCanceltPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdDcrsoPrzPropnt != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdDcrsoPrzPropnt)
                        {
                           arq.MotivoDecursoPrazo = cancelamento.MtvDcrsoPrzPortldd;
                           arq.QtdDecursoPrazo = int.Parse(cancelamento.QtdMtvDcrsoPrzPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdMtvDevLiquidPropnt != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvDevLiquidPropnt)
                        {
                           arq.MotivoDevolucaoLiquidacao = cancelamento.MtvDevLiquidPortldd;
                           arq.QtdDevolucaoLiquidacao = int.Parse(cancelamento.QtdMtvDevLiquidPortldd);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }

                     if (qtd?.Grupo_ACTC922_QtdMtvRetenPropnt != null)
                     {
                        foreach (var cancelamento in qtd?.Grupo_ACTC922_QtdMtvRetenPropnt)
                        {
                           arq.MotivoRetencao = cancelamento.MtvRetenContrto;
                           arq.QtdRetencao = int.Parse(cancelamento.QtdMtvRetenContrto);
                           new CTC922DetalhesBusiness().Incluir(arq);
                        }
                     }
                  }
               }
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
