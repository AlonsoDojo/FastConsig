using FastConsig.Seguranca.Entity;
using FastConsig.Common.Helpers;
using FastConsig.Core.Web.Helpers;

using Framework.Web.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using FastConsig.Seguranca.Model;
using System.Configuration;
using FastConsig.Seguranca.Services;
using FastConsig.Common.Loggin;
using FastConsig.Comunicado.Services;
using FastConsig.Comunicado.Entity;

namespace FastConsig.Core.Web
{
   public partial class SiteMaster : MasterPage, IPostBackEventHandler
   {
      #region *------- Métodos públicos -------*

      public Framework.CustomContext UserContext
      {
         get
         {
            try
            {
               Framework.CustomContext ctx = null;

               if (this.Page is CustomPageBase)
               {
                  ctx = ((CustomPageBase)this.Page).UserContext;

                  if (ctx == null)
                  {
                     ((CustomPageBase)this.Page).Response.Redirect(FormsAuthentication.LoginUrl, false);
                     Context.ApplicationInstance.CompleteRequest();
                  }
                  return ctx;
               }
               else
                  return null;
            }
            catch
            {
               ((CustomPageBase)this.Page).Response.Redirect(FormsAuthentication.LoginUrl, false);
               Context.ApplicationInstance.CompleteRequest();
               return null;
            }
         }
      }

      public int SessionTimeout
      {
         get
         {
            Configuration conf = WebConfigurationManager.OpenWebConfiguration(System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath);
            SessionStateSection section = (SessionStateSection)conf.GetSection("system.web/sessionState");
            return (int)section.Timeout.TotalMinutes * 1000 * 60;
         }
      }

      public void RegisterStartupScript(string name, string scriptCode)
      {
         ScriptManager.RegisterStartupScript(UpdatePanelMenu, UpdatePanelMenu.GetType(), name, scriptCode, true);
      }

