using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using System;

namespace FastConsig.Core.Web.Configuracoes
{
   public partial class EditarTipoBeneficioINSS : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarTipoBeneficioINSS.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               TipoBeneficioINSS tipoBeneficioINSS = GetCrossPageData<TipoBeneficioINSS>("TipoBeneficioINSS");
               Editar(tipoBeneficioINSS.Id);
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

         TipoBeneficioINSS tipoBeneficioINSS = GetMessage<TipoBeneficioINSS>("TipoBeneficioINSS");

         PropostaService.GetInstance().SalvarTipoBeneficioINSS(tipoBeneficioINSS);

         this.AddMessage<TipoBeneficioINSS>(tipoBeneficioINSS);

         btnExcluir.Visible = true;

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         TipoBeneficioINSS tipoBeneficioINSS = GetMessage<TipoBeneficioINSS>("TipoBeneficioINSS");

         PropostaService.GetInstance().ExcluirTipoBeneficioINSS(tipoBeneficioINSS.Id);

         this.AddMessage<TipoBeneficioINSS>(tipoBeneficioINSS);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Configuracoes/ListarTipoBeneficioINSS.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Configuracoes/ListarTipoBeneficioINSS.aspx", false);
      }

      private void Novo()
      {
         TipoBeneficioINSS tipoBeneficioINSS = new TipoBeneficioINSS();
         this.AddMessage<TipoBeneficioINSS>(tipoBeneficioINSS);
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            TipoBeneficioINSS tipoBeneficioINSS = PropostaService.GetInstance().ObtemTipoBeneficioINSS(id);

            this.AddMessage<TipoBeneficioINSS>(tipoBeneficioINSS);

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Tipo de Beneficio INSS"));
         }
      }
   }
}