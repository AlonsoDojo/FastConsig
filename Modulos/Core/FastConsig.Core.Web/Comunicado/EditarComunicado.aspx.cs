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
   public partial class EditarComunicado : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("ListarComunicados.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<ComunicadosStatus>(ComunicadoService.GetInstance().ListarStatus().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<ComboValueBoleanoModel>(PropostaService.GetInstance().ListarSimNaoBoleano().OrderBy(x => x.Descricao).ToList(), "ConfirmacaoLeitura");

            if (Request.Params["Comando"] == "Editar")
            {
               Comunicados comunicados = GetCrossPageData<Comunicados>("Comunicados");
               Editar(comunicados.Id);
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

         Comunicados comunicados = GetMessage<Comunicados>("Comunicados");

         ComunicadoService.GetInstance().SalvarComunicado(comunicados);

         this.AddMessage<Comunicados>(comunicados);

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
         Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Comunicados comunicados = GetMessage<Comunicados>("Comunicados");

         ComunicadoService.GetInstance().ExcluirComunicado(comunicados.Id);

         this.AddMessage<Comunicados>(comunicados);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Comunicado/ListarComunicados.aspx", false);
      }

      private void Novo()
      {
         Comunicados comunicados = new Comunicados();
         comunicados.Usuario = UserContext.GetUserData<Usuario>().Id;
         comunicados.DataCriacao = DateTime.Now;
         comunicados.Publicado = false;
         this.AddMessage<Comunicados>(comunicados);
         
         btnExcluir.Visible = false;
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Comunicados comunicados = ComunicadoService.GetInstance().ObtemComunicado(id);

            this.AddMessage<Comunicados>(comunicados);

            var arquivos = ComunicadoService.GetInstance().ListarArquivos(id);
            rptArquivos.DataSource = arquivos;
            rptArquivos.DataBind();

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Comunicado"));
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
         else if (e.CommandName == "Excluir")
         {
            if (!VerificarPermissaoAcessoAcaoUrl("/Comunicado/Comunicado.aspx", "Excluir Arquivo Anexado"))
            {
               ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
               return;
            }

            ComunicadoService.GetInstance().ExcluirArquivoComunicado(int.Parse(e.CommandArgument.ToString()));
            var listArquivos = ComunicadoService.GetInstance().ListarArquivos(comunicado.Id);
            rptArquivos.DataSource = listArquivos;
            rptArquivos.DataBind();
         }
      }

      protected void btnCarregarArquivo_Click(object sender, EventArgs e)
      {
         DataUnbind();

         try
         {
            if (!fileUpload.HasFile)
               throw new ComunicadoException("Arquivo Inválido");

            var comunicado = GetMessage<Comunicados>("Comunicados");

            if (!comunicado.Id.HasValue)
               throw new ComunicadoException("Para anexar um arquivo é necessário antes salvar o comunicado.");

            var listArquivos = ComunicadoService.GetInstance().ListarArquivos(comunicado.Id);

            var maximoAnexos = ConfiguracaoService.GetInstance().Config<int>("fastconsig.comunicados.maximo.anexos");

            if (listArquivos.Count == maximoAnexos)
               throw new ComunicadoException("Limite máximo é de 5 documento por comunicado!");

            var filename = fileUpload.FileName;
            var extension = System.IO.Path.GetExtension(filename);

            if (extension.ToUpper() != ".PDF")
               throw new ComunicadoException("Tipo de Arquivo Inválido");

            if (fileUpload.FileBytes.Length == 0)
               throw new ComunicadoException("Arquivo não pode ser vazio.");

            var tamanhoMaximoArquivo = ConfiguracaoService.GetInstance().Config<int>("fastconsig.tamanhomaximo.anexo");

            if (fileUpload.FileBytes.Length > tamanhoMaximoArquivo)
               throw new ComunicadoException("Limite máximo é de " + tamanhoMaximoArquivo);

            string armazenamento = ConfiguracaoService.GetInstance().Obter("fastconsig.armazenamento").Conteudo;

            ComunicadosArquivos comunicadoArquivo = new ComunicadosArquivos();
            comunicadoArquivo.Comunicado = comunicado.Id;
            comunicadoArquivo.NomeArquivo = filename;


            if (armazenamento == "filesystem")
            {
               if (!System.IO.Directory.Exists(Server.MapPath("~/Arquivos/Comunicados/" + comunicado.Id.ToString() + "/")))
                  System.IO.Directory.CreateDirectory(Server.MapPath("~/Arquivos/Comunicados/" + comunicado.Id.ToString() + "/"));

               var arquivo = Server.MapPath("~/Arquivos/Comunicados/") + comunicado.Id.ToString() + "/" + filename;
               fileUpload.SaveAs(arquivo);
               comunicadoArquivo.Conteudo = new byte[1];
            } else if (armazenamento == "database")
            {
               comunicadoArquivo.Conteudo = fileUpload.FileBytes;
            } else
            {
               throw new Exception("Forma de Armazenamento não Definida nas Configurações");
            }

            ComunicadoService.GetInstance().SalvarComunicado(comunicado, UserContext.GetUserData<Usuario>(), comunicadoArquivo);

            listArquivos = ComunicadoService.GetInstance().ListarArquivos(comunicado.Id);
            rptArquivos.DataSource = listArquivos;
            rptArquivos.DataBind();

            DataBind();

            ShowMessage(TipoMensagem.Aviso, "Arquivo Carregado com Sucesso!!!");
         }
         catch (ComunicadoException ex)
         {
            ShowMessage(TipoMensagem.Erro, ex.Message);
            return;
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, "Erro ao Carregar o Arquivo: " + ex.StackTrace);
            return;
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