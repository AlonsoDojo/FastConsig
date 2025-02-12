
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Validators.Entity;
#endregion

namespace FastConsig.Validators.Data
{
	public partial class ValidadorModelosCamposData
	{
		
		public ValidadorModelosCamposData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela TipoDado
			//------------------------------------------------------------------
			//query.Join(ValidadorModelosCampos.METADADO.TipoDado, Join.Inner, TipoDado.METADADO.Id)
			//     .Field(TipoDado.METADADO.Descricao, "DescricaoTipoDado")
			//     .Field(TipoDado.METADADO.Mapper, "MapperTipoDado");
			//------------------------------------------------------------------


		}

	}
}
