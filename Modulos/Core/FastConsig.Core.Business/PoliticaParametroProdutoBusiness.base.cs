
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
	public partial class PoliticaParametroProdutoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PoliticaParametroProduto> Listar(WhereBuilder filtro)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			return objPoliticaParametroProdutoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaParametroProduto obj)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			objPoliticaParametroProdutoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PoliticaParametroProduto obj)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			objPoliticaParametroProdutoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PoliticaParametroProduto Obtem(int? Id)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			return objPoliticaParametroProdutoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Politica(int? Politica)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			objPoliticaParametroProdutoData.ExcluirPor_Politica(Politica);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PoliticaParametroProdutoData objPoliticaParametroProdutoData = new PoliticaParametroProdutoData();

			#region Regras de negócio
			#endregion

			objPoliticaParametroProdutoData.Excluir(Id);
		}
		#endregion

	}
}
