using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class AutorizacoesMargemConsignavelResponse
   {
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
      public partial class response
      {
         private string dtOperacaoField;

         private string nomeField;

         private responseVinculoFuncional[] vinculoFuncionalField;

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
         [System.Xml.Serialization.XmlElementAttribute("vinculoFuncional")]
         public responseVinculoFuncional[] vinculoFuncional
         {
            get
            {
               return this.vinculoFuncionalField;
            }
            set
            {
               this.vinculoFuncionalField = value;
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
      public partial class responseVinculoFuncional
      {
         private string codTipoVincField;

         private string descTipoVincField;

         private int codOrgaoField;

         private string nmOrgaoField;

         private long cnpjOrgaoField;

         private int cdMatriculaField;

         private object orgMatInstField;

         private string codClassificacaoField;

         private string descClassificacaoField;

         private long cdUpagField;

         private string cdUfUpagField;

         private responseVinculoFuncionalProduto produtoField;

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
         public int codOrgao
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
         public long cnpjOrgao
         {
            get
            {
               return this.cnpjOrgaoField;
            }
            set
            {
               this.cnpjOrgaoField = value;
            }
         }

         /// <remarks/>
         public int cdMatricula
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
         public string codClassificacao
         {
            get
            {
               return this.codClassificacaoField;
            }
            set
            {
               this.codClassificacaoField = value;
            }
         }

         /// <remarks/>
         public string descClassificacao
         {
            get
            {
               return this.descClassificacaoField;
            }
            set
            {
               this.descClassificacaoField = value;
            }
         }

         /// <remarks/>
         public long cdUpag
         {
            get
            {
               return this.cdUpagField;
            }
            set
            {
               this.cdUpagField = value;
            }
         }

         /// <remarks/>
         public string cdUfUpag
         {
            get
            {
               return this.cdUfUpagField;
            }
            set
            {
               this.cdUfUpagField = value;
            }
         }

         /// <remarks/>
         public responseVinculoFuncionalProduto produto
         {
            get
            {
               return this.produtoField;
            }
            set
            {
               this.produtoField = value;
            }
         }
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseVinculoFuncionalProduto
      {

         private int cdRubricaField;

         private string dsRubricaField;

         private string cdConvenioField;

         private responseVinculoFuncionalProdutoAutorizacaoEmprestimo autorizacaoEmprestimoField;

         private responseVinculoFuncionalProdutoAutorizacaoPortabilidade autorizacaoPortabilidadeField;

         private int vlMargemDispField;

         private bool vlMargemDispFieldSpecified;

         /// <remarks/>
         public int cdRubrica
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
         public string cdConvenio
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
         public responseVinculoFuncionalProdutoAutorizacaoEmprestimo autorizacaoEmprestimo
         {
            get
            {
               return this.autorizacaoEmprestimoField;
            }
            set
            {
               this.autorizacaoEmprestimoField = value;
            }
         }

         /// <remarks/>
         public responseVinculoFuncionalProdutoAutorizacaoPortabilidade autorizacaoPortabilidade
         {
            get
            {
               return this.autorizacaoPortabilidadeField;
            }
            set
            {
               this.autorizacaoPortabilidadeField = value;
            }
         }

         /// <remarks/>
         public int vlMargemDisp
         {
            get
            {
               return this.vlMargemDispField;
            }
            set
            {
               this.vlMargemDispField = value;
            }
         }

         /// <remarks/>
         [System.Xml.Serialization.XmlIgnoreAttribute()]
         public bool vlMargemDispSpecified
         {
            get
            {
               return this.vlMargemDispFieldSpecified;
            }
            set
            {
               this.vlMargemDispFieldSpecified = value;
            }
         }
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseVinculoFuncionalProdutoAutorizacaoEmprestimo
      {

         private string autorizadoField;

         private string dtValidadeField;

         /// <remarks/>
         public string autorizado
         {
            get
            {
               return this.autorizadoField;
            }
            set
            {
               this.autorizadoField = value;
            }
         }

         /// <remarks/>
         public string dtValidade
         {
            get
            {
               return this.dtValidadeField;
            }
            set
            {
               this.dtValidadeField = value;
            }
         }
      }

      /// <remarks/>
      [System.SerializableAttribute()]
      [System.ComponentModel.DesignerCategoryAttribute("code")]
      [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
      public partial class responseVinculoFuncionalProdutoAutorizacaoPortabilidade
      {

         private string autorizadoField;

         private object dtValidadeField;

         /// <remarks/>
         public string autorizado
         {
            get
            {
               return this.autorizadoField;
            }
            set
            {
               this.autorizadoField = value;
            }
         }

         /// <remarks/>
         public object dtValidade
         {
            get
            {
               return this.dtValidadeField;
            }
            set
            {
               this.dtValidadeField = value;
            }
         }
      }
   }
}
