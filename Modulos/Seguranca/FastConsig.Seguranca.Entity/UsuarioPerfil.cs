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
   public partial class UsuarioPerfil : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [ForeignKey, DataLength(80)]
      public string IdUsuario { get; set; }

      [ForeignKey]
      public int? IdPerfil { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "UsuarioPerfil";
         public static readonly FieldReference Id = "UsuarioPerfil.Id";
         public static readonly FieldReference IdUsuario = "UsuarioPerfil.IdUsuario";
         public static readonly FieldReference IdPerfil = "UsuarioPerfil.IdPerfil";
      }
      #endregion
   }
}
