
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
	public partial class ViewContratosREFINUtilizadosData : DataBase
	{
		
		#region Listar
		public List<ViewContratosREFINUtilizados> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewContratosREFINUtilizados.METADADO.CpfCnpj)
				.Field(ViewContratosREFINUtilizados.METADADO.Proposta)
				.Field(ViewContratosREFINUtilizados.METADADO.Empresa)
				.Field(ViewContratosREFINUtilizados.METADADO.Agencia)
				.Field(ViewContratosREFINUtilizados.METADADO.Contrato)
				.Field(ViewContratosREFINUtilizados.METADADO.RedeLojas)
				.Field(ViewContratosREFINUtilizados.METADADO.Loja)
				.Field(ViewContratosREFINUtilizados.METADADO.TipoBeneficio)
				.Table(ViewContratosREFINUtilizados.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<ViewContratosREFINUtilizados> result = base.MapReaderToEntitySet<ViewContratosREFINUtilizados>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public ViewContratosREFINUtilizados Obtem(string CpfCnpj)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewContratosREFINUtilizados.METADADO.CpfCnpj)
				.Field(ViewContratosREFINUtilizados.METADADO.Proposta)
				.Field(ViewContratosREFINUtilizados.METADADO.Empresa)
				.Field(ViewContratosREFINUtilizados.METADADO.Agencia)
				.Field(ViewContratosREFINUtilizados.METADADO.Contrato)
				.Field(ViewContratosREFINUtilizados.METADADO.RedeLojas)
				.Field(ViewContratosREFINUtilizados.METADADO.Loja)
				.Field(ViewContratosREFINUtilizados.METADADO.TipoBeneficio)
				.Table(ViewContratosREFINUtilizados.METADADO.tabelaNAME);

			query.Where
				.Add(ViewContratosREFINUtilizados.METADADO.CpfCnpj, Filter.Equal, CpfCnpj);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				ViewContratosREFINUtilizados result = base.MapReaderToEntity<ViewContratosREFINUtilizados>(cmd);
				return result;
			}
		}
		#endregion

	}
}
