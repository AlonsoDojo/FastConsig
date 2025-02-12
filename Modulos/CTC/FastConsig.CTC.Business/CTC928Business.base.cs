
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
	public partial class CTC928Business : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC928> Listar(WhereBuilder filtro)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			return objCTC928Data.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928 obj)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			objCTC928Data.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928 obj)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			objCTC928Data.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC928 Obtem(int? Id)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			return objCTC928Data.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			objCTC928Data.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC928Data objCTC928Data = new CTC928Data();

			#region Regras de negócio
			#endregion

			objCTC928Data.Excluir(Id);
		}
		#endregion

	}
}
