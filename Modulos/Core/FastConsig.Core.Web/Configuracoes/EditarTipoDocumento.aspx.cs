using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarTipoDocumento : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarTipoDocumento.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               TipoDocumento tipoDocumento = GetCrossPageData<TipoDocumento>("TipoDocumento");
               Editar(tipoDocumento.Id);
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

         TipoDocumento tipoDocumento = GetMessage<TipoDocumento>("TipoDocumento");

         PropostaService.GetInstance().SalvarTiposDocumento(tipoDocumento);

         this.AddMessage<TipoDocumento>(tipoDocumento);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         TipoDocumento tipoDocumento = GetMessage<TipoDocumento>("TipoDocumento");

         PropostaService.GetInstance().ExcluirTiposDocumento(tipoDocumento.Id);

         this.AddMessage<TipoDocumento>(tipoDocumento);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarTipoDocumento.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarTipoDocumento.aspx", false);
      }

      private void Novo()
      {
         TipoDocumento tipoDocumento = new TipoDocumento();
         this.AddMessage<TipoDocumento>(tipoDocumento);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            TipoDocumento tipoDocumento = PropostaService.GetInstance().ObtemTiposDocumento(id);

            this.AddMessage<TipoDocumento>(tipoDocumento);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Tipo de Documento"));
         }
      }
   }
}