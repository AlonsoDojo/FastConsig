
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
	public partial class ValidadorModelosCamposBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ValidadorModelosCampos> Listar(WhereBuilder filtro)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			return objValidadorModelosCamposData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorModelosCampos obj)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			objValidadorModelosCamposData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorModelosCampos obj)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			objValidadorModelosCamposData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ValidadorModelosCampos Obtem(int? Id)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			return objValidadorModelosCamposData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Modelo(int? Modelo)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			objValidadorModelosCamposData.ExcluirPor_Modelo(Modelo);
		}
		public void ExcluirPor_TipoDado(int? TipoDado)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			objValidadorModelosCamposData.ExcluirPor_TipoDado(TipoDado);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ValidadorModelosCamposData objValidadorModelosCamposData = new ValidadorModelosCamposData();

			#region Regras de negócio
			#endregion

			objValidadorModelosCamposData.Excluir(Id);
		}
		#endregion

	}
}
