using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Loggin
{
   public class LogInfo
   {
      public int Id { get; set; }

      public string Level { get; set; }

      public string Logger { get; set; }

      public string Component { get; set; }

      public string Message { get; set; }

      public string Request { get; set; }

      public string MethodName { get; set; }

      public string Response { get; set; }

      public string Exception { get; set; }

      public DateTime Date { get; set; }

      public string Proposta { get; set; }

      public string Simulacao { get; set; }

      public string CPFCNPJ { get; set; }

      public string Fase { get; set; }

      public string Event { get; set; }

      public dynamic RequestDictionary { get; set; }

      public dynamic ResponseDictionary { get; set; }

      public LogTracerProvider Provider { get; set; }

      public override string ToString() => JsonConvert.SerializeObject(this);
   }
}
