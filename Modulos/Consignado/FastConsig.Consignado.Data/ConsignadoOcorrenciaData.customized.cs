
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
#endregion

namespace FastConsig.Consignado.Data
{
	public partial class ConsignadoOcorrenciaData
	{
		
		public ConsignadoOcorrenciaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela Ocorrencias
			//------------------------------------------------------------------
			//query.Join(ConsignadoOcorrencia.METADADO.Ocorrencia, Join.Inner, Ocorrencias.METADADO.Id)
			//     .Field(Ocorrencias.METADADO.Descricao, "DescricaoOcorrencias")
			//     .Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento, "PermiteLiberacaoComplementoOcorrencias")
			//     .Field(Ocorrencias.METADADO.Pendencia, "PendenciaOcorrencias")
			//     .Field(Ocorrencias.METADADO.Recusa, "RecusaOcorrencias")
			//     .Field(Ocorrencias.METADADO.Informativa, "InformativaOcorrencias")
			//     .Field(Ocorrencias.METADADO.Sistema, "SistemaOcorrencias");
			//------------------------------------------------------------------


		}

	}
}
