
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
	public partial class PropostaHierarquiaConsultaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaHierarquiaConsulta> Listar(WhereBuilder filtro)
		{
			PropostaHierarquiaConsultaData objPropostaHierarquiaConsultaData = new PropostaHierarquiaConsultaData();

			#region Regras de negócio
			#endregion

			return objPropostaHierarquiaConsultaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaHierarquiaConsulta obj)
		{
			PropostaHierarquiaConsultaData objPropostaHierarquiaConsultaData = new PropostaHierarquiaConsultaData();

			#region Regras de negócio
			#endregion

			objPropostaHierarquiaConsultaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaHierarquiaConsulta obj)
		{
			PropostaHierarquiaConsultaData objPropostaHierarquiaConsultaData = new PropostaHierarquiaConsultaData();

			#region Regras de negócio
			#endregion

			objPropostaHierarquiaConsultaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaHierarquiaConsulta Obtem(int? Id)
		{
			PropostaHierarquiaConsultaData objPropostaHierarquiaConsultaData = new PropostaHierarquiaConsultaData();

			#region Regras de negócio
			#endregion

			return objPropostaHierarquiaConsultaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostaHierarquiaConsultaData objPropostaHierarquiaConsultaData = new PropostaHierarquiaConsultaData();

			#region Regras de negócio
			#endregion

			objPropostaHierarquiaConsultaData.Excluir(Id);
		}
		#endregion

	}
}
