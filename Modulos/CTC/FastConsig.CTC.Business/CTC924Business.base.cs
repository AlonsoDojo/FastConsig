
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
	public partial class CTC924Business : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC924> Listar(WhereBuilder filtro)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			return objCTC924Data.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC924 obj)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			objCTC924Data.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC924 obj)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			objCTC924Data.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC924 Obtem(int? Id)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			return objCTC924Data.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			objCTC924Data.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC924Data objCTC924Data = new CTC924Data();

			#region Regras de negócio
			#endregion

			objCTC924Data.Excluir(Id);
		}
		#endregion

	}
}
