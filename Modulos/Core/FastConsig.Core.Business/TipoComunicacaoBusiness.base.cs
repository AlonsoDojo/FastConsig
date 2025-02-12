
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class TipoComunicacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoComunicacao> Listar(WhereBuilder filtro)
		{
			TipoComunicacaoData objTipoComunicacaoData = new TipoComunicacaoData();

			#region Regras de negócio
			#endregion

			return objTipoComunicacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoComunicacao obj)
		{
			TipoComunicacaoData objTipoComunicacaoData = new TipoComunicacaoData();

			#region Regras de negócio
			#endregion

			objTipoComunicacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoComunicacao obj)
		{
			TipoComunicacaoData objTipoComunicacaoData = new TipoComunicacaoData();

			#region Regras de negócio
			#endregion

			objTipoComunicacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoComunicacao Obtem(int? Id)
		{
			TipoComunicacaoData objTipoComunicacaoData = new TipoComunicacaoData();

			#region Regras de negócio
			#endregion

			return objTipoComunicacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoComunicacaoData objTipoComunicacaoData = new TipoComunicacaoData();

			#region Regras de negócio
			#endregion

			objTipoComunicacaoData.Excluir(Id);
		}
		#endregion

	}
}
