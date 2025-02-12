using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC900
{
   public class ACTC900RETParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC900.ACTC900>.Deserialize<FastConsig.CTC.Model.ACTC900.ACTC900>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC900.ACTC900>.Deserialize<FastConsig.CTC.Model.ACTC900.ACTC900>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC900.ACTC900>.Deserialize<FastConsig.CTC.Model.ACTC900.ACTC900>(sr);
      }
   }
}