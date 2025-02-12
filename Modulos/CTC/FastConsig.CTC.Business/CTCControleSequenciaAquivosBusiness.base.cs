
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
	public partial class CTCControleSequenciaAquivosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCControleSequenciaAquivos> Listar(WhereBuilder filtro)
		{
			CTCControleSequenciaAquivosData objCTCControleSequenciaAquivosData = new CTCControleSequenciaAquivosData();

			#region Regras de negócio
			#endregion

			return objCTCControleSequenciaAquivosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCControleSequenciaAquivos obj)
		{
			CTCControleSequenciaAquivosData objCTCControleSequenciaAquivosData = new CTCControleSequenciaAquivosData();

			#region Regras de negócio
			#endregion

			objCTCControleSequenciaAquivosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCControleSequenciaAquivos obj)
		{
			CTCControleSequenciaAquivosData objCTCControleSequenciaAquivosData = new CTCControleSequenciaAquivosData();

			#region Regras de negócio
			#endregion

			objCTCControleSequenciaAquivosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCControleSequenciaAquivos Obtem(int? Id)
		{
			CTCControleSequenciaAquivosData objCTCControleSequenciaAquivosData = new CTCControleSequenciaAquivosData();

			#region Regras de negócio
			#endregion

			return objCTCControleSequenciaAquivosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCControleSequenciaAquivosData objCTCControleSequenciaAquivosData = new CTCControleSequenciaAquivosData();

			#region Regras de negócio
			#endregion

			objCTCControleSequenciaAquivosData.Excluir(Id);
		}
		#endregion

	}
}
