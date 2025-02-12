
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
	public partial class CTCArquivoRequisicaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCArquivoRequisicao> Listar(WhereBuilder filtro)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			return objCTCArquivoRequisicaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCArquivoRequisicao obj)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCArquivoRequisicaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCArquivoRequisicao obj)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCArquivoRequisicaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCArquivoRequisicao Obtem(int? Id)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			return objCTCArquivoRequisicaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCArquivoRequisicaoData.ExcluirPor_Requisicao(Requisicao);
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCArquivoRequisicaoData.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCArquivoRequisicaoData objCTCArquivoRequisicaoData = new CTCArquivoRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCArquivoRequisicaoData.Excluir(Id);
		}
		#endregion

	}
}
