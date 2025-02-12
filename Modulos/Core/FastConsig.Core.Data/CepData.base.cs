
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
	public partial class CepData : DataBase
	{
		
		#region Listar
		public List<Cep> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Cep.METADADO.UF)
				.Field(Cep.METADADO.Localidade)
				.Field(Cep.METADADO.Bairro)
				.Field(Cep.METADADO.Logradouro)
				.Field(Cep.METADADO.CEP)
				.Field(Cep.METADADO.Complemento)
				.Field(Cep.METADADO.Nome)
				.Field(Cep.METADADO.LogradouroAbreviado)
				.Field(Cep.METADADO.CodigoIBGE)
				.Table(Cep.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<Cep> result = base.MapReaderToEntitySet<Cep>(cmd);
				return result;
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Cep obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Cep.METADADO.tabelaNAME)
				.FieldValue(Cep.METADADO.UF, obj.UF)
				.FieldValue(Cep.METADADO.Localidade, obj.Localidade)
				.FieldValue(Cep.METADADO.Bairro, obj.Bairro)
				.FieldValue(Cep.METADADO.Logradouro, obj.Logradouro)
				.FieldValue(Cep.METADADO.CEP, obj.CEP)
				.FieldValue(Cep.METADADO.Complemento, obj.Complemento)
				.FieldValue(Cep.METADADO.Nome, obj.Nome)
				.FieldValue(Cep.METADADO.LogradouroAbreviado, obj.LogradouroAbreviado)
				.FieldValue(Cep.METADADO.CodigoIBGE, obj.CodigoIBGE);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		#endregion

	}
}
