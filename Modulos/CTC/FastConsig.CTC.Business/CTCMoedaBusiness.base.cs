
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTCMoedaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMoeda> Listar(WhereBuilder filtro)
		{
			CTCMoedaData objCTCMoedaData = new CTCMoedaData();

			#region Regras de negócio
			#endregion

			return objCTCMoedaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMoeda obj)
		{
			CTCMoedaData objCTCMoedaData = new CTCMoedaData();

			#region Regras de negócio
			#endregion

			objCTCMoedaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMoeda obj)
		{
			CTCMoedaData objCTCMoedaData = new CTCMoedaData();

			#region Regras de negócio
			#endregion

			objCTCMoedaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMoeda Obtem(int? Id, string Codigo)
		{
			CTCMoedaData objCTCMoedaData = new CTCMoedaData();

			#region Regras de negócio
			#endregion

			return objCTCMoedaData.Obtem(Id, Codigo);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id, string Codigo)
		{
			CTCMoedaData objCTCMoedaData = new CTCMoedaData();

			#region Regras de negócio
			#endregion

			objCTCMoedaData.Excluir(Id, Codigo);
		}
		#endregion

	}
}
