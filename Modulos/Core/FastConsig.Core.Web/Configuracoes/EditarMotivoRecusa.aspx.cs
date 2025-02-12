using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarMotivoRecusa : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarMotivosRecusa.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               MotivoRecusa motivoRecusa = GetCrossPageData<MotivoRecusa>("MotivoRecusa");
               Editar(motivoRecusa.Id);
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

         MotivoRecusa motivoRecusa = GetMessage<MotivoRecusa>("MotivoRecusa");

         PropostaService.GetInstance().SalvarMotivoRecusa(motivoRecusa);

         this.AddMessage<MotivoRecusa>(motivoRecusa);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         MotivoRecusa motivoRecusa = GetMessage<MotivoRecusa>("MotivoRecusa");

         PropostaService.GetInstance().ExcluirMotivoRecusa(motivoRecusa.Id);

         this.AddMessage<MotivoRecusa>(motivoRecusa);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarMotivosRecusa.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarMotivosRecusa.aspx", false);
      }

      private void Novo()
      {
         MotivoRecusa motivoRecusa = new MotivoRecusa();
         this.AddMessage<MotivoRecusa>(motivoRecusa);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            MotivoRecusa motivoRecusa = PropostaService.GetInstance().ObtemMotivoRecusa(id);

            this.AddMessage<MotivoRecusa>(motivoRecusa);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Motivos de Recusa"));
         }
      }
   }
}