
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
	public partial class OcorrenciasSIAPEData
	{
		
		public OcorrenciasSIAPEData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela Ocorrencias
			//------------------------------------------------------------------
			//query.Join(OcorrenciasSIAPE.METADADO.Ocorrencia, Join.Inner, Ocorrencias.METADADO.Id)
			//     .Field(Ocorrencias.METADADO.Descricao, "DescricaoOcorrencias")
			//     .Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento, "PermiteLiberacaoComplementoOcorrencias")
			//     .Field(Ocorrencias.METADADO.Pendencia, "PendenciaOcorrencias")
			//     .Field(Ocorrencias.METADADO.Recusa, "RecusaOcorrencias")
			//     .Field(Ocorrencias.METADADO.Informativa, "InformativaOcorrencias");
			//------------------------------------------------------------------


		}

	}
}
