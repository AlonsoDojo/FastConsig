
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
	public partial class CTC922TipoParteBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC922TipoParte> Listar(WhereBuilder filtro)
		{
			CTC922TipoParteData objCTC922TipoParteData = new CTC922TipoParteData();

			#region Regras de negócio
			#endregion

			return objCTC922TipoParteData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922TipoParte obj)
		{
			CTC922TipoParteData objCTC922TipoParteData = new CTC922TipoParteData();

			#region Regras de negócio
			#endregion

			objCTC922TipoParteData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922TipoParte obj)
		{
			CTC922TipoParteData objCTC922TipoParteData = new CTC922TipoParteData();

			#region Regras de negócio
			#endregion

			objCTC922TipoParteData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC922TipoParte Obtem(int? Id)
		{
			CTC922TipoParteData objCTC922TipoParteData = new CTC922TipoParteData();

			#region Regras de negócio
			#endregion

			return objCTC922TipoParteData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC922TipoParteData objCTC922TipoParteData = new CTC922TipoParteData();

			#region Regras de negócio
			#endregion

			objCTC922TipoParteData.Excluir(Id);
		}
		#endregion

	}
}
