
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
	public partial class CTC926Business : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC926> Listar(WhereBuilder filtro)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			return objCTC926Data.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC926 obj)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			objCTC926Data.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC926 obj)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			objCTC926Data.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC926 Obtem(int? Id)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			return objCTC926Data.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			objCTC926Data.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC926Data objCTC926Data = new CTC926Data();

			#region Regras de negócio
			#endregion

			objCTC926Data.Excluir(Id);
		}
		#endregion

	}
}
