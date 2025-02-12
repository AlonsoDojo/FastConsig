using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC928
{
   public class ACTC928Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC928.ACTC928>.Deserialize<FastConsig.CTC.Model.ACTC928.ACTC928>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC928.ACTC928>.Deserialize<FastConsig.CTC.Model.ACTC928.ACTC928>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC928.ACTC928>.Deserialize<FastConsig.CTC.Model.ACTC928.ACTC928>(sr);
      }
   }
}