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
   public partial class EditarLoja : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarLojas.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<RedeLoja>(PropostaService.GetInstance().ListarRedeLoja().OrderBy(x => x.Nome).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               Lojas lojas = GetCrossPageData<Lojas>("Lojas");
               Editar(lojas.Id);
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

         Lojas lojas = GetMessage<Lojas>("Lojas");

         PropostaService.GetInstance().SalvarLoja(lojas);

         this.AddMessage<Lojas>(lojas);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Lojas lojas = GetMessage<Lojas>("Lojas");

         PropostaService.GetInstance().ExcluirLoja(lojas.Id);

         this.AddMessage<Lojas>(lojas);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarLojas.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarLojas.aspx", false);
      }

      private void Novo()
      {
         Lojas lojas = new Lojas();
         this.AddMessage<Lojas>(lojas);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Lojas lojas = PropostaService.GetInstance().ObtemLoja(id);

            this.AddMessage<Lojas>(lojas);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Loja"));
         }
      }
   }
}