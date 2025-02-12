
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
	public partial class CTCSituacaoEfetivacaoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoEfetivacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCSituacaoEfetivacaoPortabilidadeData objCTCSituacaoEfetivacaoPortabilidadeData = new CTCSituacaoEfetivacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoEfetivacaoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoEfetivacaoPortabilidade obj)
		{
			CTCSituacaoEfetivacaoPortabilidadeData objCTCSituacaoEfetivacaoPortabilidadeData = new CTCSituacaoEfetivacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoEfetivacaoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoEfetivacaoPortabilidade obj)
		{
			CTCSituacaoEfetivacaoPortabilidadeData objCTCSituacaoEfetivacaoPortabilidadeData = new CTCSituacaoEfetivacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoEfetivacaoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoEfetivacaoPortabilidade Obtem(int? Id)
		{
			CTCSituacaoEfetivacaoPortabilidadeData objCTCSituacaoEfetivacaoPortabilidadeData = new CTCSituacaoEfetivacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoEfetivacaoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoEfetivacaoPortabilidadeData objCTCSituacaoEfetivacaoPortabilidadeData = new CTCSituacaoEfetivacaoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoEfetivacaoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
