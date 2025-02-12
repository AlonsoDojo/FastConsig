using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class ListarBancos : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarBancos();
      }

      protected void BancosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Bancos)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Banco;
            ((CustomLabel)e.Item.FindControl("lblCodigoCompe")).Text = o.Banco;
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Nome;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Bancos banco = PropostaService.GetInstance().ObtemBanco(id);
         SetCrossPageData("Bancos", banco);
         Response.Redirect("/Configuracoes/EditarBanco.aspx?Comando=Editar", false);
      }

      private void CarregarBancos()
      {
         try
         {
            BancosRepeater.DataSource = PropostaService.GetInstance().ListarBancos().OrderBy(c => c.Banco).ToList();
            BancosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Bancos"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarBanco.aspx?Comando=Novo", false);
      }
   }
}