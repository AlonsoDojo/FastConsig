
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class PropostaChecklistBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaChecklist> Listar(WhereBuilder filtro)
		{
			PropostaChecklistData objPropostaChecklistData = new PropostaChecklistData();

			#region Regras de negócio
			#endregion

			return objPropostaChecklistData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaChecklist obj)
		{
			PropostaChecklistData objPropostaChecklistData = new PropostaChecklistData();

			#region Regras de negócio
			#endregion

			objPropostaChecklistData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaChecklist obj)
		{
			PropostaChecklistData objPropostaChecklistData = new PropostaChecklistData();

			#region Regras de negócio
			#endregion

			objPropostaChecklistData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaChecklist Obtem(int? Id)
		{
			PropostaChecklistData objPropostaChecklistData = new PropostaChecklistData();

			#region Regras de negócio
			#endregion

			return objPropostaChecklistData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostaChecklistData objPropostaChecklistData = new PropostaChecklistData();

			#region Regras de negócio
			#endregion

			objPropostaChecklistData.Excluir(Id);
		}
		#endregion

	}
}
