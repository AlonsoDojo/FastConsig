using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class AnuenciaContratosResponse
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

         private object cursorPaginacaoField;

         private responseContrato[] contratoField;

         private string cdRetCodeField;

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
         public object cursorPaginacao
         {
            get
            {
               return this.cursorPaginacaoField;
            }
            set
            {
               this.cursorPaginacaoField = value;
            }
         }

         /// <remarks/>
         [System.Xml.Serialization.XmlElementAttribute("contrato")]
         public responseContrato[] contrato
         {
            get
            {
               return this.contratoField;
            }
            set
            {
               this.contratoField = value;
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
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseContrato
      {

         private string codTipoVincField;

         private string descTipoVincField;

         private string codOrgaoField;

         private string cdMatriculaField;

         private string orgMatInstField;

         private string nrContratoField;

         private string cdSituacaoField;

         private string dsSituacaoField;

         private string dtEventoField;

         /// <remarks/>
         public string codTipoVinc
         {
            get
            {
               return this.codTipoVincField;
            }
            set
            {
               this.codTipoVincField = value;
            }
         }

         /// <remarks/>
         public string descTipoVinc
         {
            get
            {
               return this.descTipoVincField;
            }
            set
            {
               this.descTipoVincField = value;
            }
         }

         /// <remarks/>
         public string codOrgao
         {
            get
            {
               return this.codOrgaoField;
            }
            set
            {
               this.codOrgaoField = value;
            }
         }

         /// <remarks/>
         public string cdMatricula
         {
            get
            {
               return this.cdMatriculaField;
            }
            set
            {
               this.cdMatriculaField = value;
            }
         }

         /// <remarks/>
         public string orgMatInst
         {
            get
            {
               return this.orgMatInstField;
            }
            set
            {
               this.orgMatInstField = value;
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
         public string cdSituacao
         {
            get
            {
               return this.cdSituacaoField;
            }
            set
            {
               this.cdSituacaoField = value;
            }
         }

         /// <remarks/>
         public string dsSituacao
         {
            get
            {
               return this.dsSituacaoField;
            }
            set
            {
               this.dsSituacaoField = value;
            }
         }

         /// <remarks/>
         public string dtEvento
         {
            get
            {
               return this.dtEventoField;
            }
            set
            {
               this.dtEventoField = value;
            }
         }
      }


   }
}
