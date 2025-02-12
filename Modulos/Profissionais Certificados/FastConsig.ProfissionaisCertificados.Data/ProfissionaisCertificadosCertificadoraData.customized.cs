
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.ProfissionaisCertificados.Entity;
#endregion

namespace FastConsig.ProfissionaisCertificados.Data
{
	public partial class ProfissionaisCertificadosCertificadoraData
	{
		
		public ProfissionaisCertificadosCertificadoraData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************


		}

	}
}
