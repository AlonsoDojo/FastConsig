using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class RenovarContratoV2Request : SiapeBaseRequest
   {
      public string CdOrgao { get; set; }

      public string CdMatricula { get; set; }

      public string OrgMatInst { get; set; }

      public string CdConvenio { get; set; }

      public string NrContrato { get; set; }

      public int VlDesconto { get; set; }

      public int PzDesconto { get; set; }

      public int VlBruto { get; set; }

      public int VlLiquido { get; set; }

      public int TxJurosMensal { get; set; }

      public int Iof { get; set; }

      public int Cet { get; set; }

      public string[] ContratosRenovados { get; set; }

      public string[] EmailsParaNotificacaoAnuencia { get; set; }

      public string UrlAceite { get; set; }

      public string UrlRecusa { get; set; }

      public string DtValidadeAnuencia { get; set; }
   }
}
