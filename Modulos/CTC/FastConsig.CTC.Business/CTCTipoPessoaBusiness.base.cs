
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
	public partial class CTCTipoPessoaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoPessoa> Listar(WhereBuilder filtro)
		{
			CTCTipoPessoaData objCTCTipoPessoaData = new CTCTipoPessoaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoPessoaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoPessoa obj)
		{
			CTCTipoPessoaData objCTCTipoPessoaData = new CTCTipoPessoaData();

			#region Regras de negócio
			#endregion

			objCTCTipoPessoaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoPessoa obj)
		{
			CTCTipoPessoaData objCTCTipoPessoaData = new CTCTipoPessoaData();

			#region Regras de negócio
			#endregion

			objCTCTipoPessoaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoPessoa Obtem(int? Id)
		{
			CTCTipoPessoaData objCTCTipoPessoaData = new CTCTipoPessoaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoPessoaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoPessoaData objCTCTipoPessoaData = new CTCTipoPessoaData();

			#region Regras de negócio
			#endregion

			objCTCTipoPessoaData.Excluir(Id);
		}
		#endregion

	}
}
