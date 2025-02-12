
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
	public partial class ViewMonitorData
	{
		
		public ViewMonitorData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************
         query.Join(ViewMonitor.METADADO.Promotora, Join.Left, Promotoras.METADADO.Id)
              .Field(Promotoras.METADADO.Nome, "NomePromotora");
         query.Join(ViewMonitor.METADADO.Produto, Join.Left, Produtos.METADADO.Id)
              .Field(Produtos.METADADO.Nome, "NomeProduto");
         query.Join(ViewMonitor.METADADO.RedeLojas, Join.Left, RedeLoja.METADADO.Id )
              .Field(RedeLoja.METADADO.Nome, "NomeRedeLojasAbreviado");
      }
   }
}
