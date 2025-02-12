using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Model;
using FastConsig.Seguranca.Services;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class Usuarios : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarUsuarios();
      }

      protected void UsuarioRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Usuario)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblLogin")).Text = o.Login;
            ((CustomLabel)e.Item.FindControl("lblNome")).Text = o.Nome;
            ((CustomLabel)e.Item.FindControl("lblBloqueado")).CssClass = o.Bloqueado ? "fa fa-check" : "fa fa-ban";
            ((CustomLabel)e.Item.FindControl("lblHabilitado")).CssClass = o.Habilitado ? "fa fa-check" : "fa fa-ban";
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Usuario usuario = UsuarioService.GetInstance().Obter(id);
         SetCrossPageData("Usuario", usuario);
         Response.Redirect("/Seguranca/EditarUsuario.aspx?Comando=Editar", false);
      }

      private void CarregarUsuarios()
      {
         var usuarios = UsuarioService.GetInstance().Listar(this.UserContext?.GetUserData<Usuario>().Dominio);

         if (this.UserContext?.GetUserData<Usuario>().RedeLojas != null)
         {
            usuarios = usuarios.Where(u => u.RedeLojas == this.UserContext?.GetUserData<Usuario>().RedeLojas).ToList();
         }

         if (this.UserContext?.GetUserData<Usuario>().Loja != null)
         {
            usuarios = usuarios.Where(u => u.Loja == this.UserContext?.GetUserData<Usuario>().Loja).ToList();
         }

         UsuarioRepeater.DataSource = usuarios?.OrderBy(u => u.Login)
                                               .ToList();
         UsuarioRepeater.DataBind();
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/EditarUsuario.aspx?Comando=Novo", false);
      }
   }
}