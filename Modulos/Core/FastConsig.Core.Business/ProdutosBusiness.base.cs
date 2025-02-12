
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
	public partial class ProdutosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Produtos> Listar(WhereBuilder filtro)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			return objProdutosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Produtos obj)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			objProdutosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Produtos obj)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			objProdutosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Produtos Obtem(int? Id)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			return objProdutosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoCertificado(int? TipoCertificado)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			objProdutosData.ExcluirPor_TipoCertificado(TipoCertificado);
		}
		public void ExcluirPor_FamiliaProduto(int? FamiliaProduto)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			objProdutosData.ExcluirPor_FamiliaProduto(FamiliaProduto);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ProdutosData objProdutosData = new ProdutosData();

			#region Regras de negócio
			#endregion

			objProdutosData.Excluir(Id);
		}
		#endregion

	}
}
