using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;
using System.Linq;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarOcorrenciaSIAPE : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarOcorrenciasSIAPE.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Ocorrencias>(PropostaService.GetInstance().ListarOcorrencias().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<OcorrenciasConsignadoAcao>(PropostaService.GetInstance().ListarOcorrenciasConsignadoAcao().OrderBy(x => x.Descricao).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               OcorrenciasSIAPE ocorrenciasSIAPE = GetCrossPageData<OcorrenciasSIAPE>("OcorrenciasSIAPE");
               Editar(ocorrenciasSIAPE.Id);
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

         OcorrenciasSIAPE ocorrenciasSIAPE = GetMessage<OcorrenciasSIAPE>("OcorrenciasSIAPE");

         PropostaService.GetInstance().SalvarOcorrenciaSIAPE(ocorrenciasSIAPE);

         this.AddMessage<OcorrenciasSIAPE>(ocorrenciasSIAPE);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         OcorrenciasSIAPE ocorrenciasSIAPE = GetMessage<OcorrenciasSIAPE>("OcorrenciasSIAPE");

         PropostaService.GetInstance().ExcluirOcorrenciaSIAPE(ocorrenciasSIAPE.Id);

         this.AddMessage<OcorrenciasSIAPE>(ocorrenciasSIAPE);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarOcorrenciasSIAPE.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarOcorrenciasSIAPE.aspx", false);
      }

      private void Novo()
      {
         OcorrenciasSIAPE ocorrenciasSIAPE = new OcorrenciasSIAPE();
         this.AddMessage<OcorrenciasSIAPE>(ocorrenciasSIAPE);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            OcorrenciasSIAPE ocorrenciasSIAPE = PropostaService.GetInstance().ObtemOcorrenciaSIAPE(id);

            this.AddMessage<OcorrenciasSIAPE>(ocorrenciasSIAPE);

            this.DataBind();
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Ocorrência SIAPE"));
         }
      }
   }
}