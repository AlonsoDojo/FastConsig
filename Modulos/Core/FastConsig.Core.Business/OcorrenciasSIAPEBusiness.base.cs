
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
	public partial class OcorrenciasSIAPEBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OcorrenciasSIAPE> Listar(WhereBuilder filtro)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasSIAPEData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasSIAPE obj)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			objOcorrenciasSIAPEData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasSIAPE obj)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			objOcorrenciasSIAPEData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual OcorrenciasSIAPE Obtem(int? Id)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasSIAPEData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Acao(int? Acao)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			objOcorrenciasSIAPEData.ExcluirPor_Acao(Acao);
		}
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			objOcorrenciasSIAPEData.ExcluirPor_Ocorrencia(Ocorrencia);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OcorrenciasSIAPEData objOcorrenciasSIAPEData = new OcorrenciasSIAPEData();

			#region Regras de negócio
			#endregion

			objOcorrenciasSIAPEData.Excluir(Id);
		}
		#endregion

	}
}
