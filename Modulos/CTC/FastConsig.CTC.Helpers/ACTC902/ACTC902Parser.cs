using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC902
{
   public class ACTC902Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902>(sr);
      }
   }
}