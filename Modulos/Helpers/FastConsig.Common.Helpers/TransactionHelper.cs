using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.Common.Helpers
{
   public static class TransactionHelper
   {
      /// <summary>
      /// Executa um action e NÃO RETORNA valor para esta chamada.
      /// </summary>
      /// <param name="scopeOption"></param>
      /// <param name="action"></param>
      public static void Run(TransactionScopeOption scopeOption, Action action)
      {
         using (var scope = new TransactionScope(scopeOption))
         {
            action.Invoke();

            if (Transaction.Current != null &&
                Transaction.Current.TransactionInformation.Status != TransactionStatus.Aborted &&
                Transaction.Current.TransactionInformation.Status != TransactionStatus.Committed)
            {
               scope.Complete();
            }
         }
      }
   }
}
