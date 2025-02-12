
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
	public partial class CTCSituacaoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCSituacaoPortabilidadeData objCTCSituacaoPortabilidadeData = new CTCSituacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoPortabilidade obj)
		{
			CTCSituacaoPortabilidadeData objCTCSituacaoPortabilidadeData = new CTCSituacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoPortabilidade obj)
		{
			CTCSituacaoPortabilidadeData objCTCSituacaoPortabilidadeData = new CTCSituacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoPortabilidade Obtem(int? Id)
		{
			CTCSituacaoPortabilidadeData objCTCSituacaoPortabilidadeData = new CTCSituacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoPortabilidadeData objCTCSituacaoPortabilidadeData = new CTCSituacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
