using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using log4net;
using Newtonsoft.Json;
using FastConsig.Common.Helpers;
using System.Web.Script.Serialization;
using System.Configuration;
using Dapper;

namespace FastConsig.Common.Loggin
{
   public class LogService
   {
      #region *------- Implementação do Singleton -------*

      /// <summary>Instância do serviço de log.</summary>
      private static LogService _instance;

      private static ILog _logInstance = null;
      private static object _lockObj = new object();

      private LogService()
      {
         #region *------- Inicialização do arquivo de log -------*

         log4net.Config.XmlConfigurator.Configure();

         _logInstance = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

         #endregion
      }

      public void GravarLogWarning(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         _logInstance?.Warn(mensagem);
      }

      public void GravarLogWarning(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         log4net.ThreadContext.Properties["InnerException"] = ExceptionToJson(ex);
         _logInstance?.Warn(mensagem, ex);
      }

      public void GravarLogFatal(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         log4net.ThreadContext.Properties["InnerException"] = ExceptionToJson(ex);
         _logInstance?.Fatal(mensagem, ex);
      }

      public void GravarLogInfo(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         _logInstance?.Info(mensagem);
      }


      public void GravarLogErro(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         log4net.ThreadContext.Properties["InnerException"] = ExceptionToJson(ex);
         _logInstance?.Error(mensagem, ex);
      }

