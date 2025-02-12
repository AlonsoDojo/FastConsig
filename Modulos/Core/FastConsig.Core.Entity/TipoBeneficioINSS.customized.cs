
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
	public partial class TipoBeneficioINSS
	{
      public string DescricaoFormatada
      {
         get { return string.Format("({0}) - {1}", Id.Value.ToString("00"), Descricao); }
      }
   }
}
