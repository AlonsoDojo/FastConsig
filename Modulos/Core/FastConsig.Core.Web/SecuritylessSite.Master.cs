using System;
using System.Text;
using System.Web.UI;

using Framework.Web.UI;

namespace FastConsig.Core.Web
{
   public partial class SecuritylessSite : MasterPage, IPostBackEventHandler
   {

      protected override void OnInit(EventArgs e)
      {
         base.OnInit(e);

         if (this.Parent is CustomPageBase)
         {
            CustomPageBase page = (CustomPageBase)this.Parent;
            page.DisplayMessage += new CustomPageBase.DisplayMessageDelegate(page_DisplayMessage);
         }

         Page.EnableEventValidation = false;
      }

      /// <summary>
      /// Registra o script para fazer o scroll para cima na página de cadadtro.
      /// </summary>
      private void RegisterScrollUp()
      {
         ScriptManager.RegisterStartupScript(UpdatePanelMenu, UpdatePanelMenu.GetType(), "jsFunctionScrollUp", "ScrollUp();", true);
      }

      public void RegisterStartupScript(string name, string scriptCode)
      {
         ScriptManager.RegisterStartupScript(UpdatePanelMenu, UpdatePanelMenu.GetType(), name, scriptCode, true);
      }


      void page_DisplayMessage(TipoMensagem tipo, string mensagem)
      {
         var sbMensagem = new StringBuilder();

         string css = "alert_green";

         if (mensagem.Contains("Cannot open database"))
         {
            mensagem = "Sistema temporáriamente indisponível. Tente novamente mais tarde.";
            tipo = TipoMensagem.Alerta;
         }

         switch (tipo)
         {
            case TipoMensagem.Erro:
               css = "alert alert-danger alert-dismissible fade show";
               break;
            case TipoMensagem.Alerta:
               css = "alert alert-warning alert-dismissible fade show";
               break;
            case TipoMensagem.Aviso:
               css = "alert alert-success alert-dismissible fade show";
               break;
         }

         sbMensagem.AppendFormat("<div class=\"{0}\" role=\"alert\">\r\n", css);
         sbMensagem.Append(mensagem);
         sbMensagem.Append("   <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Fechar\"></button>");
         sbMensagem.AppendLine("</div>");
         phMensagem.Controls.Clear();
         phMensagem.Controls.Add(new LiteralControl(sbMensagem.ToString()));
         phMensagem.Focus();

         RegisterScrollUp();
      }

      #region IPostBackEventHandler Members

      void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
      {
         Response.Redirect(eventArgument);
      }

      #endregion
   }
}