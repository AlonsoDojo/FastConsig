using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.AGEN001
{
   public class AGEN001PROParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<Model.AGEN001.AGEN001PRO>.Deserialize<Model.AGEN001.AGEN001PRO>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<Model.AGEN001.AGEN001PRO>.Deserialize<Model.AGEN001.AGEN001PRO>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<Model.AGEN001.AGEN001PRO>.Deserialize<Model.AGEN001.AGEN001PRO>(sr);
      }
   }
}
