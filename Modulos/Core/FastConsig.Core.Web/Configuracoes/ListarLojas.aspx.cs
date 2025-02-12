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
   public partial class ListarLojas : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarLojas();
      }

      protected void LojasRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Lojas)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblNomeRede")).Text = o.NomeRedeLoja;
            ((CustomLabel)e.Item.FindControl("lblNomeLoja")).Text = o.Nome;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Lojas loja = PropostaService.GetInstance().ObtemLoja(int.Parse(id));
         SetCrossPageData("Lojas", loja);
         Response.Redirect("/Configuracoes/EditarLoja.aspx?Comando=Editar", false);
      }

      private void CarregarLojas()
      {
         try
         {
            LojasRepeater.DataSource = PropostaService.GetInstance().ListarLojas().OrderBy(c => c.RedeLoja).ThenBy(x => x.Loja).ToList();
            LojasRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Lojas"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarLoja.aspx?Comando=Novo", false);
      }
   }
}