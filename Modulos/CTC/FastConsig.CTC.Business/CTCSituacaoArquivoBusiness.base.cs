
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
	public partial class CTCSituacaoArquivoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoArquivo> Listar(WhereBuilder filtro)
		{
			CTCSituacaoArquivoData objCTCSituacaoArquivoData = new CTCSituacaoArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoArquivoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoArquivo obj)
		{
			CTCSituacaoArquivoData objCTCSituacaoArquivoData = new CTCSituacaoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoArquivoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoArquivo obj)
		{
			CTCSituacaoArquivoData objCTCSituacaoArquivoData = new CTCSituacaoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoArquivoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoArquivo Obtem(int? Id)
		{
			CTCSituacaoArquivoData objCTCSituacaoArquivoData = new CTCSituacaoArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoArquivoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoArquivoData objCTCSituacaoArquivoData = new CTCSituacaoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoArquivoData.Excluir(Id);
		}
		#endregion

	}
}
