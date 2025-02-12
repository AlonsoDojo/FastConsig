using System;

namespace FastConsig.CTC.Model
{
   [Serializable]
   public class FiltroMonitorArquivosModel
   {
      public DateTime? DataInicial { get; set; }
      public DateTime? DataFinal { get; set; }
      public string Arquivo { get; set; }
      public string ISPBOrigem { get; set; }
      public string ISPBDestino { get; set; }
      public int? TipoArquivo { get; set; }
      public string Contrato { get; set; }
      public string CPF { get; set; }
      public int? Fase { get; set; }
      public string NUPortabilidade { get; set; }
   }
}
