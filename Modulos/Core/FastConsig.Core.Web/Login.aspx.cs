using FastConsig.Common.Helpers;
using FastConsig.Common.Loggin;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Security;
using FastConsig.Core.Web.Helpers;


using Extensions = FastConsig.Common.Helpers.Extensions;
using UtilityHelper = FastConsig.Common.Helpers.UtilityHelper;

namespace FastConsig.Core.Web
{
   public partial class Login : CustomPageBase
   {
      protected void Page_Init(object Sender, EventArgs e)
      {
         base.OnPreInit(e);

         Response.Buffer = true;
         Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
         Response.Expires = -1500;
         Response.CacheControl = "no-cache";
      }

      protected override void OnPreRender(EventArgs e)
      {
         base.OnPreRender(e);

         string disabledScript = "<script language=\"javascript\">\r\nwindow.history.forward(1);\r\n</script>";
         ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", disabledScript);
      }

      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            ////LogServices.GetInstance().SetApplication(WebUtilityHelper.NOME_SISTEMA);
            ////LogServices.GetInstance().SetApplicationGuid(WebUtilityHelper.GUID_SISTEMA);
            ////LogServices.GetInstance().SetApplicationLogName(WebUtilityHelper.LOG_NAME);
            ////LogServices.GetInstance().SetApplicationEnvironment(ConfigurationManager.AppSettings["Environment"]);

            //// desabiliando controles de acordo com o request
            //divLogin.Visible = !Request.Url.Query.Contains("INSS");
            //divDemostrativoConsignado.Visible = !divLogin.Visible;

            //try
            //{
            //   AddMessageCollection(SegurancaServices.GetInstance().ListarDominiosAtivos(), "Dominio");
            //   DataBind();
            //}
            //catch (Exception ex)
            //{
            //   if (ex.Message.Contains("Cannot open database"))
            //   {
            //      LogServices.GetInstance().GravarLogErro(ex, "Falha na Conexão com o Banco de Dados");
            //      ShowMessage(TipoMensagem.Aviso, "Sistema Temporáriamente Indisponível.");
            //      return;
            //   } else
            //   {
            //      LogServices.GetInstance().GravarLogErro(ex, ex.Message);
            //   }
            //}

