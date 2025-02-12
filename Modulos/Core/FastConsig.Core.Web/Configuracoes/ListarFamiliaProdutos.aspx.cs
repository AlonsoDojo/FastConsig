using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class ListarFamiliaProdutos : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarFamiliaProdutos();
      }

      protected void FamiliaProdutosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (FamiliaProduto)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         FamiliaProduto familiaProduto = PropostaService.GetInstance().ObtemFamiliaProduto(int.Parse(id));
         SetCrossPageData("FamiliaProduto", familiaProduto);
         Response.Redirect("/Configuracoes/EditarFamiliaProduto.aspx?Comando=Editar", false);
      }

      private void CarregarFamiliaProdutos()
      {
         try
         {
            FamiliaProdutosRepeater.DataSource = PropostaService.GetInstance().ListarFamiliaProduto().OrderBy(c => c.Id).ToList();
            FamiliaProdutosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Familia de Produtos"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarFamiliaProduto.aspx?Comando=Novo", false);
      }
   }
}