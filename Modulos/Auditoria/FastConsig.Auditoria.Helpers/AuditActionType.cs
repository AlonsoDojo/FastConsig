using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Auditoria.Helpers
{
   public enum AuditActionType
   {
      [Description("Inserção")]
      Create = 1,
      [Description("Alteração")]
      Update,
      [Description("Exclusão")]
      Delete
   }
}
