using FastConsig.Barramento.Model;
using FastConsig.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Sicred.Services
{
   public class SicredService : IIntegracao
   {
      #region "Instância"
      private static SicredService _instance;
      private SicredService()
      {

      }
      public static SicredService GetInstance()
      {
         if (_instance == null)
            _instance = new SicredService();

         return _instance;
      }

      public List<PrazoTabelaFinanceiraModel> ListarPrazosTabela(int? tabela)
      {
         throw new NotImplementedException();
      }

      public List<TabelaFinanceiraModel> ListarTabelas(int? promotora, int? produto, string empresa)
      {
         throw new NotImplementedException();
      }
      #endregion

      public CalculoParcelaResponseModel SimularProposta(CalculoParcelaRequestModel calculo)
      {
         throw new NotImplementedException();
      }


   }
}
