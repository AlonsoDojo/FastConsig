
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
	public partial class ViewCTCFluxoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<ViewCTCFluxoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Id)
				.Field(ViewCTCFluxoPortabilidade.METADADO.TipoArquivo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoArquivo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Fase)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoFase)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Peso)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoPolitica)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Metodo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Entrada)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Saida)
				.Field(ViewCTCFluxoPortabilidade.METADADO.TipoFluxo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoFluxo)
				.Table(ViewCTCFluxoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ViewCTCFluxoPortabilidade> result = base.MapReaderToEntitySet<ViewCTCFluxoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public ViewCTCFluxoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Id)
				.Field(ViewCTCFluxoPortabilidade.METADADO.TipoArquivo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoArquivo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Fase)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoFase)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Peso)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoPolitica)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Metodo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Entrada)
				.Field(ViewCTCFluxoPortabilidade.METADADO.Saida)
				.Field(ViewCTCFluxoPortabilidade.METADADO.TipoFluxo)
				.Field(ViewCTCFluxoPortabilidade.METADADO.DescricaoFluxo)
				.Table(ViewCTCFluxoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(ViewCTCFluxoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ViewCTCFluxoPortabilidade result = base.MapReaderToEntity<ViewCTCFluxoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

	}
}
