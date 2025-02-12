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
   public partial class ListarOcorrenciasINSS : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarOcorrenciasINSS();
      }

      protected void OcorrenciasINSSRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (OcorrenciasINSS)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblCodigo")).Text = o.Codigo;
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         OcorrenciasINSS ocorrenciasINSS = PropostaService.GetInstance().ObtemOcorrenciaINSS(int.Parse(id));
         SetCrossPageData("OcorrenciasINSS", ocorrenciasINSS);
         Response.Redirect("/Configuracoes/EditarOcorrenciaINSS.aspx?Comando=Editar", false);
      }

      private void CarregarOcorrenciasINSS()
      {
         try
         {
            OcorrenciasINSSRepeater.DataSource = PropostaService.GetInstance().ListarOcorrenciasINSS().OrderBy(c => c.Id).ToList();
            OcorrenciasINSSRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Ocorrencias do INSS"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarOcorrenciaINSS.aspx?Comando=Novo", false);
      }
   }
}