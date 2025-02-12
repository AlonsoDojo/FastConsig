
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
	public partial class PropostaOcorrencias
	{
      [DataMember]
      public string DescricaoOcorrencia { get; set; }

      [DataMember]
      public string NomeUsuario { get; set; }

      [DataMember]
      public string IconClass
      {
         get
         {
            if (this.Restritiva != null)
            {
               switch (this.Restritiva)
               {
                  case "S":
                     if (this.Liberada)
                     {
                        return "uil-check-circle";
                     }
                     else
                     {
                        return "uil-exclamation-circle";
                     }
                  case "N":
                     return "uil-check-circle";
                  case "I":
                     return "uil-info-circle";
                  case "P":
                     return "uil-info-circle";
                  default:
                     return "";
               }
            }
            else { return ""; }
         }
      }

      [DataMember]
      public string RestritivaDescricao
      {
         get
         {
            if (this.Restritiva != null)
            {
               switch (this.Restritiva)
               {
                  case "S":
                     return "SIM";
                  case "N":
                     return "NÃO";
                  case "I":
                     return "INFORMATIVA";
                  case "P":
                     return "PENDÊNCIA";
                  default:
                     return "";
               }
            }
            else { return ""; }
         }
      }

      [DataMember]
      public string LiberadaDescricao
      {
         get
         {
            switch (this.Liberada)
            {
               case true:
                  return "SIM";
               case false:
                  return "NÃO";
               default:
                  return "";
            }
         }
      }

   }
}
