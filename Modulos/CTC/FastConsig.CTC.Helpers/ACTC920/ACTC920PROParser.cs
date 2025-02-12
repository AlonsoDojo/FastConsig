using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC920
{
   public class ACTC920PROParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920PRO>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920PRO>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920PRO>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920PRO>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920PRO>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920PRO>(sr);
      }
   }
}