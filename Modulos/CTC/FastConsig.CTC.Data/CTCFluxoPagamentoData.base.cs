
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
	public partial class CTCFluxoPagamentoData : DataBase
	{
		
		#region Listar
		public List<CTCFluxoPagamento> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFluxoPagamento.METADADO.Id)
				.Field(CTCFluxoPagamento.METADADO.Codigo)
				.Field(CTCFluxoPagamento.METADADO.Descricao)
				.Table(CTCFluxoPagamento.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCFluxoPagamento> result = base.MapReaderToEntitySet<CTCFluxoPagamento>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFluxoPagamento obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCFluxoPagamento.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCFluxoPagamento.METADADO.Descricao, obj.Descricao)
				.Table(CTCFluxoPagamento.METADADO.tabelaNAME);

			update.Where
				.Add(CTCFluxoPagamento.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFluxoPagamento obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCFluxoPagamento.METADADO.tabelaNAME)
				.FieldValue(CTCFluxoPagamento.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCFluxoPagamento.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCFluxoPagamento.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCFluxoPagamento Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFluxoPagamento.METADADO.Id)
				.Field(CTCFluxoPagamento.METADADO.Codigo)
				.Field(CTCFluxoPagamento.METADADO.Descricao)
				.Table(CTCFluxoPagamento.METADADO.tabelaNAME);

			query.Where
				.Add(CTCFluxoPagamento.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCFluxoPagamento result = base.MapReaderToEntity<CTCFluxoPagamento>(cmd);
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
				delete.Table(CTCFluxoPagamento.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFluxoPagamento.METADADO.Id, Filter.Equal, Id);

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
