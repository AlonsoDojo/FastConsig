using FastConsig.Common.Services;
using FastConsig.Comunicado.Entity;
using FastConsig.Comunicado.Services;
using FastConsig.Comunicado.Services.Exceptions;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Framework.Web.UI.Controls.CustomFlot_PieChart;

namespace FastConsig.Core.Web.Comunicado
{
   public partial class PreviewComunicado : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("VisualizarComunicados.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Visualizar")
            {
               Comunicados comunicados = GetCrossPageData<Comunicados>("Comunicados");
               Visualizar(comunicados.Id);
            } else if (Request.Params["Id"] != "")
            {
               Visualizar(int.Parse(Request.Params["Id"]));
            }
         }
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Comunicado/VisualizarComunicados.aspx", false);
      }

      private void Visualizar(int? id)
      {
         try
         {
            Comunicados comunicados = ComunicadoService.GetInstance().ObtemComunicado(id, UserContext.GetUserData<Usuario>().Id);

            this.AddMessage<Comunicados>(comunicados);

            var arquivos = ComunicadoService.GetInstance().ListarArquivos(id);
            rptArquivos.DataSource = arquivos;
            rptArquivos.DataBind();

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Visualizar Comunicado"));
         }
      }

      protected void rptArquivos_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
      {
         if (e.CommandArgument == null)
            return;

         DataUnbind();
         var comunicado = GetMessage<Comunicados>("Comunicado");

         if (e.CommandName == "Download")
         {
            var comunicadoArquivo = ComunicadoService.GetInstance().ObtemArquivoComunicado(int.Parse(e.CommandArgument.ToString()));

            Response.Clear();

            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + comunicadoArquivo.NomeArquivo + "");
            
            string armazenamento = ConfiguracaoService.GetInstance().Obter("fastconsig.armazenamento").Conteudo;

            if (armazenamento == "filesystem")
            {
               Response.AddHeader("Content-Length", new FileInfo(Server.MapPath("~/Arquivos/Comunicados/" + comunicado.Id.ToString() + "/") + comunicadoArquivo.NomeArquivo).Length.ToString());
               var reader = File.ReadAllBytes(Server.MapPath("~/Arquivos/Comunicados/" + comunicado.Id.ToString() + "/") + comunicadoArquivo.NomeArquivo);
               Response.BinaryWrite(reader);
            } else if (armazenamento == "database")
            {
               Response.AddHeader("Content-Length", comunicadoArquivo.Conteudo.Length.ToString());
               var reader = comunicadoArquivo.Conteudo;
               Response.BinaryWrite(reader);
            } else
            {
               throw new Exception("Forma de Armazenamento não Definida nas Configurações");
            }

            Response.End();

         }
      }

      protected void rptArquivos_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            ScriptManager scriptMan = ScriptManager.GetCurrent(this.Page);
            scriptMan.RegisterPostBackControl(((CustomLinkButton)e.Item.FindControl("lnkArquivoDownload")));
         }
      }
   }
}