
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
	public partial class CTCPoliticasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCPoliticas> Listar(WhereBuilder filtro)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			return objCTCPoliticasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPoliticas obj)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			objCTCPoliticasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPoliticas obj)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			objCTCPoliticasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCPoliticas Obtem(int? Id)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			return objCTCPoliticasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoPolitica(int? TipoPolitica)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			objCTCPoliticasData.ExcluirPor_TipoPolitica(TipoPolitica);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCPoliticasData objCTCPoliticasData = new CTCPoliticasData();

			#region Regras de negócio
			#endregion

			objCTCPoliticasData.Excluir(Id);
		}
		#endregion

	}
}
