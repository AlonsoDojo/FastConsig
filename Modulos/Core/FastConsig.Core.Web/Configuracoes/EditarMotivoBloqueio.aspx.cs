using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarMotivoBloqueio : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarMotivosBloqueio.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               MotivoBloqueio motivoBloqueio = GetCrossPageData<MotivoBloqueio>("MotivoBloqueio");
               Editar(motivoBloqueio.Id);
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

         MotivoBloqueio motivoBloqueio = GetMessage<MotivoBloqueio>("MotivoBloqueio");

         PropostaService.GetInstance().SalvarMotivoBloqueio(motivoBloqueio);

         this.AddMessage<MotivoBloqueio>(motivoBloqueio);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         MotivoBloqueio motivoBloqueio = GetMessage<MotivoBloqueio>("MotivoBloqueio");

         PropostaService.GetInstance().ExcluirMotivoBloqueio(motivoBloqueio.Id);

         this.AddMessage<MotivoBloqueio>(motivoBloqueio);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarMotivosBloqueio.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarMotivosBloqueio.aspx", false);
      }

      private void Novo()
      {
         MotivoBloqueio motivoBloqueio = new MotivoBloqueio();
         this.AddMessage<MotivoBloqueio>(motivoBloqueio);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            MotivoBloqueio motivoBloqueio = PropostaService.GetInstance().ObtemMotivoBloqueio(id);

            this.AddMessage<MotivoBloqueio>(motivoBloqueio);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Motivos de Bloqueio"));
         }
      }
   }
}