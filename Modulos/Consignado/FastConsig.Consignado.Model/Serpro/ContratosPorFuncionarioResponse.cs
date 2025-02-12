using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class ContratosPorFuncionarioResponse
   {

      // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
      public partial class response
      {

         private responseDados_servidor dados_servidorField;

         private byte cd_ret_codeField;

         private string ds_ret_codeField;

         /// <remarks/>
         public responseDados_servidor dados_servidor
         {
            get
            {
               return this.dados_servidorField;
            }
            set
            {
               this.dados_servidorField = value;
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
      public partial class responseDados_servidor
      {

         private string cd_empresaField;

         private string ds_empresaField;

         private ushort cd_orgaoField;

         private string ds_orgaoField;

         private ushort cd_matriculaField;

         private ulong nr_cpf_servidorField;

         private string nm_servidorField;

         private byte cd_sit_servField;

         private string ds_sit_servField;

         private byte cd_classe_servField;

         private string ds_classe_servField;

         private responseDados_servidorDados_autorizacao[] dados_autorizacaoField;

         /// <remarks/>
         public string cd_empresa
         {
            get
            {
               return this.cd_empresaField;
            }
            set
            {
               this.cd_empresaField = value;
            }
         }

         /// <remarks/>
         public string ds_empresa
         {
            get
            {
               return this.ds_empresaField;
            }
            set
            {
               this.ds_empresaField = value;
            }
         }

         /// <remarks/>
         public ushort cd_orgao
         {
            get
            {
               return this.cd_orgaoField;
            }
            set
            {
               this.cd_orgaoField = value;
            }
         }

         /// <remarks/>
         public string ds_orgao
         {
            get
            {
               return this.ds_orgaoField;
            }
            set
            {
               this.ds_orgaoField = value;
            }
         }

         /// <remarks/>
         public ushort cd_matricula
         {
            get
            {
               return this.cd_matriculaField;
            }
            set
            {
               this.cd_matriculaField = value;
            }
         }

         /// <remarks/>
         public ulong nr_cpf_servidor
         {
            get
            {
               return this.nr_cpf_servidorField;
            }
            set
            {
               this.nr_cpf_servidorField = value;
            }
         }

         /// <remarks/>
         public string nm_servidor
         {
            get
            {
               return this.nm_servidorField;
            }
            set
            {
               this.nm_servidorField = value;
            }
         }

         /// <remarks/>
         public byte cd_sit_serv
         {
            get
            {
               return this.cd_sit_servField;
            }
            set
            {
               this.cd_sit_servField = value;
            }
         }

         /// <remarks/>
         public string ds_sit_serv
         {
            get
            {
               return this.ds_sit_servField;
            }
            set
            {
               this.ds_sit_servField = value;
            }
         }

         /// <remarks/>
         public byte cd_classe_serv
         {
            get
            {
               return this.cd_classe_servField;
            }
            set
            {
               this.cd_classe_servField = value;
            }
         }

         /// <remarks/>
         public string ds_classe_serv
         {
            get
            {
               return this.ds_classe_servField;
            }
            set
            {
               this.ds_classe_servField = value;
            }
         }

         /// <remarks/>
         [System.Xml.Serialization.XmlElementAttribute("dados_autorizacao")]
         public responseDados_servidorDados_autorizacao[] dados_autorizacao
         {
            get
            {
               return this.dados_autorizacaoField;
            }
            set
            {
               this.dados_autorizacaoField = value;
            }
         }
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseDados_servidorDados_autorizacao
      {

         private byte cd_consigField;

         private string ds_consigField;

         private byte prazoField;

         private uint dt_operacaoField;

         private uint dt_prim_descField;

         private uint dt_ult_descField;

         private ushort vl_descontoField;

         private string nr_externoField;

         private byte cd_situacaoField;

         private string ds_situacaoField;

         private uint cd_convenioField;

         private string ds_convenioField;

         private object ds_autoField;

         /// <remarks/>
         public byte cd_consig
         {
            get
            {
               return this.cd_consigField;
            }
            set
            {
               this.cd_consigField = value;
            }
         }

         /// <remarks/>
         public string ds_consig
         {
            get
            {
               return this.ds_consigField;
            }
            set
            {
               this.ds_consigField = value;
            }
         }

         /// <remarks/>
         public byte prazo
         {
            get
            {
               return this.prazoField;
            }
            set
            {
               this.prazoField = value;
            }
         }

         /// <remarks/>
         public uint dt_operacao
         {
            get
            {
               return this.dt_operacaoField;
            }
            set
            {
               this.dt_operacaoField = value;
            }
         }

         /// <remarks/>
         public uint dt_prim_desc
         {
            get
            {
               return this.dt_prim_descField;
            }
            set
            {
               this.dt_prim_descField = value;
            }
         }

         /// <remarks/>
         public uint dt_ult_desc
         {
            get
            {
               return this.dt_ult_descField;
            }
            set
            {
               this.dt_ult_descField = value;
            }
         }

         /// <remarks/>
         public ushort vl_desconto
         {
            get
            {
               return this.vl_descontoField;
            }
            set
            {
               this.vl_descontoField = value;
            }
         }

         /// <remarks/>
         public string nr_externo
         {
            get
            {
               return this.nr_externoField;
            }
            set
            {
               this.nr_externoField = value;
            }
         }

         /// <remarks/>
         public byte cd_situacao
         {
            get
            {
               return this.cd_situacaoField;
            }
            set
            {
               this.cd_situacaoField = value;
            }
         }

         /// <remarks/>
         public string ds_situacao
         {
            get
            {
               return this.ds_situacaoField;
            }
            set
            {
               this.ds_situacaoField = value;
            }
         }

         /// <remarks/>
         public uint cd_convenio
         {
            get
            {
               return this.cd_convenioField;
            }
            set
            {
               this.cd_convenioField = value;
            }
         }

         /// <remarks/>
         public string ds_convenio
         {
            get
            {
               return this.ds_convenioField;
            }
            set
            {
               this.ds_convenioField = value;
            }
         }

         /// <remarks/>
         public object ds_auto
         {
            get
            {
               return this.ds_autoField;
            }
            set
            {
               this.ds_autoField = value;
            }
         }
      }


   }
}
