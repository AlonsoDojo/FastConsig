using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC925
{
   public class ACTC925ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925ERR>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925ERR>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925ERR>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925ERR>(sr);
      }
   }
}