
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
	public partial class CTCContasData
	{
		
		public CTCContasData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela Bancos
			//------------------------------------------------------------------
			//query.Join(CTCContas.METADADO.Banco, Join.Inner, Bancos.METADADO.Banco)
			//     .Field(Bancos.METADADO.Id, "IdBancos")
			//     .Field(Bancos.METADADO.Digito, "DigitoBancos")
			//     .Field(Bancos.METADADO.Nome, "NomeBancos")
			//     .Field(Bancos.METADADO.Cnpj, "CnpjBancos")
			//     .Field(Bancos.METADADO.Ativo, "AtivoBancos")
			//     .Field(Bancos.METADADO.ISPB, "ISPBBancos")
			//     .Field(Bancos.METADADO.CBCDataPrev, "CBCDataPrevBancos");
			//------------------------------------------------------------------


		}

	}
}
