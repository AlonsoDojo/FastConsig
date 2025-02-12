using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastConsig.Core.Model.Interfaces;
using FastConsig.Barramento.Model;

namespace FastConsig.Mock.Services
{
    public class MockService : IIntegracao
    {
      #region "Instância"
      private static MockService _instance;
      private MockService()
      {

      }
      public static MockService GetInstance()
      {
         if (_instance == null)
            _instance = new MockService();

         return _instance;
      }

      public CalculoParcelaResponseModel SimularProposta(CalculoParcelaRequestModel calculo)
      {
         throw new NotImplementedException();
      }

      public List<PrazoTabelaFinanceiraModel> ListarPrazosTabela(int? tabela)
      {
         List<PrazoTabelaFinanceiraModel> prazos = new List<PrazoTabelaFinanceiraModel>();

         if (tabela == 1044)
         {
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1044, Prazo = 48, Taxa = (decimal?)1.56, TaxaMinima = (decimal?)1.56, TaxaMaxima = (decimal?)1.56 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1044, Prazo = 60, Taxa = (decimal?)1.56, TaxaMinima = (decimal?)1.56, TaxaMaxima = (decimal?)1.56 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1044, Prazo = 72, Taxa = (decimal?)1.56, TaxaMinima = (decimal?)1.56, TaxaMaxima = (decimal?)1.56 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1044, Prazo = 84, Taxa = (decimal?)1.56, TaxaMinima = (decimal?)1.56, TaxaMaxima = (decimal?)1.56 });

         } else {
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1040, Prazo = 36, Taxa = (decimal?)1.64, TaxaMinima = (decimal?)1.64, TaxaMaxima = (decimal?)1.64 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1040, Prazo = 48, Taxa = (decimal?)1.64, TaxaMinima = (decimal?)1.64, TaxaMaxima = (decimal?)1.64 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1040, Prazo = 60, Taxa = (decimal?)1.64, TaxaMinima = (decimal?)1.64, TaxaMaxima = (decimal?)1.64 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1040, Prazo = 72, Taxa = (decimal?)1.64, TaxaMinima = (decimal?)1.64, TaxaMaxima = (decimal?)1.64 });
            prazos.Add(new PrazoTabelaFinanceiraModel { Empresa = "01", Plano = 1040, Prazo = 84, Taxa = (decimal?)1.64, TaxaMinima = (decimal?)1.64, TaxaMaxima = (decimal?)1.64 });
         }
         return prazos;
      }

      public List<TabelaFinanceiraModel> ListarTabelas(int? promotora, int? produto, string empresa)
      {
         List<TabelaFinanceiraModel> tabelas = new List<TabelaFinanceiraModel>();

         TabelaFinanceiraModel item1 = new TabelaFinanceiraModel { Empresa = "01", Plano = 1044, DescricaoPlano = "1044 - INSS NV- DIG -1,56", CarenciaMinima = 0, CarenciaMaxima = 9999 };
         TabelaFinanceiraModel item2 = new TabelaFinanceiraModel { Empresa = "01", Plano = 1040, DescricaoPlano = "1040 - INSS NV- DIG -1,64", CarenciaMinima = 0, CarenciaMaxima = 9999 };

         tabelas.Add(item1);
         tabelas.Add(item2);

         return tabelas.ToList();
      }
      #endregion
   }
}
