using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class ContratoBase
   {
      /// <summary>
      /// CD_CIA Alfanumérico(03) Código da companhia
      /// </summary>
      public string CD_CIA { get; set; }

      /// <summary>
      /// CD_EMPRESA Alfanumérico(03) Código da empresa -
      /// </summary>
      public string CD_EMPRESA { get; set; }

      /// <summary>
      /// CD_ORGAO Alfanumérico(10) Código do órgão X
      /// </summary>
      public string CD_ORGAO { get; set; }

      /// <summary>
      /// CD_MATRICULA Alfanumérico(13) Matrícula do servidor X
      /// </summary>
      public string CD_MATRICULA { get; set; }

      /// <summary>
      /// ORG_MAT_INST Alfanumérico(12) Dados do Instituidor* P
      /// </summary>
      public string ORG_MAT_INST { get; set; }

      /// <summary>
      /// NR_CPF_A Numérico(14) CPF do servidor X
      /// </summary>
      public string NR_CPF_A { get; set; }

      /// <summary>
      /// CD_CONSIG_A Numérico(06) Código da consignatária X
      /// </summary>
      public string CD_CONSIG_A { get; set; }

      /// <summary>
      /// CD_SENHA_CONSIG Alfanumérico(12) Senha da consignatária X
      /// </summary>
      public string CD_SENHA_CONSIG { get; set; }

      /// <summary>
      /// CD_USUARIO Alfanumérico(08) Usuário da consignatária -
      /// </summary>
      public string CD_USUARIO { get; set; }

      /// <summary>
      /// NR_CONTRATO Alfanumérico(20) Número do contrato X
      /// </summary>
      public string NR_CONTRATO { get; set; }

      /// <summary>
      /// DS_LIVRE Alfanumérico(20) Livre uso da Consignatária -
      /// </summary>
      public string DS_LIVRE { get; set; }
   }
}
