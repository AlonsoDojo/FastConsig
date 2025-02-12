
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
	public partial class CTCTipoRelatorioBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoRelatorio> Listar(WhereBuilder filtro)
		{
			CTCTipoRelatorioData objCTCTipoRelatorioData = new CTCTipoRelatorioData();

			#region Regras de negócio
			#endregion

			return objCTCTipoRelatorioData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoRelatorio obj)
		{
			CTCTipoRelatorioData objCTCTipoRelatorioData = new CTCTipoRelatorioData();

			#region Regras de negócio
			#endregion

			objCTCTipoRelatorioData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoRelatorio obj)
		{
			CTCTipoRelatorioData objCTCTipoRelatorioData = new CTCTipoRelatorioData();

			#region Regras de negócio
			#endregion

			objCTCTipoRelatorioData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoRelatorio Obtem(int? Id)
		{
			CTCTipoRelatorioData objCTCTipoRelatorioData = new CTCTipoRelatorioData();

			#region Regras de negócio
			#endregion

			return objCTCTipoRelatorioData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoRelatorioData objCTCTipoRelatorioData = new CTCTipoRelatorioData();

			#region Regras de negócio
			#endregion

			objCTCTipoRelatorioData.Excluir(Id);
		}
		#endregion

	}
}
