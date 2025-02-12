using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC923
{
   public class ACTC923ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC923.ACTC923ERR>.Deserialize<FastConsig.CTC.Model.ACTC923.ACTC923ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC923.ACTC923ERR>.Deserialize<FastConsig.CTC.Model.ACTC923.ACTC923ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC923.ACTC923ERR>.Deserialize<FastConsig.CTC.Model.ACTC923.ACTC923ERR>(sr);
      }
   }
}