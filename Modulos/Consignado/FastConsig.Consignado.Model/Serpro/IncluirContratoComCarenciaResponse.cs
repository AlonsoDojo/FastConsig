using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class IncluirContratoComCarenciaResponse
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

         private byte cdBcoServField;

         private ushort cdAgeServField;

         private string cdCcsServField;

         private byte nrContratoField;

         private byte seqContratoField;

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
         public byte cdBcoServ
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
         public ushort cdAgeServ
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
         public byte nrContrato
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
         public byte seqContrato
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
