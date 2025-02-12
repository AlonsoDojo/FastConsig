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
using FastConsig.Comunicado.Services;
using FastConsig.Comunicado.Entity;
using FastConsig.Seguranca.Entity;

namespace FastConsig.Core.Web.Comunicado
{
   public partial class VisualizarComunicados : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarComunicados();
      }

      private void CarregarComunicados()
      {
         try
         {
            ComunicadosRepeater.DataSource = ComunicadoService.GetInstance().ListarComunicados().OrderBy(c => c.Id).ToList()?.Where(x => x.DataVigenciaInicial <= DateTime.Parse(DateTime.Now.ToString("d")))?.Where(x => x.DataVigenciaFinal >= DateTime.Parse(DateTime.Now.ToString("d")))?.OrderByDescending(x => x.DataVigenciaInicial).Where(X => X.Publicado).ToList();
            ComunicadosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Comunicados"));
         }
      }

      protected void ComunicadosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Comunicados)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkVisualizar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblTitulo")).Text = o.Titulo;
            ((CustomLabel)e.Item.FindControl("lblStatus")).Text = o.DescricaoStatus;
         }
      }

      protected void lnkVisualizar_Click(object sender, EventArgs e)
      {
         int id = int.Parse(((LinkButton)sender).CommandArgument);
         Comunicados comunicados = ComunicadoService.GetInstance().ObtemComunicado(id);
         SetCrossPageData("Comunicados", comunicados);
         Response.Redirect("/Comunicado/PreviewComunicado.aspx?Comando=Visualizar", false);
      }
   }
}