      /// <summary>
      /// Força a atualizaçãllo das opções de menu de acordo com o status do cliente logado.
      /// </summary>
      public void RefreshMenu()
      {
         string htmlMenu = (string)ViewState[WebUtilityHelper.MENU_KEY];
         if (!string.IsNullOrEmpty(htmlMenu))
         {
            ////Retorna o menu já montado para este usuário...
            placeHolderMenu.Controls.Clear();
            placeHolderMenu.Controls.Add(new LiteralControl(htmlMenu));
            return;
         }

         var sb = new StringBuilder();
         var usuario = this.UserContext?.GetUserData<Usuario>();

         //litUsuario.Text = "<i class=\"icon-user\"></i>&nbsp;";
         //litPerfis.Text = "<i class=\"fa fa-group\"></i>&nbsp;";

         //*------- Consulta as permissões do usuário...
         if (usuario != null)
         {
            // obténdo permissões que o usuário tem acesso.
            var permissoesModel = SegurancaService.GetInstance().ObterPermissoes(usuario.Id);

            // obténdo preferência do usuário.
            //PreferenciaUsuario = UsuarioService.GetInstance().ObterPreferencia(usuario.Id);

            //litUsuario.Text = string.Format("<i class=\"icon-user\"></i><b>{0}</b><br /><i class=\"icon-xspace\"></i>{1}", usuario.Login, usuario.Nome);
            var perfistexto = string.Empty;
            foreach (var p in permissoesModel.Perfis)
            {
               var formato = "<i class=\"icon-xspace\"></i>{0}<br />";
               if (perfistexto.Length == 0)
                  formato = "<i class=\"fa fa-group\"></i>{0}<br />";

               perfistexto += string.Format(formato, p.NomePerfil);
            }
            //litPerfis.Text = perfistexto;

            //Guarda as funcionalidades que o usuário tem acesso...
            PermissaoUsuario = permissoesModel;

            try
            {
               var grupos = permissoesModel.Permissoes
                                       .Select(g => new { g.IdGrupo, g.NomeGrupo, g.Ordem })
                                       .OrderBy(g => g.Ordem)
                                       .Distinct()
                                       .ToList();

               foreach (var grupo in grupos)
               {
                  var grp = permissoesModel.Permissoes.Find(p => p.IdGrupo == grupo.IdGrupo);

                  //Monta menu da barra principal...
                  var icone = string.IsNullOrEmpty(grp.IconeGrupo) ? "fa fa-th" : grp.IconeGrupo?.Trim();
                  string linha = "<li class=\"nav-item dropdown\"><a class=\"nav-link dropdown-toggle arrow-none\" id={1}\" role=\"button\"><i class=\"{2} me-2\"></i>{0}<div class=\"arrow-down\"></div></a>";
                  sb.AppendFormat(linha, grp.NomeGrupo, grp.IdGrupo, icone);
                  sb.Append("<div class=\"dropdown-menu\" aria-labelledby=\"topnav-pages\">");

                  //Lista de funcionalidades deste grupo...
                  var funcionalidades = permissoesModel.Permissoes.Where(p => p.NomeGrupo == grp.NomeGrupo)
                                                  .OrderBy(p => p.Sequencia)
                                                  .ThenBy(p => p.Nome)
                                                  .ToList();
                  foreach (var funcionalidade in funcionalidades)
                  {
                     if (funcionalidade.Visivel)
                     {
                        string linha2 = "<a href=\"{0}\" class=\"dropdown-item\">{1}</a>";
                        sb.AppendFormat(linha2, ResolveUrl(funcionalidade.Url), funcionalidade.Nome);
                     }
                  }

                  //Fecha grupo...
                  sb.Append("</div>");
                  sb.Append("</li>");
               }
            }
            catch (Exception x)
            {
               LogService.GetInstance().GravarLogDebug(x, "Usuário sem Perfil Atribuido");
            }

         }

         List<ViewComunicados> comunicados = new List<ViewComunicados>();
         List<ViewComunicados> comunicadosNaoLidos = new List<ViewComunicados>();

         try
         {
            comunicados = ComunicadoService.GetInstance().ListarComunicadosUsuario(this.UserContext?.GetUserData<Usuario>().Id)?.Where(x => x.DataVigenciaInicial <= DateTime.Now)?.Where(x => x.DataVigenciaFinal >= DateTime.Now)?.ToList();
            comunicadosNaoLidos = comunicados.Where(x => x.DataLeitura == null).ToList();
         }
         catch (Exception) { }

         if (comunicadosNaoLidos.Count() > 0)
         {
            string htmlNotificacoes = "<span class=\"badge bg-danger rounded-pill\">" + comunicadosNaoLidos.Count() + "</span>";

            notificacoes.Controls.Add(new LiteralControl(htmlNotificacoes));
         }

         if (comunicados.Count == 0) {
            string htmlComunicados = "\t\t\t                                                         <a href=\"javascript:void(0);\" class=\"text-dark notification-item\">\r\n\t\t\t                                                            <div class=\"d-flex align-items-start\">\r\n\t\t\t                                                               <div class=\"flex-grow-1\">\r\n\t\t\t                                                                  <h6 class=\"mb-1\">Nada a Exibir</h6>\r\n\t\t\t                                                               </div>\r\n\t\t\t                                                            </div>\r\n\t\t\t\t                                                 </a>\t\t\t\t                                                 ";
            phdcomunicados.Controls.Add(new LiteralControl(htmlComunicados));
         } else
         {
            string htmlComunicados = "";
            foreach (ViewComunicados x in comunicados)
            {
               if (x.DataLeitura == null)
               {
                  htmlComunicados += string.Format("                                                                                 <a href=\"/Comunicado/PreviewComunicado.aspx?Id={0}\" class=\"text-dark notification-item\">\r\n\t\t\t                                                            <div class=\"d-flex align-items-start\">\r\n\t\t\t                                                               <div class=\"flex-grow-1\">\r\n\t\t\t                                                                  <h6 class=\"mb-1\">{1}</h6>\r\n\t\t\t                                                               </div>\r\n\t\t\t                                                            </div>\r\n\t\t\t                                                         </a>", x.Comunicado, x.Titulo);
               } else
                  {
                  htmlComunicados += string.Format("<a href=\"/Comunicado/PreviewComunicado.aspx?Id={0}\" class=\"notification-item\">\r\n\t\t\t                                                            <div class=\"d-flex align-items-start\">\r\n\t\t\t                                                               <div class=\"flex-grow-1\">\r\n\t\t\t                                                                  <h6 class=\"mb-1\">{1}</h6>\r\n\t\t\t                                                               </div>\r\n\t\t\t                                                            </div>\r\n\t\t\t\t                                                 </a>", x.Comunicado, x.Titulo);
               }
            }
            phdcomunicados.Controls.Add(new LiteralControl(htmlComunicados));
         }


         ViewState[WebUtilityHelper.MENU_KEY] = sb.ToString();
         placeHolderMenu.Controls.Add(new LiteralControl(sb.ToString()));
      }

