
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
using FastConsig.Seguranca.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class PropostaOcorrenciasData
	{
		
		public PropostaOcorrenciasData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************
         //JOIN com a tabela Ocorrencias
         //------------------------------------------------------------------
         query.Join(PropostaOcorrencias.METADADO.Ocorrencia, Join.Left, Ocorrencias.METADADO.Id)
              .Field(Ocorrencias.METADADO.Descricao, "DescricaoOcorrencia");
         query.Join(PropostaOcorrencias.METADADO.Usuario, Join.Left, Usuario.METADADO.Id)
              .Field(Usuario.METADADO.Nome, "NomeUsuario");
         //------------------------------------------------------------------

      }

   }
}
