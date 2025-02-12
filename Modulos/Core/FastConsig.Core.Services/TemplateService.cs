using FastConsig.Common.Integracao;
using FastConsig.Common.Model;
using FastConsig.Common.Services;
using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Services
{
   public class TemplateService
   {
      #region "Instância"
      private static TemplateService _instance;
      private TemplateService()
      {

      }
      public static TemplateService GetInstance()
      {
         if (_instance == null)
            _instance = new TemplateService();

         return _instance;
      }
      #endregion

      public TemplateEmailModel TemplateEmail(int templateId)
      {
         TemplateEmailModel template = new TemplateEmailModel();

         try
         {
            var emailtemplate = ObterTemplateEmail(templateId);

            template.Template = emailtemplate.Template;
            template.Assunto = emailtemplate.Assunto;

            return template;
         }
         catch (Exception)
         {
            var emailtemplate = ConfiguracaoService.GetInstance().Config<string>("fastconsig.email.contigencia");

            template.Template = emailtemplate;

            return template;
         }
      }

      public TemplateEmailModel ObterTemplateEmail(int enviarQuando)
      {
         try
         {
            var config = new ConfiguracaoRequestModel { Url = ConfiguracaoService.GetInstance().Config<string>("fastconsig.template.api") };

            return ObterTemplateEmail(config, enviarQuando);
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao tentar obter Template!", ex);
         }
      }

      /// <summary>
      /// Responsavél por buscar o template de acordo com o parâmetro informado.
      /// </summary>
      /// <param name="enviarQuando">Ação (Envia quando)</param>
      /// <returns></returns>
      /// <exception cref="Exception">Erro ao tentar obter Template.</exception>
      public string ObterTemplate(int enviarQuando)
      {
         try
         {
            var config = new ConfiguracaoRequestModel { Url = ConfiguracaoService.GetInstance().Config<string>("fastconsig.template.api") };

            return ObterTemplate(config, enviarQuando);
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao tentar obter Template!", ex);
         }
      }

      internal string ObterTemplate(ConfiguracaoRequestModel config, int enviarQuando)
      {
         //create obj request
         var execute = new ExecuteRequest(config.Url, "", "ObterTemplate");

         var parameters = new Dictionary<string, string>
            {
                { "acao", enviarQuando.ToString()}
            };

         //execute request autenticar
         var response = execute.Request("", Method.GET, parameters);

         //OK = 200
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return response.Content;

         if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) //Forbidden = 403
            throw new Exception(string.Format("Token inválido ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) //Unauthorized = 401
            throw new Exception(string.Format("Não autorizado ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            throw new Exception(string.Format("Não há conteúdo para enviar para esta solicitação ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.ErrorException != null)
            throw response.ErrorException;

         throw new Exception(string.Format("{0} - {1}", response.StatusCode, response.Content));
      }

      internal TemplateEmailModel ObterTemplateEmail(ConfiguracaoRequestModel config, int enviarQuando)
      {
         //create obj request
         var execute = new ExecuteRequest(config.Url, "", "ObterTemplateEmail");

         var parameters = new Dictionary<string, string>
            {
                { "acao", enviarQuando.ToString()}
            };

         //execute request autenticar
         var response = execute.Request("", Method.GET, parameters);

         //OK = 200
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return JsonConvert.DeserializeObject<TemplateEmailModel>(response.Content);

         if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) //Forbidden = 403
            throw new Exception(string.Format("Token inválido ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) //Unauthorized = 401
            throw new Exception(string.Format("Não autorizado ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            throw new Exception(string.Format("Não há conteúdo para enviar para esta solicitação ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.ErrorException != null)
            throw response.ErrorException;

         throw new Exception(string.Format("{0} - {1}", response.StatusCode, response.Content));
      }
   }
}
