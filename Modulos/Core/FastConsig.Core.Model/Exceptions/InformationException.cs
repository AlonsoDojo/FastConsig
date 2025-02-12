using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class InformationException : Exception
   {
      public int? code { get; set; }

      public InformationException()
      {
      }

      public InformationException(string message)
          : base(message)
      {
      }

      public InformationException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public InformationException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
