using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC901
{
   public class ACTC901Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC901.ACTC901>.Deserialize<FastConsig.CTC.Model.ACTC901.ACTC901>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC901.ACTC901>.Deserialize<FastConsig.CTC.Model.ACTC901.ACTC901>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC901.ACTC901>.Deserialize<FastConsig.CTC.Model.ACTC901.ACTC901>(sr);
      }
   }
}
