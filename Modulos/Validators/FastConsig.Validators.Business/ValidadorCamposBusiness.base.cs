
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
	public partial class ValidadorCamposBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ValidadorCampos> Listar(WhereBuilder filtro)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			return objValidadorCamposData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorCampos obj)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorCampos obj)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ValidadorCampos Obtem(int? Id)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			return objValidadorCamposData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Validador(int? Validador)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.ExcluirPor_Validador(Validador);
		}
		public void ExcluirPor_Modelo(int? Modelo)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.ExcluirPor_Modelo(Modelo);
		}
		public void ExcluirPor_CampoModelo(int? CampoModelo)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.ExcluirPor_CampoModelo(CampoModelo);
		}
		public void ExcluirPor_Rule(int? Rule)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.ExcluirPor_Rule(Rule);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ValidadorCamposData objValidadorCamposData = new ValidadorCamposData();

			#region Regras de negócio
			#endregion

			objValidadorCamposData.Excluir(Id);
		}
		#endregion

	}
}
