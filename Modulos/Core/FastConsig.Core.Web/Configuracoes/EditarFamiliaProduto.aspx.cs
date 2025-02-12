using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarFamiliaProduto : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarFamiliaProdutos.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               FamiliaProduto familiaProduto = GetCrossPageData<FamiliaProduto>("FamiliaProduto");
               Editar(familiaProduto.Id);
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

         FamiliaProduto familiaProduto = GetMessage<FamiliaProduto>("FamiliaProduto");

         PropostaService.GetInstance().SalvarFamiliaProdutos(familiaProduto);

         this.AddMessage<FamiliaProduto>(familiaProduto);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         FamiliaProduto familiaProduto = GetMessage<FamiliaProduto>("FamiliaProduto");

         PropostaService.GetInstance().ExcluirFamiliaProduto(familiaProduto.Id);

         this.AddMessage<FamiliaProduto>(familiaProduto);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarFamiliaProdutos.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarFamiliaProdutos.aspx", false);
      }

      private void Novo()
      {
         FamiliaProduto familiaProduto = new FamiliaProduto();
         this.AddMessage<FamiliaProduto>(familiaProduto);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            FamiliaProduto familiaProduto = PropostaService.GetInstance().ObtemFamiliaProduto(id);

            this.AddMessage<FamiliaProduto>(familiaProduto);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Familia de Produto"));
         }
      }
   }
}