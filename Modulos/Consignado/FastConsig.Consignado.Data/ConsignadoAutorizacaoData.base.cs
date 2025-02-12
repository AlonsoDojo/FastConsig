
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
#endregion

namespace FastConsig.Consignado.Data
{
	public partial class ConsignadoAutorizacaoData : DataBase
	{
		
		#region Listar
		public List<ConsignadoAutorizacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConsignadoAutorizacao.METADADO.Id)
				.Field(ConsignadoAutorizacao.METADADO.Cpf)
				.Field(ConsignadoAutorizacao.METADADO.CpfRepresentante)
				.Field(ConsignadoAutorizacao.METADADO.NsuAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.DataHoraAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.CanalAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.TipoDocumentoIdentificacao)
				.Field(ConsignadoAutorizacao.METADADO.DocumentoIdentificacao)
				.Field(ConsignadoAutorizacao.METADADO.ChaveIdentificadora)
				.Field(ConsignadoAutorizacao.METADADO.TermoAutorizacaoBeneficiario)
				.Field(ConsignadoAutorizacao.METADADO.PossuiAssinaturaRogo)
				.Field(ConsignadoAutorizacao.METADADO.TituloTermo)
				.Field(ConsignadoAutorizacao.METADADO.AutorTermo)
				.Field(ConsignadoAutorizacao.METADADO.CidadeAssinaturaTermo)
				.Field(ConsignadoAutorizacao.METADADO.DataHoraCriacaoTermo)
				.Field(ConsignadoAutorizacao.METADADO.TokenAutorizacao)
				.Field(ConsignadoAutorizacao.METADADO.DataValidadeAutorizacao)
				.Field(ConsignadoAutorizacao.METADADO.ConsignadoDetalhe)
				.Field(ConsignadoAutorizacao.METADADO.TipoConsignado)
				.Field(ConsignadoAutorizacao.METADADO.CodigoOrgao)
				.Field(ConsignadoAutorizacao.METADADO.CodigoMatricula)
				.Table(ConsignadoAutorizacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ConsignadoAutorizacao> result = base.MapReaderToEntitySet<ConsignadoAutorizacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ConsignadoAutorizacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ConsignadoAutorizacao.METADADO.Cpf, obj.Cpf)
				.FieldValue(ConsignadoAutorizacao.METADADO.CpfRepresentante, obj.CpfRepresentante)
				.FieldValue(ConsignadoAutorizacao.METADADO.NsuAutorizacaoDigital, obj.NsuAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataHoraAutorizacaoDigital, obj.DataHoraAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.CanalAutorizacaoDigital, obj.CanalAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.TipoDocumentoIdentificacao, obj.TipoDocumentoIdentificacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.DocumentoIdentificacao, obj.DocumentoIdentificacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.ChaveIdentificadora, obj.ChaveIdentificadora)
				.FieldValue(ConsignadoAutorizacao.METADADO.TermoAutorizacaoBeneficiario, obj.TermoAutorizacaoBeneficiario)
				.FieldValue(ConsignadoAutorizacao.METADADO.PossuiAssinaturaRogo, obj.PossuiAssinaturaRogo)
				.FieldValue(ConsignadoAutorizacao.METADADO.TituloTermo, obj.TituloTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.AutorTermo, obj.AutorTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.CidadeAssinaturaTermo, obj.CidadeAssinaturaTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataHoraCriacaoTermo, obj.DataHoraCriacaoTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.TokenAutorizacao, obj.TokenAutorizacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataValidadeAutorizacao, obj.DataValidadeAutorizacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.ConsignadoDetalhe, obj.ConsignadoDetalhe)
				.FieldValue(ConsignadoAutorizacao.METADADO.TipoConsignado, obj.TipoConsignado)
				.FieldValue(ConsignadoAutorizacao.METADADO.CodigoOrgao, obj.CodigoOrgao)
				.FieldValue(ConsignadoAutorizacao.METADADO.CodigoMatricula, obj.CodigoMatricula)
				.Table(ConsignadoAutorizacao.METADADO.tabelaNAME);

