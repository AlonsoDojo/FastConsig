using FastConsig.Common.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using Newtonsoft.Json;
using Microsoft.Web.Http;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Common.Loggin;

namespace FastConsig.Core.API
{
   /// <summary>
   /// APIs de Dominio
   /// </summary>
   [Authorize]
   [RoutePrefix("api/Dominios")]
   public class DominiosController : ApiBase
   {
      #region Bancos
      /// <summary>
      /// Lista de Bancos
      /// </summary>
      /// <returns>Lista de Bancos</returns>
      [ApiVersion("1")]
      [AcceptVerbs("GET")]
      [Route("v1/ListarBancos")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Bancos>))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage ListarBancosV1()
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               List<Bancos> lista = PropostaService.GetInstance().ListarBancos();
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(lista));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter a Lista de Bancos");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Alterar um Banco
      /// </summary>
      /// <returns>Alterar um Banco</returns>
      [ApiVersion("1")]
      [AcceptVerbs("PUT")]
      [Route("v1/AlterarBanco")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Bancos))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage AlterarBancoV1([FromBody] Bancos banco)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().AlterarBanco(banco);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(banco));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Alterar Banco");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Incluir um Banco
      /// </summary>
      /// <returns>Incluir um Banco</returns>
      [ApiVersion("1")]
      [AcceptVerbs("POST")]
      [Route("v1/IncluirBanco")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Bancos))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage IncluirBancoV1([FromBody] Bancos banco)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().IncluirBanco(banco);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(banco));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Incluir Banco");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }
      #endregion

      #region Promotoras
      /// <summary>
      /// Lista de Promotoras
      /// </summary>
      /// <returns>Lista de Promotoras</returns>
      [ApiVersion("1")]
      [AcceptVerbs("GET")]
      [Route("v1/ListarPromotoras")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Promotoras>))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage ListarOPromotorasV1()
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               List<Promotoras> lista = PropostaService.GetInstance().ListarPromotoras();
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(lista));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter a Lista de Promotoras");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Alterar uma Promotora
      /// </summary>
      /// <returns>Alterar uma Promotora</returns>
      [ApiVersion("1")]
      [AcceptVerbs("PUT")]
      [Route("v1/AlterarPromotora")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Promotoras))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage AlterarPromotoraV1([FromBody] Promotoras promotora)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().AlterarPromotora(promotora);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(promotora));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Alterar Promotora");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Incluir uma Promotora
      /// </summary>
      /// <returns>Incluir uma Promotora</returns>
      [ApiVersion("1")]
      [AcceptVerbs("POST")]
      [Route("v1/IncluirPromotora")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Promotoras))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage IncluirPromotoraV1([FromBody] Promotoras promotora)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().IncluirPromotora(promotora);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(promotora));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Incluir Promotora");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      #endregion

      #region Gerentes
      /// <summary>
      /// Lista de Gerentes
      /// </summary>
      /// <returns>Lista de Gerentes</returns>
      [ApiVersion("1")]
      [AcceptVerbs("GET")]
      [Route("v1/ListarGerentes")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Gerentes>))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage ListarGerntesV1()
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               List<Gerentes> lista = PropostaService.GetInstance().ListarGerente();
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(lista));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter a Lista de Gerentes");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Alterar um Gerente
      /// </summary>
      /// <returns>Alterar um Gerente</returns>
      [ApiVersion("1")]
      [AcceptVerbs("PUT")]
      [Route("v1/AlterarGerente")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Gerentes))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage AlterarGernteV1([FromBody] Gerentes gerente)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().AlterarGerente(gerente);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(gerente));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Alterar o Gerente");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Incluir um Gerente
      /// </summary>
      /// <returns>Incluir um Gerente</returns>
      [ApiVersion("1")]
      [AcceptVerbs("POST")]
      [Route("v1/IncluirGerente")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Gerentes))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage IncluirGernteV1([FromBody] Gerentes gerente)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().IncluirGerente(gerente);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(gerente));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter ao Incluir o Gerente");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }
      #endregion

      #region Rede de Lojas
      /// <summary>
      /// Lista de Rede de Lojas
      /// </summary>
      /// <returns>Lista de Rede de Lojas</returns>
      [ApiVersion("1")]
      [AcceptVerbs("GET")]
      [Route("v1/ListarRedeLojas")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<RedeLoja>))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage ListarRedeLojasV1()
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               List<RedeLoja> lista = PropostaService.GetInstance().ListarRedeLoja();
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(lista));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter a Lista de Rede de Lojas");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Alterar uma Rede de Lojas
      /// </summary>
      /// <returns>Alterar uma Rede de Lojas</returns>
      [ApiVersion("1")]
      [AcceptVerbs("PUT")]
      [Route("v1/AlterarRedeLojas")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(RedeLoja))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage AlterarRedeLojasV1([FromBody] RedeLoja redeloja)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().AlterarRedeLojas(redeloja);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(redeloja));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Alterar a Rede de Lojas");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Incluir uma Rede de Lojas
      /// </summary>
      /// <returns>Incluir uma Rede de Lojas</returns>
      [ApiVersion("1")]
      [AcceptVerbs("POST")]
      [Route("v1/IncluirRedeLojas")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(RedeLoja))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      public HttpResponseMessage IncluirRedeLojasV1([FromBody] RedeLoja redeloja)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().IncluirRedeLojas(redeloja);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(redeloja));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Incluir a Rede de Lojas");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      #endregion

      #region Lojas
      /// <summary>
      /// Lista de Lojas
      /// </summary>
      /// <returns>Lista de Lojas</returns>
      [ApiVersion("1")]
      [AcceptVerbs("GET")]
      [Route("v1/ListarLojas")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Lojas>))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage ListarLojasV1()
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               List<Lojas> lista = PropostaService.GetInstance().ListarLojas();
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(lista));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Obter a Lista de Lojas");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Alterar uma Loja
      /// </summary>
      /// <returns>Alterar uma Loja</returns>
      [ApiVersion("1")]
      [AcceptVerbs("PUT")]
      [Route("v1/AlterarLoja")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Lojas))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage AlterarLojaV1([FromBody] Lojas loja)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().AlterarLoja(loja);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(loja));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Alterar a Loja");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }

      /// <summary>
      /// Incluir uma Loja
      /// </summary>
      /// <returns>Incluir uma Loja</returns>
      [ApiVersion("1")]
      [AcceptVerbs("POST")]
      [Route("v1/IncluirLoja")]
      [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Lojas))]
      [SwaggerResponse(HttpStatusCode.Forbidden, Type = typeof(string))]
      [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
      [AllowAnonymous]
      public HttpResponseMessage IncluirLojaV1([FromBody] Lojas loja)
      {
         InfoRequest();
         HttpResponseMessage response = new HttpResponseMessage();

         try
         {
            try
            {
               PropostaService.GetInstance().IncluirLoja(loja);
               response.StatusCode = HttpStatusCode.OK;
               response.Content = new StringContent(JsonConvert.SerializeObject(loja));
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }
            catch (Exception ex)
            {
               response.StatusCode = HttpStatusCode.InternalServerError;
               response.Content = new StringContent(ex.Message);
               response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               LogService.GetInstance().GravarLogErro(ex, "Erro ao Incluir a Loja");
            }
            return response;
         }
         catch (UnauthorizedAccessException ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.Forbidden, ex.Message);
         }
         catch (Exception ex)
         {
            InfoRequest(ex);

            return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
         }
      }
      #endregion

   }
}