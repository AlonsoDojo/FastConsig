
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
	public partial class ProfissionaisCertificadosTipoCertificadoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ProfissionaisCertificadosTipoCertificado> Listar(WhereBuilder filtro)
		{
			ProfissionaisCertificadosTipoCertificadoData objProfissionaisCertificadosTipoCertificadoData = new ProfissionaisCertificadosTipoCertificadoData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosTipoCertificadoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosTipoCertificado obj)
		{
			ProfissionaisCertificadosTipoCertificadoData objProfissionaisCertificadosTipoCertificadoData = new ProfissionaisCertificadosTipoCertificadoData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosTipoCertificadoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosTipoCertificado obj)
		{
			ProfissionaisCertificadosTipoCertificadoData objProfissionaisCertificadosTipoCertificadoData = new ProfissionaisCertificadosTipoCertificadoData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosTipoCertificadoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ProfissionaisCertificadosTipoCertificado Obtem(int? Id)
		{
			ProfissionaisCertificadosTipoCertificadoData objProfissionaisCertificadosTipoCertificadoData = new ProfissionaisCertificadosTipoCertificadoData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosTipoCertificadoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ProfissionaisCertificadosTipoCertificadoData objProfissionaisCertificadosTipoCertificadoData = new ProfissionaisCertificadosTipoCertificadoData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosTipoCertificadoData.Excluir(Id);
		}
		#endregion

	}
}
