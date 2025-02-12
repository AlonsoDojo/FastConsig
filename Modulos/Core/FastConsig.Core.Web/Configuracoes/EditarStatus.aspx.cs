using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarStatus : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarStatus.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Status fases = GetCrossPageData<Status>("Status");
               Editar(fases.Id);
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

         Status status = GetMessage<Status>("Status");

         PropostaService.GetInstance().SalvarStatus(status);

         this.AddMessage<Status>(status);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Status status = GetMessage<Status>("Status");

         PropostaService.GetInstance().ExcluirStatus(status.Id);

         this.AddMessage<Status>(status);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarStatus.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarStatus.aspx", false);
      }

      private void Novo()
      {
         Status status = new Status();
         this.AddMessage<Status>(status);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Status Status = PropostaService.GetInstance().ObtemStatus(id);

            this.AddMessage<Status>(Status);

            if (Status.Sistema)
            {
               btnExcluir.Visible = false;
            }

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Status"));
         }
      }
   }
}