
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
	public partial class CTC921DetalhesData : DataBase
	{
		
		#region Listar
		public List<CTC921Detalhes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC921Detalhes.METADADO.Id)
				.Field(CTC921Detalhes.METADADO.CTC921)
				.Field(CTC921Detalhes.METADADO.TipoContrato)
				.Field(CTC921Detalhes.METADADO.EventoTarifa)
				.Field(CTC921Detalhes.METADADO.DataTarifa)
				.Field(CTC921Detalhes.METADADO.NUPortabilidade)
				.Field(CTC921Detalhes.METADADO.ISPBProponente)
				.Field(CTC921Detalhes.METADADO.Contrato)
				.Field(CTC921Detalhes.METADADO.CNPJIFOriginadoraContrato)
				.Field(CTC921Detalhes.METADADO.EnteConsignante)
				.Field(CTC921Detalhes.METADADO.TipoCliente)
				.Field(CTC921Detalhes.METADADO.CpfCnpjCliente)
				.Field(CTC921Detalhes.METADADO.NomeCliente)
				.Field(CTC921Detalhes.METADADO.TelefoneCliente)
				.Field(CTC921Detalhes.METADADO.EmailCliente)
				.Table(CTC921Detalhes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC921Detalhes> result = base.MapReaderToEntitySet<CTC921Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC921Detalhes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC921Detalhes.METADADO.CTC921, obj.CTC921)
				.FieldValue(CTC921Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC921Detalhes.METADADO.EventoTarifa, obj.EventoTarifa)
				.FieldValue(CTC921Detalhes.METADADO.DataTarifa, obj.DataTarifa)
				.FieldValue(CTC921Detalhes.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTC921Detalhes.METADADO.ISPBProponente, obj.ISPBProponente)
				.FieldValue(CTC921Detalhes.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTC921Detalhes.METADADO.CNPJIFOriginadoraContrato, obj.CNPJIFOriginadoraContrato)
				.FieldValue(CTC921Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC921Detalhes.METADADO.TipoCliente, obj.TipoCliente)
				.FieldValue(CTC921Detalhes.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTC921Detalhes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC921Detalhes.METADADO.TelefoneCliente, obj.TelefoneCliente)
				.FieldValue(CTC921Detalhes.METADADO.EmailCliente, obj.EmailCliente)
				.Table(CTC921Detalhes.METADADO.tabelaNAME);

			update.Where
				.Add(CTC921Detalhes.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC921Detalhes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC921Detalhes.METADADO.tabelaNAME)
				.FieldValue(CTC921Detalhes.METADADO.CTC921, obj.CTC921)
				.FieldValue(CTC921Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC921Detalhes.METADADO.EventoTarifa, obj.EventoTarifa)
				.FieldValue(CTC921Detalhes.METADADO.DataTarifa, obj.DataTarifa)
				.FieldValue(CTC921Detalhes.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTC921Detalhes.METADADO.ISPBProponente, obj.ISPBProponente)
				.FieldValue(CTC921Detalhes.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTC921Detalhes.METADADO.CNPJIFOriginadoraContrato, obj.CNPJIFOriginadoraContrato)
				.FieldValue(CTC921Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC921Detalhes.METADADO.TipoCliente, obj.TipoCliente)
				.FieldValue(CTC921Detalhes.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTC921Detalhes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC921Detalhes.METADADO.TelefoneCliente, obj.TelefoneCliente)
				.FieldValue(CTC921Detalhes.METADADO.EmailCliente, obj.EmailCliente)
				.SetIdentityField(CTC921Detalhes.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC921Detalhes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC921Detalhes.METADADO.Id)
				.Field(CTC921Detalhes.METADADO.CTC921)
				.Field(CTC921Detalhes.METADADO.TipoContrato)
				.Field(CTC921Detalhes.METADADO.EventoTarifa)
				.Field(CTC921Detalhes.METADADO.DataTarifa)
				.Field(CTC921Detalhes.METADADO.NUPortabilidade)
				.Field(CTC921Detalhes.METADADO.ISPBProponente)
				.Field(CTC921Detalhes.METADADO.Contrato)
				.Field(CTC921Detalhes.METADADO.CNPJIFOriginadoraContrato)
				.Field(CTC921Detalhes.METADADO.EnteConsignante)
				.Field(CTC921Detalhes.METADADO.TipoCliente)
				.Field(CTC921Detalhes.METADADO.CpfCnpjCliente)
				.Field(CTC921Detalhes.METADADO.NomeCliente)
				.Field(CTC921Detalhes.METADADO.TelefoneCliente)
				.Field(CTC921Detalhes.METADADO.EmailCliente)
				.Table(CTC921Detalhes.METADADO.tabelaNAME);

			query.Where
				.Add(CTC921Detalhes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC921Detalhes result = base.MapReaderToEntity<CTC921Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921Detalhes.METADADO.TipoContrato, Filter.Equal, TipoContrato);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_EventoTarifa(string EventoTarifa)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921Detalhes.METADADO.EventoTarifa, Filter.Equal, EventoTarifa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921Detalhes.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoCliente(string TipoCliente)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921Detalhes.METADADO.TipoCliente, Filter.Equal, TipoCliente);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921Detalhes.METADADO.Id, Filter.Equal, Id);

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
