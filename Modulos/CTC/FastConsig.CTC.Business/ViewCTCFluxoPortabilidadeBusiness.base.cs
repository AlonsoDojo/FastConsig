
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
	public partial class ViewCTCFluxoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ViewCTCFluxoPortabilidade> Listar(WhereBuilder filtro)
		{
			ViewCTCFluxoPortabilidadeData objViewCTCFluxoPortabilidadeData = new ViewCTCFluxoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objViewCTCFluxoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual ViewCTCFluxoPortabilidade Obtem(int? Id)
		{
			ViewCTCFluxoPortabilidadeData objViewCTCFluxoPortabilidadeData = new ViewCTCFluxoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objViewCTCFluxoPortabilidadeData.Obtem(Id);
		}
		#endregion

	}
}
