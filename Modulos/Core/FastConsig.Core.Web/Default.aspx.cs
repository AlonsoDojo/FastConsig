using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Web.Helpers;
using System.Web;
using System;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;

namespace FastConsig.Core.Web
{
   public partial class _Default : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            try
            {
               var usuario = this.UserContext?.GetUserData<Usuario>();

               var preferenciaUsuario = UsuarioService.GetInstance().ObterPreferencia(usuario.Id);

               if ((string.IsNullOrEmpty(preferenciaUsuario.paginaInicial) ? "Default.aspx" : preferenciaUsuario.paginaInicial) != "Default.aspx")
               {
                  Response.Redirect((string.IsNullOrEmpty(preferenciaUsuario.paginaInicial) ? "Default.aspx" : preferenciaUsuario.paginaInicial), false);
               }

            }
            catch (Exception ex)
            {
               LogService.GetInstance().GravarLogErro(ex, "Falha ao Redirecionar o Usuário para a Página Default Definida");
               Response.Redirect("Default.aspx", false);
            }
         }
      }
   }
}