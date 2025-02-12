using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarOcorrencia : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarOcorrencias.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Ocorrencias ocorrencias = GetCrossPageData<Ocorrencias>("Ocorrencias");
               Editar(ocorrencias.Id);
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

         Ocorrencias ocorrencias = GetMessage<Ocorrencias>("Ocorrencias");

         PropostaService.GetInstance().SalvarOcorrencia(ocorrencias);

         this.AddMessage<Ocorrencias>(ocorrencias);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Ocorrencias ocorrencias = GetMessage<Ocorrencias>("Ocorrencias");

         PropostaService.GetInstance().ExcluirOcorrencia(ocorrencias.Id);

         this.AddMessage<Ocorrencias>(ocorrencias);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarOcorrencias.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarOcorrencias.aspx", false);
      }

      private void Novo()
      {
         Ocorrencias ocorrencias = new Ocorrencias();
         this.AddMessage<Ocorrencias>(ocorrencias);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Ocorrencias ocorrencias = PropostaService.GetInstance().ObtemOcorrencia(id);

            btnExcluir.Visible = (ocorrencias.Sistema ? false : true);

            this.AddMessage<Ocorrencias>(ocorrencias);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Ocorrência"));
         }
      }
   }
}