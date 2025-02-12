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
   public partial class ViewPerfilUsuario : EntityBase
   {
      #region Propriedades
      [Key]
      public int? Id { get; set; }

      public int? IdPerfil { get; set; }

      [DataLength(50)]
      public string NomePerfil { get; set; }

      [DataLength(50)]
      public string IdUsuario { get; set; }

      [DataLength(100)]
      public string Login { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "ViewPerfilUsuario";
         public static readonly FieldReference Id = "ViewPerfilUsuario.Id";
         public static readonly FieldReference IdPerfil = "ViewPerfilUsuario.IdPerfil";
         public static readonly FieldReference NomePerfil = "ViewPerfilUsuario.NomePerfil";
         public static readonly FieldReference IdUsuario = "ViewPerfilUsuario.IdUsuario";
         public static readonly FieldReference Login = "ViewPerfilUsuario.Login";
      }
      #endregion
   }
}
