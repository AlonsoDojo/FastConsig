
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
	public partial class OcorrenciaProdutoFase
	{
      public string DescricaoOcorrencia { get; set; }
      public bool PermiteLiberacaoComplemento { get; set; }
      public bool Pendencia { get; set; }
      public bool Informativa { get; set; }
      public bool Recusa { get; set; }
   }
}
