using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;
using System.Linq;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class EditarDominio : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("Dominios.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<TipoAutenticacao>(SegurancaService.GetInstance().ListarTipoAutenticacao().OrderBy(x => x.Descricao).ToList());

            if (Request.Params["Comando"] == "Editar")
            {
               Dominio dominio = GetCrossPageData<Dominio>("Dominio");
               Editar(dominio.Id);
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

         Dominio dominio = GetMessage<Dominio>("Dominio");

         SegurancaService.GetInstance().SalvarDominio(dominio);

         this.AddMessage<Dominio>(dominio);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Dominio dominio = GetMessage<Dominio>("Dominio");

         SegurancaService.GetInstance().ExcluirDominio(dominio.Id);

         this.AddMessage<Dominio>(dominio);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Seguranca/Dominios.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/Dominios.aspx", false);
      }

      private void Novo()
      {
         Dominio dominio = new Dominio();
         this.AddMessage<Dominio>(dominio);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Dominio dominio = SegurancaService.GetInstance().ObtemDominio(id);

            this.AddMessage<Dominio>(dominio);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Dominio"));
         }
      }
   }
}