      /// <summary>
      /// Verifica se o usuário atual tem permissão de acessar a página.
      /// </summary>
      /// <param name="nomePagina"></param>
      /// <returns></returns>
      public bool VerificarPermissaoAcesso(string nomePagina)
      {
         if (PermissaoUsuario == null || !PermissaoUsuario.Permissoes.HasAny())
            return false;

         foreach (var permissao in PermissaoUsuario.Permissoes)
         {
            var parts = permissao.Url.Split('/');
            if (nomePagina.Equals(parts.Last(), StringComparison.InvariantCultureIgnoreCase))
            {
               FuncionalidadeAtual = permissao;
               lblFuncionalidadeTitulo.Text = (permissao.Titulo == null ? permissao.Nome : permissao.Titulo);
               lblGrupo.Text = permissao.NomeGrupo;
               lblFuncionalidade.Text = permissao.Nome;
               return true;
            }
         }

         return false;
      }

      public bool VerificarPermissaoAcessoAcaoUrl(string urlPagina, string nomeAcao)
      {
         if (PermissaoUsuario == null || !PermissaoUsuario.Permissoes.HasAny())
            return false;

         var usuario = this.UserContext?.GetUserData<Usuario>();

         PermissaoUsuarioModel Acoes = null;

         if (Session["Acoes"] == null)
         {
            Session["Acoes"] = SegurancaService.GetInstance().ObterAcoes(usuario.Id);
            Acoes = (PermissaoUsuarioModel)Session["Acoes"];
         }
         else
         {
            Acoes = (PermissaoUsuarioModel)Session["Acoes"];
         }

         var permissoes = Acoes.Permissoes.Where(c => c.Url == urlPagina && c.NomeAcao == nomeAcao);

         foreach (ViewPermissaoUsuario o in permissoes)
         {
            if (o.Habilitado == true)
            {
               return true;
            }
         }
         return false;
      }


      public int? VerificaContexto(string urlPagina, string nomeAcao)
      {
         var usuario = this.UserContext?.GetUserData<Usuario>();
         var Acoes = SegurancaService.GetInstance().ObterAcoes(usuario.Id);
         var permissoes = Acoes.Permissoes.Where(c => c.Url == urlPagina && c.NomeAcao == nomeAcao);

         foreach (ViewPermissaoUsuario o in permissoes)
         {
            if (o.Habilitado == true)
            {
               return o.IdGrupo;
            }
         }
         return 0;
      }

      public PreferenciaUsuarioModel ObterPreferenciaUsuario() => PreferenciaUsuario;

      /// <summary>
      /// Obtém a versão da aplicação que está sendo executada.
      /// </summary>
      public string Version
      {
         get
         {
            var versao = (string)Session[WebUtilityHelper.VERSAO_APP_KEY];
            if (string.IsNullOrEmpty(versao))
            {
               Session[WebUtilityHelper.VERSAO_APP_KEY] = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
               versao = (string)Session[WebUtilityHelper.VERSAO_APP_KEY];
            }
            return versao;
         }
      }

      #endregion

