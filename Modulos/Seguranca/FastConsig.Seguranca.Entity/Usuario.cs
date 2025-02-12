using Framework.Data;
using Framework;
using System;
using System.ComponentModel.DataAnnotations;
using FastConsig.Common.Helpers;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   public partial class Usuario : EntityBase
   {
      #region Propriedades
      [Key, DataLength(50)]
      public string Id { get; set; }

      [DataLength(100)]
      public string Login { get; set; }

      [DataLength(100)]
      public string Nome { get; set; }

      public bool Bloqueado { get; set; }

      public bool Habilitado { get; set; }

      [DataLength(250)]
      public string Email { get; set; }

      public DateTime? DataUltimoLogin { get; set; }

      public DateTime? DataRegistro { get; set; }

      [DataLength(100)]
      public string UsuarioRegistro { get; set; }

      [DataLength(100)]
      public decimal? Departamento { get; set; }
      public long? CpfCnpj { get; set; }

      public int? Promotora { get; set; }

      public string Senha { get; set; }

      public DateTime? DataUltimaTrocaSenha { get; set; }

      public string Celular { get; set; }

      public int? Dominio { get; set; }

      public string PreferenciaUsuario { get; set; }

      public int? RedeLojas { get; set; }

      public int? Loja { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Usuario";
         public static readonly FieldReference Id = "Usuario.Id";
         public static readonly FieldReference Login = "Usuario.Login";
         public static readonly FieldReference Nome = "Usuario.Nome";
         public static readonly FieldReference Bloqueado = "Usuario.Bloqueado";
         public static readonly FieldReference Habilitado = "Usuario.Habilitado";
         public static readonly FieldReference Email = "Usuario.Email";
         public static readonly FieldReference DataUltimoLogin = "Usuario.DataUltimoLogin";
         public static readonly FieldReference DataRegistro = "Usuario.DataRegistro";
         public static readonly FieldReference UsuarioRegistro = "Usuario.UsuarioRegistro";
         public static readonly FieldReference Departamento = "Usuario.Departamento";
         public static readonly FieldReference CpfCnpj = "Usuario.CpfCnpj";
         public static readonly FieldReference Promotora = "Usuario.Promotora";
         public static readonly FieldReference Senha = "Usuario.Senha";
         public static readonly FieldReference DataUltimaTrocaSenha = "Usuario.DataUltimaTrocaSenha";
         public static readonly FieldReference Celular = "Usuario.Celular";
         public static readonly FieldReference Dominio = "Usuario.Dominio";
         public static readonly FieldReference PreferenciaUsuario = "Usuario.PreferenciaUsuario";
         public static readonly FieldReference RedeLojas = "Usuario.RedeLojas";
         public static readonly FieldReference Loja = "Usuario.Loja";
      }
      #endregion

      public int? TipoAutenticacao { get; set; }
      public string URLDominio { get; set; }
      public string CpfCnpjFormatado
      {
         get
         {
            if (UtilityHelper.IsCpf(UtilityHelper.ExtractNumber($"{this.CpfCnpj:00000000000}")))
            {
               return Extensions.FormatCPF(UtilityHelper.ExtractNumber($"{this.CpfCnpj:00000000000}"));
            }
            else if (this.CpfCnpj == null)
            {
               return null;
            }
            else
            {
               return Extensions.FormatCNPJ(UtilityHelper.ExtractNumber($"{this.CpfCnpj:00000000000000}"));
            }
         }

         set
         {
            if (this.CpfCnpjFormatado != null)
               this.CpfCnpj = long.Parse(UtilityHelper.ExtractNumber(this.CpfCnpjFormatado));
         }
      }
      public string HabilitadoFormatado
      {
         get
         {
            return "<span id=\"MainContent_UsuarioRepeater_lblBloqueado_0\" class=\"" + (this.Habilitado ? "fa fa-check" : "fa fa-ban") + "\" aria-hidden=\"true\"></span>";
         }
      }
      public string BloqueadoFormatado
      {
         get
         {
            return "<span id=\"MainContent_UsuarioRepeater_lblBloqueado_0\" class=\"" + (this.Bloqueado ? "fa fa-check" : "fa fa-ban") + "\" aria-hidden=\"true\"></span>";
         }
      }

      public string UsuarioFormatado
      {
         get
         {
            return URLDominio + "\\" + this.Login;
         }
      }
      public string IdFormatado
      {
         get
         {
            return "<a id=\"MainContent_PropostasRepeater_EditarProposta_" + Id + "title=\"Editar\" class=\"glyphicon glyphicon-edit\" href=\"javascript:DoPostBackManual('" + Id + "')\"></a>";
         }
      }

   }
}
