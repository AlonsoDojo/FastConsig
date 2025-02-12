using FastConsig.Common.Helpers;
using FastConsig.Core.Business;
using FastConsig.Core.Entity;
using FastConsig.Seguranca.Business;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Model;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.Seguranca.Services
{
   public class UsuarioService
   {
      private static UsuarioService _instance;

      public static UsuarioService GetInstance()
      {
         if (_instance == null)
            _instance = new UsuarioService();

         return _instance;
      }

      public List<Usuario> Listar()
      {
         return new UsuarioBusiness().Listar(null);
      }
      public List<Usuario> Listar(int? dominio)
      {
         return new UsuarioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Usuario.METADADO.Dominio, Filter.Equal, dominio));
      }

      public Usuario Obter(string idUsuario)
      {
         return new UsuarioBusiness().Obtem(idUsuario);
      }

      public List<Usuario> ObterPorLogin(string usuario)
      {
         return new UsuarioBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Usuario.METADADO.Login, Filter.Equal, usuario));
      }

      public List<UsuarioModel> ListarUsuarios()
      {
         return new UsuarioBusiness().Listar(null).ConvertAll(c => new UsuarioModel
         {
            Id = c.Id,
            Login = c.Login,
            Nome = c.Nome,
            Bloqueado = c.Bloqueado,
            Celular = c.Celular,
            CpfCnpj = c.CpfCnpj,
            DataRegistro = c.DataRegistro,
            DataUltimaTrocaSenha = c.DataUltimaTrocaSenha,
            DataUltimoLogin = c.DataUltimoLogin,
            Dominio = c.Dominio,
            Email = c.Email,
            Habilitado = c.Habilitado,
            Loja = c.Loja,
            PreferenciaUsuario = c.PreferenciaUsuario,
            Promotora = c.Promotora,
            UsuarioRegistro = c.UsuarioRegistro,
            Senha = c.Senha,
            RedeLojas = c.RedeLojas
         });
      }

      public UsuarioModel ObterPorClientId(string clientId)
      {
         var decode = Extensions.Base64Decode(clientId);

         var user = CryptoHelper.Decrypt(decode).Split(':');

         var usuario = new UsuarioBusiness().
            Listar(Framework.Data.WhereBuilder.Create().
            Add(Usuario.METADADO.Id, Filter.Equal, user[0]).
               Add(Usuario.METADADO.Login, Filter.Equal, user[1]).
               Add(Usuario.METADADO.Senha, Filter.Equal, user[2])).FirstOrDefault() ?? null;

         if (usuario == null)
            throw new System.Exception("ClientId inválido.");

         return new UsuarioModel
         {
            Id = usuario.Id,
            Login = usuario.Login,
            Nome = usuario.Nome,
            Bloqueado = usuario.Bloqueado,
            Celular = usuario.Celular,
            CpfCnpj = usuario.CpfCnpj,
            DataRegistro = usuario.DataRegistro,
            DataUltimaTrocaSenha = usuario.DataUltimaTrocaSenha,
            DataUltimoLogin = usuario.DataUltimoLogin,
            Dominio = usuario.Dominio,
            Email = usuario.Email,
            Habilitado = usuario.Habilitado,
            Loja = usuario.Loja,
            PreferenciaUsuario = usuario.PreferenciaUsuario
         };
      }

      public bool ValidarUsuario(string login, string senha)
      {
         var usuario = new UsuarioBusiness().
            Listar(Framework.Data.WhereBuilder.Create().
               Add(Usuario.METADADO.Login, Filter.Equal, login).
               Add(Usuario.METADADO.Senha, Filter.Equal, senha)).FirstOrDefault() ?? null;

         return usuario != null;
      }

      public Usuario ObtemProfissionalCertificado(int? dominio)
      {

         var perfil = ListarPerfis().Where(x => x.Nome == "Profissional Certificado").FirstOrDefault();

         var usuarios = Listar(dominio);

         foreach (Usuario u in usuarios)
         {
            var perfis = ListarPerfis(u.Id).Where(x => x.IdPerfil == perfil.Id);

            if (perfis.Count() > 0)
            {
               return u;
            }
         }

         return null;
      }

      public void ExcluirUsuario(string idUsuario)
      {
         new UsuarioBusiness().Excluir(idUsuario);
      }

      public void IncluirUsuario(Usuario usuario)
      {
         new UsuarioBusiness().Incluir(usuario);
      }

      public void AlterarUsuario(Usuario usuario, List<UsuarioPerfil> perfisAssociados, List<UsuarioProduto> produtosAssociados)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            //*------- Grava o usuário...
            new UsuarioBusiness().Alterar(usuario);

            //*------- Apaga as permissões...
            var usuarioPerfilBiz = new UsuarioPerfilBusiness();
            usuarioPerfilBiz.ExcluirPor_IdUsuario(usuario.Id);

            //*------- Grava as permissões...
            foreach (var associado in perfisAssociados)
            {
               usuarioPerfilBiz.Incluir(associado);
            }

            //*------Apaga os Produtos
            var usuarioProdutoBiz = new UsuarioProdutoBusiness();
            usuarioProdutoBiz.ExcluirPor_Usuario(usuario.Id);

            //*------- Grava as permissões...
            foreach (var produto in produtosAssociados)
            {
               usuarioProdutoBiz.Incluir(produto);
            }
         });
      }

      public void AlterarUsuario(Usuario usuario)
      {
         new UsuarioBusiness().Alterar(usuario);
      }

      public void SalvarUsuario(Usuario usuario)
      {
         if (usuario.Id.IsNullOrEmpty())
         {
            string novaSenha = new CryptoHelper().RandomPassword(8, 10);
            usuario = Common.Helpers.UtilityHelper.Clone(usuario);
            usuario.Id = Guid.NewGuid().ToString().ToUpper();
            usuario.Senha = CryptoHelper.GenerateHashPassword(novaSenha);
            new UsuarioBusiness().Incluir(usuario);
         } else
         {
            new UsuarioBusiness().Alterar(usuario);
         }
      }

      public void AlterarPerfilUsuario(Perfil perfil, List<PerfilFuncionalidade> funcionalidadesAssociadas, List<PerfilEventoFuncionalidade> perfisEventoFuncionalidade)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            //*------- Grava os dados do perfil...
            new PerfilBusiness().Alterar(perfil);

            //*------- Apaga as permissões anteriores...
            var perfilFuncionalidadeBiz = new PerfilFuncionalidadeBusiness();
            perfilFuncionalidadeBiz.ExcluirPor_IdPerfil(perfil.Id);

            //*------- Grava as permissões...
            foreach (var assosiada in funcionalidadesAssociadas)
            {
               perfilFuncionalidadeBiz.Incluir(assosiada);
            }

            //*------- Apaga as permissões de eventos das funcionalidades anteriores...
            var perfilEventoFuncionalidadeBiz = new PerfilEventoFuncionalidadeBusiness();

            //*------- excluir as permissões de eventos das funcionalidades...
            perfilEventoFuncionalidadeBiz.ExcluirPor_IdPerfil(perfil.Id);


            //*------- Grava as permissões de eventos das funcionalidades...
            foreach (var eventos in perfisEventoFuncionalidade)
            {
               perfilEventoFuncionalidadeBiz.Incluir(eventos);
            }

         });
      }

      public List<UsuarioPerfil> ListarPerfis(string idUsuario)
      {
         return new UsuarioPerfilBusiness().Listar(idUsuario);
      }

      public List<Perfil> ListarPerfis()
      {
         return new PerfilBusiness().Listar(null);
      }
      public List<Perfil> ListarPerfis(bool externo)
      {
         return new PerfilBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Perfil.METADADO.Externo, Filter.Equal, externo));
      }

      public Perfil ObterPerfil(int? idPerfil)
      {
         return new PerfilBusiness().Obtem(idPerfil);
      }

      public Perfil ObtemPerfil(int? idPerfil)
      {
         return new PerfilBusiness().Obtem(idPerfil);
      }

      public void ExcluirPerfil(int? idPerfil)
      {
         new PerfilBusiness().Excluir(idPerfil);
      }

      public void IncluirPerfil(Perfil perfil)
      {
         new PerfilBusiness().Incluir(perfil);
      }

      public void AlterarPerfil(Perfil perfil)
      {
         new PerfilBusiness().Alterar(perfil);
      }

      public void SalvarPerfil(Perfil perfil)
      {
         if (perfil.Id == null || perfil.Id == 0)
         {
            new PerfilBusiness().Incluir(perfil);
         } else
         {
            new PerfilBusiness().Alterar(perfil);
         }
      }
      public void Alterar(Perfil perfil, List<PerfilFuncionalidade> funcionalidadesAssociadas)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            //*------- Grava os dados do perfil...
            new PerfilBusiness().Alterar(perfil);

            //*------- Apaga as permissões anteriores...
            PerfilFuncionalidadeBusiness perfilFuncionalidadeBiz = new PerfilFuncionalidadeBusiness();
            perfilFuncionalidadeBiz.ExcluirPor_IdPerfil(perfil.Id);

            //*------- Grava as permissões...
            foreach (PerfilFuncionalidade assosiada in funcionalidadesAssociadas)
            {
               perfilFuncionalidadeBiz.Incluir(assosiada);
            }
         });
      }
      public List<UsuarioProduto> ListarProdutos(string idUsuario)
      {
         return new UsuarioProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(UsuarioProduto.METADADO.Usuario, Filter.Equal, idUsuario));
      }

      public List<Produtos> ListarProdutosDoUsuario(string idUsuario)
      {
         List<UsuarioProduto> produtosUsuario = new UsuarioProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(UsuarioProduto.METADADO.Usuario, Filter.Equal, idUsuario));

         List<Produtos> produtos = new List<Produtos>();

         foreach (UsuarioProduto p in produtosUsuario)
         {
            produtos.Add(new ProdutosBusiness().Obtem(p.Produto));
         }

         return produtos;
      }

      public void AlterarPreferencia(string idUsuario, PreferenciaUsuarioModel model)
      {
         Usuario usuario = Obter(idUsuario);

         // serializando as preferências do usuário.
         usuario.PreferenciaUsuario = Newtonsoft.Json.JsonConvert.SerializeObject(model);

         // persistindo preferências do usuário.
         AlterarUsuario(usuario);
      }

      public PreferenciaUsuarioModel ObterPreferencia(string idUsuario)
      {
         var preferenciaUsuario = new PreferenciaUsuarioModel();

         Usuario usuario = Obter(idUsuario);

         if (!string.IsNullOrEmpty(usuario.PreferenciaUsuario))
            preferenciaUsuario = Newtonsoft.Json.JsonConvert.DeserializeObject<PreferenciaUsuarioModel>(usuario.PreferenciaUsuario);

         // não é permitido valor zero tempo padrão de atualização do Monitor de Propostas.
         if (preferenciaUsuario.tempoRefreshPadrao == 0)
         {
            preferenciaUsuario.tempoRefreshPadrao = 120;
            preferenciaUsuario.paginaInicial = "Default.aspx";
         }


         return preferenciaUsuario;
      }
   }
}
