
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	public partial class ViewMonitor : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Proposta { get; set; }

		public DateTime? DataCriacao { get; set; }

		[DataLength(14)]
		public string CPFCNPJ { get; set; }

		[DataLength(1)]
		public string TipoPessoa { get; set; }

		[DataLength(150)]
		public string NomeProponente { get; set; }

		[DataLength(20)]
		public string NumeroBeneficio { get; set; }

		public int? EspecieBeneficio { get; set; }

		public int? DDDCelular { get; set; }

		public int? Celular { get; set; }

		public int? Fase { get; set; }

		public int? Status { get; set; }

		[DataLength(50)]
		public string DescricaoFase { get; set; }

		[DataLength(50)]
		public string DescricaoStatus { get; set; }

		public int? Gerente { get; set; }

		[DataLength(50)]
		public string Usuario { get; set; }

		public int? Promotora { get; set; }

		public long? ProfissionalCertificado { get; set; }

		[DataLength(2147483647)]
		public string MotivoRecusa { get; set; }

		public int? Produto { get; set; }

		[DataLength(18)]
		public decimal? ValorOperacao { get; set; }

		[DataLength(12,2)]
		public decimal? ValorFinanciado { get; set; }

		public int? Prazo { get; set; }

		public DateTime? DataPrimeiroVencimento { get; set; }

		public int? Tabela { get; set; }

		[DataLength(50)]
		public string ContratoLegado { get; set; }

		[DataLength(50)]
		public string PropostaLegado { get; set; }

		public int? RedeLojas { get; set; }

		public int? Loja { get; set; }

		[DataLength(4)]
		public string BancoLiquidacao { get; set; }

		[DataLength(4)]
		public string AgenciaLiquidacao { get; set; }

		[DataLength(15)]
		public string ContaLiquidacao { get; set; }

		[DataLength(12,2)]
		public decimal? ValorLiberado { get; set; }

		public DateTime? DataAtualizacao { get; set; }

		[DataLength(50)]
		public string UsuarioProposta { get; set; }

		[DataLength(12,2)]
		public decimal? ValorParcela { get; set; }

		[DataLength(40)]
		public string NomeLoja { get; set; }

		[DataLength(100)]
		public string NomeUsuarioProposta { get; set; }

		public int? FamiliaProduto { get; set; }

		[DataLength(3)]
		public string ComissaoNMP { get; set; }

		[DataLength(2147483647)]
		public string MensagemPendencia { get; set; }

		public int? AguardandoLiberacao { get; set; }

		public DateTime? DataIntegracao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ViewMonitor";
			public static readonly FieldReference Proposta = "ViewMonitor.Proposta";
			public static readonly FieldReference DataCriacao = "ViewMonitor.DataCriacao";
			public static readonly FieldReference CPFCNPJ = "ViewMonitor.CPFCNPJ";
			public static readonly FieldReference TipoPessoa = "ViewMonitor.TipoPessoa";
			public static readonly FieldReference NomeProponente = "ViewMonitor.NomeProponente";
			public static readonly FieldReference NumeroBeneficio = "ViewMonitor.NumeroBeneficio";
			public static readonly FieldReference EspecieBeneficio = "ViewMonitor.EspecieBeneficio";
			public static readonly FieldReference DDDCelular = "ViewMonitor.DDDCelular";
			public static readonly FieldReference Celular = "ViewMonitor.Celular";
			public static readonly FieldReference Fase = "ViewMonitor.Fase";
			public static readonly FieldReference Status = "ViewMonitor.Status";
			public static readonly FieldReference DescricaoFase = "ViewMonitor.DescricaoFase";
			public static readonly FieldReference DescricaoStatus = "ViewMonitor.DescricaoStatus";
			public static readonly FieldReference Gerente = "ViewMonitor.Gerente";
			public static readonly FieldReference Usuario = "ViewMonitor.Usuario";
			public static readonly FieldReference Promotora = "ViewMonitor.Promotora";
			public static readonly FieldReference ProfissionalCertificado = "ViewMonitor.ProfissionalCertificado";
			public static readonly FieldReference MotivoRecusa = "ViewMonitor.MotivoRecusa";
			public static readonly FieldReference Produto = "ViewMonitor.Produto";
			public static readonly FieldReference ValorOperacao = "ViewMonitor.ValorOperacao";
			public static readonly FieldReference ValorFinanciado = "ViewMonitor.ValorFinanciado";
			public static readonly FieldReference Prazo = "ViewMonitor.Prazo";
			public static readonly FieldReference DataPrimeiroVencimento = "ViewMonitor.DataPrimeiroVencimento";
			public static readonly FieldReference Tabela = "ViewMonitor.Tabela";
			public static readonly FieldReference ContratoLegado = "ViewMonitor.ContratoLegado";
			public static readonly FieldReference PropostaLegado = "ViewMonitor.PropostaLegado";
			public static readonly FieldReference RedeLojas = "ViewMonitor.RedeLojas";
			public static readonly FieldReference Loja = "ViewMonitor.Loja";
			public static readonly FieldReference BancoLiquidacao = "ViewMonitor.BancoLiquidacao";
			public static readonly FieldReference AgenciaLiquidacao = "ViewMonitor.AgenciaLiquidacao";
			public static readonly FieldReference ContaLiquidacao = "ViewMonitor.ContaLiquidacao";
			public static readonly FieldReference ValorLiberado = "ViewMonitor.ValorLiberado";
			public static readonly FieldReference DataAtualizacao = "ViewMonitor.DataAtualizacao";
			public static readonly FieldReference UsuarioProposta = "ViewMonitor.UsuarioProposta";
			public static readonly FieldReference ValorParcela = "ViewMonitor.ValorParcela";
			public static readonly FieldReference NomeLoja = "ViewMonitor.NomeLoja";
			public static readonly FieldReference NomeUsuarioProposta = "ViewMonitor.NomeUsuarioProposta";
			public static readonly FieldReference FamiliaProduto = "ViewMonitor.FamiliaProduto";
			public static readonly FieldReference ComissaoNMP = "ViewMonitor.ComissaoNMP";
			public static readonly FieldReference MensagemPendencia = "ViewMonitor.MensagemPendencia";
			public static readonly FieldReference AguardandoLiberacao = "ViewMonitor.AguardandoLiberacao";
			public static readonly FieldReference DataIntegracao = "ViewMonitor.DataIntegracao";
		}
		#endregion
	}
}
