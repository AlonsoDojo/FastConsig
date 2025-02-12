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
   public partial class EventoFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      [ForeignKey]
      public int? IdFuncionalidade { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "EventoFuncionalidade";
         public static readonly FieldReference Id = "EventoFuncionalidade.Id";
         public static readonly FieldReference Nome = "EventoFuncionalidade.Nome";
         public static readonly FieldReference IdFuncionalidade = "EventoFuncionalidade.IdFuncionalidade";
      }
      #endregion
   }
}
