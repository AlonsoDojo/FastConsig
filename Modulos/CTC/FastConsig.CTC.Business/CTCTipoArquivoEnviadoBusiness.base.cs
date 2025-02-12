
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
	public partial class CTCTipoArquivoEnviadoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoArquivoEnviado> Listar(WhereBuilder filtro)
		{
			CTCTipoArquivoEnviadoData objCTCTipoArquivoEnviadoData = new CTCTipoArquivoEnviadoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoArquivoEnviadoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoArquivoEnviado obj)
		{
			CTCTipoArquivoEnviadoData objCTCTipoArquivoEnviadoData = new CTCTipoArquivoEnviadoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoEnviadoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoArquivoEnviado obj)
		{
			CTCTipoArquivoEnviadoData objCTCTipoArquivoEnviadoData = new CTCTipoArquivoEnviadoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoEnviadoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoArquivoEnviado Obtem(int? Id)
		{
			CTCTipoArquivoEnviadoData objCTCTipoArquivoEnviadoData = new CTCTipoArquivoEnviadoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoArquivoEnviadoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoArquivoEnviadoData objCTCTipoArquivoEnviadoData = new CTCTipoArquivoEnviadoData();

			#region Regras de negócio
			#endregion

			objCTCTipoArquivoEnviadoData.Excluir(Id);
		}
		#endregion

	}
}
