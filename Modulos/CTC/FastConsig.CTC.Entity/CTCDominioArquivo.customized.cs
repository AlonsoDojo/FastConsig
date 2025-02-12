
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
	public partial class CTCDominioArquivo
	{
      public string DescricaoEmissor { get; set; }
      public string DescricaoDestinatario { get; set; }
      public string ISPBEmissor { get; set; }
      public string ISPBDestinatario { get; set; }
   }
}
