using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class WaitException : Exception
   {
      public int? code { get; set; }

      public WaitException()
      {
      }

      public WaitException(string message)
          : base(message)
      {
      }

      public WaitException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public WaitException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
