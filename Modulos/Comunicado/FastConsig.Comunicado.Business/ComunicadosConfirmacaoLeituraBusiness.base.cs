
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
	public partial class ComunicadosConfirmacaoLeituraBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ComunicadosConfirmacaoLeitura> Listar(WhereBuilder filtro)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			return objComunicadosConfirmacaoLeituraData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosConfirmacaoLeitura obj)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			objComunicadosConfirmacaoLeituraData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosConfirmacaoLeitura obj)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			objComunicadosConfirmacaoLeituraData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ComunicadosConfirmacaoLeitura Obtem(int? Id)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			return objComunicadosConfirmacaoLeituraData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Comunicado(int? Comunicado)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			objComunicadosConfirmacaoLeituraData.ExcluirPor_Comunicado(Comunicado);
		}
		public void ExcluirPor_Usuario(string Usuario)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			objComunicadosConfirmacaoLeituraData.ExcluirPor_Usuario(Usuario);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ComunicadosConfirmacaoLeituraData objComunicadosConfirmacaoLeituraData = new ComunicadosConfirmacaoLeituraData();

			#region Regras de negócio
			#endregion

			objComunicadosConfirmacaoLeituraData.Excluir(Id);
		}
		#endregion

	}
}
