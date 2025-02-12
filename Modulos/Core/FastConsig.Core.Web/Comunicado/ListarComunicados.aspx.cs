using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using FastConsig.Comunicado.Services;
using FastConsig.Comunicado.Entity;
using FastConsig.Seguranca.Entity;

namespace FastConsig.Core.Web.Comunicado
{
   public partial class ListarComunicados : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();
         CarregarComunicados();
      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {
         int id = int.Parse(((LinkButton)sender).CommandArgument);
         Comunicados comunicados = ComunicadoService.GetInstance().ObtemComunicado(id);
         SetCrossPageData("Comunicados", comunicados);
         Response.Redirect("/Comunicado/EditarComunicado.aspx?Comando=Editar", false);
      }

      private void CarregarComunicados()
      {
         try
         {
            ComunicadosRepeater.DataSource = ComunicadoService.GetInstance().ListarComunicados().OrderBy(c => c.Id).ToList();
            ComunicadosRepeater.DataBind();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Consulta de Comunicados"));
         }
      }

      protected void btnNovo_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Comunicado/EditarComunicado.aspx?Comando=Novo", false);
      }

      protected void ComunicadosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Comunicados)e.Item.DataItem;
            ((CustomLinkButton)e.Item.FindControl("lnkEditar")).CommandArgument = o.Id.ToString();
            if (o.Publicado)
            {
               ((CustomLinkButton)e.Item.FindControl("lnkEditar")).Visible = false;
            } else
            {
               ((CustomLinkButton)e.Item.FindControl("lnkEditar")).Visible = true;
            }
            ((CustomLinkButton)e.Item.FindControl("lnkPublicar")).CommandArgument = o.Id.ToString();
            if (o.Publicado)
            {
               ((CustomLinkButton)e.Item.FindControl("lnkPublicar")).Visible = false;
            }
            else
            {
               ((CustomLinkButton)e.Item.FindControl("lnkPublicar")).Visible = true;
            }
            ((CustomLinkButton)e.Item.FindControl("lnkExcluir")).CommandArgument = o.Id.ToString();
            if (o.Publicado)
            {
               ((CustomLinkButton)e.Item.FindControl("lnkExcluir")).Visible = false;
            }
            else
            {
               ((CustomLinkButton)e.Item.FindControl("lnkExcluir")).Visible = true;
            }
            ((CustomLinkButton)e.Item.FindControl("lnkRemoverPublicacao")).CommandArgument = o.Id.ToString();
            if (o.Publicado)
            {
               ((CustomLinkButton)e.Item.FindControl("lnkRemoverPublicacao")).Visible = true;
            }
            else
            {
               ((CustomLinkButton)e.Item.FindControl("lnkRemoverPublicacao")).Visible = false;
            }
            ((CustomLabel)e.Item.FindControl("lblNumero")).Text = o.Id.ToString();
            ((CustomLabel)e.Item.FindControl("lblDataCriacao")).Text = o.DataCriacao.ToString();
            ((CustomLabel)e.Item.FindControl("lblTitulo")).Text = o.Titulo;
            ((CustomLabel)e.Item.FindControl("lblVigenciaInicial")).Text = o.DataVigenciaInicial.ToString();
            ((CustomLabel)e.Item.FindControl("lblVigenciaFinal")).Text = o.DataVigenciaFinal.ToString();
            ((CustomLabel)e.Item.FindControl("lblStatus")).Text = o.DescricaoStatus;
         }
      }

      protected void lnkPublicar_Click(object sender, EventArgs e)
      {
         try
         {
            var id = int.Parse(((LinkButton)sender).CommandArgument);

            var entity = ComunicadoService.GetInstance().ObtemComunicado(id);

            if (entity != null)
            {
               if (entity.Publicado)
               {
                  ShowMessage(TipoMensagem.Alerta, "Comunicado já publicado, não é permitido excluir!");
                  return;
               }
            }

            ComunicadoService.GetInstance().Publicar(id, UserContext.GetUserData<Usuario>().Id);

            ShowMessage(TipoMensagem.Aviso, "Comunicado publicado com sucesso!");

            Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);

            ShowMessage(TipoMensagem.Erro, "Falha ao Publicar o Comunicado");
         }
      }

      protected void lnkExcluir_Click(object sender, EventArgs e)
      {
         try
         {
            var id = int.Parse(((LinkButton)sender).CommandArgument);

            var entity = ComunicadoService.GetInstance().ObtemComunicado(id);

            if (entity != null)
            {
               if (entity.Publicado)
               {
                  ShowMessage(TipoMensagem.Alerta, "Comunicado já publicado, não é permitido excluir!");
                  return;
               }
            }

            ComunicadoService.GetInstance().ExcluirComunicado(id);

            ShowMessage(TipoMensagem.Aviso, MensagemTexto.MsgDadosSalvosComSucesso);

            Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);

            ShowMessage(TipoMensagem.Erro, "Falha ao Excluir o Comunicado");
         }
      }

      protected void lnkRemoverPublicacao_Click(object sender, EventArgs e)
      {
         try
         {
            var id = int.Parse(((LinkButton)sender).CommandArgument);

            var entity = ComunicadoService.GetInstance().ObtemComunicado(id);

            if (entity != null)
            {
               if (!entity.Publicado)
               {
                  ShowMessage(TipoMensagem.Alerta, "Comunicado não publicado, não é permitido remover a publicação!");
                  return;
               }
            }

            ComunicadoService.GetInstance().DesativarPublicacao(id, UserContext.GetUserData<Usuario>().Id);

            ShowMessage(TipoMensagem.Aviso, "Comunicado desativado com sucesso!");

            Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);

            ShowMessage(TipoMensagem.Erro, "Falha ao Remover a Publicação do Comunicado");
         }
      }
   }
}