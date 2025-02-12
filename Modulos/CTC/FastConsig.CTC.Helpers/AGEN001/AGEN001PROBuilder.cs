using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.AGEN001
{
   public class AGEN001PROBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<Model.AGEN001.AGEN001PRO>.Serialize((Model.AGEN001.AGEN001PRO)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<Model.AGEN001.AGEN001PRO>.Serialize((Model.AGEN001.AGEN001PRO)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}
