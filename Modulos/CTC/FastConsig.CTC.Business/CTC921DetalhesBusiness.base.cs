
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTC921DetalhesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC921Detalhes> Listar(WhereBuilder filtro)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC921DetalhesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC921Detalhes obj)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC921Detalhes obj)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC921Detalhes Obtem(int? Id)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC921DetalhesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EventoTarifa(string EventoTarifa)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.ExcluirPor_EventoTarifa(EventoTarifa);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_TipoCliente(string TipoCliente)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.ExcluirPor_TipoCliente(TipoCliente);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC921DetalhesData objCTC921DetalhesData = new CTC921DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC921DetalhesData.Excluir(Id);
		}
		#endregion

	}
}
