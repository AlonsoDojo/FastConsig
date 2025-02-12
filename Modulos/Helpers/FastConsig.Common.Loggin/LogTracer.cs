using FastConsig.Common.Helpers;
using Newtonsoft.Json;
using System;
using System.Linq;
using PostSharp.Aspects;
namespace FastConsig.Common.Loggin
{
   [Serializable]
   public class LogTracer : OnMethodBoundaryAspect
   {
      /// <summary>
      /// Enable info logger
      /// </summary>
      public bool enableInfo { get; set; }

      public bool responseSave { get; set; }

      /// <summary>
      /// Indica como sera gravado o log.
      /// </summary>
      public LogTracerProvider provider { get; set; }

      /// <summary>
      /// Method executed before the body of methods to which this aspect is applied.
      /// </summary>
      /// <param name="args"></param>
      public override void OnEntry(MethodExecutionArgs args)
      {
         if (!enableInfo) return;

         var logDescription = $"{args.Method} - Starting.";
         var parametersSerializabe = string.Empty;

         if (args.Arguments != null && args.Arguments.Count > 0)
         {
            var parameters = args.Method.GetParameters().ToDictionary(key => key.Name, value => args.Arguments[value.Position]);

            try
            { parametersSerializabe = JsonConvert.SerializeObject(parameters); }
            catch
            { parametersSerializabe = String.Empty; }
         }

         LogService.GetInstance().Info(provider, GetKey(args, "CPFCNPJ", typeof(long)), args.Method.Module.Name, logDescription, parametersSerializabe, args.Method.Name, proposta: GetKey(args, "Proposta", typeof(long)), simulacao: GetKey(args, "Simulacao", typeof(long)), fase: GetKey(args, "Fase", typeof(string)), _event: "Starting");
      }

      /// <summary>
      /// Method executed after the body of methods to which this aspect is applied, but
      /// only when the method successfully returns (i.e. when no exception flies out the method.).
      /// </summary>
      /// <param name="args"></param>
      public override void OnSuccess(MethodExecutionArgs args)
      {
         if (!enableInfo) return;

         LogService.GetInstance().Info(provider, GetKey(args, "CPFCNPJ", typeof(long)), args.Method.Module.Name, $"{args.Method} - Succeeded.", methodName: args.Method.Name, proposta: GetKey(args, "Proposta", typeof(long)), simulacao: GetKey(args, "Simulacao", typeof(long)), fase: GetKey(args, "Fase", typeof(string)), _event: "Success");
      }

      /// <summary>
      /// Method executed after the body of methods to which this aspect is applied, even
      /// when the method exists with an exception (this method is invoked from the finally block).
      /// </summary>
      /// <param name="args"></param>
      public override void OnExit(MethodExecutionArgs args)
      {
         if (!enableInfo) return;

         var logDescription = $"{args.Method} - Exit.";
         var parametersSerializabe = string.Empty;
         var response = string.Empty;

         if (args.Arguments != null && args.Arguments.Count > 0)
         {
            var parameters = args.Method.GetParameters().ToDictionary(key => key.Name, value => args.Arguments[value.Position]);

            try
            { parametersSerializabe = JsonConvert.SerializeObject(parameters); }
            catch
            { parametersSerializabe = String.Empty; }
         }

         if (responseSave)
            response = JsonConvert.SerializeObject(args.ReturnValue);

         LogService.GetInstance().Info(provider, GetKey(args, "CPFCNPJ", typeof(long)), args.Method.Module.Name, $"{args.Method} - Exited.", parametersSerializabe, methodName: args.Method.Name, response, proposta: GetKey(args, "Proposta", typeof(long)), simulacao: GetKey(args, "Simulacao", typeof(long)), fase: GetKey(args, "Fase", typeof(string)), _event: "Exit");
      }

      /// <summary>
      /// Method executed after the body of methods to which this aspect is applied, in
      /// case that the method resulted with an exception.
      /// </summary>
      /// <param name="args"></param>
      public override void OnException(MethodExecutionArgs args)
      {
         if (!enableInfo) return;

         var logDescription = $"{args.Method} - Failed.";
         var parametersSerializabe = string.Empty;

         if (args.Arguments != null && args.Arguments.Count > 0)
         {
            var parameters = args.Method.GetParameters().ToDictionary(key => key.Name, value => args.Arguments[value.Position]);

            try
            { parametersSerializabe = JsonConvert.SerializeObject(parameters); }
            catch
            { parametersSerializabe = String.Empty; }
         }

         if (args.Exception != null)
            logDescription += $" message: {args.Exception.Message}";

         LogService.GetInstance().Error(provider, GetKey(args, "CPFCNPJ", typeof(long)), args.Method.Module.Name, logDescription, methodName: args.Method.Name, response: parametersSerializabe, exception: args.Exception, proposta: GetKey(args, "Proposta", typeof(long)), simulacao: GetKey(args, "Simulacao", typeof(long)), fase: GetKey(args, "Fase", typeof(string)), _event: "Exception");
      }

      /// <summary>
      /// Obtém a propriedade chave do modelo
      /// </summary>
      /// <param name="args"></param>
      /// <param name="propName"></param>
      /// <param name="tipo"></param>
      /// <returns></returns>
      public string GetKey(MethodExecutionArgs args, string propName, Type tipo)
      {
         try
         {
            if (tipo == typeof(int))
            {
               var retorno = (int)UtilityHelper.GetPropertyValue(args.Arguments.FirstOrDefault() ?? 0, propName);

               return retorno.ToString();
            }

            if (tipo == typeof(long))
            {
               var retorno = (long)UtilityHelper.GetPropertyValue(args.Arguments.FirstOrDefault() ?? 0, propName);

               return retorno.ToString();
            }

            if (tipo == typeof(string))
               return (string)UtilityHelper.GetPropertyValue(args.Arguments.FirstOrDefault() ?? 0, propName);

            return null;

         }
         catch (Exception)
         {
            return null;
         }
      }
   }

   public enum LogTracerProvider
   {
      file = 1,
      DB = 2
   }
}
