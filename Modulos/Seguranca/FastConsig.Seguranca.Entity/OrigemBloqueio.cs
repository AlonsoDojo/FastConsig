using Framework.Data;
using Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   [DataContract]
   public partial class OrigemBloqueio : EntityBase
   {
      #region Propriedades
      [Key, Identity, DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      [DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
      public string Descricao { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "OrigemBloqueio";
         public static readonly FieldReference Id = "OrigemBloqueio.Id";
         public static readonly FieldReference Descricao = "OrigemBloqueio.Descricao";
      }
      #endregion
   }
}
