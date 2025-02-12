using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   public partial class ViewPermissaoUsuario : EntityBase
   {
      #region Propriedades
      [Key, DataLength(50)]
      public string IdUsuario { get; set; }

      [DataLength(100)]
      public string Login { get; set; }

      public int? IdGrupo { get; set; }

      public int? IdPerfil { get; set; }

      [DataLength(50)]
      public string NomeGrupo { get; set; }

      public int? Ordem { get; set; }

      [DataLength(50)]
      public string IconeGrupo { get; set; }

      public int? IdFuncionalidade { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      [DataLength(75)]
      public string Titulo { get; set; }

      [DataLength(2147483647)]
      public string Descricao { get; set; }

      [DataLength(2147483647)]
      public string NomeAcao { get; set; }

      [DataLength(250)]
      public string Url { get; set; }

      public short? Sequencia { get; set; }

      [DataLength(50)]
      public string SistemaId { get; set; }

      [DataLength(5)]
      public string SistemaSigla { get; set; }

      public bool Visivel { get; set; }

      public bool? Habilitado { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "ViewPermissaoUsuario";
         public static readonly FieldReference IdUsuario = "ViewPermissaoUsuario.IdUsuario";
         public static readonly FieldReference Login = "ViewPermissaoUsuario.Login";
         public static readonly FieldReference IdGrupo = "ViewPermissaoUsuario.IdGrupo";
         public static readonly FieldReference NomeGrupo = "ViewPermissaoUsuario.NomeGrupo";
         public static readonly FieldReference Ordem = "ViewPermissaoUsuario.Ordem";
         public static readonly FieldReference IconeGrupo = "ViewPermissaoUsuario.IconeGrupo";
         public static readonly FieldReference IdFuncionalidade = "ViewPermissaoUsuario.IdFuncionalidade";
         public static readonly FieldReference Nome = "ViewPermissaoUsuario.Nome";
         public static readonly FieldReference Titulo = "ViewPermissaoUsuario.Titulo";
         public static readonly FieldReference Descricao = "ViewPermissaoUsuario.Descricao";
         public static readonly FieldReference Url = "ViewPermissaoUsuario.Url";
         public static readonly FieldReference Sequencia = "ViewPermissaoUsuario.Sequencia";
         public static readonly FieldReference IdPerfil = "ViewPermissaoUsuario.IdPerfil";
         public static readonly FieldReference Visivel = "ViewPermissaoUsuario.Visivel";
         public static readonly FieldReference NomeAcao = "ViewPermissaoUsuario.NomeAcao";
         public static readonly FieldReference Habilitado = "ViewPermissaoUsuario.Habilitado";
      }
      #endregion
   }
}
