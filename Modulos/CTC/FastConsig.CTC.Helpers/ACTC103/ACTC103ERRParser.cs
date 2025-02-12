using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC103
{
   public class ACTC103ERRParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103ERR>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103ERR>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103ERR>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103ERR>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC103.ACTC103ERR>.Deserialize<FastConsig.CTC.Model.ACTC103.ACTC103ERR>(sr);
      }
   }
}