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
   public partial class ListarMotivosRecusa : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarMotivosRecusa();
      }

      protected void MotivosRecusaRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (MotivoRecusa)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         MotivoRecusa motivoRecusa = PropostaService.GetInstance().ObtemMotivoRecusa(int.Parse(id));
         SetCrossPageData("MotivoRecusa", motivoRecusa);
         Response.Redirect("/Configuracoes/EditarMotivoRecusa.aspx?Comando=Editar", false);
      }

      private void CarregarMotivosRecusa()
      {
         try
         {
            MotivosRecusaRepeater.DataSource = PropostaService.GetInstance().ListarMotivosRecusa().OrderBy(c => c.Id).ToList();
            MotivosRecusaRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Motivos de Recusa"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarMotivoRecusa.aspx?Comando=Novo", false);
      }
   }
}