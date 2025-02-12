using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastConsig.Auditoria.Entity
{
   [Serializable]
   public partial class AuditTable : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? ID { get; set; }

      public long? KeyFieldID { get; set; }

      public int? AuditActionTypeENUM { get; set; }

      public DateTime? DateTimeStamp { get; set; }

      [DataLength(2147483647)]
      public string DataModel { get; set; }

      [DataLength(2147483647)]
      public string Changes { get; set; }

      [DataLength(2147483647)]
      public string ValueBefore { get; set; }

      [DataLength(2147483647)]
      public string ValueAfter { get; set; }

      [DataLength(50)]
      public string Usuario { get; set; }

      public string NomeUsuario { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "AuditTable";
         public static readonly FieldReference ID = "AuditTable.ID";
         public static readonly FieldReference KeyFieldID = "AuditTable.KeyFieldID";
         public static readonly FieldReference AuditActionTypeENUM = "AuditTable.AuditActionTypeENUM";
         public static readonly FieldReference DateTimeStamp = "AuditTable.DateTimeStamp";
         public static readonly FieldReference DataModel = "AuditTable.DataModel";
         public static readonly FieldReference Changes = "AuditTable.Changes";
         public static readonly FieldReference ValueBefore = "AuditTable.ValueBefore";
         public static readonly FieldReference ValueAfter = "AuditTable.ValueAfter";
         public static readonly FieldReference Usuario = "AuditTable.Usuario";
      }
      #endregion
   }
}
