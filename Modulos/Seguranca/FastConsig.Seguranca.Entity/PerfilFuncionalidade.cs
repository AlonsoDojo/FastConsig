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
   public partial class PerfilFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [ForeignKey]
      public int? IdPerfil { get; set; }

      [ForeignKey]
      public int? IdFuncionalidade { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "PerfilFuncionalidade";
         public static readonly FieldReference Id = "PerfilFuncionalidade.Id";
         public static readonly FieldReference IdPerfil = "PerfilFuncionalidade.IdPerfil";
         public static readonly FieldReference IdFuncionalidade = "PerfilFuncionalidade.IdFuncionalidade";
      }
      #endregion
   }
}
