
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class PropostaPendenciaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaPendencia> Listar(WhereBuilder filtro)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			return objPropostaPendenciaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaPendencia obj)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaPendencia obj)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaPendencia Obtem(int? Id)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			return objPropostaPendenciaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Proposta(int? Proposta)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.ExcluirPor_Proposta(Proposta);
		}
		public void ExcluirPor_FaseAtual(int? FaseAtual)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.ExcluirPor_FaseAtual(FaseAtual);
		}
		public void ExcluirPor_FaseDestino(int? FaseDestino)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.ExcluirPor_FaseDestino(FaseDestino);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostaPendenciaData objPropostaPendenciaData = new PropostaPendenciaData();

			#region Regras de negócio
			#endregion

			objPropostaPendenciaData.Excluir(Id);
		}
		#endregion

	}
}
