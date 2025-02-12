using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.DataPrev.Services.Exceptions
{
   public class DataPrevException : System.Exception
   {
      public DataPrevException() { }
      public DataPrevException(string message) : base(message) { }
      public DataPrevException(string message, System.Exception inner) : base(message, inner) { }
      protected DataPrevException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
   }
}
