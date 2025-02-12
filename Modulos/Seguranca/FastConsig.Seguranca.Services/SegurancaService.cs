using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Business;
using FastConsig.Seguranca.Model;
using FastConsig.Common.Loggin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data;
using FastConsig.Common.Helpers;
using FastConsig.Core.Business;
using FastConsig.Core.Entity;

namespace FastConsig.Seguranca.Services
{
    public class SegurancaService
    {
      private static SegurancaService _instance;
      private SegurancaService()
      {
      }

      public static SegurancaService GetInstance()
      {
         return _instance ?? (_instance = new SegurancaService());
      }

      public Usuario Autenticar(string dominioUsuario, string senha)
      {
         var loginParts = dominioUsuario.Split('\\');
         if (loginParts.Length != 2)
            return null;

         var segurancaBiz = new SegurancaBusiness();
         Usuario usuario;

         try
         {
            //TODO: Fazer a verificação do Tipo de Dominio aqui e fazer a autenticação aqui
            usuario = segurancaBiz.ObtemPorLogin(dominioUsuario);

            if (usuario.TipoAutenticacao == 1)
            {
               //Verifica se o Domínio\Usuário e Senha estão OK no AD...
               if (!segurancaBiz.AutenticacoAD(loginParts[0], loginParts[1], senha))
                  return null;
            }
            else
            {
               var senhaEncriptada = CryptoHelper.GenerateHashPassword(senha);

               if (senhaEncriptada != usuario.Senha)
                  return null;
            }

            //Retorna a lista de grupos que o usuário pertence...
            //var gruposAD = segurancaBiz.ObtemGruposAutorizados(loginParts[0], loginParts[1]);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, ex.Message);
            return null;
         }

         return usuario;

      }

      public Usuario BuscarUsuario(string dominioUsuario)
      {
         var loginParts = dominioUsuario.Split('\\');
         if (loginParts.Length != 2)
         {
            var dominio = this.ObtemDominioAtivoUsuario(dominioUsuario);

            if (dominio == null)
            {
               return null;
            }
            else
            {
               dominioUsuario = dominio + "\\" + loginParts[0];
            }
         }


         var segurancaBiz = new SegurancaBusiness();
         Usuario usuario;

         try
         {
            //TODO: Fazer a verificação do Tipo de Dominio aqui e fazer a autenticação aqui
            usuario = segurancaBiz.ObtemPorLogin(dominioUsuario);

         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, ex.Message);
            return null;
         }

         return usuario;

      }

      /// <summary>
      /// Registra que o usuário realizou o login agora.
      /// </summary>
      /// <param name="usuario"></param>
      public void RegistrarLogin(Usuario usuario)
      {
         if (usuario == null)
            return;

         usuario.DataUltimoLogin = DateTime.Now;
         new UsuarioBusiness().Alterar(usuario);
      }

      /// <summary>
      /// Obtem as permissões do usuário no sistema.
      /// </summary>
      /// <param name="idUsuario"></param>
      /// <returns></returns>
      public PermissaoUsuarioModel ObterPermissoes(string idUsuario)
      {
         //Consultar Perfis do usuário no sistema...
         var permissao = new PermissaoUsuarioModel();

         //Consulta as permissões do usuário no sistema
         using (var biz = new ViewPermissaoUsuarioBusiness())
         {
            var permissoes = biz.ObtemPermissao(idUsuario);
            permissao.Permissoes = biz.JoinPermissions(permissoes);
         }

         permissao.Perfis = new ViewPerfilUsuarioBusiness().Listar(idUsuario);

         return permissao;
      }


      /// <summary>
      /// Obtem as permissões do usuário no sistema.
      /// </summary>
      /// <param name="idUsuario"></param>
      /// <returns></returns>
      public PermissaoUsuarioModel ObterAcoes(string idUsuario)
      {
         //Consultar Perfis do usuário no sistema...
         var permissao = new PermissaoUsuarioModel();

         //Consulta as permissões do usuário no sistema
         using (var biz = new ViewPermissaoUsuarioBusiness())
         {
            var permissoes = biz.ObtemPermissao(idUsuario);
            permissao.Permissoes = permissoes;
         }

         permissao.Perfis = new ViewPerfilUsuarioBusiness().Listar(idUsuario);

         return permissao;
      }

      public Usuario ObterInformacoesUsuario(string Id)
      {
         var usuario = new UsuarioBusiness().Obtem(Id);
         return usuario;
      }

      #region Dominio
      public List<Dominio> ListarDominios()
      {
         return new DominioBusiness().Listar(null);
      }

      public List<UsuarioProduto> ListarProdutosHabilitados(string usuario)
      {
         return new UsuarioProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(UsuarioProduto.METADADO.Usuario, Filter.Equal, usuario)).ToList();
      }

      public List<Dominio> ListarDominiosAtivos()
      {
         return new DominioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Dominio.METADADO.Ativo, Filter.Equal, true));
      }

      public void SalvarDominio(Dominio dominio)
      {
         if (dominio.Id == null || dominio.Id == 0)
         {
            new DominioBusiness().Incluir(dominio);
         }
         else
         {
            new DominioBusiness().Alterar(dominio);
         }
      }

      public void ExcluirDominio(int? id)
      {
         new DominioBusiness().Excluir(id);
      }

      public Dominio ObtemDominio(int? id)
      {
         return new DominioBusiness().Obtem(id);
      }
      #endregion

      #region Tipo de Autenticacao
      public List<TipoAutenticacao> ListarTipoAutenticacao()
      {
         return new TipoAutenticacaoBusiness().Listar(null);
      }
      #endregion

      public bool OnBlackList(Usuario usuario)
      {
         return (new UsuarioBlacklistBusiness().Obtem(usuario.CpfCnpj) == null ? false : true);
      }

      public bool IsBlocked(Usuario usuario)
      {
         return (new UsuarioBloqueioBusiness().Listar(WhereBuilder.Create().Add(UsuarioBloqueio.METADADO.CpfCnpj, Filter.Equal, usuario.CpfCnpj.ToString().PadLeft(11, '0'))
                                                                           .Add(UsuarioBloqueio.METADADO.DataInicioBloqueio, Filter.LessOrEqual, DateTime.Now.Date)
                                                                           .Add(UsuarioBloqueio.METADADO.DataFimBloqueio, Filter.GreatherOrEqual, DateTime.Now.Date)).Count() > 0 ? true : false);
      }

      public string ObtemDominioAtivoUsuario(string usuario)
      {
         return new DominioBusiness().Obtem(new UsuarioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Usuario.METADADO.Login, Filter.Equal, usuario, Link.And).Add(Usuario.METADADO.Bloqueado, Filter.Equal, false)).FirstOrDefault()?.Dominio)?.URL;
      }

      public string ObtemDominioAtivoUsuario2(string usuario)
      {
         return new DominioBusiness().Obtem(new UsuarioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Usuario.METADADO.Login, Filter.Equal, usuario, Link.And)).FirstOrDefault()?.Dominio)?.URL;
      }

      public bool? VerificaDominioAtivo(string dominio)
      {
         return new DominioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Dominio.METADADO.URL, Filter.Equal, dominio, Link.And).Add(Dominio.METADADO.Ativo, Filter.Equal, true)).FirstOrDefault()?.Ativo;
      }

      public List<Usuario> ListarUsuariosPromotora(int? promotora)
      {
         return new UsuarioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Usuario.METADADO.Promotora, Filter.Equal, promotora, Link.And));
      }
   }
}
