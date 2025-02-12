using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
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

namespace FastConsig.Core.Web.Seguranca
{
   public partial class Parametros : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarParametros();
      }

      protected void ParametrosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            Configuracao o = (Configuracao)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Chave;
            ((CustomLabel)e.Item.FindControl("lblChave")).Text = o.Chave;
            ((CustomLabel)e.Item.FindControl("lblValor")).Text = o.Conteudo;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Configuracao configuracao = ConfiguracaoService.GetInstance().Obter(id);
         SetCrossPageData("Configuracao", configuracao);
         Response.Redirect("/Seguranca/EditarParametro.aspx?Comando=Editar", false);
      }

      private void CarregarParametros()
      {
         try
         {
            ParametrosRepeater.DataSource = ConfiguracaoService.GetInstance().Listar().OrderBy(x => x.Chave).ToList();
            ParametrosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Parâmetros"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/EditarParametro.aspx?Comando=Novo", false);
      }
   }
}