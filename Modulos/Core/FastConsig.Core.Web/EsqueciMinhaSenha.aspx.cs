using System;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;

namespace FastConsig.Core.Web
{
   public partial class EsqueciMinhaSenha : CustomPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {

         }
      }

      protected void btnEnviar_Click(object sender, EventArgs e)
      {
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

         var loginParts = login.Split('\\');
         if (loginParts.Length != 2)
         {
            ShowMessage(TipoMensagem.Alerta, MensagemTexto.MsgLoginFormatoInvalido);
            return;
         }

         var usuario = SegurancaService.GetInstance().BuscarUsuario(login);

         if (usuario == null)
         {
            ShowMessage(TipoMensagem.Alerta, "Usuário ou Senha Inválidos");
            return;
         }

         if (usuario.TipoAutenticacao == 1)
         {
            ShowMessage(TipoMensagem.Alerta, "Operação não Permitida. Entre em Contato com o Suporte.");
            return;
         }

         //var novaSenha = new CryptoBusiness().RandomPasswordNoEspcial(8, 10);

         //usuario.Senha = CryptoBusiness.GenerateHashPassword(novaSenha);
         //usuario.DataUltimaTrocaSenha = DateTime.Now;

         //UsuarioServices.GetInstance().Alterar(usuario);

         //string msgRetorno = "";

         //if (usuario.Celular!=null)
         //{
         //   IAgenteServices.GetInstance().EnviarMensagem(Common.Helpers.UtilityHelper.ExtractNumber(usuario.Celular), "Sua nova senha de acesso ao sistema Credit Manager e " + novaSenha);
         //   msgRetorno = "Nova Senha Enviada via SMS para o Celular (**) *****-*" + usuario.Celular.Right(3);
         //}


         //var xpto = new Dictionary<string, object> { };
         //xpto.Add("{{email.to}}", usuario.Email);
         //xpto.Add("{{pessoa.nome}}", usuario.Nome);

         //EnviarNotificacao(new MailConfig { EmailFrom = ConfiguracaoService.GetInstance().Config<string>("creditmanager.mail.from"), SmtpServer = ConfiguracaoService.GetInstance().Obter("STMP_SERVER").Conteudo }, xpto, "Recuperação de Senha", "Sua nova senha de acesso ao sistema Credit Manager é " + novaSenha);

         //if(msgRetorno=="")
         //{
         //   msgRetorno = "Nova Senha Enviada para o e-mail " + Common.Helpers.UtilityHelper.hideEmail(usuario.Email);
         //} else
         //{
         //   msgRetorno += " e para o e-mail " + Common.Helpers.UtilityHelper.hideEmail(usuario.Email);
         //}

         //ShowMessage(TipoMensagem.Aviso, msgRetorno);

         //ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS", "setTimeout(function() { window.location.replace('Login.aspx') }, 5000);", true);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("Login.aspx", false);
      }

      //private static void EnviarNotificacao(MailConfig config, Dictionary<string, object> parametros, string subject, string mensagem)
      //{
      //   ////Pendente alguma coisa de parâmetros?
      //   //if (config == null)
      //   //   return;

      //   //// Obtém o template para este email...
      //   //var template = new FastConsig.Helpers.TemplateContent();
      //   //template.BodyContent = mensagem;


      //   ////Envia o email para o(s) usuário(s)...            
      //   //string destinatario = string.Empty;

      //   //if (parametros.ContainsKey("{{email.to}}"))
      //   //   destinatario = parametros["{{email.to}}"]?.ToString();
      //   ////destinatario = destinatario.IsValidEmail() ? destinatario : null;

      //   //string copiaPara = null;
      //   //if (parametros.ContainsKey("{{email.bcc}}"))
      //   //   copiaPara = parametros["{{email.bcc}}"]?.ToString();

      //   ////Envia o e-mail como "Background Thread"...
      //   ////MailHelper.SendMail(config, destinatario, copiaPara, subject, template);
      //   //Task.Run(() => FastConsig.Helpers.MailHelper.SendMail(config, destinatario, copiaPara, subject, template));
      //}
   }
}