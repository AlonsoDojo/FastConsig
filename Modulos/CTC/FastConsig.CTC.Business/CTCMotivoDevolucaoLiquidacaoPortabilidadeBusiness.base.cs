
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
	public partial class CTCMotivoDevolucaoLiquidacaoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoDevolucaoLiquidacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCMotivoDevolucaoLiquidacaoPortabilidadeData objCTCMotivoDevolucaoLiquidacaoPortabilidadeData = new CTCMotivoDevolucaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoDevolucaoLiquidacaoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoDevolucaoLiquidacaoPortabilidade obj)
		{
			CTCMotivoDevolucaoLiquidacaoPortabilidadeData objCTCMotivoDevolucaoLiquidacaoPortabilidadeData = new CTCMotivoDevolucaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDevolucaoLiquidacaoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoDevolucaoLiquidacaoPortabilidade obj)
		{
			CTCMotivoDevolucaoLiquidacaoPortabilidadeData objCTCMotivoDevolucaoLiquidacaoPortabilidadeData = new CTCMotivoDevolucaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDevolucaoLiquidacaoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoDevolucaoLiquidacaoPortabilidade Obtem(int? Id)
		{
			CTCMotivoDevolucaoLiquidacaoPortabilidadeData objCTCMotivoDevolucaoLiquidacaoPortabilidadeData = new CTCMotivoDevolucaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoDevolucaoLiquidacaoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoDevolucaoLiquidacaoPortabilidadeData objCTCMotivoDevolucaoLiquidacaoPortabilidadeData = new CTCMotivoDevolucaoLiquidacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDevolucaoLiquidacaoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
