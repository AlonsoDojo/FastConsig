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
   public partial class PerfilEventoFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      public bool Habilitado { get; set; }

      [ForeignKey]
      public int? IdPerfil { get; set; }

      [ForeignKey]
      public int? IdEventoFuncionalidade { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "PerfilEventoFuncionalidade";
         public static readonly FieldReference Id = "PerfilEventoFuncionalidade.Id";
         public static readonly FieldReference Habilitado = "PerfilEventoFuncionalidade.Habilitado";
         public static readonly FieldReference IdPerfil = "PerfilEventoFuncionalidade.IdPerfil";
         public static readonly FieldReference IdEventoFuncionalidade = "PerfilEventoFuncionalidade.IdEventoFuncionalidade";
      }
      #endregion
   }
}
