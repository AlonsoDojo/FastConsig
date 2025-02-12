using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class ContratoResponse
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

         private responseContrato contratoField;

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
         public responseContrato contrato
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

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseContrato
      {

         private string codTipoVincField;

         private string descTipoVincField;

         private ushort codOrgaoField;

         private string nmOrgaoField;

         private uint cdMatriculaField;

         private object orgMatInstField;

         private ushort cdRubricaField;

         private string dsRubricaField;

         private byte nrSequenciaField;

         private byte cdConvenioField;

         private byte nrContratoField;

         private byte cdSituacaoField;

         private string dsSituacaoField;

         private uint vlBrutoField;

         private uint vlLiquidoField;

         private uint vlDescontoField;

         private byte pzDescontoField;

         private ushort txJurosMensalField;

         private byte iofField;

         private ushort cetField;

         private string dtInclusaoField;

         private string dtAnuenciaField;

         private uint anoMesPrimDescField;

         private uint anoMesUltDescField;

         private string[] emailsParaNotificacaoAnuenciaField;

         private string urlAceiteField;

         private string urlRecusaField;

         private string dtValidadeAnuenciaField;

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
         public ushort codOrgao
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
         public string nmOrgao
         {
            get
            {
               return this.nmOrgaoField;
            }
            set
            {
               this.nmOrgaoField = value;
            }
         }

         /// <remarks/>
         public uint cdMatricula
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
         public object orgMatInst
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
         public ushort cdRubrica
         {
            get
            {
               return this.cdRubricaField;
            }
            set
            {
               this.cdRubricaField = value;
            }
         }

         /// <remarks/>
         public string dsRubrica
         {
            get
            {
               return this.dsRubricaField;
            }
            set
            {
               this.dsRubricaField = value;
            }
         }

         /// <remarks/>
         public byte nrSequencia
         {
            get
            {
               return this.nrSequenciaField;
            }
            set
            {
               this.nrSequenciaField = value;
            }
         }

         /// <remarks/>
         public byte cdConvenio
         {
            get
            {
               return this.cdConvenioField;
            }
            set
            {
               this.cdConvenioField = value;
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
         public byte cdSituacao
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
         public uint vlBruto
         {
            get
            {
               return this.vlBrutoField;
            }
            set
            {
               this.vlBrutoField = value;
            }
         }

         /// <remarks/>
         public uint vlLiquido
         {
            get
            {
               return this.vlLiquidoField;
            }
            set
            {
               this.vlLiquidoField = value;
            }
         }

         /// <remarks/>
         public uint vlDesconto
         {
            get
            {
               return this.vlDescontoField;
            }
            set
            {
               this.vlDescontoField = value;
            }
         }

         /// <remarks/>
         public byte pzDesconto
         {
            get
            {
               return this.pzDescontoField;
            }
            set
            {
               this.pzDescontoField = value;
            }
         }

         /// <remarks/>
         public ushort txJurosMensal
         {
            get
            {
               return this.txJurosMensalField;
            }
            set
            {
               this.txJurosMensalField = value;
            }
         }

         /// <remarks/>
         public byte iof
         {
            get
            {
               return this.iofField;
            }
            set
            {
               this.iofField = value;
            }
         }

         /// <remarks/>
         public ushort cet
         {
            get
            {
               return this.cetField;
            }
            set
            {
               this.cetField = value;
            }
         }

         /// <remarks/>
         public string dtInclusao
         {
            get
            {
               return this.dtInclusaoField;
            }
            set
            {
               this.dtInclusaoField = value;
            }
         }

         /// <remarks/>
         public string dtAnuencia
         {
            get
            {
               return this.dtAnuenciaField;
            }
            set
            {
               this.dtAnuenciaField = value;
            }
         }

         /// <remarks/>
         public uint anoMesPrimDesc
         {
            get
            {
               return this.anoMesPrimDescField;
            }
            set
            {
               this.anoMesPrimDescField = value;
            }
         }

         /// <remarks/>
         public uint anoMesUltDesc
         {
            get
            {
               return this.anoMesUltDescField;
            }
            set
            {
               this.anoMesUltDescField = value;
            }
         }

         /// <remarks/>
         [System.Xml.Serialization.XmlArrayItemAttribute("email", IsNullable = false)]
         public string[] emailsParaNotificacaoAnuencia
         {
            get
            {
               return this.emailsParaNotificacaoAnuenciaField;
            }
            set
            {
               this.emailsParaNotificacaoAnuenciaField = value;
            }
         }

         /// <remarks/>
         public string urlAceite
         {
            get
            {
               return this.urlAceiteField;
            }
            set
            {
               this.urlAceiteField = value;
            }
         }

         /// <remarks/>
         public string urlRecusa
         {
            get
            {
               return this.urlRecusaField;
            }
            set
            {
               this.urlRecusaField = value;
            }
         }

         /// <remarks/>
         public string dtValidadeAnuencia
         {
            get
            {
               return this.dtValidadeAnuenciaField;
            }
            set
            {
               this.dtValidadeAnuenciaField = value;
            }
         }
      }


   }
}
