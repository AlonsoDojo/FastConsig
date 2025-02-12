
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCPoliticasData
	{
		
		public CTCPoliticasData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela TipoPolitica
			//------------------------------------------------------------------
			//query.Join(CTCPoliticas.METADADO.TipoPolitica, Join.Inner, TipoPolitica.METADADO.Id)
			//     .Field(TipoPolitica.METADADO.Descricao, "DescricaoTipoPolitica");
			//------------------------------------------------------------------


		}

	}
}
