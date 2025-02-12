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
   public partial class ListarGerentes : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarGerentes();
      }

      protected void GerentesRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Gerentes)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Nome;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Gerentes gerentes = PropostaService.GetInstance().ObtemGerente(int.Parse(id));
         SetCrossPageData("Gerentes", gerentes);
         Response.Redirect("/Configuracoes/EditarGerente.aspx?Comando=Editar", false);
      }

      private void CarregarGerentes()
      {
         try
         {
            GerentesRepeater.DataSource = PropostaService.GetInstance().ListarGerente().OrderBy(c => c.Id).ToList();
            GerentesRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Gerentes"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/EditarGerente.aspx?Comando=Novo", false);
      }
   }
}