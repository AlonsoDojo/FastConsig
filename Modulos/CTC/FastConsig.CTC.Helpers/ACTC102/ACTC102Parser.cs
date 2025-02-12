using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC102
{
   public class ACTC102Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC102.ACTC102>.Deserialize<FastConsig.CTC.Model.ACTC102.ACTC102>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC102.ACTC102>.Deserialize<FastConsig.CTC.Model.ACTC102.ACTC102>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC102.ACTC102>.Deserialize<FastConsig.CTC.Model.ACTC102.ACTC102>(sr);
      }
   }
}
