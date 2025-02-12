using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   [Serializable]
   public class TemplateContent
   {
      public string BodyContent { get; set; }
      public List<LinkedResource> LinkedResources { get; }

      public TemplateContent()
      {
         LinkedResources = new List<LinkedResource>();
      }

      //Faz uma cópia dos dados deste objeto...
      public TemplateContent Clone()
      {
         return UtilityHelper.Clone(this);
      }
   }
}
