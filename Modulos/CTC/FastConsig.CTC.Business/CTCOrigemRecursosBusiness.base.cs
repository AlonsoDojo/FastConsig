
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
	public partial class CTCOrigemRecursosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCOrigemRecursos> Listar(WhereBuilder filtro)
		{
			CTCOrigemRecursosData objCTCOrigemRecursosData = new CTCOrigemRecursosData();

			#region Regras de negócio
			#endregion

			return objCTCOrigemRecursosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCOrigemRecursos obj)
		{
			CTCOrigemRecursosData objCTCOrigemRecursosData = new CTCOrigemRecursosData();

			#region Regras de negócio
			#endregion

			objCTCOrigemRecursosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCOrigemRecursos obj)
		{
			CTCOrigemRecursosData objCTCOrigemRecursosData = new CTCOrigemRecursosData();

			#region Regras de negócio
			#endregion

			objCTCOrigemRecursosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCOrigemRecursos Obtem(int? Id)
		{
			CTCOrigemRecursosData objCTCOrigemRecursosData = new CTCOrigemRecursosData();

			#region Regras de negócio
			#endregion

			return objCTCOrigemRecursosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCOrigemRecursosData objCTCOrigemRecursosData = new CTCOrigemRecursosData();

			#region Regras de negócio
			#endregion

			objCTCOrigemRecursosData.Excluir(Id);
		}
		#endregion

	}
}
