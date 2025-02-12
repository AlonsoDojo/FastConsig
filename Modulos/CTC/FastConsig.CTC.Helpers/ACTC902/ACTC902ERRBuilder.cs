using FastConsig.Common.Helpers;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.IO;
using System.Text;

namespace FastConsig.CTC.Helpers.ACTC902
{
   public class ACTC902ERRBuilder : IACTCBuilder
   {
      public string GetXML(IACTC obj)
      {
         return XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902ERR>.Serialize((FastConsig.CTC.Model.ACTC902.ACTC902ERR)obj);
      }

      public StreamReader Build(IACTC obj)
      {
         var serialized = XMLUtility<FastConsig.CTC.Model.ACTC902.ACTC902ERR>.Serialize((FastConsig.CTC.Model.ACTC902.ACTC902ERR)obj);

         byte[] byteArray = Encoding.ASCII.GetBytes(serialized);
         MemoryStream stream = new MemoryStream(byteArray);

         StreamReader reader = new StreamReader(stream);

         return reader;
      }
   }
}