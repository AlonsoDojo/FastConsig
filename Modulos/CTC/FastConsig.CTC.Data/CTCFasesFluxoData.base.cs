
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
	public partial class CTCFasesFluxoData : DataBase
	{
		
		#region Listar
		public List<CTCFasesFluxo> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFasesFluxo.METADADO.Id)
				.Field(CTCFasesFluxo.METADADO.TipoArquivo)
				.Field(CTCFasesFluxo.METADADO.TipoFluxo)
				.Field(CTCFasesFluxo.METADADO.Fase)
				.Field(CTCFasesFluxo.METADADO.Status)
				.Field(CTCFasesFluxo.METADADO.Ordem)
				.Table(CTCFasesFluxo.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCFasesFluxo> result = base.MapReaderToEntitySet<CTCFasesFluxo>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public CTCFasesFluxo Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFasesFluxo.METADADO.Id)
				.Field(CTCFasesFluxo.METADADO.TipoArquivo)
				.Field(CTCFasesFluxo.METADADO.TipoFluxo)
				.Field(CTCFasesFluxo.METADADO.Fase)
				.Field(CTCFasesFluxo.METADADO.Status)
				.Field(CTCFasesFluxo.METADADO.Ordem)
				.Table(CTCFasesFluxo.METADADO.tabelaNAME);

			query.Where
				.Add(CTCFasesFluxo.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCFasesFluxo result = base.MapReaderToEntity<CTCFasesFluxo>(cmd);
				return result;
			}
		}
		#endregion

	}
}
