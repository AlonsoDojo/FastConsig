
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
	public partial class ValidadorBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Validador> Listar(WhereBuilder filtro)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			return objValidadorData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Validador obj)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			objValidadorData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Validador obj)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			objValidadorData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Validador Obtem(int? Id)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			return objValidadorData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Modelo(int? Modelo)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			objValidadorData.ExcluirPor_Modelo(Modelo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ValidadorData objValidadorData = new ValidadorData();

			#region Regras de negócio
			#endregion

			objValidadorData.Excluir(Id);
		}
		#endregion

	}
}
