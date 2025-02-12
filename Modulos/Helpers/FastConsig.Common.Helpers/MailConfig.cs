using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   [Serializable]
   public class MailConfig
   {
      public string SmtpServer { get; set; }
      public int SmtpPort { get; set; }
      public bool UseSSL { get; set; }
      public string EmailFrom { get; set; }
      public string Login { get; set; }
      public string Password { get; set; }
   }
}
