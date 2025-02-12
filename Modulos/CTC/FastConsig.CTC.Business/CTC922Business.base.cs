
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
	public partial class CTC922Business : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC922> Listar(WhereBuilder filtro)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			return objCTC922Data.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922 obj)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			objCTC922Data.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922 obj)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			objCTC922Data.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC922 Obtem(int? Id)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			return objCTC922Data.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			objCTC922Data.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC922Data objCTC922Data = new CTC922Data();

			#region Regras de negócio
			#endregion

			objCTC922Data.Excluir(Id);
		}
		#endregion

	}
}
