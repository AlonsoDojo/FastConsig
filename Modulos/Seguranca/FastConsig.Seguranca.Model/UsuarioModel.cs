using FastConsig.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Model
{
   public class UsuarioModel
   {
      public string Id { get; set; }

      public string Login { get; set; }

      public string Nome { get; set; }

      public bool Bloqueado { get; set; }

      public bool Habilitado { get; set; }

      public string Email { get; set; }

      public DateTime? DataUltimoLogin { get; set; }

      public DateTime? DataRegistro { get; set; }

      public string UsuarioRegistro { get; set; }

      public int? Departamento { get; set; }

      public long? CpfCnpj { get; set; }

      public int? Promotora { get; set; }

      public string Senha { get; set; }

      public DateTime? DataUltimaTrocaSenha { get; set; }

      public string Celular { get; set; }

      public int? Dominio { get; set; }

      public string PreferenciaUsuario { get; set; }

      public int? RedeLojas { get; set; }

      public int? Loja { get; set; }

      public string ClientId { get { return Extensions.Base64Encode(CryptoHelper.Encrypt(string.Concat(Id, ":", Login, ":", Senha, ":", DataRegistro))); } }
   }

}
