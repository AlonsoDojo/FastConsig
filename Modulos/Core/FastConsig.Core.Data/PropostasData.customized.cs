
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class PropostasData
	{
		
		public PropostasData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela TipoFormalizacao
			//------------------------------------------------------------------
			//query.Join(Propostas.METADADO.TipoFormalizacao, Join.Inner, TipoFormalizacao.METADADO.Id)
			//     .Field(TipoFormalizacao.METADADO.Descricao, "DescricaoTipoFormalizacao");
			//------------------------------------------------------------------


		}

	}
}
