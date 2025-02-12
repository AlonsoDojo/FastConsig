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
   public partial class TipoAutenticacao : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(50)]
      public string Descricao { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "TipoAutenticacao";
         public static readonly FieldReference Id = "TipoAutenticacao.Id";
         public static readonly FieldReference Descricao = "TipoAutenticacao.Descricao";
      }
      #endregion
   }
}
