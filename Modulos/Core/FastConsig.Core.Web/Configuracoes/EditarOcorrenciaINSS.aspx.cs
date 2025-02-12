using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;
using System.Linq;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarOcorrenciaINSS : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarOcorrenciasINSS.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Ocorrencias>(PropostaService.GetInstance().ListarOcorrencias().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<OcorrenciasConsignadoAcao>(PropostaService.GetInstance().ListarOcorrenciasConsignadoAcao().OrderBy(x => x.Descricao).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               OcorrenciasINSS ocorrenciasINSS = GetCrossPageData<OcorrenciasINSS>("OcorrenciasINSS");
               Editar(ocorrenciasINSS.Id);
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

         OcorrenciasINSS ocorrenciasINSS = GetMessage<OcorrenciasINSS>("OcorrenciasINSS");

         PropostaService.GetInstance().SalvarOcorrenciaINSS(ocorrenciasINSS);

         this.AddMessage<OcorrenciasINSS>(ocorrenciasINSS);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         OcorrenciasINSS ocorrenciasINSS = GetMessage<OcorrenciasINSS>("OcorrenciasINSS");

         PropostaService.GetInstance().ExcluirOcorrenciaINSS(ocorrenciasINSS.Id);

         this.AddMessage<OcorrenciasINSS>(ocorrenciasINSS);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarOcorrenciasINSS.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarOcorrenciasINSS.aspx", false);
      }

      private void Novo()
      {
         OcorrenciasINSS ocorrenciasINSS = new OcorrenciasINSS();
         this.AddMessage<OcorrenciasINSS>(ocorrenciasINSS);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            OcorrenciasINSS ocorrenciasINSS = PropostaService.GetInstance().ObtemOcorrenciaINSS(id);

            this.AddMessage<OcorrenciasINSS>(ocorrenciasINSS);

            this.DataBind();
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Ocorrência INSS"));
         }
      }
   }
}