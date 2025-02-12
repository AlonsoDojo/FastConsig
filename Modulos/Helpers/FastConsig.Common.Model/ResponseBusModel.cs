using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Model
{
   [Serializable]
   public class ResponseBusModel
   {
      /// <summary>
      /// Retorno da requisição.
      /// </summary>
      public string Content { get; set; }

      /// <summary>
      /// Status da requisição http.
      /// Status: 200 - Execução com sucesso.
      /// Status: 400 - Solicitação inválida para pesquisa.
      /// Status: 403 - Token inválido.
      /// Status: 500 - Erro interno do servidor.
      /// </summary>
      public HttpStatusCode StatusCode { get; set; }

      /// <summary>
      /// Descrição do status
      /// </summary>
      public string StatusDescription { get; set; }

      /// <summary>
      /// Status de resposta
      /// </summary>
      public ResponseStatus ResponseStatus { get; set; }

      /// <summary>
      /// Exceção
      /// </summary>
      public Exception ErrorException { get; set; }
   }

   /// <summary>
   /// Status de resposta
   /// </summary>
   public enum ResponseStatus
   {
      None = 0,
      Completed = 1,
      Error = 2,
      TimedOut = 3,
      Aborted = 4
   }
}
