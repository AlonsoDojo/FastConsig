
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
	public partial class TipoFormalizacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoFormalizacao> Listar(WhereBuilder filtro)
		{
			TipoFormalizacaoData objTipoFormalizacaoData = new TipoFormalizacaoData();

			#region Regras de negócio
			#endregion

			return objTipoFormalizacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoFormalizacao obj)
		{
			TipoFormalizacaoData objTipoFormalizacaoData = new TipoFormalizacaoData();

			#region Regras de negócio
			#endregion

			objTipoFormalizacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoFormalizacao obj)
		{
			TipoFormalizacaoData objTipoFormalizacaoData = new TipoFormalizacaoData();

			#region Regras de negócio
			#endregion

			objTipoFormalizacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoFormalizacao Obtem(int? Id)
		{
			TipoFormalizacaoData objTipoFormalizacaoData = new TipoFormalizacaoData();

			#region Regras de negócio
			#endregion

			return objTipoFormalizacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoFormalizacaoData objTipoFormalizacaoData = new TipoFormalizacaoData();

			#region Regras de negócio
			#endregion

			objTipoFormalizacaoData.Excluir(Id);
		}
		#endregion

	}
}
