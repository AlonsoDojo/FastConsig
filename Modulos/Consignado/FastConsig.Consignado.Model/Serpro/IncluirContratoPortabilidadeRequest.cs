using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class IncluirContratoPortabilidadeRequest : SiapeBaseRequest
   {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
      public string NrCpf { get; set; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

      public string CdOrgao { get; set; }

      public string CdMatricula { get; set; }

      public string OrgMatInst { get; set; }

      public string CdConvenio { get; set; }

      public string NrContrato { get; set; }

      public string VlDesconto { get; set; }

      public string PzDesconto { get; set; }

      public string VlBruto { get; set; }

      public string VlLiquido { get; set; }

      public string TxJurosMensal { get; set; }

      public string Iof { get; set; }

      public string Cet { get; set; }

      public ContratoPortado ContratoPortado { get; set; }

      public string DtInicioProcessoCip { get; set; }

      public string NrProcessoCip { get; set; }
   }

   public class ContratoPortado
   {
      public string NrCnpj { get; set; }

      public string NrContrato { get; set; }
   }
}
