using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarFase : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarFases.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Fases fases = GetCrossPageData<Fases>("Fases");
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

         Fases Fases = GetMessage<Fases>("Fases");

         PropostaService.GetInstance().SalvarFase(Fases);

         this.AddMessage<Fases>(Fases);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Fases Fases = GetMessage<Fases>("Fases");

         PropostaService.GetInstance().ExcluirFase(Fases.Id);

         this.AddMessage<Fases>(Fases);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarFases.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarFases.aspx", false);
      }

      private void Novo()
      {
         Fases Fases = new Fases();
         this.AddMessage<Fases>(Fases);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Fases Fases = PropostaService.GetInstance().ObtemFase(id);

            if (Fases.Sistema)
            {
               btnExcluir.Visible = false;
            }

            this.AddMessage<Fases>(Fases);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Fases"));
         }
      }
   }
}