using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class INSSException : Exception
   {
      public int? code { get; set; }

      public INSSException()
      {
      }

      public INSSException(string message)
          : base(message)
      {
      }

      public INSSException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public INSSException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
