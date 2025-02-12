using Framework.Data;
using Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   [DataContract]
   public partial class ViewUsuario : EntityBase
   {
      #region Propriedades
      [Key, DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Id")]
      public string Id { get; set; }

      [DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Login")]
      public string Login { get; set; }

      [DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Nome")]
      public string Nome { get; set; }

      [DataMember, JsonProperty("Bloqueado")]
      public bool Bloqueado { get; set; }

      [DataMember, JsonProperty("Habilitado")]
      public bool Habilitado { get; set; }

      [DataLength(250), MaxLength(250), StringLength(250), DataMember, JsonProperty("Email")]
      public string Email { get; set; }

      [DataMember, JsonProperty("DataUltimoLogin")]
      public DateTime? DataUltimoLogin { get; set; }

      [DataMember, JsonProperty("DataRegistro")]
      public DateTime? DataRegistro { get; set; }

      [DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("UsuarioRegistro")]
      public string UsuarioRegistro { get; set; }

      [DataMember, JsonProperty("Departamento")]
      public int? Departamento { get; set; }

      [DataMember, JsonProperty("cpfcnpj")]
      public long? cpfcnpj { get; set; }

      [DataMember, JsonProperty("Promotora")]
      public int? Promotora { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Senha")]
      public string Senha { get; set; }

      [DataMember, JsonProperty("DataUltimaTrocaSenha")]
      public DateTime? DataUltimaTrocaSenha { get; set; }

      [DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("Celular")]
      public string Celular { get; set; }

      [DataMember, JsonProperty("Dominio")]
      public int? Dominio { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("PreferenciaUsuario")]
      public string PreferenciaUsuario { get; set; }

      [DataLength(6), MaxLength(6), StringLength(6), DataMember, JsonProperty("RedeLojas")]
      public string RedeLojas { get; set; }

      [DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Loja")]
      public string Loja { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "ViewUsuario";
         public static readonly FieldReference Id = "ViewUsuario.Id";
         public static readonly FieldReference Login = "ViewUsuario.Login";
         public static readonly FieldReference Nome = "ViewUsuario.Nome";
         public static readonly FieldReference Bloqueado = "ViewUsuario.Bloqueado";
         public static readonly FieldReference Habilitado = "ViewUsuario.Habilitado";
         public static readonly FieldReference Email = "ViewUsuario.Email";
         public static readonly FieldReference DataUltimoLogin = "ViewUsuario.DataUltimoLogin";
         public static readonly FieldReference DataRegistro = "ViewUsuario.DataRegistro";
         public static readonly FieldReference UsuarioRegistro = "ViewUsuario.UsuarioRegistro";
         public static readonly FieldReference Departamento = "ViewUsuario.Departamento";
         public static readonly FieldReference cpfcnpj = "ViewUsuario.cpfcnpj";
         public static readonly FieldReference Promotora = "ViewUsuario.Promotora";
         public static readonly FieldReference Senha = "ViewUsuario.Senha";
         public static readonly FieldReference DataUltimaTrocaSenha = "ViewUsuario.DataUltimaTrocaSenha";
         public static readonly FieldReference Celular = "ViewUsuario.Celular";
         public static readonly FieldReference Dominio = "ViewUsuario.Dominio";
         public static readonly FieldReference PreferenciaUsuario = "ViewUsuario.PreferenciaUsuario";
         public static readonly FieldReference RedeLojas = "ViewUsuario.RedeLojas";
         public static readonly FieldReference Loja = "ViewUsuario.Loja";
      }
      #endregion
   }
}
