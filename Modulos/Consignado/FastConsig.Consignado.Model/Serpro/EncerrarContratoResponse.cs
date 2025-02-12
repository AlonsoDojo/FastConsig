using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class EncerrarContratoResponse
   {

      // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
      public partial class response
      {

         private byte cd_ret_codeField;

         private string ds_ret_codeField;

         /// <remarks/>
         public byte cd_ret_code
         {
            get
            {
               return this.cd_ret_codeField;
            }
            set
            {
               this.cd_ret_codeField = value;
            }
         }

         /// <remarks/>
         public string ds_ret_code
         {
            get
            {
               return this.ds_ret_codeField;
            }
            set
            {
               this.ds_ret_codeField = value;
            }
         }
      }


   }
}
