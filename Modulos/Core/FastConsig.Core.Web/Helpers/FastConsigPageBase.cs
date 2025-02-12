using FastConsig.Common.Loggin;
using Framework.Web.UI;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Security;
using FastConsig.Common.Services;

namespace FastConsig.Core.Web.Helpers
{
   public class FastConsigPageBase : CustomPageBase
   {
      protected void Page_Init(object Sender, EventArgs e)
      {
         base.OnPreInit(e);

         Response.Cache.SetCacheability(HttpCacheability.NoCache);
         Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
         Response.Cache.SetNoStore();

         var contexto = Contexto;
      }

      protected override void OnPreRender(EventArgs e)
      {
         base.OnPreRender(e);

         string disabledScript = "<script language=\"javascript\">\r\nwindow.history.forward(1);\r\n</script>";
         ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", disabledScript);
      }

      protected Framework.CustomContext Contexto
      {
         get
         {
            try
            {
               var pageBase = Page as CustomPageBase;
               if (pageBase == null)
                  return null;

               var ctx = pageBase.UserContext;
               if (ctx == null)
               {
                  pageBase.Response.Redirect(FormsAuthentication.LoginUrl, false);
                  Context.ApplicationInstance.CompleteRequest();
               }
               return ctx;
            }
            catch
            {
               ((CustomPageBase)Page).Response.Redirect(FormsAuthentication.LoginUrl, false);
               Context.ApplicationInstance.CompleteRequest();
               return null;
            }
         }
      }

      /// <summary>
      /// Verifica se o usuário logado possui permissão de acesso na página atual.
      /// </summary>
      protected void VerificarPermissaoAcesso()
      {
         var somentePagina = Path.GetFileName(Request.Url.ToString());
         var inicioParam = somentePagina.IndexOf("?");
         if (inicioParam >= 0)
            somentePagina = somentePagina.Substring(0, inicioParam);

         VerificarPermissaoAcesso(somentePagina);
      }

      /// <summary>
      /// Verifica se o usuário logado possui permissão de acesso na página informada.
      /// </summary>
      protected void VerificarPermissaoAcesso(string nomePagina)
      {
         ////Verifica se o usuário logado tem permissão de acessar a página...
         var temAcesso = ((SiteMaster)this.Master).VerificarPermissaoAcesso(nomePagina);
         if (!temAcesso)
            try { Server.Transfer("~/AcessoNaoPermitido.aspx"); } catch { }
      }

      protected bool VerificarPermissaoAcessoPagina(string nomePagina)
      {
         ////Verifica se o usuário logado tem permissão de acessar a página...
         var temAcesso = ((SiteMaster)this.Master).VerificarPermissaoAcesso(nomePagina);
         return temAcesso;
      }

      /// <summary>
      /// 
      /// </summary>
      protected bool VerificarPermissaoAcessoAcaoUrl(string urlPagina, string nomeAcao)
      {
         ////Verifica se o usuário logado tem permissão de acessar a página...
         return ((SiteMaster)this.Master).VerificarPermissaoAcessoAcaoUrl(urlPagina, nomeAcao);
      }

      protected bool VerificarPermissaoAcessoAcaoUrl(string urlPagina, string nomeAcao, string fase)
      {
         ////Verifica se o usuário logado tem permissão de acessar a página...
         return ((SiteMaster)this.Master).VerificarPermissaoAcessoAcaoUrl(urlPagina, nomeAcao.Trim() + " " + fase.Trim());
      }

      protected int? VerificarConexto(string urlPagina, string nomeAcao)
      {
         ////Verifica se o usuário logado tem permissão de acessar a página...
         return ((SiteMaster)this.Master).VerificaContexto(urlPagina, nomeAcao);
      }

      ///// <summary>
      ///// Obténdo preferencia(s) do usuário.
      ///// </summary>
      ///// <returns></returns>
      //protected PreferenciaUsuarioModel ObterPreferenciaUsuario() => ((SiteMaster)this.Master).ObterPreferenciaUsuario();

      /// <summary>
      /// Obtém o conteúdo de um objeto armazenado numa página.
      /// </summary>
      /// <typeparam name="TEntity"></typeparam>
      /// <returns></returns>
      protected TEntity GetCrossPageData<TEntity>(string tagName)
      {
         if (!(this.Master is SiteMaster) || string.IsNullOrEmpty(tagName?.Trim()))
            return default(TEntity);

         var key = string.Format("{0}_{1}", WebUtilityHelper.TAG_CROSS_PAGE_KEY, tagName.Trim().Replace(" ", "_"));

         return (TEntity)Session[key];
      }

