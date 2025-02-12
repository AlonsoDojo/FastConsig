using FastConsig.Seguranca.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Model
{
   [Serializable]
   public class PermissaoUsuarioModel
   {
      public List<ViewPermissaoUsuario> Permissoes { get; set; }
      public List<ViewPerfilUsuario> Perfis { get; set; }
   }
}
