
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
	public partial class CTCPoliticaConfiguracaoExecucaoData
	{
		
		public CTCPoliticaConfiguracaoExecucaoData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela TipoPessoa
         //------------------------------------------------------------------
         //query.Join(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa, Join.Inner, TipoPessoa.METADADO.Id)
         //     .Field(TipoPessoa.METADADO.Codigo, "CodigoTipoPessoa")
         //     .Field(TipoPessoa.METADADO.Descricao, "DescricaoTipoPessoa");
         //------------------------------------------------------------------
         //JOIN com a tabela CTCPoliticas
         //------------------------------------------------------------------
         query.Join(CTCPoliticaConfiguracaoExecucao.METADADO.Politica, Join.Inner, CTCPoliticas.METADADO.Id)
              //.Field(CTCPoliticas.METADADO.Descricao, "DescricaoCTCPoliticas")
              .Field(CTCPoliticas.METADADO.Metodo, "Metodo");
         //.Field(CTCPoliticas.METADADO.TipoPolitica, "TipoPoliticaCTCPoliticas")
         //.Field(CTCPoliticas.METADADO.Async, "AsyncCTCPoliticas")
         //.Field(CTCPoliticas.METADADO.Parametros, "ParametrosCTCPoliticas");
         //------------------------------------------------------------------

      }

   }
}
