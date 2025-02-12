
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
	public partial class CTCRCOBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCRCO> Listar(WhereBuilder filtro)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			return objCTCRCOData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRCO obj)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRCO obj)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCRCO Obtem(int? Id)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			return objCTCRCOData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.ExcluirPor_Arquivo(Arquivo);
		}
      public void ExcluirPor_Competencia(string competencia)
      {
         CTCRCOData objCTCRCOData = new CTCRCOData();

         #region Regras de negócio
         #endregion

         objCTCRCOData.ExcluirPor_Competencia(competencia);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
		{
			CTCRCOData objCTCRCOData = new CTCRCOData();

			#region Regras de negócio
			#endregion

			objCTCRCOData.Excluir(Id);
		}
		#endregion

	}
}
