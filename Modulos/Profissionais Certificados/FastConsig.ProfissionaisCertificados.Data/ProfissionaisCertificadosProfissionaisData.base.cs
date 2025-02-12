
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.ProfissionaisCertificados.Entity;
#endregion

namespace FastConsig.ProfissionaisCertificados.Data
{
	public partial class ProfissionaisCertificadosProfissionaisData : DataBase
	{
		
		#region Listar
		public List<ProfissionaisCertificadosProfissionais> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Id)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Certificadora)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Cpf)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Nome)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.DataValidade)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado)
				.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ProfissionaisCertificadosProfissionais> result = base.MapReaderToEntitySet<ProfissionaisCertificadosProfissionais>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosProfissionais obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Cpf, obj.Cpf)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Nome, obj.Nome)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.DataValidade, obj.DataValidade)
				.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);

			update.Where
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Id, Filter.Equal, obj.Id)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Certificadora, Filter.Equal, obj.Certificadora)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado, Filter.Equal, obj.TipoCertificado)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao, Filter.Equal, obj.DataAprovacao)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado, Filter.Equal, obj.NumeroCertificado);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosProfissionais obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Id, obj.Id)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Certificadora, obj.Certificadora)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado, obj.TipoCertificado)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao, obj.DataAprovacao)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado, obj.NumeroCertificado)
				.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Cpf, obj.Cpf)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.Nome, obj.Nome)
				.FieldValue(ProfissionaisCertificadosProfissionais.METADADO.DataValidade, obj.DataValidade);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		public ProfissionaisCertificadosProfissionais Obtem(long? Id, int? Certificadora, int? TipoCertificado, DateTime? DataAprovacao, string NumeroCertificado)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Id)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Certificadora)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Cpf)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.Nome)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.DataValidade)
				.Field(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado)
				.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);

			query.Where
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Id, Filter.Equal, Id)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Certificadora, Filter.Equal, Certificadora)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado, Filter.Equal, TipoCertificado)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao, Filter.Equal, DataAprovacao)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado, Filter.Equal, NumeroCertificado);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ProfissionaisCertificadosProfissionais result = base.MapReaderToEntity<ProfissionaisCertificadosProfissionais>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Certificadora(int? Certificadora)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);
			delete.Where
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Certificadora, Filter.Equal, Certificadora);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoCertificado(int? TipoCertificado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);
			delete.Where
				.Add(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado, Filter.Equal, TipoCertificado);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id, int? Certificadora, int? TipoCertificado, DateTime? DataAprovacao, string NumeroCertificado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ProfissionaisCertificadosProfissionais.METADADO.tabelaNAME);
			delete.Where
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Id, Filter.Equal, Id)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.Certificadora, Filter.Equal, Certificadora)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.TipoCertificado, Filter.Equal, TipoCertificado)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.DataAprovacao, Filter.Equal, DataAprovacao)
				.Add(ProfissionaisCertificadosProfissionais.METADADO.NumeroCertificado, Filter.Equal, NumeroCertificado);

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
