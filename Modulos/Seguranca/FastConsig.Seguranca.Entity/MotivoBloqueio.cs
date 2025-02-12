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
   public partial class MotivoBloqueio : EntityBase
   {
      #region Propriedades
      [Key, Identity, DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      [DataLength(250), MaxLength(250), StringLength(250), DataMember, JsonProperty("Descricao")]
      public string Descricao { get; set; }

      [ForeignKey, DataMember, JsonProperty("Origem")]
      public int? Origem { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "MotivoBloqueio";
         public static readonly FieldReference Id = "MotivoBloqueio.Id";
         public static readonly FieldReference Descricao = "MotivoBloqueio.Descricao";
         public static readonly FieldReference Origem = "MotivoBloqueio.Origem";
      }
      #endregion
   }
}
