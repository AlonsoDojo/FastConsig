
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
	public partial class CTCMotivoDecursoPrazoPortabilidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoDecursoPrazoPortabilidade> Listar(WhereBuilder filtro)
		{
			CTCMotivoDecursoPrazoPortabilidadeData objCTCMotivoDecursoPrazoPortabilidadeData = new CTCMotivoDecursoPrazoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoDecursoPrazoPortabilidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoDecursoPrazoPortabilidade obj)
		{
			CTCMotivoDecursoPrazoPortabilidadeData objCTCMotivoDecursoPrazoPortabilidadeData = new CTCMotivoDecursoPrazoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDecursoPrazoPortabilidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoDecursoPrazoPortabilidade obj)
		{
			CTCMotivoDecursoPrazoPortabilidadeData objCTCMotivoDecursoPrazoPortabilidadeData = new CTCMotivoDecursoPrazoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDecursoPrazoPortabilidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoDecursoPrazoPortabilidade Obtem(int? Id)
		{
			CTCMotivoDecursoPrazoPortabilidadeData objCTCMotivoDecursoPrazoPortabilidadeData = new CTCMotivoDecursoPrazoPortabilidadeData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoDecursoPrazoPortabilidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoDecursoPrazoPortabilidadeData objCTCMotivoDecursoPrazoPortabilidadeData = new CTCMotivoDecursoPrazoPortabilidadeData();

			#region Regras de negócio
			#endregion

			objCTCMotivoDecursoPrazoPortabilidadeData.Excluir(Id);
		}
		#endregion

	}
}
