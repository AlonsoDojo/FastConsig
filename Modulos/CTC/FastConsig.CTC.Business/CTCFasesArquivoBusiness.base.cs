
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
	public partial class CTCFasesArquivoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCFasesArquivo> Listar(WhereBuilder filtro)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCFasesArquivoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFasesArquivo obj)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			objCTCFasesArquivoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFasesArquivo obj)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			objCTCFasesArquivoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCFasesArquivo Obtem(int? Id)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCFasesArquivoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			objCTCFasesArquivoData.ExcluirPor_Arquivo(Arquivo);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			objCTCFasesArquivoData.ExcluirPor_Fase(Fase);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCFasesArquivoData objCTCFasesArquivoData = new CTCFasesArquivoData();

			#region Regras de negócio
			#endregion

			objCTCFasesArquivoData.Excluir(Id);
		}
		#endregion

	}
}
