
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
	public partial class PessoasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Pessoas> Listar(WhereBuilder filtro)
		{
			PessoasData objPessoasData = new PessoasData();

			#region Regras de negócio
			#endregion

			return objPessoasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Pessoas obj)
		{
			PessoasData objPessoasData = new PessoasData();

			#region Regras de negócio
			#endregion

			objPessoasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Pessoas obj)
		{
			PessoasData objPessoasData = new PessoasData();

			#region Regras de negócio
			#endregion

			objPessoasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		#endregion

	}
}
