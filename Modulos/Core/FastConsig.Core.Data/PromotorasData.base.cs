
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class PromotorasData : DataBase
	{
		
		#region Listar
		public List<Promotoras> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Promotoras.METADADO.Id)
				.Field(Promotoras.METADADO.Nome)
				.Field(Promotoras.METADADO.Cep)
				.Field(Promotoras.METADADO.Endereco)
				.Field(Promotoras.METADADO.Numero)
				.Field(Promotoras.METADADO.Complemento)
				.Field(Promotoras.METADADO.Bairro)
				.Field(Promotoras.METADADO.Cidade)
				.Field(Promotoras.METADADO.Estado)
				.Field(Promotoras.METADADO.Telefone)
				.Field(Promotoras.METADADO.Email)
				.Field(Promotoras.METADADO.Cnpj)
				.Field(Promotoras.METADADO.Ativo)
				.Field(Promotoras.METADADO.Correspondente)
				.Field(Promotoras.METADADO.NomeFantasia)
				.Field(Promotoras.METADADO.IndiceReclamacoes)
				.Field(Promotoras.METADADO.ResultadoReclamacoes)
				.Field(Promotoras.METADADO.IndiceAcoesJudiciais)
				.Field(Promotoras.METADADO.ResultadoAcoesJudiciais)
				.Field(Promotoras.METADADO.IndicadorNaoConformidade)
				.Field(Promotoras.METADADO.DataBaseConsultaQuadroSocietario)
				.Field(Promotoras.METADADO.Gerente)
				.Table(Promotoras.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Promotoras> result = base.MapReaderToEntitySet<Promotoras>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Promotoras obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Promotoras.METADADO.Nome, obj.Nome)
				.FieldValue(Promotoras.METADADO.Cep, obj.Cep)
				.FieldValue(Promotoras.METADADO.Endereco, obj.Endereco)
				.FieldValue(Promotoras.METADADO.Numero, obj.Numero)
				.FieldValue(Promotoras.METADADO.Complemento, obj.Complemento)
				.FieldValue(Promotoras.METADADO.Bairro, obj.Bairro)
				.FieldValue(Promotoras.METADADO.Cidade, obj.Cidade)
				.FieldValue(Promotoras.METADADO.Estado, obj.Estado)
				.FieldValue(Promotoras.METADADO.Telefone, obj.Telefone)
				.FieldValue(Promotoras.METADADO.Email, obj.Email)
				.FieldValue(Promotoras.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(Promotoras.METADADO.Ativo, obj.Ativo)
				.FieldValue(Promotoras.METADADO.Correspondente, obj.Correspondente)
				.FieldValue(Promotoras.METADADO.NomeFantasia, obj.NomeFantasia)
				.FieldValue(Promotoras.METADADO.IndiceReclamacoes, obj.IndiceReclamacoes)
				.FieldValue(Promotoras.METADADO.ResultadoReclamacoes, obj.ResultadoReclamacoes)
				.FieldValue(Promotoras.METADADO.IndiceAcoesJudiciais, obj.IndiceAcoesJudiciais)
				.FieldValue(Promotoras.METADADO.ResultadoAcoesJudiciais, obj.ResultadoAcoesJudiciais)
				.FieldValue(Promotoras.METADADO.IndicadorNaoConformidade, obj.IndicadorNaoConformidade)
				.FieldValue(Promotoras.METADADO.DataBaseConsultaQuadroSocietario, obj.DataBaseConsultaQuadroSocietario)
				.FieldValue(Promotoras.METADADO.Gerente, obj.Gerente)
				.Table(Promotoras.METADADO.tabelaNAME);

			update.Where
				.Add(Promotoras.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Promotoras obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Promotoras.METADADO.tabelaNAME)
				.FieldValue(Promotoras.METADADO.Nome, obj.Nome)
				.FieldValue(Promotoras.METADADO.Cep, obj.Cep)
				.FieldValue(Promotoras.METADADO.Endereco, obj.Endereco)
				.FieldValue(Promotoras.METADADO.Numero, obj.Numero)
				.FieldValue(Promotoras.METADADO.Complemento, obj.Complemento)
				.FieldValue(Promotoras.METADADO.Bairro, obj.Bairro)
				.FieldValue(Promotoras.METADADO.Cidade, obj.Cidade)
				.FieldValue(Promotoras.METADADO.Estado, obj.Estado)
				.FieldValue(Promotoras.METADADO.Telefone, obj.Telefone)
				.FieldValue(Promotoras.METADADO.Email, obj.Email)
				.FieldValue(Promotoras.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(Promotoras.METADADO.Ativo, obj.Ativo)
				.FieldValue(Promotoras.METADADO.Correspondente, obj.Correspondente)
				.FieldValue(Promotoras.METADADO.NomeFantasia, obj.NomeFantasia)
				.FieldValue(Promotoras.METADADO.IndiceReclamacoes, obj.IndiceReclamacoes)
				.FieldValue(Promotoras.METADADO.ResultadoReclamacoes, obj.ResultadoReclamacoes)
				.FieldValue(Promotoras.METADADO.IndiceAcoesJudiciais, obj.IndiceAcoesJudiciais)
				.FieldValue(Promotoras.METADADO.ResultadoAcoesJudiciais, obj.ResultadoAcoesJudiciais)
				.FieldValue(Promotoras.METADADO.IndicadorNaoConformidade, obj.IndicadorNaoConformidade)
				.FieldValue(Promotoras.METADADO.DataBaseConsultaQuadroSocietario, obj.DataBaseConsultaQuadroSocietario)
				.FieldValue(Promotoras.METADADO.Gerente, obj.Gerente)
            .SetIdentityField(Promotoras.METADADO.Id);
         #endregion

         using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

            obj.Id = base.ExecuteScalar<int?>(cmd);
         }
		}
		#endregion

		#region Obtem
		public Promotoras Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Promotoras.METADADO.Id)
				.Field(Promotoras.METADADO.Nome)
				.Field(Promotoras.METADADO.Cep)
				.Field(Promotoras.METADADO.Endereco)
				.Field(Promotoras.METADADO.Numero)
				.Field(Promotoras.METADADO.Complemento)
				.Field(Promotoras.METADADO.Bairro)
				.Field(Promotoras.METADADO.Cidade)
				.Field(Promotoras.METADADO.Estado)
				.Field(Promotoras.METADADO.Telefone)
				.Field(Promotoras.METADADO.Email)
				.Field(Promotoras.METADADO.Cnpj)
				.Field(Promotoras.METADADO.Ativo)
				.Field(Promotoras.METADADO.Correspondente)
				.Field(Promotoras.METADADO.NomeFantasia)
				.Field(Promotoras.METADADO.IndiceReclamacoes)
				.Field(Promotoras.METADADO.ResultadoReclamacoes)
				.Field(Promotoras.METADADO.IndiceAcoesJudiciais)
				.Field(Promotoras.METADADO.ResultadoAcoesJudiciais)
				.Field(Promotoras.METADADO.IndicadorNaoConformidade)
				.Field(Promotoras.METADADO.DataBaseConsultaQuadroSocietario)
				.Field(Promotoras.METADADO.Gerente)
				.Table(Promotoras.METADADO.tabelaNAME);

			query.Where
				.Add(Promotoras.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Promotoras result = base.MapReaderToEntity<Promotoras>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Gerente(int? Gerente)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Promotoras.METADADO.tabelaNAME);
			delete.Where
				.Add(Promotoras.METADADO.Gerente, Filter.Equal, Gerente);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(Promotoras.METADADO.tabelaNAME);
			delete.Where
				.Add(Promotoras.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
