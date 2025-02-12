using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC921
{
   public class ACTC921Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC921.ACTC921>.Deserialize<FastConsig.CTC.Model.ACTC921.ACTC921>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC921.ACTC921>.Deserialize<FastConsig.CTC.Model.ACTC921.ACTC921>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC921.ACTC921>.Deserialize<FastConsig.CTC.Model.ACTC921.ACTC921>(sr);
      }
   }
}