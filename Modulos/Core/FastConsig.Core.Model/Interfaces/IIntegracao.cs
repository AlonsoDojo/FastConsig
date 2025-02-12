using FastConsig.Barramento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Interfaces
{
   public interface IIntegracao
   {
      CalculoParcelaResponseModel SimularProposta(CalculoParcelaRequestModel calculo);

      List<TabelaFinanceiraModel> ListarTabelas(int? promotora, int? produto, string empresa);

      List<PrazoTabelaFinanceiraModel> ListarPrazosTabela(int? tabela);
   }
}
