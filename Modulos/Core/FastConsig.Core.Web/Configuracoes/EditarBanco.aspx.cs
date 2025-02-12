using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarBanco : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarBancos.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Bancos bancos = GetCrossPageData<Bancos>("Bancos");
               Editar(bancos.Banco);
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

         Bancos bancos = GetMessage<Bancos>("Bancos");

         PropostaService.GetInstance().SalvarBanco(bancos);

         this.AddMessage<Bancos>(bancos);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Bancos bancos = GetMessage<Bancos>("Bancos");

         PropostaService.GetInstance().ExcluirBanco(bancos.Banco);

         this.AddMessage<Bancos>(bancos);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarBancos.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarBancos.aspx", false);
      }

      private void Novo()
      {
         Bancos bancos = new Bancos();
         this.AddMessage<Bancos>(bancos);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(string id)
      {
         try
         {
            Bancos bancos = PropostaService.GetInstance().ObtemBanco(id);

            this.AddMessage<Bancos>(bancos);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Banco"));
         }
      }
   }
}