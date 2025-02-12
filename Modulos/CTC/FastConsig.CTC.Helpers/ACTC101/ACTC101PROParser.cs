using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC101
{
   public class ACTC101PROParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101PRO>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101PRO>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101PRO>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101PRO>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101PRO>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101PRO>(sr);
      }
   }
}