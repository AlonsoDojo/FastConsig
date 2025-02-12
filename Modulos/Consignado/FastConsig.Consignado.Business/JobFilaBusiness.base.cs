
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
	public partial class JobFilaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobFila> Listar(WhereBuilder filtro)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			return objJobFilaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobFila obj)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			objJobFilaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobFila obj)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			objJobFilaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobFila Obtem(long? Id)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			return objJobFilaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdStatus(int? IdStatus)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			objJobFilaData.ExcluirPor_IdStatus(IdStatus);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			JobFilaData objJobFilaData = new JobFilaData();

			#region Regras de negócio
			#endregion

			objJobFilaData.Excluir(Id);
		}
		#endregion

	}
}
