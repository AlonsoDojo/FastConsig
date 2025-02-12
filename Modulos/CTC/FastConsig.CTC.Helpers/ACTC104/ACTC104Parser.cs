using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC104
{
   public class ACTC104Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC104.ACTC104>.Deserialize<FastConsig.CTC.Model.ACTC104.ACTC104>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC104.ACTC104>.Deserialize<FastConsig.CTC.Model.ACTC104.ACTC104>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC104.ACTC104>.Deserialize<FastConsig.CTC.Model.ACTC104.ACTC104>(sr);
      }
   }
}