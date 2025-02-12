
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
using FastConsig.Comunicado.Data;
#endregion

namespace FastConsig.Comunicado.Business
{
	public partial class ComunicadosStatusBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ComunicadosStatus> Listar(WhereBuilder filtro)
		{
			ComunicadosStatusData objComunicadosStatusData = new ComunicadosStatusData();

			#region Regras de negócio
			#endregion

			return objComunicadosStatusData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosStatus obj)
		{
			ComunicadosStatusData objComunicadosStatusData = new ComunicadosStatusData();

			#region Regras de negócio
			#endregion

			objComunicadosStatusData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosStatus obj)
		{
			ComunicadosStatusData objComunicadosStatusData = new ComunicadosStatusData();

			#region Regras de negócio
			#endregion

			objComunicadosStatusData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ComunicadosStatus Obtem(int? Id)
		{
			ComunicadosStatusData objComunicadosStatusData = new ComunicadosStatusData();

			#region Regras de negócio
			#endregion

			return objComunicadosStatusData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ComunicadosStatusData objComunicadosStatusData = new ComunicadosStatusData();

			#region Regras de negócio
			#endregion

			objComunicadosStatusData.Excluir(Id);
		}
		#endregion

	}
}
