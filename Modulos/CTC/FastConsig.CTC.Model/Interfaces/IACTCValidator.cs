using System.IO;

namespace FastConsig.CTC.Model.Interfaces
{
   public interface IACTCValidator
   {
      bool Validate(string tipoArquivo, StringReader xml, out string erro);
      bool Validate(string tipoArquivo, string xml, out string erro);
   }
}
