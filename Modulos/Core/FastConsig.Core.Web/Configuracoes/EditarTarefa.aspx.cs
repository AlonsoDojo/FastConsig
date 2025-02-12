using CronExpressionDescriptor;
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
   public partial class EditarTarefa : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarTarefas.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Fila>(SchedulerService.GetInstance().ListarFila().OrderBy(x => x.Nome).ToList());
            AddMessageCollection<TipoAgenda>(SchedulerService.GetInstance().ListarTipoAgenda().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<TipoTarefa>(SchedulerService.GetInstance().ListarTipoTarefa().OrderBy(x => x.Descricao).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               Tarefa tarefa = GetCrossPageData<Tarefa>("Tarefa");
               Editar(tarefa.Id);
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

         Tarefa tarefa = GetMessage<Tarefa>("Tarefa");

         SchedulerService.GetInstance().SalvarTarefa(tarefa);

         this.AddMessage<Tarefa>(tarefa);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Tarefa tarefa = GetMessage<Tarefa>("Tarefa");

         SchedulerService.GetInstance().ExcluirTarefa(tarefa.Id);

         this.AddMessage<Tarefa>(tarefa);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarTarefas.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarTarefas.aspx", false);
      }

      private void Novo()
      {
         Tarefa tarefa = new Tarefa();
         this.AddMessage<Tarefa>(tarefa);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Tarefa tarefa = SchedulerService.GetInstance().ObtemTarefa(id);

            this.AddMessage<Tarefa>(tarefa);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Tarefa"));
         }
      }

        protected void txtAgenda_TextChanged(object sender, EventArgs e)
        {
         DataUnbind();
         Tarefa tarefa = GetMessage<Tarefa>("Tarefa");
         txtDescricaoAgenda.InnerText = ExpressionDescriptor.GetDescription(tarefa.Agenda, new Options() { Locale = "pt-BR" });
      }
    }
}