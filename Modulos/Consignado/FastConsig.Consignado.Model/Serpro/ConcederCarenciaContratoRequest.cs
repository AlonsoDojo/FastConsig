using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class ConcederCarenciaContratoRequest : SiapeBaseRequest
   {
      public string CdOrgao { get; set; }

      public string CdMatricula { get; set; }

      public string OrgMatInst { get; set; }

      public string CdConvenio { get; set; }

      public string NrContratoOrigem { get; set; }

      public string NovoNrContrato { get; set; }

      public string VlDesconto { get; set; }

      public string PzDesconto { get; set; }

      public string VlBruto { get; set; }

      public string VlLiquido { get; set; }

      public string TxJurosMensal { get; set; }

      public string Iof { get; set; }

      public string Cet { get; set; }

      public string[] EmailsParaNotificacaoAnuencia { get; set; }

      public string UrlAceite { get; set; }

      public string urlRecusa { get; set; }

      public string dtValidadeAnuencia { get; set; }

      public string CarenciaAte { get; set; }
   }
}
