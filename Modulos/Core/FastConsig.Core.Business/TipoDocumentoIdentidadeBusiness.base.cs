
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
	public partial class TipoDocumentoIdentidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoDocumentoIdentidade> Listar(WhereBuilder filtro)
		{
			TipoDocumentoIdentidadeData objTipoDocumentoIdentidadeData = new TipoDocumentoIdentidadeData();

			#region Regras de negócio
			#endregion

			return objTipoDocumentoIdentidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDocumentoIdentidade obj)
		{
			TipoDocumentoIdentidadeData objTipoDocumentoIdentidadeData = new TipoDocumentoIdentidadeData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoIdentidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoDocumentoIdentidade obj)
		{
			TipoDocumentoIdentidadeData objTipoDocumentoIdentidadeData = new TipoDocumentoIdentidadeData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoIdentidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoDocumentoIdentidade Obtem(int? Id)
		{
			TipoDocumentoIdentidadeData objTipoDocumentoIdentidadeData = new TipoDocumentoIdentidadeData();

			#region Regras de negócio
			#endregion

			return objTipoDocumentoIdentidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoDocumentoIdentidadeData objTipoDocumentoIdentidadeData = new TipoDocumentoIdentidadeData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoIdentidadeData.Excluir(Id);
		}
		#endregion

	}
}
