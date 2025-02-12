
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
	[Serializable]
	[DataContract]
	public partial class ViewContratosREFINUtilizados : EntityBase
	{
		#region Propriedades
		[Key, DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("CpfCnpj")]
		public string CpfCnpj { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Empresa")]
		public string Empresa { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Agencia")]
		public string Agencia { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("Contrato")]
		public string Contrato { get; set; }

		[DataMember, JsonProperty("RedeLojas")]
		public int? RedeLojas { get; set; }

		[DataMember, JsonProperty("Loja")]
		public int? Loja { get; set; }

		[DataLength(3), MaxLength(3), StringLength(3), DataMember, JsonProperty("TipoBeneficio")]
		public string TipoBeneficio { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ViewContratosREFINUtilizados";
			public static readonly FieldReference CpfCnpj = "ViewContratosREFINUtilizados.CpfCnpj";
			public static readonly FieldReference Proposta = "ViewContratosREFINUtilizados.Proposta";
			public static readonly FieldReference Empresa = "ViewContratosREFINUtilizados.Empresa";
			public static readonly FieldReference Agencia = "ViewContratosREFINUtilizados.Agencia";
			public static readonly FieldReference Contrato = "ViewContratosREFINUtilizados.Contrato";
			public static readonly FieldReference RedeLojas = "ViewContratosREFINUtilizados.RedeLojas";
			public static readonly FieldReference Loja = "ViewContratosREFINUtilizados.Loja";
			public static readonly FieldReference TipoBeneficio = "ViewContratosREFINUtilizados.TipoBeneficio";
		}
		#endregion
	}
}
