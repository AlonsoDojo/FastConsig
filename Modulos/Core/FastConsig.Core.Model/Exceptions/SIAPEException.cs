using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class SIAPEException : Exception
   {
      public int? code { get; set; }

      public SIAPEException()
      {
      }

      public SIAPEException(string message)
          : base(message)
      {
      }

      public SIAPEException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public SIAPEException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
