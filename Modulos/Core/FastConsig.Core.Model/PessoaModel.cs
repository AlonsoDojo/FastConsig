using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model
{
   [Serializable]
   public class PessoaModel
   {
      /// <summary>
      /// Descrição do tipo de pessoa, Física ou Jurídica
      /// </summary>
      public string TipoPessoa { get; set; }

      /// <summary>
      /// Número de inscrição (CPF/CNPJ) do cliente
      /// </summary>
      public string Inscricao { get; set; }

      /// <summary>
      /// Nome do cliente
      /// </summary>
      public string Nome { get; set; }

      /// <summary>
      /// Nome resumido do cliente
      /// </summary>
      public string NomeResumido { get; set; }


      /// <summary>
      /// Obj Nascimento
      /// </summary>
      public Nascimento Nascimento { get; set; }

      /// <summary>
      /// Obj Telefone
      /// </summary>
      public Telefone Telefone { get; set; }

      /// <summary>
      /// Órgão expedidor do documento de identificação
      /// </summary>
      public string OrgaoExpedidor { get; set; }

      /// <summary>
      /// Data de expedição do documento de identificação (formato AAAA-MM-DD)
      /// </summary>
      public DateTime? DataExpedicao { get; set; }

      /// <summary>
      /// Código CVM
      /// </summary>
      public string CodigoOperacaoCvm { get; set; }

      /// <summary>
      /// UF - Unidade federativa do cliente
      /// </summary>
      public string UfRg { get; set; }

      /// <summary>
      /// Código da atividade econômica CNAE
      /// </summary>
      public string AtividadedEconomicaCnae { get; set; }

      /// <summary>
      /// Indicador se o cliente é um fundo de investimentos
      /// </summary>
      public string FundoInvestimento { get; set; }

      /// <summary>
      /// Identificação se o cliente é funcionário (S ou N)
      /// </summary>
      public string Funcionario { get; set; }

      /// <summary>
      /// Código de estatística financeira
      /// </summary>
      public long? CodigoEstatisticaFinanceira { get; set; }

      /// <summary>
      /// Data de cadastro do cliente (formato AAAA-MM-DD)
      /// </summary>
      public DateTime? DataCadastro { get; set; }

      /// <summary>
      /// Valor do património
      /// </summary>
      public long? ValorPatrimonio { get; set; }

      /// <summary>
      /// Tipo de relacionamento
      /// </summary>
      public string TipoRelacionamento { get; set; }

      /// <summary>
      /// Optante simples
      /// </summary>
      public string OptanteSimples { get; set; }

      /// <summary>
      /// Indicador de risco diferênciado
      /// </summary>
      public string RiscoDiferenciado { get; set; }

      /// <summary>
      /// Descrição do porte do cliente
      /// </summary>
      public string PorteCliente { get; set; }

      /// <summary>
      /// Identificação de cliente ativo (S ou N)
      /// </summary>
      public string IdAtivo { get; set; }

      /// <summary>
      /// Código do gerente do cliente
      /// </summary>
      public int? CodigoGerente { get; set; }

      /// <summary>
      /// Data de alteração no cadastro do cliente
      /// </summary>
      public DateTime? DataAlteracao { get; set; }

      /// <summary>
      /// Código do regime de bens
      /// </summary>
      public string CodigoRegimeBem { get; set; }

      /// <summary>
      /// Código do cliente
      /// </summary>
      public int? IdPessoa { get; set; }

      /// <summary>
      /// Identificação do usuário que efetuou o cadastro
      /// </summary>
      public string UsuaraioCadastro { get; set; }

      /// <summary>
      /// Código do ramo de atividade
      /// </summary>
      public long? CodigoRamoAtividade { get; set; }

      /// <summary>
      /// RG - Registro geral ou outro documento de identificação (DI)
      /// </summary>
      public string Rg { get; set; }

      /// <summary>
      /// Obj Filiacao
      /// </summary>
      public Filiacao Filiacao { get; set; }

      /// <summary>
      /// Tipo do documento de identificação
      /// </summary>
      public string TipoDi { get; set; }

      /// <summary>
      /// Valor do rendimento mensal
      /// </summary>
      public long? RendimentoMensal { get; set; }

      /// <summary>
      /// Descrição do grupo econômico
      /// </summary>
      public string GrupoEconomico { get; set; }

      /// <summary>
      /// Descrição do ramo de atividade
      /// </summary>
      public string RamoAtividde { get; set; }

      /// <summary>
      /// Descrição do Indicador de proteção do emprego (confirmar)
      /// </summary>
      public string MotivoPpe { get; set; }

      /// <summary>
      /// Valor do faturamento mensal
      /// </summary>
      public long? FaturamentoMensal { get; set; }

      /// <summary>
      /// Indicador se o cliente é uma instituição financeira
      /// </summary>
      public string IndicadorIf { get; set; }

      /// <summary>
      /// Indicador programa de proteção do emprego (confirmar)
      /// </summary>
      public string IndicadorPpe { get; set; }

      /// <summary>
      /// Código SWIFT
      /// </summary>
      public string CodigoSwift { get; set; }

      /// <summary>
      /// Descrição do regime de bens
      /// </summary>
      public string RegimeBem { get; set; }

      /// <summary>
      /// Data de atualização do cadastro
      /// </summary>
      public DateTime? DataAtualizacaoCadastro { get; set; }

      /// <summary>
      /// Código do estado civil do cliente
      /// </summary>
      public long? CodigoEstadoCivil { get; set; }

      /// <summary>
      /// Obj Conjuge
      /// </summary>
      public Conjuge Conjuge { get; set; }

      /// <summary>
      /// Código do porte do cliente
      /// </summary>
      public string CodigoPorteCliente { get; set; }

      /// <summary>
      /// Código da atividade econômica CNAE
      /// </summary>
      public string IdAtividadedEconomicaCnae { get; set; }

      /// <summary>
      /// Nome do responsável
      /// </summary>
      public string Responsavel { get; set; }

      /// <summary>
      /// E-mail do cliente
      /// </summary>
      public string Email { get; set; }

      /// <summary>
      /// Nome do gerente do cliente
      /// </summary>
      public string Gerente { get; set; }

      /// <summary>
      /// Data de alteração do património
      /// </summary>
      public DateTime? DataAlteracaoPatrimonio { get; set; }

      /// <summary>
      /// Obj Endereco
      /// </summary>
      public Endereco Endereco { get; set; }

      /// <summary>
      /// Categoria do risco diferenciado
      /// </summary>
      public string CategoriaRd { get; set; }

      /// <summary>
      /// Código do grupo econômico
      /// </summary>
      public string CodigoGrupoEconomico { get; set; }

      /// <summary>
      /// Descrição do estado civil do cliente
      /// </summary>
      public string EstadoCivil { get; set; }

      /// <summary>
      /// Descrição da estatística financeira
      /// </summary>
      public string EstatisticaFinanceira { get; set; }

      /// <summary>
      /// Indicador obriga cadastro completo
      /// </summary>
      public string ObrigaCadastroCompleto { get; set; }

      /// <summary>
      /// Código da classificação de risco original
      /// </summary>
      public string CodigoClassificacaoRiscoOriginal { get; set; }

      /// <summary>
      /// Data do primeiro contrato SFN
      /// </summary>
      public DateTime? DataPrimeiroContratoSfn { get; set; }

      /// <summary>
      /// Indicador divulga informações central de risco
      /// </summary>
      public string DivulgaInformacaoCentralRisco { get; set; }

      /// <summary>
      /// Código da classificação de risco
      /// </summary>
      public string CodigoClassificacaoRisco { get; set; }

      /// <summary>
      /// Indicador se o cliente reside no exterior
      /// </summary>
      public string ResideExterior { get; set; }

      /// <summary>
      /// Sexo do cliente
      /// </summary>
      public string Sexo { get; set; }

      /// <summary>
      /// Identificação do usuário aprovador da alteração do cadastro
      /// </summary>
      public string UsuarioAprovador { get; set; }

      public string PorteClienteFormatado
      {
         get
         {
            if (this.PorteCliente == "MICRO")
            {
               return "MC";
            }
            else if (this.PorteCliente == "PEQUENO PORTE")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "PEQUENO")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "PEQUENO SUPERIOR")
            {
               return "PS";
            }
            else if (this.PorteCliente == "MEDIO")
            {
               return "MD";
            }
            else if (this.PorteCliente == "MEDIO SUPERIOR")
            {
               return "MS";
            }
            else if (this.PorteCliente == "GRANDE INICIAL")
            {
               return "GI";
            }
            else if (this.PorteCliente == "GRANDE")
            {
               return "GD";
            }
            else if (this.PorteCliente == "GRANDE SUPERIOR")
            {
               return "GS";
            }
            else if (this.PorteCliente == "CORPORATE")
            {
               return "CP";
            }
            else if (this.PorteCliente == "CORPORATE SUPERIOR")
            {
               return "CS";
            }
            else if (this.PorteCliente == "SEM RENDIMENTO")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "ATE 1 SALARIO MINIMO")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "1 A 2 SALARIOS MIN")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "2 A 3 SALARIOS MIN")
            {
               return "PQ";
            }
            else if (this.PorteCliente == "3 A 5 SALARIOS MIN")
            {
               return "MD";
            }
            else if (this.PorteCliente == "5 A 10 SALARIOS MIN")
            {
               return "MS";
            }
            else if (this.PorteCliente == "10 A 20 SALARIOS MIN")
            {
               return "GD";
            }
            else if (this.PorteCliente == "ACIMA DE 20 SAL MIN")
            {
               return "PV";
            }
            else
               return this.PorteCliente;
         }
      }
   }

   public class Conjuge
   {
      /// <summary>
      /// Nome do cônjuge
      /// </summary>
      public string Cpf { get; set; }

      /// <summary>
      /// CPF do cônjuge
      /// </summary>
      public string Nome { get; set; }
   }

   public class Endereco
   {
      /// <summary>
      /// UF - Unidade federativa do cliente
      /// </summary>
      public string Uf { get; set; }

      /// <summary>
      /// Tipo de endereço (Residencial, Comercial, Outros)
      /// </summary>
      public string Tipo { get; set; }

      /// <summary>
      /// Cidade do cliente
      /// </summary>
      public string Cidade { get; set; }

      /// <summary>
      /// Complemento do endereço do cliente
      /// </summary>
      public string Complemento { get; set; }

      /// <summary>
      /// Endereço do cliente
      /// </summary>
      public string Logradouro { get; set; }

      /// <summary>
      /// Número do endereço do cliente
      /// </summary>
      public long? Numero { get; set; }

      /// <summary>
      /// Bairro do cliente
      /// </summary>
      public string Bairro { get; set; }

      /// <summary>
      /// Código do tipo de endereço (1-Residencial, 2-Comercial, 3-Outros)
      /// </summary>
      public long? IdTipo { get; set; }

      /// <summary>
      /// Data de alteração
      /// </summary>
      public DateTime? DataAlteracao { get; set; }

      /// <summary>
      /// País do cliente
      /// </summary>
      public string Pais { get; set; }

      /// <summary>
      /// Cep do cliente
      /// </summary>
      public long? Cep { get; set; }
   }

   public class Filiacao
   {
      /// <summary>
      /// Nome do pai
      /// </summary>
      public string Mae { get; set; }

      /// <summary>
      /// Nome da mãe
      /// </summary>
      public string Pai { get; set; }
   }

   public class Nascimento
   {
      /// <summary>
      /// UF - Estado de nacionalidade do cliente
      /// </summary>
      public string Uf { get; set; }

      /// <summary>
      /// Cidade de nascimento
      /// </summary>
      public string Cidade { get; set; }

      /// <summary>
      /// Data de nascimento do cliente (formato AAAA-MM-DD)
      /// </summary>
      public DateTime? Data { get; set; }

      /// <summary>
      /// Nacionalidade do cliente
      /// </summary>
      public string Nacionalidade { get; set; }

      /// <summary>
      /// Pais de nascimento do cliente
      /// </summary>
      public string Pais { get; set; }
   }

   public class Telefone
   {
      /// <summary>
      /// Número
      /// </summary>
      public long? Fone { get; set; }

      /// <summary>
      /// DDD
      /// </summary>
      public long? Ddd { get; set; }

      /// <summary>
      /// DDI
      /// </summary>
      public long? Ddi { get; set; }
   }
}
