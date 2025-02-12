using FastConsig.Common.Helpers;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System.IO;

namespace FastConsig.CTC.Helpers.AGEN001
{
   public class AGEN001Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.AGEN001.AGEN001>.Deserialize<FastConsig.CTC.Model.AGEN001.AGEN001>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.AGEN001.AGEN001>.Deserialize<FastConsig.CTC.Model.AGEN001.AGEN001>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.AGEN001.AGEN001>.Deserialize<FastConsig.CTC.Model.AGEN001.AGEN001>(sr);
      }
   }
}
