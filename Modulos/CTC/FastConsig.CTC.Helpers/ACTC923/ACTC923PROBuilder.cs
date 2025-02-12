using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC923
{
   public class ACTC923PROBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC923.ACTC923PRO>.Serialize((FastConsig.CTC.Model.ACTC923.ACTC923PRO)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<FastConsig.CTC.Model.ACTC923.ACTC923PRO>.Serialize((FastConsig.CTC.Model.ACTC923.ACTC923PRO)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}