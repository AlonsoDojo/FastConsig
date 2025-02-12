
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
	public partial class CTCArquivosData
	{
		
		public CTCArquivosData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela CTCSituacaoArquivo
         //------------------------------------------------------------------
         query.Join(CTCArquivos.METADADO.SituacaoArquivo, Join.Inner, CTCSituacaoArquivo.METADADO.Id)
              .Field(CTCSituacaoArquivo.METADADO.Descricao, "SituacaoArquivoDescricao");

         //JOIN com a tabela CTCSituacaoArquivo
         //------------------------------------------------------------------
         query.Join(CTCArquivos.METADADO.CodigoErro, Join.Left, CTCCodigoErro.METADADO.Codigo)
              .Field(CTCCodigoErro.METADADO.Descricao, "DescricaoErro");

         //JOIN com a tabela CTCDominioArquivo
         //------------------------------------------------------------------
         query.Join(CTCArquivos.METADADO.DominioArquivo, Join.Left, CTCDominioArquivo.METADADO.Id)
              .Field(CTCDominioArquivo.METADADO.GradeHorariaInicial, "GradeHorariaInicial");

      }

	}
}
