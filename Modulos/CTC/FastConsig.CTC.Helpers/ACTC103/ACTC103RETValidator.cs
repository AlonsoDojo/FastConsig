using FastConsig.Common.Helpers;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.IO;

namespace FastConsig.CTC.Helpers.ACTC103
{
   public class ACTC103RETValidator : IACTCValidator
   {
      public bool Validate(string tipoArquivo, StringReader xml, out string erro)
      {
         throw new NotImplementedException();
      }

      public bool Validate(string tipoArquivo, string xml, out string erro)
      {
         var arquivo = CTCService.GetInstance().BuscarArquivosDominio(tipoArquivo);

         bool resultado = XMLUtility<IACTC>.Validade(xml, tipoArquivo, out erro);

         return resultado;
      }
   }
}