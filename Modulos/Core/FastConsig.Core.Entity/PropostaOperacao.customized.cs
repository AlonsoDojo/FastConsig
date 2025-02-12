
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
	public partial class PropostaOperacao
	{
      [DataMember]
      public string DescricaoProduto { get; set; }

      [DataMember]
      public string DescricaoPeriodo { get; set; }

      [DataMember]
      public string DescricaoOperacao { get; set; }

      [DataMember]
      public string DescricaoMoeda { get; set; }

      [DataMember]
      public string DescricaoDecisao { get; set; }

      [DataMember]
      public string DescricaoTaxa { get; set; }

      [DataMember]
      public string DescricaoIndexador { get; set; }

      [DataMember]
      public string PrazoFormatado
      {
         get
         {
            return this.Prazo.ToString() + " " + this.DescricaoPeriodo;
         }
      }

      [DataMember]
      public string TaxaFormatada
      {
         get
         {
            if (Taxa != null)
               return Taxa.Value.ToString("N6");
            return string.Empty;
         }
      }

      [DataMember]
      public List<PropostaParcelas> Parcelas { get; set; }

      public PropostaOperacao()
      {
         this.Parcelas = new List<PropostaParcelas>();
      }

      [DataMember]
      public string DataEmissaoFormatada
      {
         get
         {
            if (DataEmissao != null)
               return DataEmissao.Value.ToString("dd/MM/yyyy");
            return String.Empty;
         }
      }

      [DataMember]
      public string DataPrimeiroVencimentoFormatada
      {
         get
         {
            if (DataPrimeiroVencimento != null)
               return DataPrimeiroVencimento.Value.ToString("dd/MM/yyyy");
            return String.Empty;
         }
      }

      [DataMember]
      public string ValorFinanciadoTotalFormatado
      {
         get
         {
            if (ValorFinanciadoTotal != null)
               return ValorFinanciadoTotal.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorLiberadoFormatado
      {
         get
         {
            if (ValorLiberado != null)
               return ValorLiberado.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorEntradaFormatado
      {
         get
         {
            if (ValorEntrada != null)
               return ValorEntrada.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorSeguroFormatado
      {
         get
         {
            if (ValorSeguro != null)
               return ValorSeguro.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorTACFormatado
      {
         get
         {
            if (ValorTAC != null)
               return ValorTAC.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorTFCFormatado
      {
         get
         {
            if (ValorTFC != null)
               return ValorTFC.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorPSTFormatado
      {
         get
         {
            if (ValorPST != null)
               return ValorPST.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorParcelaFormatado
      {
         get
         {
            if (ValorParcela != null)
               return ValorParcela.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorIOFFormatado
      {
         get
         {
            if (ValorIOF != null)
               return ValorIOF.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorIOFNormalFormatado
      {
         get
         {
            if (ValorIOFNormal != null)
               return ValorIOFNormal.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string ValorIOFAdicionalFormatado
      {
         get
         {
            if (ValorIOFAdicional != null)
               return ValorIOFAdicional.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string TaxaMesFormatado
      {
         get
         {
            if (TaxaMes != null)
               return TaxaMes.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string TaxaAnoFormatado
      {
         get
         {
            if (TaxaAno != null)
               return TaxaAno.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string CETMesFormatado
      {
         get
         {
            if (CETMes != null)
               return CETMes.Value.ToString("N2");
            return string.Empty;
         }
      }

      [DataMember]
      public string CETAnoFormatado
      {
         get
         {
            if (CETAno != null)
               return CETAno.Value.ToString("N2");
            return string.Empty;
         }
      }
   }
}
