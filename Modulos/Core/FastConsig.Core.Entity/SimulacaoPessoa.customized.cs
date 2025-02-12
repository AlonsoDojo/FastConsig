
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json;
#endregion

namespace FastConsig.Core.Entity
{
	public partial class SimulacaoPessoa
   {
      [DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NumeroBeneficioSIAPE")]
      public string NumeroBeneficioSIAPE { get; set; }
   }
}
