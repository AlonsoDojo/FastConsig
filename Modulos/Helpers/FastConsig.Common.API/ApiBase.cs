using FastConsig.Common.Loggin;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace FastConsig.Common.API
{
   public class ApiBase : ApiController
   {
      #region *------- Gravação de log -------*

      /// <summary>
      /// 
      /// </summary>
      /// <param name="mensagem"></param>
      /// <param name="methodName"></param>
      protected void GravarLogInfo(string mensagem, [CallerMemberName] string methodName = null) => LogService.GetInstance().GravarLogInfo(mensagem, methodName);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="ex"></param>
      /// <param name="mensagem"></param>
      /// <param name="parameters"></param>
      /// <param name="methodName"></param>
      /// <param name="sourceFilePath"></param>
      /// <param name="sourceLineNumber"></param>
      protected void GravarLogErro(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogErro(ex, mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="mensagem"></param>
      /// <param name="parameters"></param>
      /// <param name="methodName"></param>
      /// <param name="sourceFilePath"></param>
      /// <param name="sourceLineNumber"></param>
      protected void GravarLogDebug(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogDebug(mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="mensagem"></param>
      /// <param name="parameters"></param>
      /// <param name="methodName"></param>
      /// <param name="sourceFilePath"></param>
      /// <param name="sourceLineNumber"></param>
      protected void GravarLogWarning(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogWarning(mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="ex"></param>
      /// <param name="mensagem"></param>
      /// <param name="parameters"></param>
      /// <param name="methodName"></param>
      /// <param name="sourceFilePath"></param>
      /// <param name="sourceLineNumber"></param>
      protected void GravarLogFatal(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogFatal(ex, mensagem, parameters, methodName, sourceFilePath, sourceLineNumber);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="token"></param>
      /// <param name="exception"></param>
      /// <param name="parameters"></param>
      /// <param name="methodName"></param>
      /// <param name="request"></param>
      /// <param name="sourceFilePath"></param>
      /// <param name="sourceLineNumber"></param>
      protected void GravarLogToken(string token, Exception exception, object parameters = null, [CallerMemberName] string methodName = null, string request = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0) => LogService.GetInstance().GravarLogErro(exception, string.Format("Request: {0}  Msg: {1}", request, request), parameters, methodName, sourceFilePath, sourceLineNumber);

      #endregion

      /// <summary>
      /// Gravar o request
      /// </summary>
      /// <param name="exception"></param>
      protected void InfoRequest(Exception exception = null)
      {
         try
         {
            // Get call stack
            StackTrace stackTrace = new StackTrace();

            // get token or empty
            var token = Request.Headers.Authorization?.Parameter ?? null;

            // get resquest or empty
            var request = JsonConvert.SerializeObject(new { Request.Headers }) ?? string.Empty;

            /*
                Recuperando o nome do método que está gravando a exceção    
                Se for nulo grava InfoRequest
             */
            var methodName = stackTrace.GetFrame(2)?.GetMethod()?.Name ?? "InfoRequest";

            /*
                Se for lambda_method grava como InfoRequest
             */
            if (methodName == "lambda_method") methodName = "InfoRequest";

            // persit log
            GravarLogToken(token, exception, methodName, request);
         }
         catch (Exception ex)
         {
            /*
                Ocorreu algum erro ao tentar gravar o log em tabela?
                Então log em arquivo
             */

            GravarLogErro(ex, ex.Message);
         }
      }

      /// <summary>
      /// Responsável por realizar tracking e validação do token
      /// </summary>        
      protected void Config()
      {
         // log request
         InfoRequest();

         // recuperando o token para realizar a segunda autenticação
         var token = Request.Headers?.Authorization?.Parameter;

         if (token == null) throw new UnauthorizedAccessException("Não Autorizado - Token nulo");
      }
   }
}
