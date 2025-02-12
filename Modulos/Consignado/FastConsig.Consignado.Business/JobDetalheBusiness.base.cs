
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
	public partial class JobDetalheBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobDetalhe> Listar(WhereBuilder filtro)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			return objJobDetalheData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobDetalhe obj)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			objJobDetalheData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobDetalhe obj)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			objJobDetalheData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobDetalhe Obtem(int? IdJob)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			return objJobDetalheData.Obtem(IdJob);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJob(int? IdJob)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			objJobDetalheData.ExcluirPor_IdJob(IdJob);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? IdJob)
		{
			JobDetalheData objJobDetalheData = new JobDetalheData();

			#region Regras de negócio
			#endregion

			objJobDetalheData.Excluir(IdJob);
		}
		#endregion

	}
}
