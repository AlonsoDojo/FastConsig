using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class ListarRedeLojas : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarRedeLojas();
      }

      protected void RedeLojasRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (RedeLoja)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Nome;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         RedeLoja redeLoja = PropostaService.GetInstance().ObtemRedeLojas(int.Parse(id));
         SetCrossPageData("RedeLoja", redeLoja);
         Response.Redirect("/Configuracoes/EditarRedeLojas.aspx?Comando=Editar", false);
      }

      private void CarregarRedeLojas()
      {
         try
         {
            RedeLojasRepeater.DataSource = PropostaService.GetInstance().ListarRedeLoja().OrderBy(c => c.Nome).ToList();
            RedeLojasRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Rede de Lojas"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarRedeLojas.aspx?Comando=Novo", false);
      }
   }
}