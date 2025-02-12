
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
	public partial class CTCArquivosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCArquivos> Listar(WhereBuilder filtro)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			return objCTCArquivosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCArquivos obj)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			objCTCArquivosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCArquivos obj)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			objCTCArquivosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCArquivos Obtem(int? Id)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			return objCTCArquivosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_SituacaoArquivo(int? SituacaoArquivo)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			objCTCArquivosData.ExcluirPor_SituacaoArquivo(SituacaoArquivo);
		}
		public void ExcluirPor_DominioArquivo(int? DominioArquivo)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			objCTCArquivosData.ExcluirPor_DominioArquivo(DominioArquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCArquivosData objCTCArquivosData = new CTCArquivosData();

			#region Regras de negócio
			#endregion

			objCTCArquivosData.Excluir(Id);
		}
		#endregion

	}
}
