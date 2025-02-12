
#region Usings
using System.ComponentModel.DataAnnotations;
using Framework.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using FastConsig.Common.Helpers;
#endregion

namespace FastConsig.Core.Entity
{
   public partial class ViewMonitor
   {
      public string NomeRedeLojasAbreviado { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("NomePromotora")]
      public string NomePromotora { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("NomeProduto")]
      public string NomeProduto { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("ValorOperacaoFormatado")]
      public string ValorOperacaoFormatado
      {
         get
         {
            if (ValorOperacao != null)
            {
               return ValorOperacao.Value.ToString("N2");
            }
            else
            {
               return null;
            }
         }
      }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("DataCriacaoFormatado")]
      public string DataCriacaoFormatado
      {
         get
         {
            if (DataCriacao != null)
            {
               return DataCriacao.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
               return null;
            }
         }
      }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("DataAtualizacaoFormatado")]
      public string DataAtualizacaoFormatado
      {
         get
         {
            if (DataCriacao != null)
            {
               return DataAtualizacao.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
               return null;
            }
         }
      }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("UsuarioPropostaFormatado")]
      public string UsuarioPropostaFormatado
      {
         get
         {
            return "";
         }
      }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("CPFCNPJFormatado")]
      public string CPFCNPJFormatado
      {
         get
         {
            if (CPFCNPJ != null)
            {
               if (TipoPessoa == "F")
               {
                  string cpf = "00000000000000" + CPFCNPJ.Trim();
                  cpf = cpf.Right(11);
                  return cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9);

               }
               else
               {
                  string cnpj = "000000000000000000" + CPFCNPJ.Trim();
                  cnpj = cnpj.Right(14);
                  return cnpj.Substring(0, 2) + "." + cnpj.Substring(2, 3) + "." + cnpj.Substring(5, 3) + "/" + cnpj.Substring(8, 4) + "-" + cnpj.Substring(12);
               }
            }
            else
            {
               return null;
            }
         }
      }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("AguardandoLiberacaoFormatado")]
      public string AguardandoLiberacaoFormatado
      {
         get
         {
            return "<img src='" + (AguardandoLiberacao > 0 ? "/Imagens/bullet-yellow.png" : "/Imagens/bullet-green.png") + "' style='width: 10px; height: 10px;' title='" + (AguardandoLiberacao > 0 ? "Existem Ocorrências Aguardando Liberação" : "Sem Ocorrências Aguardando Liberação") + "' />&nbsp;<a id=\"MainContent_PropostasRepeater_EditarProposta_" + Proposta + " title=\"Editar\" class=\"uil uil-pen font-size-16\" href=\"javascript:DoPostBackManualMonitor(" + Proposta + ")\"></a>";
         }
      }
   }
}
