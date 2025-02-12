
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
	public partial class CTC921Business : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC921> Listar(WhereBuilder filtro)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			return objCTC921Data.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC921 obj)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC921 obj)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC921 Obtem(int? Id)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			return objCTC921Data.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoRelatorio(string TipoRelatorio)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.ExcluirPor_TipoRelatorio(TipoRelatorio);
		}
		public void ExcluirPor_SituacaoProcessamento(string SituacaoProcessamento)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.ExcluirPor_SituacaoProcessamento(SituacaoProcessamento);
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC921Data objCTC921Data = new CTC921Data();

			#region Regras de negócio
			#endregion

			objCTC921Data.Excluir(Id);
		}
		#endregion

	}
}
