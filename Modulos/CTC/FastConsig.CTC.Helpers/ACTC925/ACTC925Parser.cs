using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC925
{
   public class ACTC925Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC925.ACTC925>.Deserialize<FastConsig.CTC.Model.ACTC925.ACTC925>(sr);
      }
   }
}