using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Auditoria.Model
{
   public class AuditDelta
   {
      public string FieldName { get; set; }
      public string ValueBefore { get; set; }
      public string ValueAfter { get; set; }
   }
}
