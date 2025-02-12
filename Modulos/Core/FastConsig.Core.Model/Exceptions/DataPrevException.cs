using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Exceptions
{
   public class DataPrevException : Exception
   {
      public int? code { get; set; }

      public DataPrevException()
      {
      }

      public DataPrevException(string message)
          : base(message)
      {
      }

      public DataPrevException(string message, int? code)
          : base(message)
      {
         this.code = code;
      }

      public DataPrevException(string message, Exception inner)
          : base(message, inner)
      {
      }
   }
}
