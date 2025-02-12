
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
	public partial class ViewPropostaCheckListData : DataBase
	{
		
		#region Listar
		public List<ViewPropostaCheckList> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewPropostaCheckList.METADADO.Id)
				.Field(ViewPropostaCheckList.METADADO.Proposta)
				.Field(ViewPropostaCheckList.METADADO.IdItem)
				.Field(ViewPropostaCheckList.METADADO.Descricao)
				.Field(ViewPropostaCheckList.METADADO.Obrigatorio)
				.Field(ViewPropostaCheckList.METADADO.TipoDocumento)
				.Field(ViewPropostaCheckList.METADADO.DocumentoNecessario)
				.Field(ViewPropostaCheckList.METADADO.Cumprido)
				.Table(ViewPropostaCheckList.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ViewPropostaCheckList> result = base.MapReaderToEntitySet<ViewPropostaCheckList>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public ViewPropostaCheckList Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewPropostaCheckList.METADADO.Id)
				.Field(ViewPropostaCheckList.METADADO.Proposta)
				.Field(ViewPropostaCheckList.METADADO.IdItem)
				.Field(ViewPropostaCheckList.METADADO.Descricao)
				.Field(ViewPropostaCheckList.METADADO.Obrigatorio)
				.Field(ViewPropostaCheckList.METADADO.TipoDocumento)
				.Field(ViewPropostaCheckList.METADADO.DocumentoNecessario)
				.Field(ViewPropostaCheckList.METADADO.Cumprido)
				.Table(ViewPropostaCheckList.METADADO.tabelaNAME);

			query.Where
				.Add(ViewPropostaCheckList.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ViewPropostaCheckList result = base.MapReaderToEntity<ViewPropostaCheckList>(cmd);
				return result;
			}
		}
		#endregion

	}
}
