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
   public partial class Perfil : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      public bool Habilitado { get; set; }

      public bool Externo { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Perfil";
         public static readonly FieldReference Id = "Perfil.Id";
         public static readonly FieldReference Nome = "Perfil.Nome";
         public static readonly FieldReference Habilitado = "Perfil.Habilitado";
         public static readonly FieldReference Externo = "Perfil.Externo";
      }
      #endregion
   }
}
