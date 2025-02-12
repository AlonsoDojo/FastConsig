using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class Beneficio : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("elegivelEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? ElegivelEmprestimo { get; set; }

      [JsonProperty("bloqueadoEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? BloqueadoEmprestimo { get; set; }

      [JsonProperty("dataDespacho", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataDespacho { get; set; }

      public InfoBeneficioResponseModel InfoBeneficio { get; set; }

      public AverbacaoEmprestimoConsignadoModel Averbacao { get; set; }

      /// <summary>
      /// Modelo para refinanciamento do INSS DataPrev.
      /// </summary>
      public RefinanciamentoModel Refinanciamento { get; set; }

      /// <summary>
      /// Após a execução de uma da operação de averbação é  possível incluir as informações do contrato incluído ou alterado.
      /// </summary>
      public InformacaoContratoRequestModel InformacaoContrato { get; set; }
   }
}
