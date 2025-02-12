
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
using FastConsig.Comunicado.Data;
#endregion

namespace FastConsig.Comunicado.Business
{
	public partial class ComunicadosArquivosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ComunicadosArquivos> Listar(WhereBuilder filtro)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			return objComunicadosArquivosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosArquivos obj)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			objComunicadosArquivosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosArquivos obj)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			objComunicadosArquivosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ComunicadosArquivos Obtem(int? Id)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			return objComunicadosArquivosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Comunicado(int? Comunicado)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			objComunicadosArquivosData.ExcluirPor_Comunicado(Comunicado);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ComunicadosArquivosData objComunicadosArquivosData = new ComunicadosArquivosData();

			#region Regras de negócio
			#endregion

			objComunicadosArquivosData.Excluir(Id);
		}
		#endregion

	}
}
