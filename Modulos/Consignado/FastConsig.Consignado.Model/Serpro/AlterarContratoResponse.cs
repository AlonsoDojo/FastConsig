using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class AlterarContratoResponse
   {

      // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
      public partial class response
      {

         private string dtOperacaoField;

         private byte cdRetCodeField;

         private string dsRetCodeField;

         /// <remarks/>
         public string dtOperacao
         {
            get
            {
               return this.dtOperacaoField;
            }
            set
            {
               this.dtOperacaoField = value;
            }
         }

         /// <remarks/>
         public byte cdRetCode
         {
            get
            {
               return this.cdRetCodeField;
            }
            set
            {
               this.cdRetCodeField = value;
            }
         }

         /// <remarks/>
         public string dsRetCode
         {
            get
            {
               return this.dsRetCodeField;
            }
            set
            {
               this.dsRetCodeField = value;
            }
         }
      }


   }
}
