
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
   public partial class CTCDominioArquivoData
   {

      public CTCDominioArquivoData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************
         query.Join(CTCDominioArquivo.METADADO.Emissor, Join.Left, CTCTipoParte.METADADO.Id)
              .Field(CTCTipoParte.METADADO.Descricao, "DescricaoEmissor")
              .Field(CTCTipoParte.METADADO.ISPB, "ISPBEmissor");
         query.Join(CTCDominioArquivo.METADADO.Destinatario, Join.Left, CTCTipoParteDestino.METADADO.Id)
              .Field(CTCTipoParteDestino.METADADO.Descricao, "DescricaoDestinatario")
              .Field(CTCTipoParteDestino.METADADO.ISPB, "ISPBDestinatario");
      }

   }
}
