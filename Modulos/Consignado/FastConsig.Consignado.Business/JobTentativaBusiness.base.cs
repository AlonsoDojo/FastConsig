
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
	public partial class JobTentativaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobTentativa> Listar(WhereBuilder filtro)
		{
			JobTentativaData objJobTentativaData = new JobTentativaData();

			#region Regras de negócio
			#endregion

			return objJobTentativaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobTentativa obj)
		{
			JobTentativaData objJobTentativaData = new JobTentativaData();

			#region Regras de negócio
			#endregion

			objJobTentativaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobTentativa obj)
		{
			JobTentativaData objJobTentativaData = new JobTentativaData();

			#region Regras de negócio
			#endregion

			objJobTentativaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobTentativa Obtem(long? Id)
		{
			JobTentativaData objJobTentativaData = new JobTentativaData();

			#region Regras de negócio
			#endregion

			return objJobTentativaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			JobTentativaData objJobTentativaData = new JobTentativaData();

			#region Regras de negócio
			#endregion

			objJobTentativaData.Excluir(Id);
		}
		#endregion

	}
}
