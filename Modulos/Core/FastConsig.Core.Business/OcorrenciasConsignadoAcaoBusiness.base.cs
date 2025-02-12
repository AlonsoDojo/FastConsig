
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
	public partial class OcorrenciasConsignadoAcaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OcorrenciasConsignadoAcao> Listar(WhereBuilder filtro)
		{
			OcorrenciasConsignadoAcaoData objOcorrenciasConsignadoAcaoData = new OcorrenciasConsignadoAcaoData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasConsignadoAcaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasConsignadoAcao obj)
		{
			OcorrenciasConsignadoAcaoData objOcorrenciasConsignadoAcaoData = new OcorrenciasConsignadoAcaoData();

			#region Regras de negócio
			#endregion

			objOcorrenciasConsignadoAcaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasConsignadoAcao obj)
		{
			OcorrenciasConsignadoAcaoData objOcorrenciasConsignadoAcaoData = new OcorrenciasConsignadoAcaoData();

			#region Regras de negócio
			#endregion

			objOcorrenciasConsignadoAcaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual OcorrenciasConsignadoAcao Obtem(int? Id)
		{
			OcorrenciasConsignadoAcaoData objOcorrenciasConsignadoAcaoData = new OcorrenciasConsignadoAcaoData();

			#region Regras de negócio
			#endregion

			return objOcorrenciasConsignadoAcaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OcorrenciasConsignadoAcaoData objOcorrenciasConsignadoAcaoData = new OcorrenciasConsignadoAcaoData();

			#region Regras de negócio
			#endregion

			objOcorrenciasConsignadoAcaoData.Excluir(Id);
		}
		#endregion

	}
}
