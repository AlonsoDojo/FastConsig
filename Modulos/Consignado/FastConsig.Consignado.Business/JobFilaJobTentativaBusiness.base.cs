
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
	public partial class JobFilaJobTentativaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobFilaJobTentativa> Listar(WhereBuilder filtro)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			return objJobFilaJobTentativaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaJobTentativa obj)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			objJobFilaJobTentativaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaJobTentativa obj)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			objJobFilaJobTentativaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobFilaJobTentativa Obtem(long? Id)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			return objJobFilaJobTentativaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdFilaJob(long? IdFilaJob)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			objJobFilaJobTentativaData.ExcluirPor_IdFilaJob(IdFilaJob);
		}
		public void ExcluirPor_IdJobTentativa(long? IdJobTentativa)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			objJobFilaJobTentativaData.ExcluirPor_IdJobTentativa(IdJobTentativa);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			JobFilaJobTentativaData objJobFilaJobTentativaData = new JobFilaJobTentativaData();

			#region Regras de negócio
			#endregion

			objJobFilaJobTentativaData.Excluir(Id);
		}
		#endregion

	}
}
