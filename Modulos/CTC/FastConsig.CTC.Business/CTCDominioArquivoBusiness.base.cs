
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
	public partial class CTCDominioArquivoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCDominioArquivo> Listar(WhereBuilder filtro)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCDominioArquivoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCDominioArquivo obj)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			objCTCDominioArquivoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCDominioArquivo obj)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			objCTCDominioArquivoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCDominioArquivo Obtem(int? Id)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			return objCTCDominioArquivoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Emissor(int? Emissor)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			objCTCDominioArquivoData.ExcluirPor_Emissor(Emissor);
		}
		public void ExcluirPor_Destinatario(int? Destinatario)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			objCTCDominioArquivoData.ExcluirPor_Destinatario(Destinatario);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCDominioArquivoData objCTCDominioArquivoData = new CTCDominioArquivoData();

			#region Regras de negócio
			#endregion

			objCTCDominioArquivoData.Excluir(Id);
		}
		#endregion

	}
}
