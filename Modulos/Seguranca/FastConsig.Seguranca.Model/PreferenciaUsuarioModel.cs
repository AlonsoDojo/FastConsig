using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Model
{
   /// <summary>
   /// Preferências do usuário
   /// </summary>
   [Serializable]
   public class PreferenciaUsuarioModel
   {
      /// <summary>
      /// Página padrão do usuário.
      /// </summary>
      public string paginaInicial { get; set; }

      /// <summary>
      /// Tempo padrão para atualização da página de Monitor de Propostas.
      /// </summary>
      public int tempoRefreshPadrao { get; set; }

      //TODO: Criar um objeto para colocar por tela
      public bool monitorPropostaOrdenacaoDataCriacao { get; set; }
   }
}
