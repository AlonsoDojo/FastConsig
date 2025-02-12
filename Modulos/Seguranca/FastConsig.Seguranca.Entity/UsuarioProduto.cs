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
   public partial class UsuarioProduto : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [ForeignKey, DataLength(50)]
      public string Usuario { get; set; }

      public int Produto { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "UsuarioProduto";
         public static readonly FieldReference Id = "UsuarioProduto.Id";
         public static readonly FieldReference Usuario = "UsuarioProduto.Usuario";
         public static readonly FieldReference Produto = "UsuarioProduto.Produto";
      }
      #endregion
   }
}
