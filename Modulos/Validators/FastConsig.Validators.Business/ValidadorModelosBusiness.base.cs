
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
	public partial class ValidadorModelosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ValidadorModelos> Listar(WhereBuilder filtro)
		{
			ValidadorModelosData objValidadorModelosData = new ValidadorModelosData();

			#region Regras de negócio
			#endregion

			return objValidadorModelosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorModelos obj)
		{
			ValidadorModelosData objValidadorModelosData = new ValidadorModelosData();

			#region Regras de negócio
			#endregion

			objValidadorModelosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorModelos obj)
		{
			ValidadorModelosData objValidadorModelosData = new ValidadorModelosData();

			#region Regras de negócio
			#endregion

			objValidadorModelosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ValidadorModelos Obtem(int? Id)
		{
			ValidadorModelosData objValidadorModelosData = new ValidadorModelosData();

			#region Regras de negócio
			#endregion

			return objValidadorModelosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ValidadorModelosData objValidadorModelosData = new ValidadorModelosData();

			#region Regras de negócio
			#endregion

			objValidadorModelosData.Excluir(Id);
		}
		#endregion

	}
}
