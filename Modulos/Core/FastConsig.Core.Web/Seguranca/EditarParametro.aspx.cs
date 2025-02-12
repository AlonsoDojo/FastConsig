using FastConsig.Common.Services;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class EditarParametro : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("Parametros.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Configuracao configuracao = GetCrossPageData<Configuracao>("Configuracao");
               Editar(configuracao.Chave);
               txtCodigo.Enabled = false;
            }
            else if (Request.Params["Comando"] == "Novo")
            {
               Novo();
            }
         }
      }

      protected void btnSalvar_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Configuracao configuracao = GetMessage<Configuracao>("Configuracao");

         ConfiguracaoService.GetInstance().Salvar(configuracao);

         this.AddMessage<Configuracao>(configuracao);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Configuracao configuracao = GetMessage<Configuracao>("Configuracao");

         ConfiguracaoService.GetInstance().Excluir(configuracao.Chave);

         this.AddMessage<Configuracao>(configuracao);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Seguranca/Parametros.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/Parametros.aspx", false);
      }

      private void Novo()
      {
         Configuracao configuracao = new Configuracao();
         this.AddMessage<Configuracao>(configuracao);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(string id)
      {
         try
         {
            Configuracao configuracao = ConfiguracaoService.GetInstance().Obter(id);

            this.AddMessage<Configuracao>(configuracao);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Configuração"));
         }
      }
   }
}