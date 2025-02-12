using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class IncluirContratoV2Response
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

         private string nmServField;

         private string cdBcoServField;

         private string cdAgeServField;

         private string cdCcsServField;

         private string nrContratoField;

         private string seqContratoField;

         private string cdRetCodeField;

         private string dsRetCodeField;

         private string[] textField;

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
         public string nmServ
         {
            get
            {
               return this.nmServField;
            }
            set
            {
               this.nmServField = value;
            }
         }

         /// <remarks/>
         public string cdBcoServ
         {
            get
            {
               return this.cdBcoServField;
            }
            set
            {
               this.cdBcoServField = value;
            }
         }

         /// <remarks/>
         public string cdAgeServ
         {
            get
            {
               return this.cdAgeServField;
            }
            set
            {
               this.cdAgeServField = value;
            }
         }

         /// <remarks/>
         public string cdCcsServ
         {
            get
            {
               return this.cdCcsServField;
            }
            set
            {
               this.cdCcsServField = value;
            }
         }

         /// <remarks/>
         public string nrContrato
         {
            get
            {
               return this.nrContratoField;
            }
            set
            {
               this.nrContratoField = value;
            }
         }

         /// <remarks/>
         public string seqContrato
         {
            get
            {
               return this.seqContratoField;
            }
            set
            {
               this.seqContratoField = value;
            }
         }

         /// <remarks/>
         public string cdRetCode
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

         /// <remarks/>
         [System.Xml.Serialization.XmlTextAttribute()]
         public string[] Text
         {
            get
            {
               return this.textField;
            }
            set
            {
               this.textField = value;
            }
         }
      }
   }
}
