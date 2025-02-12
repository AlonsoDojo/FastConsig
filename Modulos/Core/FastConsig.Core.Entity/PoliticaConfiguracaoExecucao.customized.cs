
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
   public partial class PoliticaConfiguracaoExecucao
   {
      public string Metodo { get; set; }

      public bool Simulacao { get; set; }

      public string TipoPessoaCodigo { get; set; }
   }
}
