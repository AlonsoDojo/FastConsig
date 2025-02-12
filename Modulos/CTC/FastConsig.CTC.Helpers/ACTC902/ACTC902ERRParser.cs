using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC902
{
   public class ACTC902ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902ERR>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902ERR>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902ERR>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902ERR>(sr);
      }
   }
}