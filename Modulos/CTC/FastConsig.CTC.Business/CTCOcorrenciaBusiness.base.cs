
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
	public partial class CTCOcorrenciaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCOcorrencia> Listar(WhereBuilder filtro)
		{
			CTCOcorrenciaData objCTCOcorrenciaData = new CTCOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objCTCOcorrenciaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCOcorrencia obj)
		{
			CTCOcorrenciaData objCTCOcorrenciaData = new CTCOcorrenciaData();

			#region Regras de negócio
			#endregion

			objCTCOcorrenciaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCOcorrencia obj)
		{
			CTCOcorrenciaData objCTCOcorrenciaData = new CTCOcorrenciaData();

			#region Regras de negócio
			#endregion

			objCTCOcorrenciaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCOcorrencia Obtem(int? Id)
		{
			CTCOcorrenciaData objCTCOcorrenciaData = new CTCOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objCTCOcorrenciaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCOcorrenciaData objCTCOcorrenciaData = new CTCOcorrenciaData();

			#region Regras de negócio
			#endregion

			objCTCOcorrenciaData.Excluir(Id);
		}
		#endregion

	}
}
