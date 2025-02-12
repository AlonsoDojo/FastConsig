
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
	public partial class TipoPessoaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoPessoa> Listar(WhereBuilder filtro)
		{
			TipoPessoaData objTipoPessoaData = new TipoPessoaData();

			#region Regras de negócio
			#endregion

			return objTipoPessoaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoPessoa obj)
		{
			TipoPessoaData objTipoPessoaData = new TipoPessoaData();

			#region Regras de negócio
			#endregion

			objTipoPessoaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoPessoa obj)
		{
			TipoPessoaData objTipoPessoaData = new TipoPessoaData();

			#region Regras de negócio
			#endregion

			objTipoPessoaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoPessoa Obtem(int? Id)
		{
			TipoPessoaData objTipoPessoaData = new TipoPessoaData();

			#region Regras de negócio
			#endregion

			return objTipoPessoaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoPessoaData objTipoPessoaData = new TipoPessoaData();

			#region Regras de negócio
			#endregion

			objTipoPessoaData.Excluir(Id);
		}
		#endregion

	}
}
