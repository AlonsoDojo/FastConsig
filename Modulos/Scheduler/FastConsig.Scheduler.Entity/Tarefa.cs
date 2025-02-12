using Framework;
using Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace FastConsig.Scheduler.Entity
{
   [Serializable]
   public partial class Tarefa : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      [ForeignKey]
      public int? TipoTarefa { get; set; }

      [ForeignKey]
      public int? TipoAgenda { get; set; }

      [ForeignKey]
      public int? Fila { get; set; }

      [DataLength(100)]
      public string Agenda { get; set; }

      [DataLength(200)]
      public string Assembly { get; set; }

      [DataLength(200)]
      public string ClassName { get; set; }

      [DataLength(200)]
      public string Nome { get; set; }

      [DataLength(2147483647)]
      public string Parametros { get; set; }

      public string NomeFila { get; set; }
      public bool Ativo { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "Tarefas";
         public static readonly FieldReference Id = "Tarefas.Id";
         public static readonly FieldReference TipoTarefa = "Tarefas.TipoTarefa";
         public static readonly FieldReference TipoAgenda = "Tarefas.TipoAgenda";
         public static readonly FieldReference Fila = "Tarefas.Fila";
         public static readonly FieldReference Agenda = "Tarefas.Agenda";
         public static readonly FieldReference Assembly = "Tarefas.Assembly";
         public static readonly FieldReference ClassName = "Tarefas.ClassName";
         public static readonly FieldReference Nome = "Tarefas.Nome";
         public static readonly FieldReference Parametros = "Tarefas.Parametros";
         public static readonly FieldReference Ativo = "Tarefas.Ativo";
      }
      #endregion
   }
}
