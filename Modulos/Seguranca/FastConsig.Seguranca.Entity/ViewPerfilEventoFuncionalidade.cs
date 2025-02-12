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
   public partial class ViewPerfilEventoFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key]
      public int? Id { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      public int? PerfilEventoFuncionalidadeId { get; set; }

      public bool Habilitado { get; set; }

      public int? IdPerfilFuncionalidade { get; set; }

      public int? IdFuncionalidade { get; set; }

      public int? IdPerfil { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "ViewPerfilEventoFuncionalidade";
         public static readonly FieldReference Id = "ViewPerfilEventoFuncionalidade.Id";
         public static readonly FieldReference Nome = "ViewPerfilEventoFuncionalidade.Nome";
         public static readonly FieldReference PerfilEventoFuncionalidadeId = "ViewPerfilEventoFuncionalidade.PerfilEventoFuncionalidadeId";
         public static readonly FieldReference Habilitado = "ViewPerfilEventoFuncionalidade.Habilitado";
         public static readonly FieldReference IdPerfilFuncionalidade = "ViewPerfilEventoFuncionalidade.IdPerfilFuncionalidade";
         public static readonly FieldReference IdFuncionalidade = "ViewPerfilEventoFuncionalidade.IdFuncionalidade";
         public static readonly FieldReference IdPerfil = "ViewPerfilEventoFuncionalidade.IdPerfil";
      }
      #endregion
   }
}
