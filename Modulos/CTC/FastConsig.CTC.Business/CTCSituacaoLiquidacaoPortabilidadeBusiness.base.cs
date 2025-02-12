
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTCSituacaoLiquidacaoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoLiquidacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCSituacaoLiquidacaoPortabilidadeData objCTCSituacaoLiquidacaoPortabilidadeData = new CTCSituacaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoLiquidacaoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoLiquidacaoPortabilidade obj)
		{
			CTCSituacaoLiquidacaoPortabilidadeData objCTCSituacaoLiquidacaoPortabilidadeData = new CTCSituacaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoLiquidacaoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoLiquidacaoPortabilidade obj)
		{
			CTCSituacaoLiquidacaoPortabilidadeData objCTCSituacaoLiquidacaoPortabilidadeData = new CTCSituacaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoLiquidacaoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoLiquidacaoPortabilidade Obtem(int? Id)
		{
			CTCSituacaoLiquidacaoPortabilidadeData objCTCSituacaoLiquidacaoPortabilidadeData = new CTCSituacaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoLiquidacaoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoLiquidacaoPortabilidadeData objCTCSituacaoLiquidacaoPortabilidadeData = new CTCSituacaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoLiquidacaoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
