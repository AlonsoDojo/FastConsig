
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
	public partial class PropostaOcorrenciasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaOcorrencias> Listar(WhereBuilder filtro)
		{
			PropostaOcorrenciasData objPropostaOcorrenciasData = new PropostaOcorrenciasData();

			#region Regras de negócio
			#endregion

			return objPropostaOcorrenciasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaOcorrencias obj)
		{
			PropostaOcorrenciasData objPropostaOcorrenciasData = new PropostaOcorrenciasData();

			#region Regras de negócio
			#endregion

			objPropostaOcorrenciasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaOcorrencias obj)
		{
			PropostaOcorrenciasData objPropostaOcorrenciasData = new PropostaOcorrenciasData();

			#region Regras de negócio
			#endregion

			objPropostaOcorrenciasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaOcorrencias Obtem(int? Id)
		{
			PropostaOcorrenciasData objPropostaOcorrenciasData = new PropostaOcorrenciasData();

			#region Regras de negócio
			#endregion

			return objPropostaOcorrenciasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostaOcorrenciasData objPropostaOcorrenciasData = new PropostaOcorrenciasData();

			#region Regras de negócio
			#endregion

			objPropostaOcorrenciasData.Excluir(Id);
		}
		#endregion

	}
}