      protected override void OnInit(EventArgs e)
      {
         base.OnInit(e);

         phMensagem.Controls.Add(new LiteralControl("<div id=\"msg\"></div>"));
         if (this.Parent is CustomPageBase)
         {
            var page = (CustomPageBase)this.Parent;
            page.DisplayMessage += new CustomPageBase.DisplayMessageDelegate(page_DisplayMessage);
         }

         Page.EnableEventValidation = false;
      }

      protected override void OnLoad(EventArgs e)
      {
         ////*------- Monta as opções de menu do usuário...
         RefreshMenu();

         if (!Page.IsPostBack)
         {
            labelNome.Text = string.Format("{0} - {1}", UserContext?.Login, UserContext?.Nome);
            Usuario data = (Usuario)UserContext?.UserData;
            labelNome.Text = string.Format("{0} {1}", UserContext?.Nome, (data?.RedeLojas != null ? "(" + data.RedeLojas + "/" + data.Loja + ")" : ""));
            this.RegisterStartupScript("SessionAlert", "SessionExpireAlert(" + SessionTimeout.ToString() + ");");
         }

         base.OnLoad(e);
      }

      /// <summary>
      /// Delegate do Framework para adicionar uma mensagem na tela para o usuário.
      /// </summary>
      /// <param name="tipo"></param>
      /// <param name="mensagem"></param>
      void page_DisplayMessage(TipoMensagem tipo, string mensagem)
      {
         var sbMensagem = new StringBuilder();

         string css = "alert_green";

         if (mensagem.Contains("Cannot open database"))
         {
            mensagem = "Sistema temporáriamente indisponível. Tente novamente mais tarde.";
            tipo = TipoMensagem.Alerta;
         }

         switch (tipo)
         {
            case TipoMensagem.Erro:
               css = "alert alert-danger alert-dismissible fade show";
               break;
            case TipoMensagem.Alerta:
               css = "alert alert-warning alert-dismissible fade show";
               break;
            case TipoMensagem.Aviso:
               css = "alert alert-success alert-dismissible fade show";
               break;
         }

         sbMensagem.AppendFormat("<div class=\"{0}\" role=\"alert\">\r\n", css);
         sbMensagem.Append(mensagem);
         sbMensagem.Append("   <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Fechar\"></button>");
         sbMensagem.AppendLine("</div>");
         phMensagem.Controls.Clear();
         phMensagem.Controls.Add(new LiteralControl(sbMensagem.ToString()));
         phMensagem.Focus();

         RegisterScrollUp();
      }

      /// <summary>
      /// Registra o script para fazer o scroll para cima na página de cadadtro.
      /// </summary>
      private void RegisterScrollUp()
      {
         ScriptManager.RegisterStartupScript(UpdatePanelMenu, UpdatePanelMenu.GetType(), "jsFunctionScrollUp", "ScrollUp();", true);
      }

      /// <summary>
      /// Permissões das funcionalidades do usuário.
      /// </summary>
      private PermissaoUsuarioModel PermissaoUsuario
      {
         get { return (PermissaoUsuarioModel)Session[WebUtilityHelper.PERMISSOES_KEY]; }
         set { Session[WebUtilityHelper.PERMISSOES_KEY] = value; }
      }

      /// <summary>
      /// Preferência(s) do usuário.
      /// </summary>
      private PreferenciaUsuarioModel PreferenciaUsuario
      {
         get { return (PreferenciaUsuarioModel)Session[WebUtilityHelper.PREFERENCIA_USUARIO_KEY]; }
         set { Session[WebUtilityHelper.PREFERENCIA_USUARIO_KEY] = value; }
      }

      /// <summary>
      /// Funcionalidades atual sendo carregada/validada.
      /// </summary>
      protected ViewPermissaoUsuario FuncionalidadeAtual
      {
         get { return (ViewPermissaoUsuario)ViewState[WebUtilityHelper.FUNCIONALIDADE_KEY]; }
         set { ViewState[WebUtilityHelper.FUNCIONALIDADE_KEY] = value; }
      }

      #region IPostBackEventHandler Members

      void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
      {
         Response.Redirect(eventArgument, false);
      }

      #endregion

      protected void searchButton_Click(object sender, EventArgs e)
      {

      }
   }
}