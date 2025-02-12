using Framework;
using Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   public partial class Dominio : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(100)]
      public string URL { get; set; }

      [DataLength(100)]
      public string Descricao { get; set; }

      public int? TipoAutenticacao { get; set; }
      public bool Ativo { get; set; }
      public string TipoAutenticacaoDescricao { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Dominio";
         public static readonly FieldReference Id = "Dominio.Id";
         public static readonly FieldReference URL = "Dominio.URL";
         public static readonly FieldReference Descricao = "Dominio.Descricao";
         public static readonly FieldReference TipoAutenticacao = "Dominio.TipoAutenticacao";
         public static readonly FieldReference Ativo = "Dominio.Ativo";
      }
      #endregion
   }
}
