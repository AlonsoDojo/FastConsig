
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Data;
#endregion

namespace FastConsig.Consignado.Business
{
	public partial class ConfiguracaoJobBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ConfiguracaoJob> Listar(WhereBuilder filtro)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			return objConfiguracaoJobData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ConfiguracaoJob obj)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			objConfiguracaoJobData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ConfiguracaoJob obj)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			objConfiguracaoJobData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ConfiguracaoJob Obtem(int? Id)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			return objConfiguracaoJobData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJob(int? IdJob)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			objConfiguracaoJobData.ExcluirPor_IdJob(IdJob);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ConfiguracaoJobData objConfiguracaoJobData = new ConfiguracaoJobData();

			#region Regras de negócio
			#endregion

			objConfiguracaoJobData.Excluir(Id);
		}
		#endregion

	}
}
