using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC922
{
   public class ACTC922Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC922.ACTC922>.Deserialize<FastConsig.CTC.Model.ACTC922.ACTC922>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC922.ACTC922>.Deserialize<FastConsig.CTC.Model.ACTC922.ACTC922>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC922.ACTC922>.Deserialize<FastConsig.CTC.Model.ACTC922.ACTC922>(sr);
      }
   }
}