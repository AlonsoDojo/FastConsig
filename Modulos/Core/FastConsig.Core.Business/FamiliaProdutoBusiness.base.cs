
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
	public partial class FamiliaProdutoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<FamiliaProduto> Listar(WhereBuilder filtro)
		{
			FamiliaProdutoData objFamiliaProdutoData = new FamiliaProdutoData();

			#region Regras de negócio
			#endregion

			return objFamiliaProdutoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(FamiliaProduto obj)
		{
			FamiliaProdutoData objFamiliaProdutoData = new FamiliaProdutoData();

			#region Regras de negócio
			#endregion

			objFamiliaProdutoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(FamiliaProduto obj)
		{
			FamiliaProdutoData objFamiliaProdutoData = new FamiliaProdutoData();

			#region Regras de negócio
			#endregion

			objFamiliaProdutoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual FamiliaProduto Obtem(int? Id)
		{
			FamiliaProdutoData objFamiliaProdutoData = new FamiliaProdutoData();

			#region Regras de negócio
			#endregion

			return objFamiliaProdutoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			FamiliaProdutoData objFamiliaProdutoData = new FamiliaProdutoData();

			#region Regras de negócio
			#endregion

			objFamiliaProdutoData.Excluir(Id);
		}
		#endregion

	}
}
