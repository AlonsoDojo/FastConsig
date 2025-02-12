using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   [Serializable]
   public class Excecao
   {
      //Id da configuração job
      public int? Id { get; set; }

      /// <summary>
      /// Dia que não pode rodar
      /// </summary>
      public DateTime DataInicio { get; set; }

      /// <summary>
      /// Dia que não pode rodar
      /// </summary>
      public DateTime DataFim { get; set; }

      /// <summary>
      /// Horário inicial da execução.
      /// </summary>
      public string HorarioInicial { get; set; }

      /// <summary>
      /// Horário final de execução.
      /// </summary>
      public string HorarioFinal { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public string Motivo { get; set; }
   }
}
