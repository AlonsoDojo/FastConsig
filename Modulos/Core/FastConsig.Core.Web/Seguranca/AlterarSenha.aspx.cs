using FastConsig.Common.Helpers;
using FastConsig.Core.Model;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Model;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class AlterarSenha : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         if (!IsPostBack)
         {
            AddMessage<AlterarSenhaModel>("AlterarSenhaModel", new AlterarSenhaModel());
            DataBind();
         }
      }

      protected void cmdAlterarSenha_Click(object sender, EventArgs e)
      {
         DataUnbind();
         var usuario = Contexto.GetUserData<Usuario>();
         var senha = GetMessage<AlterarSenhaModel>("AlterarSenhaModel");

         if (usuario.TipoAutenticacao == 1)
         {
            ShowMessage(TipoMensagem.Erro, "Não é possível realizar a alteração de senha por esta funcionalidade. Entre em contato com o suporte");
            return;
         }

         if (usuario.Senha != CryptoHelper.GenerateHashPassword(txtSenhaAtual.Text))
         {
            ShowMessage(TipoMensagem.Erro, "Senha Anterior não Confere...");
            return;
         }

         if (txtNovaSenha.Text != txtConfirmacaoSenha.Text)
         {
            ShowMessage(TipoMensagem.Erro, "As Senhas não conferem...");
            return;
         }

         usuario.Senha = CryptoHelper.GenerateHashPassword(txtNovaSenha.Text);

         UsuarioService.GetInstance().AlterarUsuario(usuario);

         ShowMessage(TipoMensagem.Aviso, "Senha Alterada com Sucesso...");
      }
   }
}