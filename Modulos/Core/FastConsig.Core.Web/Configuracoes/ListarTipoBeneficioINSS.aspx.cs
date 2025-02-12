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
   public partial class ListarTipoBeneficioINSS : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarTipoBeneficioINSS();
      }

      protected void TipoBeneficioINSSRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (TipoBeneficioINSS)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblCodigo")).Text = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Descricao;
            ((CustomLabel)e.Item.FindControl("lblUtilizacao")).Text = o.Utilizacao;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         TipoBeneficioINSS tipoBeneficioINSS = PropostaService.GetInstance().ObtemTipoBeneficioINSS(int.Parse(id));
         SetCrossPageData("TipoBeneficioINSS", tipoBeneficioINSS);
         Response.Redirect("/Configuracoes/EditarTipoBeneficioINSS.aspx?Comando=Editar", false);
      }

      private void CarregarTipoBeneficioINSS()
      {
         try
         {
            TipoBeneficioINSSRepeater.DataSource = PropostaService.GetInstance().ListarTipoBeneficioINSS().OrderBy(c => c.Id).ToList();
            TipoBeneficioINSSRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Tipo de Beneficio INSS"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarTipoBeneficioINSS.aspx?Comando=Novo", false);
      }
   }
}