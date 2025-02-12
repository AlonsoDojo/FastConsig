using FastConsig.Common.Helpers;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC926
{
   public class ACTC926Parser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC926.ACTC926>.Deserialize<FastConsig.CTC.Model.ACTC926.ACTC926>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC926.ACTC926>.Deserialize<FastConsig.CTC.Model.ACTC926.ACTC926>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC926.ACTC926>.Deserialize<FastConsig.CTC.Model.ACTC926.ACTC926>(sr);
      }
   }
}