      public void GravarLogDebug(string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         _logInstance?.Debug(mensagem);
      }
      public void GravarLogDebug(Exception ex, string mensagem, object parameters = null, [CallerMemberName] string methodName = null, [CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = 0)
      {
         log4net.ThreadContext.Properties["MethodName"] = methodName;
         log4net.ThreadContext.Properties["FilePath"] = sourceFilePath;
         log4net.ThreadContext.Properties["LineNumber"] = sourceLineNumber;
         log4net.ThreadContext.Properties["InnerException"] = ExceptionToJson(ex);
         log4net.ThreadContext.Properties["Parameters"] = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
         _logInstance?.Debug(mensagem);
      }

      public void SetApplication(string application)
      {
         log4net.GlobalContext.Properties["Application"] = application;
      }

      public void SetApplicationGuid(string applicationGuid)
      {
         log4net.GlobalContext.Properties["ApplicationGuid"] = applicationGuid;
      }

      public void SetApplicationEnvironment(string environment)
      {
         log4net.GlobalContext.Properties["Environment"] = environment;
      }

      public void SetApplicationLogName(string name)
      {
         log4net.GlobalContext.Properties["LogName"] = name;
      }

      public void SetUser(string user)
      {
         log4net.GlobalContext.Properties["User"] = user;
      }

      /// <summary>
      /// Recupera até o terceiro nível de exception
      /// </summary>
      /// <param name="exception"></param>
      /// <returns></returns>
      public static string ExceptionToJson(Exception exception)
      {
         if (exception == null)
            return string.Empty;

         var error = new Dictionary<string, string>
                {
                    {"Type", exception.GetType().ToString()},
                    {"Message", exception.Message},
                    {"InnerException 1", exception.InnerException?.Message ?? string.Empty },
                    {"InnerException 2", exception.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 3", exception.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 4", exception.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 5", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 6", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 7", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 8", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"StackTrace", exception.StackTrace}
                };

         foreach (DictionaryEntry data in exception.Data) error.Add(data.Key.ToString(), data.Value.ToString());

         return JsonConvert.SerializeObject(error, Newtonsoft.Json.Formatting.Indented);
      }

      /// <summary>
      /// Obtém a instância do serviço de gravação de log.
      /// </summary>
      /// <returns></returns>
      public static LogService GetInstance()
      {
         if (_instance == null)
            _instance = new LogService();

         return _instance;
      }

      #endregion

      #region *------- Log File -------*

      /// <summary>
      /// Gravar log em arquivo
      /// </summary>
      /// <param name="ex"></param>
      /// <param name="mensagem"></param>
      public void Error(Exception ex, string mensagem) => _logInstance?.Error(mensagem, ex);

      public void Info(string mensagem) => _logInstance?.Info(mensagem);

      public void Error(LogTracerProvider provider, string cpfCnpj, string component = null, string message = null, string request = null, [CallerMemberName] string methodName = null, string response = null, Exception exception = null, string proposta = null, string simulacao = null, string fase = null, string _event = null)
      {
         // create model
         var model = new LogInfo
         {

            Level = "Error",
            Logger = "LogTracer",
            CPFCNPJ = cpfCnpj,
            //Key = key,
            Component = component,
            Message = message,
            Request = request,
            MethodName = methodName,
            Response = response,
            //Custom = custom,
            Date = DateTime.Now,
            Exception = Extensions.ExceptionToJson(exception),
            Proposta = proposta,
            Simulacao = simulacao,
            Fase = fase,
            Event = _event,
            Provider = provider
         };

         // persit model
         Log(model);
      }

      public void Info(LogTracerProvider provider, string cpfCnpj, string component = null, string message = null, string request = null, [CallerMemberName] string methodName = null, string response = null, Exception exception = null, string proposta = null, string simulacao = null, string fase = null, string _event = null)
      {
         // create model
         var model = new LogInfo
         {
            Level = "Info",
            Logger = "LogTracer",
            CPFCNPJ = cpfCnpj,
            //Key = key,
            Component = component,
            Message = message,
            Request = request,
            MethodName = methodName,
            Response = response,
            //Custom = custom,
            Date = DateTime.Now,
            Exception = Extensions.ExceptionToJson(exception),
            Proposta = proposta,
            Simulacao = simulacao,
            Fase = fase,
            Event = _event,
            Provider = provider
         };

         // persit model
         Log(model);
      }



      #endregion

      /// <summary>
      /// Salva um LogTransaction
      /// </summary>
      /// <param name="obj"></param>
      protected void Log(LogInfo logInfo)
      {
         if (ConfigurationManager.ConnectionStrings["LogConnection"] == null)
            throw new Exception("LogConnection está nulo.");

         try
         {
            if (logInfo.Provider == LogTracerProvider.file)
            {
               Info(Newtonsoft.Json.JsonConvert.SerializeObject(logInfo));
            }
            else
            {
               using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
               {
                  /*
                     CREATE TABLE FastConsig.dbo.Log (
                        Id int IDENTITY(1,1) NOT NULL,
                        [Level] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
                        Logger varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
                        Component varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
                        Message varchar(4000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        Request varchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        MethodName varchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
                        CPFCNPJ varchar(8000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        Response varchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        [Exception] varchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        [Date] datetime NOT NULL,
                        Proposta bigint NULL,
                        Simulacao bigint NULL,
                        Fase varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
                        Event varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
                     );
                   */

                  string insertQuery = @"INSERT INTO Log ([Level], Logger, Component, Message, Request, MethodName, CPFCNPJ, Response, [Exception], [Date], [Proposta], [Simulacao], [Fase], [Event]) VALUES (@Level, @Logger, @Component, @Message, @Request, @MethodName, @CPFCNPJ, @Response, @Exception, @Date, @Proposta, @Simulacao, @Fase, @Event);";

                  var result = db.Execute(insertQuery, logInfo);
               }
            }
         }
         catch (TimeoutException)
         {

         }
         catch (Exception ex)
         {
            /*
                Ocorreu algum erro ao tentar gravar o log em tabela?
                Então log em arquivo
             */

            Error(ex, String.Format("Gravando erro original - CPFCNPJ: {0}", logInfo.CPFCNPJ));

            Error(ex, String.Format("Gravando erro secundário - CPFCNPJ: {0}", logInfo.CPFCNPJ));
         }
      }

      #region *---------------------------- CRUD ---------------------------------------------------*

      /// <summary>
      /// Listar logs
      /// </summary>
      /// <returns></returns>
      public List<LogInfo> Listar()
      {
         var logs = new List<LogInfo>();

         if (ConfigurationManager.ConnectionStrings["LogConnection"] == null)
            throw new Exception("LogConnection está nulo.");

         using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LogConnection"].ConnectionString))
            logs = db.Query<LogInfo>(@"SELECT * FROM Log").ToList();

         return ConverterJson(logs);
      }

      /// <summary>
      /// Obter logs
      /// </summary>
      /// <param name="Proposta">Proposta</param>
      /// <param name="Simulacao">Simulação</param>
      /// <returns></returns>
      /// <exception cref="Exception"></exception>
      public List<LogInfo> Obter(long? Proposta, long? Simulacao)
      {
         var logs = new List<LogInfo>();

         if (ConfigurationManager.ConnectionStrings["LogConnection"] == null)
            throw new Exception("LogConnection está nulo.");

         using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LogConnection"].ConnectionString))
         {
            // Temporario
            if (Proposta != null && Simulacao != null)
               logs = db.Query<LogInfo>(@"SELECT * FROM Log WHERE Proposta = @Proposta or Simulacao = @Simulacao", new { Proposta = Proposta, Simulacao = Simulacao }).ToList();
            else if (Proposta != null)
               logs = db.Query<LogInfo>(@"SELECT * FROM Log WHERE Proposta = @Proposta", new { Proposta = Proposta }).ToList();
            else if (Simulacao != null)
               logs = db.Query<LogInfo>(@"SELECT * FROM Log WHERE Simulacao = @Simulacao", new { Simulacao = Simulacao }).ToList();
            else
               throw new Exception("Parâmetros inválidos");
         }

         return ConverterJson(logs);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="logs"></param>
      /// <returns></returns>
      private List<LogInfo> ConverterJson(List<LogInfo> logs)
      {
         var serializer = new JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
         serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

         logs.ForEach(c =>
         {
            try
            {
               if (c.Request != null)
                  c.RequestDictionary = (dynamic)serializer.Deserialize(c.Request, typeof(IDictionary<string, object>));

               if (c.Response != null)
                  c.ResponseDictionary = (dynamic)serializer.Deserialize(c.Response, typeof(IDictionary<string, object>));
            }
            catch (Exception) { }
         });

         return logs;
      }

      #endregion

      public Dictionary<DateTime, string> ViewLog(DateTime dataPesquisa)
      {
         //buscando o nome do arquivo
         var nomeArquivo = Path.Combine(GetLogPath(), string.Format("Logs-{0}.log", dataPesquisa.ToString("yyyy-MM-dd")));

         //recupera o primeiro arquivo encontrado no diretório
         if (!File.Exists(nomeArquivo))
            return null;

         //armazena as linhas que serão colocadas no objeto de retorno
         var listaRetorno = new Dictionary<DateTime, string>();

         //armazena o valor das linhas correspondentes a cada horário no log
         var valorLinha = new StringBuilder();

         DateTime? dataUltimoLog = null;
         string line;

         using (var file = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
         {
            using (var reader = new StreamReader(file, Encoding.Default))
            {
               while ((line = reader.ReadLine()) != null)
               {
                  if (line.StartsWith("["))
                  {
                     if (dataUltimoLog.HasValue)
                     {
                        if (listaRetorno.ContainsKey(dataUltimoLog.Value))
                        {
                           listaRetorno[dataUltimoLog.Value] = listaRetorno[dataUltimoLog.Value] +
                                                               "<br /><br />" +
                                                               valorLinha.ToString().Replace("\r\n", "<br/>");
                        }
                        else
                        {
                           listaRetorno.Add(dataUltimoLog.Value, valorLinha.ToString().Replace("\r\n", "<br/>"));
                        }
                     }

                     dataUltimoLog = DateTime.Parse(line.Substring(1, 19));

                     valorLinha.Clear();
                     valorLinha.AppendLine(line.Substring(26));
                  }
                  else
                  {
                     valorLinha.Append(line);
                  }
               }
            }
         }

         if (dataUltimoLog.HasValue)
         {
            listaRetorno.Add(dataUltimoLog.Value, valorLinha.ToString().Replace("\r\n", "<br/>"));
         }

         return listaRetorno;
      }

      protected static string GetLogPath()
      {
         string assemblyFolder = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
         return Path.Combine(assemblyFolder, "App_Data/Logs");
      }
   }
}
