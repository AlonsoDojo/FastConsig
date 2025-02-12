
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
	public partial class CTCTipoContratoPropostaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoContratoProposta> Listar(WhereBuilder filtro)
		{
			CTCTipoContratoPropostaData objCTCTipoContratoPropostaData = new CTCTipoContratoPropostaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoPropostaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoProposta obj)
		{
			CTCTipoContratoPropostaData objCTCTipoContratoPropostaData = new CTCTipoContratoPropostaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoPropostaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoProposta obj)
		{
			CTCTipoContratoPropostaData objCTCTipoContratoPropostaData = new CTCTipoContratoPropostaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoPropostaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoContratoProposta Obtem(int? Id)
		{
			CTCTipoContratoPropostaData objCTCTipoContratoPropostaData = new CTCTipoContratoPropostaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoPropostaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoContratoPropostaData objCTCTipoContratoPropostaData = new CTCTipoContratoPropostaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoPropostaData.Excluir(Id);
		}
		#endregion

	}
}
