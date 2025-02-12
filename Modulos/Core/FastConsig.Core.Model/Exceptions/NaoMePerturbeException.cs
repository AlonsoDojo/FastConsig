using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class NaoMePerturbeException : Exception
   {
      public int? code { get; set; }

      public NaoMePerturbeException()
      {
      }

      public NaoMePerturbeException(string message)
          : base(message)
      {
      }

      public NaoMePerturbeException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public NaoMePerturbeException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
