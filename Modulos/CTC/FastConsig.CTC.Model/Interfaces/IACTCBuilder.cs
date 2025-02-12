using System.IO;

namespace FastConsig.CTC.Model.Interfaces
{
   public interface IACTCBuilder
   {
      string GetXML(IACTC obj);
      StreamReader Build(IACTC obj);
   }
}
