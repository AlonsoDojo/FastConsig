
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
	public partial class OcorrenciasINSSBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OcorrenciasINSS> Listar(WhereBuilder filtro)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasINSSData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasINSS obj)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			objOcorrenciasINSSData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasINSS obj)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			objOcorrenciasINSSData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual OcorrenciasINSS Obtem(int? Id)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasINSSData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Acao(int? Acao)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			objOcorrenciasINSSData.ExcluirPor_Acao(Acao);
		}
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			objOcorrenciasINSSData.ExcluirPor_Ocorrencia(Ocorrencia);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OcorrenciasINSSData objOcorrenciasINSSData = new OcorrenciasINSSData();

			#region Regras de negócio
			#endregion

			objOcorrenciasINSSData.Excluir(Id);
		}
		#endregion

	}
}
