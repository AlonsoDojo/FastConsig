
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
	public partial class CTCFaixasRCOBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCFaixasRCO> Listar(WhereBuilder filtro)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			return objCTCFaixasRCOData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFaixasRCO obj)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFaixasRCO obj)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCFaixasRCO Obtem(int? Id)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			return objCTCFaixasRCOData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Vigencia(int? Vigencia)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.ExcluirPor_Vigencia(Vigencia);
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCFaixasRCOData objCTCFaixasRCOData = new CTCFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCFaixasRCOData.Excluir(Id);
		}
		#endregion

	}
}
