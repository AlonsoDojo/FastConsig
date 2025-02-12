
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
#endregion

namespace FastConsig.Comunicado.Data
{
	public partial class ViewComunicadosData : DataBase
	{
		
		#region Listar
		public List<ViewComunicados> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewComunicados.METADADO.Comunicado)
				.Field(ViewComunicados.METADADO.Usuario)
				.Field(ViewComunicados.METADADO.DataLeitura)
				.Field(ViewComunicados.METADADO.DataVigenciaInicial)
				.Field(ViewComunicados.METADADO.DataVigenciaFinal)
				.Field(ViewComunicados.METADADO.Titulo)
				.Field(ViewComunicados.METADADO.ConfirmacaoLeitura)
				.Table(ViewComunicados.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ViewComunicados> result = base.MapReaderToEntitySet<ViewComunicados>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public ViewComunicados Obtem(int? Comunicado)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewComunicados.METADADO.Comunicado)
				.Field(ViewComunicados.METADADO.Usuario)
				.Field(ViewComunicados.METADADO.DataLeitura)
				.Field(ViewComunicados.METADADO.DataVigenciaInicial)
				.Field(ViewComunicados.METADADO.DataVigenciaFinal)
				.Field(ViewComunicados.METADADO.Titulo)
				.Field(ViewComunicados.METADADO.ConfirmacaoLeitura)
				.Table(ViewComunicados.METADADO.tabelaNAME);

			query.Where
				.Add(ViewComunicados.METADADO.Comunicado, Filter.Equal, Comunicado);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ViewComunicados result = base.MapReaderToEntity<ViewComunicados>(cmd);
				return result;
			}
		}
		#endregion

	}
}
