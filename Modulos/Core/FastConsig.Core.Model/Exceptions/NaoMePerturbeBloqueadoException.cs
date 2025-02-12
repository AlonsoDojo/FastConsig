using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class NaoMePerturbeBloqueadoException : Exception
   {
      public int? code { get; set; }

      public NaoMePerturbeBloqueadoException()
      {
      }

      public NaoMePerturbeBloqueadoException(string message)
          : base(message)
      {
      }

      public NaoMePerturbeBloqueadoException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public NaoMePerturbeBloqueadoException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
