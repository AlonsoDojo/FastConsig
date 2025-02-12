using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Scheduler.Entity;
using FastConsig.Scheduler.Services;
using Framework.Web.UI;
using System;
using System.Linq;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarPromotora : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarPromotoras.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Gerentes>(PropostaService.GetInstance().ListarGerente().OrderBy(x => x.Nome).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               Promotoras promotoras = GetCrossPageData<Promotoras>("Promotoras");
               Editar(promotoras.Id);
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

         Promotoras promotoras = GetMessage<Promotoras>("Promotoras");

         PropostaService.GetInstance().SalvarPromotora(promotoras);

         this.AddMessage<Promotoras>(promotoras);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Promotoras promotoras = GetMessage<Promotoras>("Promotoras");

         PropostaService.GetInstance().ExcluirPromotora(promotoras.Id);

         this.AddMessage<Promotoras>(promotoras);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarPromotoras.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarPromotoras.aspx", false);
      }

      private void Novo()
      {
         Promotoras promotoras = new Promotoras();
         this.AddMessage<Promotoras>(promotoras);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Promotoras promotoras = PropostaService.GetInstance().ObtemPromotora(id);

            this.AddMessage<Promotoras>(promotoras);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Promotora"));
         }
      }
   }
}