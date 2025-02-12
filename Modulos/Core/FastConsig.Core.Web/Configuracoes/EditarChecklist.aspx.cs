using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarChecklist : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarCheckList.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               CheckList checklist = GetCrossPageData<CheckList>("CheckList");
               Editar(checklist.Id);
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

         CheckList checklist = GetMessage<CheckList>("CheckList");

         PropostaService.GetInstance().SalvarCheckList(checklist);

         this.AddMessage<CheckList>(checklist);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         CheckList checklist = GetMessage<CheckList>("CheckList");

         PropostaService.GetInstance().ExcluirCheckList(checklist);

         this.AddMessage<CheckList>(checklist);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarChecklist.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarChecklist.aspx", false);
      }

      private void Novo()
      {
         CheckList checklist = new CheckList();
         this.AddMessage<CheckList>(checklist);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int id)
      {
         try
         {
            CheckList checklist = PropostaService.GetInstance().ObtemCheckList(id);

            this.AddMessage<CheckList>(checklist);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Checklist"));
         }
      }
   }
}