using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   public static class MailHelper
   {
      public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
      {
         return true;
      }

      /// <summary>
      /// Envia um e-mail para o destinatário, utilizando o template.
      /// </summary>
      /// <param name="config">Informações para envio de e-mail</param>
      /// <param name="to">E-mail do destinatário</param>
      /// <param name="subject">Assunto do e-mail</param>
      /// <param name="template">Template do e-mail</param>
      /// <param name="contentAttachs">Arquivos que deverão ser anexados (em byte[])</param>
      /// <param name="attachments">Localização dos arquivos que deverão ser anexados</param>
      public static void SendMail(MailConfig config, string to, string subject, TemplateContent template,
                                  Dictionary<string, object> contentAttachs = null, string[] attachments = null)
      {
         SendMail(config, to, null, subject, template, contentAttachs, attachments);
      }

      /// <summary>
      /// Envia um e-mail para o destinatário, utilizando o template.
      /// </summary>
      /// <param name="config">Informações para envio de e-mail</param>
      /// <param name="to">E-mail do destinatário</param>
      /// <param name="bcc">E-mail que serão copiados</param>
      /// <param name="subject">Assunto do e-mail</param>
      /// <param name="template">Template do e-mail</param>
      /// <param name="contentAttachs">Arquivos que deverão ser anexados (em byte[])</param>
      /// <param name="attachments">Localização dos arquivos que deverão ser anexados</param>
      public static void SendMail(MailConfig config, string to, string bcc, string subject, TemplateContent template,
                                  Dictionary<string, object> contentAttachs = null, string[] attachments = null)
      {
         //Cria a view text/html
         var htmlView = AlternateView.CreateAlternateViewFromString(template.BodyContent, Encoding.UTF8, "text/html");
         foreach (var item in template.LinkedResources)
            htmlView.LinkedResources.Add(item);

         using (var client = new SmtpClient(config.SmtpServer, config.SmtpPort))
         {
            client.EnableSsl = config.UseSSL;

            if (!string.IsNullOrWhiteSpace(config.Login))
               client.Credentials = new NetworkCredential(config.Login, config.Password);

            using (var message = new MailMessage())
            {
               var destinatarios = to?.Split(';');

               if (destinatarios.HasAny())
               {
                  foreach (var para in destinatarios)
                     message.To.Add(new MailAddress(para));
               }

               message.From = new MailAddress(config.EmailFrom);
               message.Subject = subject;
               message.Body = template.BodyContent;
               message.IsBodyHtml = true;

               message.AlternateViews.Add(htmlView);

               //Se foi definido cópia para o e-mail, informa agora...
               var copias = bcc?.Split(';');
               if (copias.HasAny())
               {
                  foreach (var copia in copias)
                     message.Bcc.Add(copia);
               }
               //Arquivos fisicos do disco...
               if (attachments != null && attachments.Length > 0)
               {
                  foreach (var filePath in attachments)
                     message.Attachments.Add(new Attachment(filePath));
               }

               //Stream de conteúdos...
               if (contentAttachs != null && contentAttachs.Count > 0)
               {
                  foreach (var item in contentAttachs)
                     message.Attachments.Add(new Attachment(new MemoryStream((byte[])item.Value), item.Key));
               }

               client.Send(message);
            }
         }
      }

      /// <summary>
      /// Envia um e-mail para o destinatário.
      /// </summary>
      /// <param name="config">Informações para envio de e-mail</param>
      /// <param name="to">E-mail do destinatário</param>
      /// <param name="subject">Assunto do e-mail</param>
      /// <param name="body">Texto do e-mail que deve ser enviado.</param>
      /// <param name="Error">Descrição do erro ocorrido.</param>
      /// <returns>True se enviou o e-mail</returns>
      public static bool SendMail(MailConfig config, string to, string subject, string body, out string Error)
      {
         try
         {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(config.EmailFrom);
            message.Subject = subject;

            message.To.Add(new MailAddress(to));
            message.Body = body;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(config.SmtpServer, config.SmtpPort);
            client.UseDefaultCredentials = false;
            client.EnableSsl = config.UseSSL;
            client.Credentials = new NetworkCredential(config.Login, config.Password);
            client.Send(message);

            Error = null;
            return true;
         }
         catch (Exception ex)
         {
            Error = ex.Message;
            return false;
         }
      }
   }
}
