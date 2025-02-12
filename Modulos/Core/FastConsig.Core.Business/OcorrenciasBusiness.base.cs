
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
	public partial class OcorrenciasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Ocorrencias> Listar(WhereBuilder filtro)
		{
			OcorrenciasData objOcorrenciasData = new OcorrenciasData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Ocorrencias obj)
		{
			OcorrenciasData objOcorrenciasData = new OcorrenciasData();

			#region Regras de negócio
			#endregion

			objOcorrenciasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Ocorrencias obj)
		{
			OcorrenciasData objOcorrenciasData = new OcorrenciasData();

			#region Regras de negócio
			#endregion

			objOcorrenciasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Ocorrencias Obtem(int? Id)
		{
			OcorrenciasData objOcorrenciasData = new OcorrenciasData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OcorrenciasData objOcorrenciasData = new OcorrenciasData();

			#region Regras de negócio
			#endregion

			objOcorrenciasData.Excluir(Id);
		}
		#endregion

	}
}
