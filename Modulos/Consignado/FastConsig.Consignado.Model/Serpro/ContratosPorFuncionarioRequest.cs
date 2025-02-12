using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   /// <summary>
   /// Esta Model serve também para o ContratosPorFuncionarioV1Request
   /// </summary>
   public class ContratosPorFuncionarioRequest
   {
      /// <summary>
      /// CD_CIA Alfanumérico(03) Código da companhia
      /// </summary>
      public string CD_CIA { get; set; }

      /// <summary>
      /// CD_EMPRESA Alfanumérico(03) Código da empresa
      /// </summary>
      public string CD_EMPRESA { get; set; }

      /// <summary>
      /// CD_ORGAO Alfanumérico(10) Código do órgão
      /// </summary>
      public string CD_ORGAO { get; set; }

      /// <summary>
      /// CD_MATRICULA Alfanumérico(13) Matrícula do servidor
      /// </summary>
      public string CD_MATRICULA { get; set; }

      /// <summary>
      /// ORG_MAT_INST Alfanumérico(12) Dados do Instituidor
      /// Este campo é formado de: 
      /// Órgão(Alfanumérico(05)) + Matrícula do Instituidor(Alfanumérico(07))
      /// </summary>
      public string ORG_MAT_INST { get; set; }

      /// <summary>
      /// NR_CPF_A Numérico(14) CPF do servidor
      /// </summary>
      public string NR_CPF_A { get; set; }

      /// <summary>
      /// CD_CONSIG_A Numérico(06) Código da consignatária
      /// </summary>
      public string CD_CONSIG_A { get; set; }

      /// <summary>
      /// CD_SENHA_CONSIG Alfanumérico(12) Senha da consignatária
      /// </summary>
      public string CD_SENHA_CONSIG { get; set; }

      /// <summary>
      /// CD_USUARIO Alfanumérico(08) Usuário da consignatária
      /// </summary>
      public string CD_USUARIO { get; set; }

      /// <summary>
      /// CD_CONVENIO_A Numérico(06) Código do convênio
      /// </summary>
      public string CD_CONVENIO_A { get; set; }
   }
}
