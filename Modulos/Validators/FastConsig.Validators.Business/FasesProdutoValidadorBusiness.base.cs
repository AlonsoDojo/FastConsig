
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Validators.Entity;
using FastConsig.Validators.Data;
#endregion

namespace FastConsig.Validators.Business
{
	public partial class FasesProdutoValidadorBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<FasesProdutoValidador> Listar(WhereBuilder filtro)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			return objFasesProdutoValidadorData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(FasesProdutoValidador obj)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			objFasesProdutoValidadorData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(FasesProdutoValidador obj)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			objFasesProdutoValidadorData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual FasesProdutoValidador Obtem(int? Id)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			return objFasesProdutoValidadorData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_FaseProduto(int? FaseProduto)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			objFasesProdutoValidadorData.ExcluirPor_FaseProduto(FaseProduto);
		}
		public void ExcluirPor_Validador(int? Validador)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			objFasesProdutoValidadorData.ExcluirPor_Validador(Validador);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			FasesProdutoValidadorData objFasesProdutoValidadorData = new FasesProdutoValidadorData();

			#region Regras de negócio
			#endregion

			objFasesProdutoValidadorData.Excluir(Id);
		}
		#endregion

	}
}
