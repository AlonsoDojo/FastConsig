using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   public static class TemplateHelper
   {
      //Cache que pode ser utilizado no site ou no serviço windows...
      private static readonly MemoryCache _cache = MemoryCache.Default;
      private static object _locker = new object();

      public static TemplateContent CarregarTemplate(TipoEmailProcessamentoTemplateEnum template)
      {
         var nomeTemplate = string.Format("{0}.html", Enum.GetName(typeof(TipoEmailProcessamentoTemplateEnum), template));

         var mailTemplate = LerTemplateDoArquivo(nomeTemplate);

         return mailTemplate; 
      }

      public static TemplateContent CarregarTemplate(string html)
      {
         return new TemplateContent() { BodyContent = html };
      }

      public static byte[] CarregarImagem(TipoImagemTemplateEnum tipoImagem)
      {
         var nomeImagem = string.Format("{0}.png", Enum.GetName(typeof(TipoImagemTemplateEnum), tipoImagem));
         return LerImagemDoArquivo(nomeImagem);
      }

      /// <summary>
      /// Le o conteúdo do template do arquivo em disco.
      /// </summary>
      /// <param name="nomeTemplate">Nome do arquivo de template para ser carregado</param>
      /// <returns>Conteúdo do template.</returns>
      private static TemplateContent LerTemplateDoArquivo(string nomeTemplate)
      {
         //Primeiro verifica se está rodando em um website ou serviço windows, para 
         //se posicionar na pasta base do site, onde os templates estão localizados
         string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");

         //Monta o nome do arquivo completo...
         templatePath = Path.Combine(templatePath, nomeTemplate);
         if (File.Exists(templatePath))
            return new TemplateContent() { BodyContent = File.ReadAllText(templatePath, Encoding.UTF8) };

         return null;
      }

      /// <summary>
      /// Lê o conteúdo da imagem do arquivo.
      /// </summary>
      /// <param name="nomeImagem"></param>
      /// <returns></returns>
      private static byte[] LerImagemDoArquivo(string nomeImagem)
      {
         string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");

         imagePath = Path.Combine(imagePath, nomeImagem);

         return File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : null;
      }
   }
}
