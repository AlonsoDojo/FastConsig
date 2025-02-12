using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class Perfis : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarPerfis();
      }

      protected void PerfilRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            Perfil o = (Perfil)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblNome")).Text = o.Nome;
            ((CustomLabel)e.Item.FindControl("lblHabilitado")).CssClass = o.Habilitado ? "fa fa-check" : "fa fa-ban";
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Perfil perfil = UsuarioService.GetInstance().ObtemPerfil(int.Parse(id));
         SetCrossPageData("Perfil", perfil);
         Response.Redirect("/Seguranca/EditarPerfil.aspx?Comando=Editar", false);
      }

      private void CarregarPerfis()
      {
         try
         {
            PerfilRepeater.DataSource = UsuarioService.GetInstance().ListarPerfis().OrderBy(x => x.Id).ToList();
            PerfilRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Perfil"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/EditarPerfil.aspx?Comando=Novo", false);
      }
   }
}