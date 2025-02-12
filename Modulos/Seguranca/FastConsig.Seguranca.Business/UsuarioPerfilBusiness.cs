using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Business
{
   public partial class UsuarioPerfilBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<UsuarioPerfil> Listar(WhereBuilder filtro)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         return objUsuarioPerfilData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioPerfil obj)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         objUsuarioPerfilData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(UsuarioPerfil obj)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         objUsuarioPerfilData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual UsuarioPerfil Obtem(int? Id)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         return objUsuarioPerfilData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdUsuario(string IdUsuario)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         objUsuarioPerfilData.ExcluirPor_IdUsuario(IdUsuario);
      }
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         objUsuarioPerfilData.ExcluirPor_IdPerfil(IdPerfil);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         UsuarioPerfilData objUsuarioPerfilData = new UsuarioPerfilData();

         #region Regras de negócio
         #endregion

         objUsuarioPerfilData.Excluir(Id);
      }
      #endregion
      public List<UsuarioPerfil> Listar(string idUsuario)
      {
         var filtro = WhereBuilder.Create()
                           .Add(UsuarioPerfil.METADADO.IdUsuario, Filter.Equal, idUsuario);

         return Listar(filtro);
      }
   }
}
