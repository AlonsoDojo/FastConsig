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
   public partial class GrupoFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      [DataLength(50)]
      public string Icone { get; set; }

      public bool Habilitado { get; set; }

      [ForeignKey, DataLength(50)]
      public string SistemaId { get; set; }

      public int? Ordem { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "GrupoFuncionalidade";
         public static readonly FieldReference Id = "GrupoFuncionalidade.Id";
         public static readonly FieldReference Nome = "GrupoFuncionalidade.Nome";
         public static readonly FieldReference Icone = "GrupoFuncionalidade.Icone";
         public static readonly FieldReference Habilitado = "GrupoFuncionalidade.Habilitado";
         public static readonly FieldReference SistemaId = "GrupoFuncionalidade.SistemaId";
         public static readonly FieldReference Ordem = "GrupoFuncionalidade.Ordem";
      }
      #endregion
   }
}
