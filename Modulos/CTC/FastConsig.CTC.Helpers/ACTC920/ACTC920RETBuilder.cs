using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC920
{
   public class ACTC920RETBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920>.Serialize((FastConsig.CTC.Model.ACTC920.ACTC920)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920>.Serialize((FastConsig.CTC.Model.ACTC920.ACTC920)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}