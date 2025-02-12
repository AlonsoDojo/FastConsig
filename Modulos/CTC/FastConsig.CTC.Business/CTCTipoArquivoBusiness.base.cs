
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
	public partial class CTCTipoArquivoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoArquivo> Listar(WhereBuilder filtro)
		{
			CTCTipoArquivoData objCTCTipoArquivoData = new CTCTipoArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoArquivoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoArquivo obj)
		{
			CTCTipoArquivoData objCTCTipoArquivoData = new CTCTipoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoArquivo obj)
		{
			CTCTipoArquivoData objCTCTipoArquivoData = new CTCTipoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoArquivo Obtem(int? Id)
		{
			CTCTipoArquivoData objCTCTipoArquivoData = new CTCTipoArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoArquivoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoArquivoData objCTCTipoArquivoData = new CTCTipoArquivoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoData.Excluir(Id);
		}
		#endregion

	}
}
