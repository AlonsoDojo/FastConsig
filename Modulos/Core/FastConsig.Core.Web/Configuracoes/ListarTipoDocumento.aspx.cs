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
   public partial class ListarTipoDocumento : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarTipoDocumento();
      }

      protected void TipoDocumentoRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (TipoDocumento)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         TipoDocumento tipoDocumento = PropostaService.GetInstance().ObtemTiposDocumento(int.Parse(id));
         SetCrossPageData("TipoDocumento", tipoDocumento);
         Response.Redirect("/Configuracoes/EditarTipoDocumento.aspx?Comando=Editar", false);
      }

      private void CarregarTipoDocumento()
      {
         try
         {
            TipoDocumentoRepeater.DataSource = PropostaService.GetInstance().ListarTiposDocumento().OrderBy(c => c.Descricao).ToList();
            TipoDocumentoRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Tipo de Documento"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarTipoDocumento.aspx?Comando=Novo", false);
      }
   }
}