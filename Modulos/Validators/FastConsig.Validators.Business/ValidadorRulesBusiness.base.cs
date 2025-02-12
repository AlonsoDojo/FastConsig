
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
	public partial class ValidadorRulesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ValidadorRules> Listar(WhereBuilder filtro)
		{
			ValidadorRulesData objValidadorRulesData = new ValidadorRulesData();

			#region Regras de negócio
			#endregion

			return objValidadorRulesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorRules obj)
		{
			ValidadorRulesData objValidadorRulesData = new ValidadorRulesData();

			#region Regras de negócio
			#endregion

			objValidadorRulesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorRules obj)
		{
			ValidadorRulesData objValidadorRulesData = new ValidadorRulesData();

			#region Regras de negócio
			#endregion

			objValidadorRulesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ValidadorRules Obtem(int? Id)
		{
			ValidadorRulesData objValidadorRulesData = new ValidadorRulesData();

			#region Regras de negócio
			#endregion

			return objValidadorRulesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ValidadorRulesData objValidadorRulesData = new ValidadorRulesData();

			#region Regras de negócio
			#endregion

			objValidadorRulesData.Excluir(Id);
		}
		#endregion

	}
}
