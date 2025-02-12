using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC101
{
   public class ACTC101ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101ERR>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101ERR>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC101.ACTC101ERR>.Deserialize<FastConsig.CTC.Model.ACTC101.ACTC101ERR>(sr);
      }
   }
}