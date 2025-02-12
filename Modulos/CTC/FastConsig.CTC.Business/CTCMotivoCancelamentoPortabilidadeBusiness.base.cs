
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
	public partial class CTCMotivoCancelamentoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoCancelamentoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCMotivoCancelamentoPortabilidadeData objCTCMotivoCancelamentoPortabilidadeData = new CTCMotivoCancelamentoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoCancelamentoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoCancelamentoPortabilidade obj)
		{
			CTCMotivoCancelamentoPortabilidadeData objCTCMotivoCancelamentoPortabilidadeData = new CTCMotivoCancelamentoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoCancelamentoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoCancelamentoPortabilidade obj)
		{
			CTCMotivoCancelamentoPortabilidadeData objCTCMotivoCancelamentoPortabilidadeData = new CTCMotivoCancelamentoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoCancelamentoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoCancelamentoPortabilidade Obtem(int? Id)
		{
			CTCMotivoCancelamentoPortabilidadeData objCTCMotivoCancelamentoPortabilidadeData = new CTCMotivoCancelamentoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoCancelamentoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoCancelamentoPortabilidadeData objCTCMotivoCancelamentoPortabilidadeData = new CTCMotivoCancelamentoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoCancelamentoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
