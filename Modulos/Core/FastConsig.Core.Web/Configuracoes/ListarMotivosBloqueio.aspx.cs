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

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class ListarMotivosBloqueio : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarMotivosBloqueio.aspx");
         CarregarMotivosBloqueio();
      }

      protected void MotivosBloqueioRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (MotivoBloqueio)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         MotivoBloqueio motivoBloqueio = PropostaService.GetInstance().ObtemMotivoBloqueio(int.Parse(id));
         SetCrossPageData("MotivoBloqueio", motivoBloqueio);
         Response.Redirect("/Configuracoes/EditarMotivoBloqueio.aspx?Comando=Editar", false);
      }

      private void CarregarMotivosBloqueio()
      {
         try
         {
            MotivosBloqueioRepeater.DataSource = PropostaService.GetInstance().ListarMotivosBloqueio().OrderBy(c => c.Id).ToList();
            MotivosBloqueioRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Motivos de Bloqueio"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarMotivoBloqueio.aspx?Comando=Novo", false);
      }
   }
}