using FastConsig.Common.Model;
using FastConsig.Common.Helpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Integracao
{
   /// <summary>
   /// Responsavél pela comunicação com o serviço de emprestimos do barramento.
   /// </summary>
   public class ExecuteRequest
   {
      private string Url { get; }
      private string Token { get; }
      private string RootApiPath { get; }

      private Func<bool, string> ObterToken;

      /// <summary>
      /// É para utilizar o Bearer Token para autenticar.
      /// </summary>
      public bool BearerToken { get; set; }

      public ExecuteRequest(string url, string rootApiPath)
      {
         Url = url;
         RootApiPath = rootApiPath;
      }

      public ExecuteRequest(string url, Func<bool, string> _obterToken, string rootApiPath, bool bearerToken = false)
      {
         Url = url;
         ObterToken = _obterToken;
         RootApiPath = rootApiPath;
         BearerToken = bearerToken;
      }

      public ExecuteRequest(string url, string token, string rootApiPath, bool bearerToken = false)
      {
         Url = url;
         Token = token;
         RootApiPath = rootApiPath;
         BearerToken = bearerToken;
      }

      /// <summary>
      /// Resposanvél por executar requisições para o serviço de emprestimos.
      /// </summary>
      /// <param name="model">Configuração necessário para execução.</param>
      /// <param name="path">Path para execução (https://.../api/v2/emprestimos/{path})</param>
      /// <param name="parameters">Parâmetros para execução</param>
      /// <returns>Retorno completo da solicitação.</returns>
      public ResponseBusModel Request(string path, Dictionary<string, string> parameters = null)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
         // set method http
         var requestFormat = (string.IsNullOrEmpty(path)) ?
                                RootApiPath :
                                string.Format("{0}/{1}", RootApiPath, path);
         var request = new RestRequest(requestFormat, Method.GET);

         // add parameters
         foreach (var item in parameters ?? new Dictionary<string, string>())
            request.AddParameter(item.Key, item.Value);

         // add headers Key and Accept application
         request.AddHeader("accept", "application/json");

         if (BearerToken)
            request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
         else
            request.AddHeader("X-API-KEY", Token);

         // execute the request
         var client = new RestClient(Url);
         IRestResponse response = client.Execute(request);

         // return response
         return new ResponseBusModel
         {
            Content = response.Content,
            StatusCode = response.StatusCode,
            StatusDescription = response.StatusDescription,
            ResponseStatus = (Common.Model.ResponseStatus)response.ResponseStatus,
            ErrorException = response.ErrorException
         };
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="path"></param>
      /// <param name="method"></param>
      /// <param name="parameters"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public ResponseBusModel RequestAuthorizationBasic(string path, Method method, string key)
      {
         // ignore validade certificate
         //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
         //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

         // O protocolo para comunicação com o gateway de API é o HTTP com SSL / TLS(HTTPS), sendo que os protocolos de segurança devem ser a partir do TLS 1.2.
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         // set method http
         var requestFormat = (string.IsNullOrEmpty(path)) ?
                             RootApiPath :
                             string.Format("{0}/{1}", RootApiPath, path);

         var request = new RestRequest(requestFormat, method);

         request.AddHeader("Authorization", string.Format("Basic {0}", key));

         request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

         request.AddParameter("grant_type", "client_credentials");

         // execute the request
         var client = new RestClient(Url);
         IRestResponse response = client.Execute(request);

         // return response
         return new ResponseBusModel
         {
            Content = response.Content,
            StatusCode = response.StatusCode,
            StatusDescription = response.StatusDescription,
            ResponseStatus = (Common.Model.ResponseStatus)response.ResponseStatus,
            ErrorException = response.ErrorException
         };
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="path"></param>
      /// <param name="method"></param>
      /// <param name="parameters"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      /// 
      //TODO: Avaliar
      //      [LogTracer(enableInfo = true, responseSave = true, provider = LogTracerProvider.file)]
#pragma warning disable CS0618 // Type or member is obsolete
      public ResponseBusModel RequestCertificate(string path, Method method, string urlCertificado, string passwordCertificado, IEnumerable<Parameter> parameters = null, object body = null)
#pragma warning restore CS0618 // Type or member is obsolete
      {
         // O protocolo para comunicação com o gateway de API é o HTTP com SSL / TLS(HTTPS), sendo que os protocolos de segurança devem ser a partir do TLS 1.2.
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         ServicePointManager.Expect100Continue = true;
         ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

         // set method http
         var requestFormat = (string.IsNullOrEmpty(path)) ?
                             RootApiPath :
                             string.Format("{0}/{1}", RootApiPath, path);

         var request = new RestRequest(requestFormat, method);

         //request.RequestFormat = DataFormat.Json;

         if (body != null)
            request.AddJsonBody(body);

         // add parameters
         foreach (var item in parameters.OrEmptyIfNull())
            request.AddParameter(item);

         // add headers Key and Accept application
         request.AddHeader("Content-Type", "application/json");

         if (BearerToken)
            request.AddHeader("Authorization", string.Format("Bearer {0}", Token));

         // execute the requests
         var client = new RestClient(Url);

         client.ClientCertificates = new X509CertificateCollection() { new X509Certificate2(urlCertificado, passwordCertificado) };

         IRestResponse response = client.Execute(request);

         // return response
         return new ResponseBusModel
         {
            Content = response.Content,
            StatusCode = response.StatusCode,
            StatusDescription = response.StatusDescription,
            ResponseStatus = (Common.Model.ResponseStatus)response.ResponseStatus,
            ErrorException = response.ErrorException
         };
      }

      public ResponseBusModel RequestAuthorizationAuthO2(string path, Method method, string consumerKey, string consumerSecret, string urlCertificado, string passwordCertificado)
      {
         if (ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         // set method http
         var requestFormat = string.IsNullOrEmpty(path) ? RootApiPath : string.Format("{0}/{1}", RootApiPath, path);

         var request = new RestRequest(requestFormat, method);

         var grant_type = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}", consumerKey, consumerSecret);

         request.AddHeader("cache-control", "no-cache");
         request.AddHeader("content-type", "application/x-www-form-urlencoded");
         request.AddParameter("application/x-www-form-urlencoded", grant_type, ParameterType.RequestBody);

         // execute the request
         var client = new RestClient(Url)
         {
            ClientCertificates = new X509CertificateCollection() { new X509Certificate2(urlCertificado, passwordCertificado) }
         };

         IRestResponse response = client.Execute(request);

         // return response
         return new ResponseBusModel
         {
            Content = response.Content,
            StatusCode = response.StatusCode,
            StatusDescription = response.StatusDescription,
            ResponseStatus = (Common.Model.ResponseStatus)response.ResponseStatus,
            ErrorException = response.ErrorException
         };
      }

      public ResponseBusModel Request(string path, Method method, Dictionary<string, string> parameters = null, object body = null)
      {
         // ignore validade certificate
         //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
         //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         // set method http
         var requestFormat = (string.IsNullOrEmpty(path)) ?
                             RootApiPath :
                             string.Format("{0}/{1}", RootApiPath, path);

         var request = new RestRequest(requestFormat, method);

         request.RequestFormat = DataFormat.Json;

#pragma warning disable CS0618 // Type or member is obsolete
         if (body != null)
            request.AddBody(body);
#pragma warning restore CS0618 // Type or member is obsolete

         // add parameters
         foreach (var item in parameters ?? new Dictionary<string, string>())
            request.AddParameter(item.Key, item.Value);

         // add headers Key and Accept application
         request.AddHeader("accept", "application/json");

         if (BearerToken)
            request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
         else
            request.AddHeader("X-API-KEY", Token);

         // execute the request
         var client = new RestClient(Url);
         IRestResponse response = client.Execute(request);

         // return response
         return new ResponseBusModel
         {
            Content = response.Content,
            StatusCode = response.StatusCode,
            StatusDescription = response.StatusDescription,
            ResponseStatus = (Model.ResponseStatus)response.ResponseStatus,
            ErrorException = response.ErrorException
         };
      }
   }
}
