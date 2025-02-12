using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Scheduler.Entity
{
   [Serializable]
   public partial class PoliticaExecucaoTarefa : EntityBase
   {
      #region Propriedades
      [Key, Identity]
      public int? Id { get; set; }

      public int? TipoTarefa { get; set; }

      public int? Politica { get; set; }

      public int? Peso { get; set; }

      public bool Validacao { get; set; }

      public bool Execucao { get; set; }

      public bool Erro { get; set; }

      public bool Exito { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "PoliticaExecucaoTarefa";
         public static readonly FieldReference Id = "PoliticaExecucaoTarefa.Id";
         public static readonly FieldReference TipoTarefa = "PoliticaExecucaoTarefa.TipoTarefa";
         public static readonly FieldReference Politica = "PoliticaExecucaoTarefa.Politica";
         public static readonly FieldReference Peso = "PoliticaExecucaoTarefa.Peso";
         public static readonly FieldReference Validacao = "PoliticaExecucaoTarefa.Validacao";
         public static readonly FieldReference Execucao = "PoliticaExecucaoTarefa.Execucao";
         public static readonly FieldReference Erro = "PoliticaExecucaoTarefa.Erro";
         public static readonly FieldReference Exito = "PoliticaExecucaoTarefa.Exito";
      }
      #endregion
   }
}
