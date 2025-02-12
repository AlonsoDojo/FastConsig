using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   public partial class Configuracao : EntityBase
   {
      #region Propriedades
      [Key, DataLength(250)]
      public string Chave { get; set; }

      [DataLength(2147483647)]
      public string Conteudo { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Configuracao";
         public static readonly FieldReference Chave = "Configuracao.Chave";
         public static readonly FieldReference Conteudo = "Configuracao.Conteudo";
      }
      #endregion
   }
}
