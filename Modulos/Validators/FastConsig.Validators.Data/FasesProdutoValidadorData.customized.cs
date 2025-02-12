
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
	public partial class FasesProdutoValidadorData
	{
		
		public FasesProdutoValidadorData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela FasesProduto
			//------------------------------------------------------------------
			//query.Join(FasesProdutoValidador.METADADO.FaseProduto, Join.Inner, FasesProduto.METADADO.Id)
			//     .Field(FasesProduto.METADADO.Produto, "ProdutoFasesProduto")
			//     .Field(FasesProduto.METADADO.Fase, "FaseFasesProduto")
			//     .Field(FasesProduto.METADADO.Ordem, "OrdemFasesProduto");
			//------------------------------------------------------------------

			//JOIN com a tabela Validador
			//------------------------------------------------------------------
			//query.Join(FasesProdutoValidador.METADADO.Validador, Join.Inner, Validador.METADADO.Id)
			//     .Field(Validador.METADADO.Nome, "NomeValidador")
			//     .Field(Validador.METADADO.Descricao, "DescricaoValidador")
			//     .Field(Validador.METADADO.Modelo, "ModeloValidador")
			//     .Field(Validador.METADADO.Classe, "ClasseValidador");
			//------------------------------------------------------------------


		}

	}
}
