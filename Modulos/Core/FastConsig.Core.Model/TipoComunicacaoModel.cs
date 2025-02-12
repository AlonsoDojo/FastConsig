using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model
{
   public class TipoComunicacaoModel
   {
      public int? Id { get; set; }

      public bool SMS { get; set; }

      public bool EMail { get; set; }

      public bool Whatsapp { get; set; }

      public bool Fisico { get; set; }

      public string Descricao { get; set; }
   }
}
