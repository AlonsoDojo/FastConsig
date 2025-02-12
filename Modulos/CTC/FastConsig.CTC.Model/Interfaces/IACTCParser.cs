using System.IO;

namespace FastConsig.CTC.Model.Interfaces
{
   public interface IACTCParser
   {
      object Parse(StreamReader sr);
   }
}
