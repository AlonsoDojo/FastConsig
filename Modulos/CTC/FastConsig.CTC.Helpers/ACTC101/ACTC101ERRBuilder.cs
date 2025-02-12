using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC101
{
   public class ACTC101ERRBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101ERR>.Serialize((FastConsig.CTC.Model.ACTC101.ACTC101ERR)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101ERR>.Serialize((FastConsig.CTC.Model.ACTC101.ACTC101ERR)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}