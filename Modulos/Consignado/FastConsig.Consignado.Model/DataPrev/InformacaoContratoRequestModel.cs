using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class InformacaoContratoRequestModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio")]
      public long NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante")]
      public long CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("contratoEmprestimo")]
      public string ContratoEmprestimo { get; set; }

      [JsonProperty("indicadorAssinaturaCertDigitalICPBrasil")]
      public bool IndicadorAssinaturaCertDigitalIcpBrasil { get; set; }

      [JsonProperty("documentoOficialComFotoFrente")]
      public string DocumentoOficialComFotoFrente { get; set; }

      [JsonProperty("documentoOficialComFotoVerso")]
      public string DocumentoOficialComFotoVerso { get; set; }

      [JsonProperty("registroBiometricoFacial")]
      public string RegistroBiometricoFacial { get; set; }

      [JsonProperty("baseBiometrica")]
      public string BaseBiometrica { get; set; }

      [JsonProperty("score")]
      public string Score { get; set; }

      [JsonProperty("indicadorValidacaoComDocOficial")]
      public bool IndicadorValidacaoComDocOficial { get; set; }

      [JsonProperty("ip")]
      public string Ip { get; set; }

      [JsonProperty("dataHoraAssinatura")]
      public string DataHoraAssinatura { get; set; }

      [JsonProperty("latitude")]
      public string Latitude { get; set; }

      [JsonProperty("longitude")]
      public string Longitude { get; set; }

      [JsonProperty("dispositivo")]
      public string Dispositivo { get; set; }

      [JsonProperty("indicadorAnalfabetismo")]
      public bool IndicadorAnalfabetismo { get; set; }

      [JsonProperty("nsuContrato")]
      public string NsuContrato { get; set; }

      /// <summary>
      /// Quais são os domínios para o campo: “Tipo de autenticação adotado”?
      /// 01 – Dispositivos móveis via APP
      /// 02 – Centrais de atendimento(Call center)
      /// 03 – Internet Banking
      /// 04 – Correspondentes
      /// 05 – Agências ou rede conveniada
      /// 06 – ATM
      /// </summary>
      [JsonProperty("tipoAutenticacao")]
      public int TipoAutenticacao { get; set; }
   }
}
