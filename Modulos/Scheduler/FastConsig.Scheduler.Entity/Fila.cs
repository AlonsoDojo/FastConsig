using Framework.Data;
using Framework;
using System;
using System.ComponentModel.DataAnnotations;

namespace FastConsig.Scheduler.Entity
{
   [Serializable]
   public partial class Fila : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(200)]
      public string Nome { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Fila";
         public static readonly FieldReference Id = "Fila.Id";
         public static readonly FieldReference Nome = "Fila.Nome";
      }
      #endregion
   }
}
