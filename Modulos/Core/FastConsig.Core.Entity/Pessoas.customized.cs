
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
using FastConsig.Common.Helpers;
#endregion

namespace FastConsig.Core.Entity
{
	public partial class Pessoas
	{
      [DataMember]
      public string OrgaoEmissorDescricao { get; set; }

      [DataMember]
      public string TipoDocumentoIdentidadeDescricao { get; set; }

      [DataMember]
      public string CelularFormatado
      {
         get
         {
            return (Celular == null ? null : "(" + this.DDDCelular + ") " + this.Celular.Value.ToString("######-####"));
         }
      }

      [DataMember]
      public string CpfCnpjFormatado
      {
         get
         {
            if (string.IsNullOrEmpty(this.CpfCnpj))
            {
               return null;
            }
            else if (UtilityHelper.IsCpf(UtilityHelper.ExtractNumber($"{long.Parse(this.CpfCnpj.Trim()).ToString().PadLeft(11, '0'):000000000000}")))
            {
               return Extensions.FormatCPF(UtilityHelper.ExtractNumber($"{long.Parse(this.CpfCnpj.Trim()).ToString().PadLeft(11, '0'):000000000000}"));
            }
            else
            {
               return Extensions.FormatCNPJ(UtilityHelper.ExtractNumber($"{this.CpfCnpj:00000000000000}"));
            }
         }

         set
         {
            this.CpfCnpj = UtilityHelper.ExtractNumber(this.CpfCnpjFormatado);
         }
      }

      [DataMember]
      public string CepResidencialFormatado
      {
         get
         {
            if (CEPResidencial != null)
            {
               return Convert.ToUInt64(CEPResidencial).ToString(@"00000\-000");
            }
            else return null;
         }
      }

      [DataMember]
      public string CepComercialFormatado
      {
         get
         {
            if (CEPComercial != null)
            {
               return Convert.ToUInt64(CEPComercial).ToString(@"00000\-000");
            }
            else return null;
         }
      }

      [DataMember]
      public string EnderecoResidencialFormatado
      {
         get
         {
            if (EnderecoResidencial != null)
            {
               return EnderecoResidencial.Trim() + (NumeroResidencial != null ? ", " + NumeroResidencial.Trim() : "") + (ComplementoResidencial != null ? " - " + ComplementoResidencial.Trim() : "") + (BairroResidencial != null ? " - " + BairroResidencial.Trim() : "");
            }
            else return null;
         }
      }

      [DataMember]
      public string EnderecoComercialFormatado
      {
         get
         {
            if (EnderecoComercial != null)
            {
               return EnderecoComercial.Trim() + (NumeroComercial != null ? ", " + NumeroComercial.Trim() : "") + (ComplementoComercial != null ? " - " + ComplementoComercial.Trim() : "") + (BairroComercial != null ? " - " + BairroComercial.Trim() : "");
            }
            else return null;
         }
      }

      [DataMember]
      public string TipoCompromisso { get; set; }

      [DataMember]
      public int TipoCompromissoCodigo
      {
         get
         {
            return (TipoCompromisso == "CL" ? 1 : (TipoCompromisso == "PR" ? 4 : (TipoCompromisso == "AV" ? 2 : (TipoCompromisso == "CM" ? 3 : (TipoCompromisso == "CC" ? 6 : (TipoCompromisso == "AN" ? 5 : (TipoCompromisso == "SC" ? 7 : (TipoCompromisso == "SD" ? 8 : 0))))))));
         }
      }

      [DataMember]
      public string TipoCompromissoDescricao
      {
         get
         {
            return (TipoCompromisso == "CL" ? "Proponente" : (TipoCompromisso == "PR" ? "Proponente" : (TipoCompromisso == "AV" ? "Devedor Solidário" : (TipoCompromisso == "CM" ? "Complementar" : (TipoCompromisso == "CC" ? "Complementar" : (TipoCompromisso == "AN" ? "Anuente" : (TipoCompromisso == "SC" ? "Sócio" : (TipoCompromisso == "SD" ? "Sacado" : "Não Definido"))))))));
         }
      }

      [DataMember]
      public string CelularAux
      {
         get
         {
            return (Celular == null ? null : "(" + this.DDDCelular + ") " + this.Celular.Value.ToString("######-####"));
         }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               this.DDDCelular = null;
               this.Celular = null;
            }
            else
            {
               var celular = value.Split(' ');

               this.DDDCelular = Convert.ToInt32(celular[0].Replace("(", "").Replace(")", ""));
               this.Celular = Convert.ToInt32(celular[1].Replace("-", ""));
            }
         }
      }
   }
}