      /// <summary>
      /// Guarda o conteúdo de um objeto para ser recuperado por outro em outra página.
      /// </summary>
      /// <typeparam name="TEntity"></typeparam>
      protected void SetCrossPageData<TEntity>(string tagName, TEntity data)
      {
         if (!(this.Master is SiteMaster) || string.IsNullOrEmpty(tagName?.Trim()))
            return;

         var key = string.Format("{0}_{1}", WebUtilityHelper.TAG_CROSS_PAGE_KEY, tagName.Trim().Replace(" ", "_"));
         Session[key] = data;
      }

      /// <summary>
      /// Define quanto tempo tem para o próximo refesh de página ocorrer antes de finalizar a sessão atual.
      /// </summary>
      /// <returns></returns>
      protected int NextRefreshTimoutSession()
      {
         var timeout = (Session.Timeout * 60);
         return (timeout - 120) > 0 ? timeout - 120 : timeout - 60;
      }

      #region *------- Impressão e fila de impressão -------*

      ///// <summary>
      ///// Adiciona uma nova requisição na fila de impressão.
      ///// </summary>
      ///// <typeparam name="T"></typeparam>
      ///// <param name="urlImpressao"></param>
      ///// <param name="obj"></param>
      ///// <returns></returns>
      //protected string AdicionarFilaImpressao<T>(string urlImpressao, T obj) where T : new()
      //{
      //   var fila = new FilaImpressao
      //   {
      //      urlDestino = urlImpressao,
      //      Parametros = Common.Helpers.UtilityHelper.SerializeData(obj)
      //   };

      //   ImpressaoService.GetInstance().AdicionarFila(fila);
      //   return fila.Id;
      //}

      ///// <summary>
      ///// Obtém uma fila de impressão.
      ///// </summary>
      ///// <param name="id">Id da fila a ser recuparada</param>
      ///// <returns></returns>
      //protected FilaImpressao ObterFilaImpressao(string id) => ImpressaoService.GetInstance().ObterFila(id);

      /// <summary>
      /// Redireciona para a página de impressão, informando o ID da fila de impressão.
      /// </summary>
      /// <param name="filaId">Id da fila de impressão armazenado na tabela FilaImpressao.</param>
      protected void RegistrarPrintPage(string filaId)
      {

      }

      #endregion

      /// <summary>
      /// Obtém o parâmetro de configuração do sistema, retornando o tipo de dado desejado.
      /// </summary>
      /// <typeparam name="T">Tipo de dados desejado.</typeparam>
      /// <param name="chave">Chave de configuração.</param>
      /// <returns>Conteúdo correspondente a chave de configuração.</returns>
      protected T Config<T>(string chave) where T : new() => ConfiguracaoService.GetInstance().Config(chave, default(T));

      /// <summary>
      /// Obtém o parâmetro de configuração do sistema, retornando o tipo de dado desejado.
      /// </summary>
      /// <typeparam name="T">Tipo de dados desejado.</typeparam>
      /// <param name="chave">Chave de configuração.</param>
      /// <param name="valorDefault">Valor default caso não exista definicão da configuração.</param>
      /// <returns>Conteúdo correspondente a chave de configuração.</returns>
      protected T Config<T>(string chave, T valorDefault) where T : new() => ConfiguracaoService.GetInstance().Config(chave, valorDefault);

      /// <summary>
      /// Redireciona para outra pagina.
      /// </summary>
      /// <param name="page">pagina</param>
      /// <param name="parameter">parâmetro</param>
      protected void SendToPage(string page, string parameter)
      {
         var masterpage = (SiteMaster)Master;
         masterpage.RegisterStartupScript("____Page___",
                         string.Format("OpenNewWindow('/{0}?Comando=Visualizar&Id={1}');", page, parameter));
      }

      /// <summary>
      /// Redireciona para outra pagina para geração do report.
      /// </summary>
      /// <param name="page">pagina</param>
      /// <param name="parameter">parâmetro</param>
      protected void GenerateReport(string page, string parameter)
      {
         var masterpage = (SiteMaster)Master;
         masterpage.RegisterStartupScript("____Page___", string.Format("OpenNewWindow('/{0}?Comando=GenerateReport&Id={1}');", page, parameter));
      }

      #region *------- Tratamento de LOG de execução -------*
      public void GravarLogInfo(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogInfo(mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);
      public void GravarLogErro(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogErro(ex, mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);
      public void GravarLogDebug(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogDebug(mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);
      public void GravarLogWarning(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogWarning(mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);
      public void GravarLogFatal(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogFatal(ex, mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);
      #endregion
   }
}