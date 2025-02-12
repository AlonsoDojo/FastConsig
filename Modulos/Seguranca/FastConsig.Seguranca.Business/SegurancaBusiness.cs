using FastConsig.Seguranca.Entity;
using Framework.Data;
using System.Collections.Generic;
using System.Linq;
using System.DirectoryServices.AccountManagement;

namespace FastConsig.Seguranca.Business
{
   public class SegurancaBusiness
   {
      /// <summary>
      /// Authentica o uuário no AD.
      /// </summary>
      /// <param name="domain">Dominio a ser pesquisado</param>
      /// <param name="username"></param>
      /// <param name="pwd"></param>
      /// <returns></returns>
      public bool AutenticacoAD(string domain, string username, string pwd)
      {
         bool isValid = false;
         using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
         {
            // validate the credentials
            isValid = pc.ValidateCredentials(username, pwd);
         }
         return isValid;
      }

      /// <summary>
      /// Obtém usuário por login no formato Domain\User.
      /// </summary>
      /// <param name="login">Domain\User</param>
      /// <returns></returns>
      public Usuario ObtemPorLogin(string login)
      {
         var parts = login.Split('\\');

         var dominio = new DominioBusiness().Listar(WhereBuilder.Create().Add(Dominio.METADADO.URL, Filter.Equal, parts[0])).FirstOrDefault()?.Id;

         var filtro = WhereBuilder.Create()
                            .Add(Usuario.METADADO.Login, Filter.Equal, parts[1])
                            .Add(Usuario.METADADO.Dominio, Filter.Equal, dominio);

         var usuarios = new UsuarioBusiness().Listar(filtro);
         return usuarios?.FirstOrDefault();
      }

      /// <summary>
      /// Obtém a lista de grupos associados a este usuário.
      /// </summary>
      /// <param name="domain"></param>
      /// <param name="username"></param>
      /// <returns></returns>
      public List<string> ObtemGruposAutorizados(string domain, string username)
      {
         List<string> groups = null;
         using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
         {
            // validate the credentials
            UserPrincipal user = UserPrincipal.FindByIdentity(pc, username);
            var groupsAD = user.GetAuthorizationGroups();
            groups = groupsAD.Select(g => g.Name)
                             .ToList();
         }

         return groups;
      }
   }
}
