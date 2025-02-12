
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Data;
#endregion

namespace FastConsig.Consignado.Business
{
	public partial class ConsignadoOcorrenciaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ConsignadoOcorrencia> Listar(WhereBuilder filtro)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objConsignadoOcorrenciaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ConsignadoOcorrencia obj)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objConsignadoOcorrenciaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ConsignadoOcorrencia obj)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objConsignadoOcorrenciaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ConsignadoOcorrencia Obtem(int? Id)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objConsignadoOcorrenciaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objConsignadoOcorrenciaData.ExcluirPor_Ocorrencia(Ocorrencia);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ConsignadoOcorrenciaData objConsignadoOcorrenciaData = new ConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objConsignadoOcorrenciaData.Excluir(Id);
		}
		#endregion

	}
}