            if (UserContext != null)
               Logout();
         }
      }

      //#region *------- Login do usuário -------*

      protected void cmdEntrar_Click(object sender, EventArgs e)
      {
         try
         {
            //   #region *------- Validação de login e senha -------*

            //   if (divDemostrativoConsignado.Visible)
            //   {
            //      if (string.IsNullOrWhiteSpace(CPF.Text.Trim()))
            //      {
            //         ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgLoginNaoInformado);
            //         return;
            //      }

            //      if (string.IsNullOrWhiteSpace(Token.Text.Trim()))
            //      {
            //         ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgLoginCodigoSegurancaNaoInformado);
            //         return;
            //      }

            //      var numeroCPF = UtilityHelper.ExtractNumber(CPF.Text.Trim());

            //      if (!UtilityHelper.IsCpf(numeroCPF))
            //      {
            //         ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgLoginCPFNaoValido);
            //         return;
            //      }

            //      //var proposta = PropostaService.GetInstance().ListarPropostasMonitor(
            //      //    new Model.FiltroMonitorModel
            //      //    {
            //      //       Proposta = int.Parse(Token.Text.Trim()),
            //      //       CpfCnpj = numeroCPF
            //      //    }).FirstOrDefault();

            //      //if (proposta == null)
            //      //   throw new NotAutorizedException("CPF/Token inválidos.", "DemostrativoINSS.aspx");

            //      //if (proposta.Status == "REJEITADA")
            //      //   throw new NotAutorizedException("CPF/Token inválidos.", "DemostrativoINSS.aspx");

            //      //var token = Extensions.Base64Encode(CryptoHelper.Encrypt(proposta.Proposta.ToString()));

            //      //Response.Redirect(String.Concat("/Concessao/DemonstrativoINSS.aspx?Token=", token), false);
            //   }

            string dominio = SegurancaService.GetInstance().ObtemDominioAtivoUsuario(txtUsuario.Text.Trim());

            bool? dominioativo = SegurancaService.GetInstance().VerificaDominioAtivo(dominio);

            if (dominioativo == null || dominioativo == false)
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgUsuarioBloqueado);
               return;
            }

            var login = string.Format(@"{0}\{1}", dominio, txtUsuario.Text.Trim());

            if (string.IsNullOrWhiteSpace(login))
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgLoginNaoInformado);
               return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text.Trim()))
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgSenhaNaoInformada);
               return;
            }

            //   #endregion

            var usuario = SegurancaService.GetInstance().Autenticar(login, txtSenha.Text);
            if (usuario == null)
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgUsuarioSenhaInvalido);
               return;
            }

            if (usuario.Bloqueado)
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgUsuarioBloqueado);
               return;
            }

            if (!usuario.Habilitado)
            {
               ShowMessage(TipoMensagem.Alerta, "Usuário não está habilitado");
               return;
            }

            if (SegurancaService.GetInstance().OnBlackList(usuario))
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgUsuarioBloqueado);
               return;
            }

            if (SegurancaService.GetInstance().IsBlocked(usuario))
            {
               ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgUsuarioBloqueado);
               return;
            }

            //Registra o login do usuário no sistema...
            SegurancaService.GetInstance().RegistrarLogin(usuario);

            //Cria a sessão do usuário para entrar no sistema...
            CriarSessaoUsuario(usuario);

            //   //#region *------- Executa rotinas de inicialização e periodicidades -------*

            //   ////Faz a limpeza de registros antigos...
            //   //try { ImpressaoService.GetInstance().ExpurgarFila(); } catch { }
            //   #endregion
         }
         catch (NotAutorizedException ex)
         {
            ShowMessage(TipoMensagem.Erro, ex.Message);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Mensagem: " + ex.Message + " - StackTrace: " + ex.StackTrace);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "validação de login"));
         }
      }

      //#endregion

      ///<summary>
      ///Cria sessão do usuário logado e chama a página default do site.
      ///</summary>
      ///<param name="usuario"></param>
      private void CriarSessaoUsuario(Usuario usuario)
      {
         //*------- Cria o contexto de usuário e informa que ele já atualizou a senha de acesso.
         Session.Clear();
         this.CreateContext(DateTime.Now.TimeOfDay.Milliseconds, usuario.Login, usuario.Nome, usuario);
         LogService.GetInstance().SetUser(usuario.Id);
         FormsAuthentication.SetAuthCookie(usuario.Nome, true);

         //if (!usuario.TermoUsuario)
         //{
         //   var masterpage = (SecuritylessSite)Master;
         //   pnlPopupTermoAceite.Visible = true;
         //   masterpage.RegisterStartupScript("ShowModalTermoAceite",
         //       string.Format("$('#{0}').modal('show');",
         //       pnlPopupTermoAceite.ClientID));
         //}
         //else
         //{
            Response.Redirect("Default.aspx", false);
         //}
      }

      /// <summary>
      /// Faz o logout do cliente, direcionando para a página de login novamente.
      /// </summary>
      private void Logout()
      {
         Session.Abandon();
         FormsAuthentication.SignOut();
      }

      protected void lnkEsqueciMinhaSenha_Click(object sender, EventArgs e) => Response.Redirect("EsqueciMinhaSenha.aspx", false);

      protected void btnAceitarTermo_Click(object sender, EventArgs e)
      {
         //var usuario = this.UserContext?.GetUserData<Usuario>();
         //usuario.TermoUsuario = true;
         //UsuarioServices.GetInstance().Alterar(usuario);

         //ComunicadoConfirmacaoLeitura confirmacaoLeitura = new ComunicadoConfirmacaoLeitura() { Usuario = usuario.Id, DataLeitura = DateTime.Now, ComunicadoId = -1 };

         //ComunicadoService.GetInstance().GravarConfirmacaoLeitura(confirmacaoLeitura);

         //Response.Redirect("Default.aspx", false);
      }

      protected void lnkEsqueciMinhaSenha_Click1(object sender, EventArgs e)
      {

      }
   }
}