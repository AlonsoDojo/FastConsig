
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCMotivoDevolucaoLiquidacaoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<CTCMotivoDevolucaoLiquidacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Descricao)
				.Table(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCMotivoDevolucaoLiquidacaoPortabilidade> result = base.MapReaderToEntitySet<CTCMotivoDevolucaoLiquidacaoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoDevolucaoLiquidacaoPortabilidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.Table(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			update.Where
				.Add(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoDevolucaoLiquidacaoPortabilidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.tabelaNAME)
				.FieldValue(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCMotivoDevolucaoLiquidacaoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Descricao)
				.Table(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCMotivoDevolucaoLiquidacaoPortabilidade result = base.MapReaderToEntity<CTCMotivoDevolucaoLiquidacaoPortabilidade>(cmd);
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
				delete.Table(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCMotivoDevolucaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

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
