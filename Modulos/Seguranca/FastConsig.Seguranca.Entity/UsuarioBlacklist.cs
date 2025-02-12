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
   public partial class UsuarioBlacklist : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public long? CpfCnpj { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "UsuarioBlacklist";
         public static readonly FieldReference CpfCnpj = "UsuarioBlacklist.CpfCnpj";
      }
      #endregion
   }
}
