
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
	public partial class PoliticasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Politicas> Listar(WhereBuilder filtro)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			return objPoliticasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Politicas obj)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			objPoliticasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Politicas obj)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			objPoliticasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Politicas Obtem(int? Id)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			return objPoliticasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoPolitica(int? TipoPolitica)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			objPoliticasData.ExcluirPor_TipoPolitica(TipoPolitica);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PoliticasData objPoliticasData = new PoliticasData();

			#region Regras de negócio
			#endregion

			objPoliticasData.Excluir(Id);
		}
		#endregion

	}
}
