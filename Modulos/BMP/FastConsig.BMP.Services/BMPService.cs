using FastConsig.Barramento.Model;
using FastConsig.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.BMP.Services
{
    public class BMPService : IIntegracao
    {
      #region "Instância"
      private static BMPService _instance;
      private BMPService()
      {

      }
      public static BMPService GetInstance()
      {
         if (_instance == null)
            _instance = new BMPService();

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
