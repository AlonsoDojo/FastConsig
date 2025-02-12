
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.CTC.Entity
{
	[Serializable]
	public partial class CTCPagamentosRecebidos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public int? Evento { get; set; }

		[DataLength(20)]
		public string NumeroControle { get; set; }

		public DateTime? DataBACEN { get; set; }

		[DataLength(8)]
		public string ISPBDebitado { get; set; }

		[DataLength(4)]
		public string AgenciaDebitada { get; set; }

		[DataLength(13)]
		public string ContaDebitada { get; set; }

		[DataLength(14)]
		public string CNPJDebitado { get; set; }

		[DataLength(150)]
		public string NomeClienteDebitado { get; set; }

		[DataLength(8)]
		public string ISPBCreditado { get; set; }

		[DataLength(4)]
		public string AgenciaCreditada { get; set; }

		[DataLength(13)]
		public string ContaCreditada { get; set; }

		[DataLength(14)]
		public string CNPJCreditado { get; set; }

		[DataLength(150)]
		public string NomeClienteCreditado { get; set; }

		[DataLength(18,2)]
		public decimal? ValorLancamento { get; set; }

		[DataLength(8)]
		public string ISPBPrestador { get; set; }

		public DateTime? DataMovimento { get; set; }

		[DataLength(21)]
		public string NUPortabilidade { get; set; }

		public bool Acatado { get; set; }

		public bool Conciliado { get; set; }

		public bool Devolvido { get; set; }

		[DataLength(50)]
		public string UsuarioAcatador { get; set; }

		[DataLength(50)]
		public string UsuarioDevolucao { get; set; }

		public DateTime? DataAcatamento { get; set; }

		public DateTime? DataDevolucao { get; set; }

		public int? Devolucao { get; set; }

		[ForeignKey]
		public int? Requisicao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCPagamentosRecebidos";
			public static readonly FieldReference Id = "CTCPagamentosRecebidos.Id";
			public static readonly FieldReference Evento = "CTCPagamentosRecebidos.Evento";
			public static readonly FieldReference NumeroControle = "CTCPagamentosRecebidos.NumeroControle";
			public static readonly FieldReference DataBACEN = "CTCPagamentosRecebidos.DataBACEN";
			public static readonly FieldReference ISPBDebitado = "CTCPagamentosRecebidos.ISPBDebitado";
			public static readonly FieldReference AgenciaDebitada = "CTCPagamentosRecebidos.AgenciaDebitada";
			public static readonly FieldReference ContaDebitada = "CTCPagamentosRecebidos.ContaDebitada";
			public static readonly FieldReference CNPJDebitado = "CTCPagamentosRecebidos.CNPJDebitado";
			public static readonly FieldReference NomeClienteDebitado = "CTCPagamentosRecebidos.NomeClienteDebitado";
			public static readonly FieldReference ISPBCreditado = "CTCPagamentosRecebidos.ISPBCreditado";
			public static readonly FieldReference AgenciaCreditada = "CTCPagamentosRecebidos.AgenciaCreditada";
			public static readonly FieldReference ContaCreditada = "CTCPagamentosRecebidos.ContaCreditada";
			public static readonly FieldReference CNPJCreditado = "CTCPagamentosRecebidos.CNPJCreditado";
			public static readonly FieldReference NomeClienteCreditado = "CTCPagamentosRecebidos.NomeClienteCreditado";
			public static readonly FieldReference ValorLancamento = "CTCPagamentosRecebidos.ValorLancamento";
			public static readonly FieldReference ISPBPrestador = "CTCPagamentosRecebidos.ISPBPrestador";
			public static readonly FieldReference DataMovimento = "CTCPagamentosRecebidos.DataMovimento";
			public static readonly FieldReference NUPortabilidade = "CTCPagamentosRecebidos.NUPortabilidade";
			public static readonly FieldReference Acatado = "CTCPagamentosRecebidos.Acatado";
			public static readonly FieldReference Conciliado = "CTCPagamentosRecebidos.Conciliado";
			public static readonly FieldReference Devolvido = "CTCPagamentosRecebidos.Devolvido";
			public static readonly FieldReference UsuarioAcatador = "CTCPagamentosRecebidos.UsuarioAcatador";
			public static readonly FieldReference UsuarioDevolucao = "CTCPagamentosRecebidos.UsuarioDevolucao";
			public static readonly FieldReference DataAcatamento = "CTCPagamentosRecebidos.DataAcatamento";
			public static readonly FieldReference DataDevolucao = "CTCPagamentosRecebidos.DataDevolucao";
			public static readonly FieldReference Devolucao = "CTCPagamentosRecebidos.Devolucao";
			public static readonly FieldReference Requisicao = "CTCPagamentosRecebidos.Requisicao";
		}
		#endregion
	}
}
