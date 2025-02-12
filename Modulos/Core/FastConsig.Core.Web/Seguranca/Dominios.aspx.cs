using FastConsig.Common.Loggin;
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
   public partial class Dominios : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarDominios();
      }

      protected void DominiosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Dominio)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
            ((CustomLabel)e.Item.FindControl("lblTipo")).Text = o.TipoAutenticacaoDescricao;
            ((CustomLabel)e.Item.FindControl("lblHabilitado")).CssClass = o.Ativo ? "fa fa-check" : "fa fa-ban";
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Dominio dominio = SegurancaService.GetInstance().ObtemDominio(int.Parse(id));
         SetCrossPageData("Dominio", dominio);
         Response.Redirect("/Seguranca/EditarDominio.aspx?Comando=Editar", false);
      }

      private void CarregarDominios()
      {
         try
         {
            DominiosRepeater.DataSource = DominioService.GetInstance().Listar().OrderBy(c => c.Id).ToList();
            DominiosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Dominios"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/EditarDominio.aspx?Comando=Novo", false);
      }
   }
}