
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
	public partial class CTC928ClienteProdutoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC928ClienteProduto> Listar(WhereBuilder filtro)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			return objCTC928ClienteProdutoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928ClienteProduto obj)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			objCTC928ClienteProdutoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928ClienteProduto obj)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			objCTC928ClienteProdutoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC928ClienteProduto Obtem(int? Id)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			return objCTC928ClienteProdutoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Cliente(int? Cliente)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			objCTC928ClienteProdutoData.ExcluirPor_Cliente(Cliente);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC928ClienteProdutoData objCTC928ClienteProdutoData = new CTC928ClienteProdutoData();

			#region Regras de negócio
			#endregion

			objCTC928ClienteProdutoData.Excluir(Id);
		}
		#endregion

	}
}
