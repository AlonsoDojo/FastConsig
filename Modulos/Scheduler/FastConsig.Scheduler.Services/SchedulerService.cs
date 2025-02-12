using Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Hangfire;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using FastConsig.Scheduler.Entity;
using FastConsig.Common.Loggin;
using FastConsig.Scheduler.Business;
using FastConsig.Scheduler.Model;

namespace FastConsig.Scheduler.Services
{
   public class SchedulerService
   {
      #region "Instância"
      private static SchedulerService _instance;

#pragma warning disable CS0649
      private readonly IServiceProvider serviceProvider;
#pragma warning restore CS0649

      private SchedulerService()
      {

      }
      public static SchedulerService GetInstance()
      {
         if (_instance == null)
            _instance = new SchedulerService();

         return _instance;
      }
      #endregion

      public string[] ListarFilas()
      {
         var filas = new FilaBusiness().Listar(null);
         var retorno = new string[filas.Count];
         int i = 0;
         foreach (var fila in filas)
         {
            retorno[i] = fila.Nome.ToLower();
            i++;
         }
         return retorno;
      }

      public List<TipoAgenda> ListarTipoAgenda()
      {
         return new TipoAgendaBusiness().Listar(null);
      }

      public List<TipoTarefa> ListarTipoTarefa()
      {
         return new TipoTarefaBusiness().Listar(null);
      }

      public List<Fila> ListarFila()
      {
         return new FilaBusiness().Listar(null);
      }

      public List<Tarefa> ListarTarefasRecorrentes()
      {
         return new TarefasBusiness().Listar(WhereBuilder.Create().Add(Tarefa.METADADO.TipoTarefa, Filter.Equal, 1));
      }

      [DisplayName("{5} (Job#{0}) => {2}")]
      [Queue("{4}")]
      public void InvokeJob(long jobId, string assemblyName, string className, string methodName, string fila, string nome, string[] parametros = null)
      {
         Type job = Type.GetType($"{className}, {assemblyName}");

         Object classInstance = ActivatorUtilities.CreateInstance(serviceProvider, job);
         MethodInfo method = job.GetMethod(methodName);

         object[] jobParameters = parametros;

         method.Invoke(classInstance, jobParameters);
      }

      public List<PoliticaExecucaoTarefa> ListarPoliticasTarefa(long tarefa)
      {
         return new PoliticaExecucaoTarefaBusiness().Listar(WhereBuilder.Create().Add(PoliticaExecucaoTarefa.METADADO.Id, Filter.Equal, tarefa)).OrderBy(x => x.Peso).ToList();
      }

      public void ExecutaPolitica(string politica, string parametros)
      {
         Type t = Type.GetType(politica + ", FastConsig.Scheduler.Politicas");
         dynamic o = Activator.CreateInstance(t) as IPoliticaJOB;
         o.Execute(parametros);
      }

      #region "Fila de Processamento"
      public FilaProcessamentoAssincrona CriarFilaProcessamento(FilaProcessamentoAssincrona fila)
      {
         new FilaProcessamentoAssincronaBusiness().Incluir(fila);
         return fila;
      }

      public FilaProcessamentoAssincrona AlterarFilaProcessamento(FilaProcessamentoAssincrona fila)
      {
         new FilaProcessamentoAssincronaBusiness().Alterar(fila);
         return fila;
      }

      public FilaProcessamentoAssincrona ObterFilaProcessamento(int fila)
      {
         FilaProcessamentoAssincrona retorno = new FilaProcessamentoAssincronaBusiness().Obtem(fila);
         return retorno;
      }

      public Tarefa ObtemTarefa(int? tarefa)
      {
         return new TarefasBusiness().Obtem(tarefa);
      }

      public void ExcluirTarefa(int? tarefa)
      {
         new TarefasBusiness().Excluir(tarefa);
      }
      public void SalvarTarefa(Tarefa tarefa)
      {
         if (tarefa.Id == null || tarefa.Id == 0)
         {
            new TarefasBusiness().Incluir(tarefa);
         } else
         {
            new TarefasBusiness().Alterar(tarefa);
         }
      }

      public dynamic BuscaParametrosTarefa(string nomeTarefa)
      {
         var tarefa = new TarefasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Tarefa.METADADO.ClassName, Filter.Equal, nomeTarefa)).FirstOrDefault();

         if (!string.IsNullOrEmpty(tarefa.Parametros))
         {
            return JsonConvert.DeserializeObject<dynamic>(tarefa.Parametros);
         }
         else return null;
      }

      public T BuscaParametrosTarefa<T>(string nomeTarefa) where T : new()
      {
         // Busca a tarefa pelo nome
         var tarefa = new TarefasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Tarefa.METADADO.ClassName, Filter.Equal, nomeTarefa)).FirstOrDefault();

         // Verifica se os parâmetros da tarefa não estão vazios
         if (!string.IsNullOrEmpty(tarefa?.Parametros))
         {
            try
            {
               // Tenta desserializar os parâmetros da tarefa para o tipo T
               return JsonConvert.DeserializeObject<T>(tarefa.Parametros);
            }
            catch (JsonException ex)
            {
               // Captura e trata a exceção de desserialização
               LogService.GetInstance().GravarLogWarning(ex, $"Erro ao desserializar os parâmetros: {ex.Message}");
               // Retorna uma nova instância de T em caso de falha
               return new T();
            }
         }

         // Retorna uma nova instância de T se os parâmetros estiverem vazios ou nulos
         return new T();
      }
      #endregion
   }
}
