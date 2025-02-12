using FastConsig.Barramento.Model;
using FastConsig.BMP.Services;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.Core.Model;
using FastConsig.Mock.Services;
using FastConsig.Sicred.Services;
using System;
using System.Collections.Generic;

namespace FastConsig.Barramento.Services
{
   public class BarramentoService
    {
      #region "Instância"
      private static BarramentoService _instance;
      private BarramentoService()
      {

      }
      public static BarramentoService GetInstance()
      {
         if (_instance == null)
            _instance = new BarramentoService();

         return _instance;
      }
      #endregion

      public CalculoParcelaResponseModel SimularProposta(CalculoParcelaRequestModel calculo)
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         LogService.GetInstance().GravarLogDebug("Acessando a Simulação Através do Serviço " + legado, calculo);

         switch (legado.ToUpper())
         {
            case "SICRED":
               break;
            case "MOCK":
               break;
            case "BMP":
               break;
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               break;
         }

         return new CalculoParcelaResponseModel();
      }

      public void GerarProposta()
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         LogService.GetInstance().GravarLogDebug("Acessando a Geração da Proposta pelo Serviço " + legado);

         switch (legado.ToUpper())
         {
            case "SICRED":
               break;
            case "MOCK":
               break;
            case "BMP":
               break;
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               break;
         }
      }

      public void GerarCCB()
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         switch (legado.ToUpper())
         {
            case "SICRED":
               break;
            case "MOCK":
               break;
            case "BMP":
               break;
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               break;
         }
      }

      public void LiberarPagamento()
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         LogService.GetInstance().GravarLogDebug("Acessando a Liberação do Pagamento da Proposta pelo Serviço " + legado);

         switch (legado.ToUpper())
         {
            case "SICRED":
               break;
            case "MOCK":
               break;
            case "BMP":
               break;
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               break;
         }
      }

      public List<TabelaFinanceiraModel> ListarTabelas(int? promota, int? produto, string empresa = "01")
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         LogService.GetInstance().GravarLogDebug("Listando as Tabelas Financeiras pelo Serviço " + legado);

         switch (legado.ToUpper())
         {
            case "SICRED":
               return SicredService.GetInstance().ListarTabelas(promota, produto, empresa);
            case "MOCK":
               return MockService.GetInstance().ListarTabelas(promota, produto, empresa);
            case "BMP":
               return BMPService.GetInstance().ListarTabelas(promota, produto, empresa);
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               return new List<TabelaFinanceiraModel>();
         }
      }

      public List<PrazoTabelaFinanceiraModel> ListarPrazosTabela(int? tabela)
      {
         string legado = ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado");

         LogService.GetInstance().GravarLogDebug(String.Format("Listando os Prazos da Tabela {0} pelo Serviço " + legado, tabela));

         switch (legado.ToUpper())
         {
            case "SICRED":
               return SicredService.GetInstance().ListarPrazosTabela(tabela);
            case "MOCK":
               return MockService.GetInstance().ListarPrazosTabela(tabela);
            case "BMP":
               return BMPService.GetInstance().ListarPrazosTabela(tabela);
            default:
               LogService.GetInstance().GravarLogErro(new Exception("Sistema Legado Não Definido"), "Sistema Legado Não Definido", ConfiguracaoService.GetInstance().Config<string>("fastconsig.sistema.legado"));
               return new List<PrazoTabelaFinanceiraModel>();
         }
      }
   }
}
