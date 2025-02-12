using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class ValidacaoDadosException : Exception
   {
      public int? code { get; set; }

      public ValidacaoDadosException()
      {
      }

      public ValidacaoDadosException(string message)
          : base(message)
      {
      }

      public ValidacaoDadosException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public ValidacaoDadosException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
