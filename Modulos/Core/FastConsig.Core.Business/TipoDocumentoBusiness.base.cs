
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
	public partial class TipoDocumentoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoDocumento> Listar(WhereBuilder filtro)
		{
			TipoDocumentoData objTipoDocumentoData = new TipoDocumentoData();

			#region Regras de negócio
			#endregion

			return objTipoDocumentoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDocumento obj)
		{
			TipoDocumentoData objTipoDocumentoData = new TipoDocumentoData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoDocumento obj)
		{
			TipoDocumentoData objTipoDocumentoData = new TipoDocumentoData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoDocumento Obtem(int? Id)
		{
			TipoDocumentoData objTipoDocumentoData = new TipoDocumentoData();

			#region Regras de negócio
			#endregion

			return objTipoDocumentoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoDocumentoData objTipoDocumentoData = new TipoDocumentoData();

			#region Regras de negócio
			#endregion

			objTipoDocumentoData.Excluir(Id);
		}
		#endregion

	}
}
