using FastConsig.Common.Loggin;
using FastConsig.Core.Web.Helpers;
using FastConsig.Scheduler.Entity;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using FastConsig.Scheduler.Services;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class ListarTarefas : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarTarefas();
      }

      protected void TarefasRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Tarefa)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDescricao")).Text = o.Nome;
         }
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         string id = ((LinkButton)sender).CommandArgument;
         Tarefa tarefa = SchedulerService.GetInstance().ObtemTarefa(int.Parse(id));
         SetCrossPageData("Tarefa", tarefa);
         Response.Redirect("/Configuracoes/EditarTarefa.aspx?Comando=Editar", false);
      }

      private void CarregarTarefas()
      {
         try
         {
            TarefasRepeater.DataSource = SchedulerService.GetInstance().ListarTarefasRecorrentes().OrderBy(c => c.Id).ToList();
            TarefasRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Tarefas"));
         }
      }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
         Response.Redirect("/Configuracoes/EditarTarefa.aspx?Comando=Novo", false);
      }
    }
}