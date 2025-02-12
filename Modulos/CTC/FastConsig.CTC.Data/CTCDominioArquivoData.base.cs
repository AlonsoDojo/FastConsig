
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
	public partial class CTCDominioArquivoData : DataBase
	{
		
		#region Listar
		public List<CTCDominioArquivo> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCDominioArquivo.METADADO.Id)
				.Field(CTCDominioArquivo.METADADO.NomeArquivo)
				.Field(CTCDominioArquivo.METADADO.Classe)
				.Field(CTCDominioArquivo.METADADO.Monitorar)
				.Field(CTCDominioArquivo.METADADO.Entrada)
				.Field(CTCDominioArquivo.METADADO.Saida)
				.Field(CTCDominioArquivo.METADADO.GradeHorariaInicial)
				.Field(CTCDominioArquivo.METADADO.GradeHorariaFinal)
				.Field(CTCDominioArquivo.METADADO.Parser)
				.Field(CTCDominioArquivo.METADADO.Builder)
				.Field(CTCDominioArquivo.METADADO.Process)
				.Field(CTCDominioArquivo.METADADO.Arquivo)
				.Field(CTCDominioArquivo.METADADO.Protocolo)
				.Field(CTCDominioArquivo.METADADO.Retorno)
				.Field(CTCDominioArquivo.METADADO.Erro)
				.Field(CTCDominioArquivo.METADADO.Emissor)
				.Field(CTCDominioArquivo.METADADO.Destinatario)
				.Field(CTCDominioArquivo.METADADO.Online)
				.Field(CTCDominioArquivo.METADADO.LimiteRegistros)
				.Field(CTCDominioArquivo.METADADO.Descricao)
				.Field(CTCDominioArquivo.METADADO.Validator)
				.Field(CTCDominioArquivo.METADADO.XSD)
				.Field(CTCDominioArquivo.METADADO.Domingo)
				.Field(CTCDominioArquivo.METADADO.Segunda)
				.Field(CTCDominioArquivo.METADADO.Terca)
				.Field(CTCDominioArquivo.METADADO.Quarta)
				.Field(CTCDominioArquivo.METADADO.Quinta)
				.Field(CTCDominioArquivo.METADADO.Sexta)
				.Field(CTCDominioArquivo.METADADO.Sabado)
				.Field(CTCDominioArquivo.METADADO.ValidaDiaUtil)
				.Table(CTCDominioArquivo.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCDominioArquivo> result = base.MapReaderToEntitySet<CTCDominioArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCDominioArquivo obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCDominioArquivo.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTCDominioArquivo.METADADO.Classe, obj.Classe)
				.FieldValue(CTCDominioArquivo.METADADO.Monitorar, obj.Monitorar)
				.FieldValue(CTCDominioArquivo.METADADO.Entrada, obj.Entrada)
				.FieldValue(CTCDominioArquivo.METADADO.Saida, obj.Saida)
				.FieldValue(CTCDominioArquivo.METADADO.GradeHorariaInicial, obj.GradeHorariaInicial)
				.FieldValue(CTCDominioArquivo.METADADO.GradeHorariaFinal, obj.GradeHorariaFinal)
				.FieldValue(CTCDominioArquivo.METADADO.Parser, obj.Parser)
				.FieldValue(CTCDominioArquivo.METADADO.Builder, obj.Builder)
				.FieldValue(CTCDominioArquivo.METADADO.Process, obj.Process)
				.FieldValue(CTCDominioArquivo.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCDominioArquivo.METADADO.Protocolo, obj.Protocolo)
				.FieldValue(CTCDominioArquivo.METADADO.Retorno, obj.Retorno)
				.FieldValue(CTCDominioArquivo.METADADO.Erro, obj.Erro)
				.FieldValue(CTCDominioArquivo.METADADO.Emissor, obj.Emissor)
				.FieldValue(CTCDominioArquivo.METADADO.Destinatario, obj.Destinatario)
				.FieldValue(CTCDominioArquivo.METADADO.Online, obj.Online)
				.FieldValue(CTCDominioArquivo.METADADO.LimiteRegistros, obj.LimiteRegistros)
				.FieldValue(CTCDominioArquivo.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCDominioArquivo.METADADO.Validator, obj.Validator)
				.FieldValue(CTCDominioArquivo.METADADO.XSD, obj.XSD)
				.FieldValue(CTCDominioArquivo.METADADO.Domingo, obj.Domingo)
				.FieldValue(CTCDominioArquivo.METADADO.Segunda, obj.Segunda)
				.FieldValue(CTCDominioArquivo.METADADO.Terca, obj.Terca)
				.FieldValue(CTCDominioArquivo.METADADO.Quarta, obj.Quarta)
				.FieldValue(CTCDominioArquivo.METADADO.Quinta, obj.Quinta)
				.FieldValue(CTCDominioArquivo.METADADO.Sexta, obj.Sexta)
				.FieldValue(CTCDominioArquivo.METADADO.Sabado, obj.Sabado)
				.FieldValue(CTCDominioArquivo.METADADO.ValidaDiaUtil, obj.ValidaDiaUtil)
				.Table(CTCDominioArquivo.METADADO.tabelaNAME);

			update.Where
				.Add(CTCDominioArquivo.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCDominioArquivo obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCDominioArquivo.METADADO.tabelaNAME)
				.FieldValue(CTCDominioArquivo.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTCDominioArquivo.METADADO.Classe, obj.Classe)
				.FieldValue(CTCDominioArquivo.METADADO.Monitorar, obj.Monitorar)
				.FieldValue(CTCDominioArquivo.METADADO.Entrada, obj.Entrada)
				.FieldValue(CTCDominioArquivo.METADADO.Saida, obj.Saida)
				.FieldValue(CTCDominioArquivo.METADADO.GradeHorariaInicial, obj.GradeHorariaInicial)
				.FieldValue(CTCDominioArquivo.METADADO.GradeHorariaFinal, obj.GradeHorariaFinal)
				.FieldValue(CTCDominioArquivo.METADADO.Parser, obj.Parser)
				.FieldValue(CTCDominioArquivo.METADADO.Builder, obj.Builder)
				.FieldValue(CTCDominioArquivo.METADADO.Process, obj.Process)
				.FieldValue(CTCDominioArquivo.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCDominioArquivo.METADADO.Protocolo, obj.Protocolo)
				.FieldValue(CTCDominioArquivo.METADADO.Retorno, obj.Retorno)
				.FieldValue(CTCDominioArquivo.METADADO.Erro, obj.Erro)
				.FieldValue(CTCDominioArquivo.METADADO.Emissor, obj.Emissor)
				.FieldValue(CTCDominioArquivo.METADADO.Destinatario, obj.Destinatario)
				.FieldValue(CTCDominioArquivo.METADADO.Online, obj.Online)
				.FieldValue(CTCDominioArquivo.METADADO.LimiteRegistros, obj.LimiteRegistros)
				.FieldValue(CTCDominioArquivo.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCDominioArquivo.METADADO.Validator, obj.Validator)
				.FieldValue(CTCDominioArquivo.METADADO.XSD, obj.XSD)
				.FieldValue(CTCDominioArquivo.METADADO.Domingo, obj.Domingo)
				.FieldValue(CTCDominioArquivo.METADADO.Segunda, obj.Segunda)
				.FieldValue(CTCDominioArquivo.METADADO.Terca, obj.Terca)
				.FieldValue(CTCDominioArquivo.METADADO.Quarta, obj.Quarta)
				.FieldValue(CTCDominioArquivo.METADADO.Quinta, obj.Quinta)
				.FieldValue(CTCDominioArquivo.METADADO.Sexta, obj.Sexta)
				.FieldValue(CTCDominioArquivo.METADADO.Sabado, obj.Sabado)
				.FieldValue(CTCDominioArquivo.METADADO.ValidaDiaUtil, obj.ValidaDiaUtil)
				.SetIdentityField(CTCDominioArquivo.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCDominioArquivo Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCDominioArquivo.METADADO.Id)
				.Field(CTCDominioArquivo.METADADO.NomeArquivo)
				.Field(CTCDominioArquivo.METADADO.Classe)
				.Field(CTCDominioArquivo.METADADO.Monitorar)
				.Field(CTCDominioArquivo.METADADO.Entrada)
				.Field(CTCDominioArquivo.METADADO.Saida)
				.Field(CTCDominioArquivo.METADADO.GradeHorariaInicial)
				.Field(CTCDominioArquivo.METADADO.GradeHorariaFinal)
				.Field(CTCDominioArquivo.METADADO.Parser)
				.Field(CTCDominioArquivo.METADADO.Builder)
				.Field(CTCDominioArquivo.METADADO.Process)
				.Field(CTCDominioArquivo.METADADO.Arquivo)
				.Field(CTCDominioArquivo.METADADO.Protocolo)
				.Field(CTCDominioArquivo.METADADO.Retorno)
				.Field(CTCDominioArquivo.METADADO.Erro)
				.Field(CTCDominioArquivo.METADADO.Emissor)
				.Field(CTCDominioArquivo.METADADO.Destinatario)
				.Field(CTCDominioArquivo.METADADO.Online)
				.Field(CTCDominioArquivo.METADADO.LimiteRegistros)
				.Field(CTCDominioArquivo.METADADO.Descricao)
				.Field(CTCDominioArquivo.METADADO.Validator)
				.Field(CTCDominioArquivo.METADADO.XSD)
				.Field(CTCDominioArquivo.METADADO.Domingo)
				.Field(CTCDominioArquivo.METADADO.Segunda)
				.Field(CTCDominioArquivo.METADADO.Terca)
				.Field(CTCDominioArquivo.METADADO.Quarta)
				.Field(CTCDominioArquivo.METADADO.Quinta)
				.Field(CTCDominioArquivo.METADADO.Sexta)
				.Field(CTCDominioArquivo.METADADO.Sabado)
				.Field(CTCDominioArquivo.METADADO.ValidaDiaUtil)
				.Table(CTCDominioArquivo.METADADO.tabelaNAME);

			query.Where
				.Add(CTCDominioArquivo.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCDominioArquivo result = base.MapReaderToEntity<CTCDominioArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Emissor(int? Emissor)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCDominioArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCDominioArquivo.METADADO.Emissor, Filter.Equal, Emissor);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Destinatario(int? Destinatario)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCDominioArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCDominioArquivo.METADADO.Destinatario, Filter.Equal, Destinatario);

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
				delete.Table(CTCDominioArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCDominioArquivo.METADADO.Id, Filter.Equal, Id);

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
