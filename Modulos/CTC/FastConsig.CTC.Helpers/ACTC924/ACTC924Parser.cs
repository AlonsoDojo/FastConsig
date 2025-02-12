using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC924
{
   public class ACTC924Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC924.ACTC924>.Deserialize<FastConsig.CTC.Model.ACTC924.ACTC924>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC924.ACTC924>.Deserialize<FastConsig.CTC.Model.ACTC924.ACTC924>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC924.ACTC924>.Deserialize<FastConsig.CTC.Model.ACTC924.ACTC924>(sr);
      }
   }
}