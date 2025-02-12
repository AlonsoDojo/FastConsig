using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class VinculosFuncionaisResponse
   {

      // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
      public partial class response
      {

         private responseDadosPessoa dadosPessoaField;

         private byte cd_ret_codeField;

         private string ds_ret_codeField;

         /// <remarks/>
         public responseDadosPessoa dadosPessoa
         {
            get
            {
               return this.dadosPessoaField;
            }
            set
            {
               this.dadosPessoaField = value;
            }
         }

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

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseDadosPessoa
      {

         private ulong cpfField;

         private string nomeField;

         private responseDadosPessoaVinculo[] vinculosDeServidorField;

         private object vinculosDePensionistaField;

         /// <remarks/>
         public ulong cpf
         {
            get
            {
               return this.cpfField;
            }
            set
            {
               this.cpfField = value;
            }
         }

         /// <remarks/>
         public string nome
         {
            get
            {
               return this.nomeField;
            }
            set
            {
               this.nomeField = value;
            }
         }

         /// <remarks/>
         [System.Xml.Serialization.XmlArrayItemAttribute("vinculo", IsNullable = false)]
         public responseDadosPessoaVinculo[] vinculosDeServidor
         {
            get
            {
               return this.vinculosDeServidorField;
            }
            set
            {
               this.vinculosDeServidorField = value;
            }
         }

         /// <remarks/>
         public object vinculosDePensionista
         {
            get
            {
               return this.vinculosDePensionistaField;
            }
            set
            {
               this.vinculosDePensionistaField = value;
            }
         }
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseDadosPessoaVinculo
      {

         private ushort codOrgaoField;

         private string nmOrgaoField;

         private uint cdMatriculaField;

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
      }


   }
}
