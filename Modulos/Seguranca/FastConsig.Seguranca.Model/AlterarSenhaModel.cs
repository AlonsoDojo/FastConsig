using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Model
{
   [Serializable]
   public class AlterarSenhaModel
   {
      public string SenhaAtual { get; set; }
      public string NovaSenha { get; set; }
      public string ConfirmacaoSenha { get; set; }
   }
}
