
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
	public partial class MeioLiberacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<MeioLiberacao> Listar(WhereBuilder filtro)
		{
			MeioLiberacaoData objMeioLiberacaoData = new MeioLiberacaoData();

			#region Regras de negócio
			#endregion

			return objMeioLiberacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(MeioLiberacao obj)
		{
			MeioLiberacaoData objMeioLiberacaoData = new MeioLiberacaoData();

			#region Regras de negócio
			#endregion

			objMeioLiberacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(MeioLiberacao obj)
		{
			MeioLiberacaoData objMeioLiberacaoData = new MeioLiberacaoData();

			#region Regras de negócio
			#endregion

			objMeioLiberacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual MeioLiberacao Obtem(int? Id)
		{
			MeioLiberacaoData objMeioLiberacaoData = new MeioLiberacaoData();

			#region Regras de negócio
			#endregion

			return objMeioLiberacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			MeioLiberacaoData objMeioLiberacaoData = new MeioLiberacaoData();

			#region Regras de negócio
			#endregion

			objMeioLiberacaoData.Excluir(Id);
		}
		#endregion

	}
}
