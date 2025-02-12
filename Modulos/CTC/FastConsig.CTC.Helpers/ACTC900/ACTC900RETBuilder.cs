using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC900
{
   public class ACTC900RETBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC900.ACTC900>.Serialize((FastConsig.CTC.Model.ACTC900.ACTC900)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<FastConsig.CTC.Model.ACTC900.ACTC900>.Serialize((FastConsig.CTC.Model.ACTC900.ACTC900)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}