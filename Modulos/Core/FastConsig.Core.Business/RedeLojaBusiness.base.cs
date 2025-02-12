
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
	public partial class RedeLojaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<RedeLoja> Listar(WhereBuilder filtro)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			return objRedeLojaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(RedeLoja obj)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			objRedeLojaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(RedeLoja obj)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			objRedeLojaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual RedeLoja Obtem(int? Id)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			return objRedeLojaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Promotora(int? Promotora)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			objRedeLojaData.ExcluirPor_Promotora(Promotora);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			RedeLojaData objRedeLojaData = new RedeLojaData();

			#region Regras de negócio
			#endregion

			objRedeLojaData.Excluir(Id);
		}
		#endregion

	}
}
