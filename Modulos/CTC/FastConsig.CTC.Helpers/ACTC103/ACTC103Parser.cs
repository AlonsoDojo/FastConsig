using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC103
{
   public class ACTC103Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103>(sr);
      }
   }
}