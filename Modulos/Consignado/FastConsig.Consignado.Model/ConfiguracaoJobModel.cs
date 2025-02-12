using FastConsig.Common.Helpers;
using FastConsig.Consignado.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   [Serializable]
   public class ConfiguracaoJobModel
   {
      public int Id { get; set; }

      public int IdJob { get; set; }

      public string NomeJob { get; set; }

      public string Path { get; set; }

      public string HorarioExecucao { get; set; }

      public ParametroExtraModel ParametrosExtras { get; set; }

      public bool Dom { get; set; }

      public bool Seg { get; set; }

      public bool Ter { get; set; }

      public bool Qua { get; set; }

      public bool Qui { get; set; }

      public bool Sex { get; set; }

      public bool Sab { get; set; }

      public bool Habilitado { get; set; }

      public string EmailAvisoConclusao { get; set; }

      public string EmailAvisoErro { get; set; }

      /// <summary>
      /// Quantas tentativas?
      /// </summary>
      public int? TentativasExecucao { get; set; }

      /// <summary>
      /// Aguardar quando tempo para excutar novamente
      /// </summary>
      public int? DelayExecucao { get; set; }

      public DateTime? DataProcessamento { get; set; }

      public long idFila { get; set; }

      public string Environment { get; set; }

      //propriedade usadas só para consulta na tela de configuração job
      public string Parametros { get; set; }

      //propriedade usadas só para consulta na tela de configuração job
      public string HoraIni { get; set; }

      //propriedade usadas só para consulta na tela de configuração job     
      public string HoraFim { get; set; }

      public static implicit operator ConfiguracaoJobModel(ConfiguracaoJob entity)
      {
         if (entity.IdJob == null)
            return null;

         if (entity.Id != null)
            return new ConfiguracaoJobModel()
            {
               EmailAvisoConclusao = entity.EmailAvisoConclusao,
               EmailAvisoErro = entity.EmailAvisoErro,
               Habilitado = entity.Habilitado,
               HorarioExecucao = entity.HorarioExecucao,
               IdJob = entity.IdJob.Value,
               NomeJob = entity.NomeJob,
               ParametrosExtras = string.IsNullOrEmpty(entity.ParametrosExtras)
                  ? null
                  : JsonConvert.DeserializeObject<ParametroExtraModel>(entity.ParametrosExtras,
                     new JsonSerializerSettings
                     { ContractResolver = new IncludeIgnored(true) }),
               TentativasExecucao = entity.TentativasExecucao,
               DelayExecucao = entity.DelayExecucao,
               Dom = entity.Dom,
               Seg = entity.Seg,
               Ter = entity.Ter,
               Qua = entity.Qua,
               Qui = entity.Qui,
               Sex = entity.Sex,
               Sab = entity.Sab,
               Id = entity.Id.Value
            };

         return null;
      }
   }
}
