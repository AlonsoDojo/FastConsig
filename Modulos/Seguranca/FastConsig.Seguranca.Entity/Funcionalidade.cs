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
   public partial class Funcionalidade : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [ForeignKey]
      public int? IdGrupoFuncionalidade { get; set; }

      [DataLength(50)]
      public string Nome { get; set; }

      [DataLength(75)]
      public string Titulo { get; set; }

      [DataLength(2147483647)]
      public string Descricao { get; set; }

      [DataLength(250)]
      public string Url { get; set; }

      public bool Habilitado { get; set; }

      public short? Sequencia { get; set; }

      public bool Visivel { get; set; }

      public string SistemaId { get; set; }
      
      public string NomeGrupo { get; set; }
      
      public string HabilitadoTexto
      {
         get { return Habilitado ? "Sim" : "Não"; }
      }
      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Funcionalidade";
         public static readonly FieldReference Id = "Funcionalidade.Id";
         public static readonly FieldReference IdGrupoFuncionalidade = "Funcionalidade.IdGrupoFuncionalidade";
         public static readonly FieldReference Nome = "Funcionalidade.Nome";
         public static readonly FieldReference Titulo = "Funcionalidade.Titulo";
         public static readonly FieldReference Descricao = "Funcionalidade.Descricao";
         public static readonly FieldReference Url = "Funcionalidade.Url";
         public static readonly FieldReference Habilitado = "Funcionalidade.Habilitado";
         public static readonly FieldReference Sequencia = "Funcionalidade.Sequencia";
         public static readonly FieldReference Visivel = "Funcionalidade.Visivel";
      }
      #endregion
   }
}
