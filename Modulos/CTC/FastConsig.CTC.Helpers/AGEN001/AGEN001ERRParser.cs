using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.AGEN001
{
   public class AGEN001ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<Model.AGEN001.AGEN001ERR>.Deserialize<Model.AGEN001.AGEN001ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<Model.AGEN001.AGEN001ERR>.Deserialize<Model.AGEN001.AGEN001ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<Model.AGEN001.AGEN001ERR>.Deserialize<Model.AGEN001.AGEN001ERR>(sr);
      }
   }
}
