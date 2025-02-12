using FastConsig.Common.Helpers;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC902
{
   public class ACTC902PROParser : IACTCParser
   {
      public object Parse(string xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902PRO>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902PRO>(xml);
      }

      public object Parse(StringReader xml)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902PRO>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902PRO>(xml);
      }

      public object Parse(StreamReader sr)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902PRO>.Deserialize<FastConsig.CTC.Model.ACTC902.ACTC902PRO>(sr);
      }
   }
}