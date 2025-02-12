
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
	public partial class TipoPoliticaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoPolitica> Listar(WhereBuilder filtro)
		{
			TipoPoliticaData objTipoPoliticaData = new TipoPoliticaData();

			#region Regras de negócio
			#endregion

			return objTipoPoliticaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoPolitica obj)
		{
			TipoPoliticaData objTipoPoliticaData = new TipoPoliticaData();

			#region Regras de negócio
			#endregion

			objTipoPoliticaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoPolitica obj)
		{
			TipoPoliticaData objTipoPoliticaData = new TipoPoliticaData();

			#region Regras de negócio
			#endregion

			objTipoPoliticaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoPolitica Obtem(int? Id)
		{
			TipoPoliticaData objTipoPoliticaData = new TipoPoliticaData();

			#region Regras de negócio
			#endregion

			return objTipoPoliticaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoPoliticaData objTipoPoliticaData = new TipoPoliticaData();

			#region Regras de negócio
			#endregion

			objTipoPoliticaData.Excluir(Id);
		}
		#endregion

	}
}
