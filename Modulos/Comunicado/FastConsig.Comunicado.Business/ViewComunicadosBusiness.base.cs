
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
	public partial class ViewComunicadosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ViewComunicados> Listar(WhereBuilder filtro)
		{
			ViewComunicadosData objViewComunicadosData = new ViewComunicadosData();

			#region Regras de negócio
			#endregion

			return objViewComunicadosData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual ViewComunicados Obtem(int? Comunicado)
		{
			ViewComunicadosData objViewComunicadosData = new ViewComunicadosData();

			#region Regras de negócio
			#endregion

			return objViewComunicadosData.Obtem(Comunicado);
		}
		#endregion

	}
}
