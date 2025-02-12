using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarGerente : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarGerentes.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Gerentes gerentes = GetCrossPageData<Gerentes>("Gerentes");
               Editar(gerentes.Id);
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

         Gerentes gerentes = GetMessage<Gerentes>("Gerentes");

         PropostaService.GetInstance().SalvarGerente(gerentes);

         this.AddMessage<Gerentes>(gerentes);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Gerentes gerentes = GetMessage<Gerentes>("Gerentes");

         PropostaService.GetInstance().ExcluirGerente(gerentes.Id);

         this.AddMessage<Gerentes>(gerentes);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarGerentes.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarGerentes.aspx", false);
      }

      private void Novo()
      {
         Gerentes gerentes = new Gerentes();
         this.AddMessage<Gerentes>(gerentes);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Gerentes gerentes = PropostaService.GetInstance().ObtemGerente(id);

            this.AddMessage<Gerentes>(gerentes);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Gerente"));
         }
      }
   }
}