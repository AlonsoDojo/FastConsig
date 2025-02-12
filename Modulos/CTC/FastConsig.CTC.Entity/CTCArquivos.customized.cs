
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.CTC.Entity
{
	public partial class CTCArquivos
	{
      public string SituacaoArquivoDescricao { get; set; }

      public string DescricaoErro { get; set; }

      public DateTime? GradeHorariaInicial { get; set; }
   }
}
