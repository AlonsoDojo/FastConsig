
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
	public partial class BancosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Bancos> Listar(WhereBuilder filtro)
		{
			BancosData objBancosData = new BancosData();

			#region Regras de negócio
			#endregion

			return objBancosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Bancos obj)
		{
			BancosData objBancosData = new BancosData();

			#region Regras de negócio
			#endregion

			objBancosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Bancos obj)
		{
			BancosData objBancosData = new BancosData();

			#region Regras de negócio
			#endregion

			objBancosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Bancos Obtem(string Banco)
		{
			BancosData objBancosData = new BancosData();

			#region Regras de negócio
			#endregion

			return objBancosData.Obtem(Banco);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(string Banco)
		{
			BancosData objBancosData = new BancosData();

			#region Regras de negócio
			#endregion

			objBancosData.Excluir(Banco);
		}
		#endregion

	}
}
