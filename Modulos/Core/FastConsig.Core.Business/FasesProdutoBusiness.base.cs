
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
	public partial class FasesProdutoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<FasesProduto> Listar(WhereBuilder filtro)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			return objFasesProdutoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(FasesProduto obj)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			objFasesProdutoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(FasesProduto obj)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			objFasesProdutoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual FasesProduto Obtem(int? Id)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			return objFasesProdutoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			objFasesProdutoData.ExcluirPor_Produto(Produto);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			objFasesProdutoData.ExcluirPor_Fase(Fase);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			FasesProdutoData objFasesProdutoData = new FasesProdutoData();

			#region Regras de negócio
			#endregion

			objFasesProdutoData.Excluir(Id);
		}
		#endregion

	}
}
