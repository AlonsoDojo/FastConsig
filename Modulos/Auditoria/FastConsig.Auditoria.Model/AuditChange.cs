using FastConsig.Auditoria.Helpers;
using System.Collections.Generic;

namespace FastConsig.Auditoria.Model
{
   public class AuditChange
   {
      public string DateTimeStamp { get; set; }
      public AuditActionType AuditActionType { get; set; }
      public string AuditActionTypeName { get; set; }
      public List<AuditDelta> Changes { get; set; }
      public string Usuario { get; set; }
      public string NomeUsuario { get; set; }
      public AuditChange()
      {
         Changes = new List<AuditDelta>();
      }

   }
}
