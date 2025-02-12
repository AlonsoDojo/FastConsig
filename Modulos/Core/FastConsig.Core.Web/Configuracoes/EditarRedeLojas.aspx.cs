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
   public partial class EditarRedeLojas : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarRedeLojas.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Promotoras>(PropostaService.GetInstance().ListarPromotoras().OrderBy(x => x.Nome).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               RedeLoja redeLoja = GetCrossPageData<RedeLoja>("RedeLoja");
               Editar(redeLoja.Id);
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

         RedeLoja redeLoja = GetMessage<RedeLoja>("RedeLoja");

         PropostaService.GetInstance().SalvarRedeLojas(redeLoja);

         this.AddMessage<RedeLoja>(redeLoja);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         RedeLoja redeLoja = GetMessage<RedeLoja>("RedeLoja");

         PropostaService.GetInstance().ExcluirRedeLojas(redeLoja.Id);

         this.AddMessage<RedeLoja>(redeLoja);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarRedeLojas.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarRedeLojas.aspx", false);
      }

      private void Novo()
      {
         RedeLoja redeLoja = new RedeLoja();
         this.AddMessage<RedeLoja>(redeLoja);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            RedeLoja redeLoja = PropostaService.GetInstance().ObtemRedeLojas(id);

            this.AddMessage<RedeLoja>(redeLoja);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Rede de Lojas"));
         }
      }
   }
}