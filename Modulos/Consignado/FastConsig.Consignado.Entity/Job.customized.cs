
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Consignado.Entity
{
	public partial class Job
	{
      public string Result { get; set; }

      public DateTime? DataProcessamento { get; set; }

      public long? idJobTentativa { get; set; }

      public string Type { get; set; }

      public bool Debug { get; set; }

      public string LoggingType { get; set; }

      public string LoggingLocation { get; set; }

      public int LoggingMaximumSize { get; set; }

      public string Status { get; set; }
   }
}
