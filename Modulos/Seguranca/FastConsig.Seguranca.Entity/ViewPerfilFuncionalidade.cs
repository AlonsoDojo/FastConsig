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
   public partial class ViewPerfilFuncionalidade : EntityBase
   {
      #region Propriedades
      [Key]
      public int? IdFuncionalidade { get; set; }

      public int? IdGrupoFuncionalidade { get; set; }

      public int? IdPerfil { get; set; }

      [DataLength(50)]
      public string NomeGrupo { get; set; }

      public short? Sequencia { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      [DataLength(250)]
      public string Url { get; set; }

      public bool Habilitado { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "ViewPerfilFuncionalidade";
         public static readonly FieldReference IdFuncionalidade = "ViewPerfilFuncionalidade.IdFuncionalidade";
         public static readonly FieldReference IdGrupoFuncionalidade = "ViewPerfilFuncionalidade.IdGrupoFuncionalidade";
         public static readonly FieldReference IdPerfil = "ViewPerfilFuncionalidade.IdPerfil";
         public static readonly FieldReference NomeGrupo = "ViewPerfilFuncionalidade.NomeGrupo";
         public static readonly FieldReference Sequencia = "ViewPerfilFuncionalidade.Sequencia";
         public static readonly FieldReference Nome = "ViewPerfilFuncionalidade.Nome";
         public static readonly FieldReference Url = "ViewPerfilFuncionalidade.Url";
         public static readonly FieldReference Habilitado = "ViewPerfilFuncionalidade.Habilitado";
      }
      #endregion
   }
}
