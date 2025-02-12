
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
	public partial class ComunicadosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Comunicados> Listar(WhereBuilder filtro)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			return objComunicadosData.Listar(filtro);
		}
		#endregion

		#region Listar Comunicados (É Retirado o Conteúdo devido ao tamanho)
		public virtual List<Comunicados> ListarComunicados(WhereBuilder filtro)
      {
         ComunicadosData objComunicadosData = new ComunicadosData();

         #region Regras de negócio
         #endregion

         return objComunicadosData.ListarComunicados(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Comunicados obj)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Comunicados obj)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Comunicados Obtem(int? Id)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			return objComunicadosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Usuario(string Usuario)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.ExcluirPor_Usuario(Usuario);
		}
		public void ExcluirPor_Status(int? Status)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.ExcluirPor_Status(Status);
		}
		public void ExcluirPor_UsuarioAlteracao(string UsuarioAlteracao)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.ExcluirPor_UsuarioAlteracao(UsuarioAlteracao);
		}
		public void ExcluirPor_UsuarioPublicador(string UsuarioPublicador)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.ExcluirPor_UsuarioPublicador(UsuarioPublicador);
		}
		public void ExcluirPor_UsuarioDesativacao(string UsuarioDesativacao)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.ExcluirPor_UsuarioDesativacao(UsuarioDesativacao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ComunicadosData objComunicadosData = new ComunicadosData();

			#region Regras de negócio
			#endregion

			objComunicadosData.Excluir(Id);
		}
		#endregion

	}
}
