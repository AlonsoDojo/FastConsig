using Framework.Data;
using Framework;
using System;
using System.ComponentModel.DataAnnotations;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   public partial class Departamento : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? id { get; set; }

      [DataLength(100)]
      public string Descricao { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Departamento";
         public static readonly FieldReference id = "Departamento.id";
         public static readonly FieldReference Descricao = "Departamento.Descricao";
      }
      #endregion
   }
}
