
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.ProfissionaisCertificados.Entity;
using FastConsig.ProfissionaisCertificados.Data;
#endregion

namespace FastConsig.ProfissionaisCertificados.Business
{
	public partial class ProfissionaisCertificadosCertificadoraBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ProfissionaisCertificadosCertificadora> Listar(WhereBuilder filtro)
		{
			ProfissionaisCertificadosCertificadoraData objProfissionaisCertificadosCertificadoraData = new ProfissionaisCertificadosCertificadoraData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosCertificadoraData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosCertificadora obj)
		{
			ProfissionaisCertificadosCertificadoraData objProfissionaisCertificadosCertificadoraData = new ProfissionaisCertificadosCertificadoraData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosCertificadoraData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosCertificadora obj)
		{
			ProfissionaisCertificadosCertificadoraData objProfissionaisCertificadosCertificadoraData = new ProfissionaisCertificadosCertificadoraData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosCertificadoraData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ProfissionaisCertificadosCertificadora Obtem(int? Id)
		{
			ProfissionaisCertificadosCertificadoraData objProfissionaisCertificadosCertificadoraData = new ProfissionaisCertificadosCertificadoraData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosCertificadoraData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ProfissionaisCertificadosCertificadoraData objProfissionaisCertificadosCertificadoraData = new ProfissionaisCertificadosCertificadoraData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosCertificadoraData.Excluir(Id);
		}
		#endregion

	}
}
