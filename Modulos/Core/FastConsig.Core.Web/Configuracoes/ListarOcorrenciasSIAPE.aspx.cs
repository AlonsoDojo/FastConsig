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
   public partial class ListarOcorrenciasSIAPE : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarOcorrenciasSIAPE();
      }

      protected void OcorrenciasSIAPERepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (OcorrenciasSIAPE)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblCodigo")).Text = o.Codigo;
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         OcorrenciasSIAPE ocorrenciasSIAPE = PropostaService.GetInstance().ObtemOcorrenciaSIAPE(int.Parse(id));
         SetCrossPageData("OcorrenciasSIAPE", ocorrenciasSIAPE);
         Response.Redirect("/Configuracoes/EditarOcorrenciaSIAPE.aspx?Comando=Editar", false);
      }

      private void CarregarOcorrenciasSIAPE()
      {
         try
         {
            OcorrenciasSIAPERepeater.DataSource = PropostaService.GetInstance().ListarOcorrenciasSIAPE().OrderBy(c => c.Id).ToList();
            OcorrenciasSIAPERepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Ocorrências do SIAPE"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarOcorrenciaSIAPE.aspx?Comando=Novo", false);
      }
   }
}