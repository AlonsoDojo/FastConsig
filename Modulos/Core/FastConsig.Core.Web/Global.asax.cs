using FastConsig.Core.Web.Helpers;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FastConsig.Common.Loggin;

namespace FastConsig.Core.Web
{
   public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
         //Variaveis Globais do LOG
         LogService.GetInstance().SetApplication(WebUtilityHelper.NOME_SISTEMA);
         LogService.GetInstance().SetApplicationGuid(WebUtilityHelper.GUID_SISTEMA);
         LogService.GetInstance().SetApplicationLogName(WebUtilityHelper.LOG_NAME);
         LogService.GetInstance().SetApplicationEnvironment(ConfigurationManager.AppSettings["Environment"]);

         //GlobalConfiguration.Configuration.RegisterDataTables();
         // DataTables.AspNet registration with default options.
         var options = new DataTables.AspNet.Mvc5.Options()
             .EnableRequestAdditionalParameters()
             .EnableResponseAdditionalParameters();

         var binder = new DataTables.AspNet.Mvc5.ModelBinder();
         binder.ParseAdditionalParameters = Parser;

         DataTables.AspNet.Mvc5.Configuration.RegisterDataTables(options, binder);

         // Code that runs on application startup
         CustomTextBox.UseJavascriptAsPossible = true;
            CustomPageBase.GlobalDoNotAdjustFieldWidth = true;

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

      /*
            protected void Application_Error(Object sender, EventArgs e)
            {
               Exception exception = Server.GetLastError();
               //if (exception is HttpUnhandledException)
               //{
               //    if (exception.InnerException == null)
               //    {
               //        Server.Transfer("ERROR_PAGE_LOCATION", false);
               //        return;
               //    }
               //    exception = exception.InnerException;
               //}

               //if (exception is HttpException)
               //{
               //    if (((HttpException)exception).GetHttpCode() == 404)
               //    {
               //        //page = sessionExists ? "" : ""; //NOT_FOUND_PAGE_LOCATION
               //        Server.ClearError();
               //        Server.Transfer("/PaginaNaoEncontrada.aspx", false);
               //        return;
               //    }
               //}

               //if (Context != null && Context.IsCustomErrorEnabled)
               //    Server.Transfer("ERROR_PAGE_LOCATION", false);
               //else
               LogServices.GetInstance().GravarLogErro(exception, "Unhandled Exception trapped in Global.asax");

               Server.Transfer("/ErroGeral.aspx", false);
            }*/

      private IDictionary<string, object> Parser(ControllerContext controllerContext, ModelBindingContext modelBindingContext)
      {
         var p1 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param1").AttemptedValue);
         var p2 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param2").AttemptedValue);
         var p3 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param3").AttemptedValue);
         var p4 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param4").AttemptedValue);
         var p5 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param5").AttemptedValue);
         var p6 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param6").AttemptedValue);
         var p7 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param7").AttemptedValue);
         var p8 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param8").AttemptedValue);
         var p9 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param9").AttemptedValue);
         var p10 = System.Convert.ToString(modelBindingContext.ValueProvider.GetValue("param10").AttemptedValue);

         return new Dictionary<string, object>()
            {
                { "param1", p1 },
                { "param2", p2 },
                { "param3", p3 },
                { "param4", p4 },
                { "param5", p5 },
                { "param6", p6 },
                { "param7", p7 },
                { "param8", p8 },
                { "param9", p9 },
                { "param10", p10 }
            };
      }
   }
}