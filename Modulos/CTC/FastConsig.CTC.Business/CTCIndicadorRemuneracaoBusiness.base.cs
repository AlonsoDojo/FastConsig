
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
	public partial class CTCIndicadorRemuneracaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCIndicadorRemuneracao> Listar(WhereBuilder filtro)
		{
			CTCIndicadorRemuneracaoData objCTCIndicadorRemuneracaoData = new CTCIndicadorRemuneracaoData();

			#region Regras de negócio
			#endregion

			return objCTCIndicadorRemuneracaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCIndicadorRemuneracao obj)
		{
			CTCIndicadorRemuneracaoData objCTCIndicadorRemuneracaoData = new CTCIndicadorRemuneracaoData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorRemuneracaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCIndicadorRemuneracao obj)
		{
			CTCIndicadorRemuneracaoData objCTCIndicadorRemuneracaoData = new CTCIndicadorRemuneracaoData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorRemuneracaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCIndicadorRemuneracao Obtem(int? Id)
		{
			CTCIndicadorRemuneracaoData objCTCIndicadorRemuneracaoData = new CTCIndicadorRemuneracaoData();

			#region Regras de negócio
			#endregion

			return objCTCIndicadorRemuneracaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCIndicadorRemuneracaoData objCTCIndicadorRemuneracaoData = new CTCIndicadorRemuneracaoData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorRemuneracaoData.Excluir(Id);
		}
		#endregion

	}
}