			update.Where
				.Add(ConsignadoAutorizacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ConsignadoAutorizacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ConsignadoAutorizacao.METADADO.tabelaNAME)
				.FieldValue(ConsignadoAutorizacao.METADADO.Cpf, obj.Cpf)
				.FieldValue(ConsignadoAutorizacao.METADADO.CpfRepresentante, obj.CpfRepresentante)
				.FieldValue(ConsignadoAutorizacao.METADADO.NsuAutorizacaoDigital, obj.NsuAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataHoraAutorizacaoDigital, obj.DataHoraAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.CanalAutorizacaoDigital, obj.CanalAutorizacaoDigital)
				.FieldValue(ConsignadoAutorizacao.METADADO.TipoDocumentoIdentificacao, obj.TipoDocumentoIdentificacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.DocumentoIdentificacao, obj.DocumentoIdentificacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.ChaveIdentificadora, obj.ChaveIdentificadora)
				.FieldValue(ConsignadoAutorizacao.METADADO.TermoAutorizacaoBeneficiario, obj.TermoAutorizacaoBeneficiario)
				.FieldValue(ConsignadoAutorizacao.METADADO.PossuiAssinaturaRogo, obj.PossuiAssinaturaRogo)
				.FieldValue(ConsignadoAutorizacao.METADADO.TituloTermo, obj.TituloTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.AutorTermo, obj.AutorTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.CidadeAssinaturaTermo, obj.CidadeAssinaturaTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataHoraCriacaoTermo, obj.DataHoraCriacaoTermo)
				.FieldValue(ConsignadoAutorizacao.METADADO.TokenAutorizacao, obj.TokenAutorizacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.DataValidadeAutorizacao, obj.DataValidadeAutorizacao)
				.FieldValue(ConsignadoAutorizacao.METADADO.ConsignadoDetalhe, obj.ConsignadoDetalhe)
				.FieldValue(ConsignadoAutorizacao.METADADO.TipoConsignado, obj.TipoConsignado)
				.FieldValue(ConsignadoAutorizacao.METADADO.CodigoOrgao, obj.CodigoOrgao)
				.FieldValue(ConsignadoAutorizacao.METADADO.CodigoMatricula, obj.CodigoMatricula)
				.SetIdentityField(ConsignadoAutorizacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ConsignadoAutorizacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConsignadoAutorizacao.METADADO.Id)
				.Field(ConsignadoAutorizacao.METADADO.Cpf)
				.Field(ConsignadoAutorizacao.METADADO.CpfRepresentante)
				.Field(ConsignadoAutorizacao.METADADO.NsuAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.DataHoraAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.CanalAutorizacaoDigital)
				.Field(ConsignadoAutorizacao.METADADO.TipoDocumentoIdentificacao)
				.Field(ConsignadoAutorizacao.METADADO.DocumentoIdentificacao)
				.Field(ConsignadoAutorizacao.METADADO.ChaveIdentificadora)
				.Field(ConsignadoAutorizacao.METADADO.TermoAutorizacaoBeneficiario)
				.Field(ConsignadoAutorizacao.METADADO.PossuiAssinaturaRogo)
				.Field(ConsignadoAutorizacao.METADADO.TituloTermo)
				.Field(ConsignadoAutorizacao.METADADO.AutorTermo)
				.Field(ConsignadoAutorizacao.METADADO.CidadeAssinaturaTermo)
				.Field(ConsignadoAutorizacao.METADADO.DataHoraCriacaoTermo)
				.Field(ConsignadoAutorizacao.METADADO.TokenAutorizacao)
				.Field(ConsignadoAutorizacao.METADADO.DataValidadeAutorizacao)
				.Field(ConsignadoAutorizacao.METADADO.ConsignadoDetalhe)
				.Field(ConsignadoAutorizacao.METADADO.TipoConsignado)
				.Field(ConsignadoAutorizacao.METADADO.CodigoOrgao)
				.Field(ConsignadoAutorizacao.METADADO.CodigoMatricula)
				.Table(ConsignadoAutorizacao.METADADO.tabelaNAME);

			query.Where
				.Add(ConsignadoAutorizacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ConsignadoAutorizacao result = base.MapReaderToEntity<ConsignadoAutorizacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ConsignadoAutorizacao.METADADO.tabelaNAME);
			delete.Where
				.Add(ConsignadoAutorizacao.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
