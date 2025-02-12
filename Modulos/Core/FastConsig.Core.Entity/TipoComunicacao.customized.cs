
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
	public partial class TipoComunicacao
	{
      [DataMember]
      public string Descricao
      {
         get
         {
            string retorno = "";

            if (this.SMS)
            {
               retorno += (retorno == "" ? "SMS" : " + SMS");
            }

            if (this.EMail)
            {
               retorno += (retorno == "" ? "E-Mail" : " + E-Mail");
            }

            if (this.Whatsapp)
            {
               retorno += (retorno == "" ? "Whatsapp" : " + Whatsapp");
            }

            if (this.Fisico)
            {
               retorno += (retorno == "" ? "Fisico" : " + Fisico");
            }

            return retorno;
         }
      }
   }
}
