using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Model
{
   [Serializable]
   public class ConfiguracaoRequestModel
   {
      /// <summary>
      /// Endereço para o serviço no Barramento.
      /// </summary>
      public string Url { get; set; }

      /// <summary>
      /// Token de seguranço do serviço no Barramento.
      /// </summary>
      public string Token { get; set; }

      /// <summary>
      /// Username para autenticação
      /// </summary>
      public string Username { get; set; }

      /// <summary>
      /// Password para autenticação
      /// </summary>
      public string Password { get; set; }


   }
}
