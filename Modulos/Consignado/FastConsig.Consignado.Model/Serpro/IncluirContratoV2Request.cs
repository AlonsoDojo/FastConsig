using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class IncluirContratoV2Request : SiapeBaseRequest
   {
      /// <summary>
      /// Código do órgão.
      /// </summary>
      public string CdOrgao { get; set; }

      /// <summary>
      /// Matrícula do servidor ou pensionista.
      /// </summary>
      public string CdMatricula { get; set; }

      /// <summary>
      /// Órgão (numérico(5)) + Matrícula do Instituidor (numérico(07)).
      /// </summary>
      public string OrgMatInst { get; set; }

      /// <summary>
      /// Código do convênio que identifica o tipo de produto/serviço alvo da ação.
      /// </summary>
      public string CdConvenio { get; set; }

      /// <summary>
      /// Número do contrato.
      /// </summary>
      public string NrContrato { get; set; }

      /// <summary>
      /// Valor de desconto mensal.Se for informado este campo, os campos “vlPercentual”, “cdAssuntoCalculo” e “rubricas” não deverão ser informados e viceversa.
      /// /// </summary>
      public decimal VlDesconto { get; set; }

      public decimal PzDesconto { get; set; }

      public decimal VlBruto { get; set; }

      public decimal VlLiquido { get; set; }

      public decimal TxJurosMensal { get; set; }

      public decimal Iof { get; set; }

      public decimal Cet { get; set; }

      public decimal VlPercentual { get; set; }

      public string CdAssuntoCalculo { get; set; }

      public string[] Rubricas { get; set; }

      public string[] EmailsParaNotificacaoAnuencia { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public string UrlAceite { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public string UrlRecusa { get; set; }

      /// <summary>
      /// Data limite para o servidor aceitar ou rejeitar o contrato proposto no formato DD/MM/AAAA.Obrigatório somente para contratos de empréstimo.
      /// </summary>
      public string DtValidadeAnuencia { get; set; }
   }
}
