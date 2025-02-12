using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC920
{
   public class ACTC920ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920ERR>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920ERR>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC920.ACTC920ERR>.Deserialize<FastConsig.CTC.Model.ACTC920.ACTC920ERR>(sr);
      }
   }
}