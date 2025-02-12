using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastConsig.Core.Web.Helpers
{
   public static class MensagemTexto
   {
      public static readonly string MsgUsuarioBloqueado = "O usuário informado está bloqueado temporariamente ou não existe.";
      public static readonly string MsgUsuarioDesabilitado = "O usuário informado está desabilitado e não pode acessar o sistema.";
      public static readonly string MsgLoginNaoInformado = "Login não informado.";
      public static readonly string MsgLoginFormatoInvalido = "Login informado está inválido. Utilize o formato: [Dominio\\Usuario].";
      public static readonly string MsgSenhaNaoInformada = "Senha não informada.";
      public static readonly string MsgUsuarioSenhaInvalido = "Usuário ou senha inválido(s).";
      public static readonly string MsgPathADNaoConfigurado = "Informações do caminho do AD não configurada no sistema.";
      public static readonly string MsgDataJaProcessada = "A data informada já possui um registro de processamento anterior.";
      public static readonly string MsgArquivoNaoImportado = "Para efetuar a análise dos arquivos é necessário informar os dois arquivos STALLOS e CHANGE.";


      public static readonly string MsgPadraoErro = "Ocorreu um erro no processo de {0}. Por favor, tente novamente mais tarde.";
      public static readonly string MsgDadosSalvosComSucesso = "Os dados foram salvos com sucesso.";
      public static readonly string MsgDadosExcluidoComSucesso = "Os dados foram excluídos com sucesso.";

      public const string MsgErroFk = "Não foi possível {0} os dados {1}, pois existem registros relacionados a esse item.";
      public const string MsgErroPk = "Já existe um registro utilizando o(a) {0} {1}. por favor, informe outro(a) {0}.";

      public static readonly string MsgBalancoSomatorioQtdeObrigatoria = "Para realizar o balanço somatório é necessário selecionar no mínimo 2 empresas.";
      public static readonly string MsgBalancoSomatorioMaxPermitido = "Não é permitido balanço somatório com mais do que 15 empresas.";
      public static readonly string MsgEmpresaNaoPossuiBalanco = "{0} não possui balanço.";
      public static readonly string MsgBalancoSomaGrupoAviso = "Somente serão utilizados balanços que estejam com o status de fechado.";

      public static readonly string MsgBalancoSomatorioEmpresasSelecionadas = "Há diferença nos períodos dos demonstrativos selecionados.";
      public static readonly string MsgBalancoSomatorioEmpresasSelecionadasPTAX = "Há diferença entre as taxas PTAX nos períodos dos demonstrativos selecionados.";

      public static readonly string MsgFichaPFModalidadeHomeEquity = "É necessário informar os dados da Garantia do Imóvel e também informar ao menos uma pesquisa do imóvel no quadro de 'Pesquisa da Internet'";

      public static readonly string MsgFichaPFCalculoRendaMensalPercentualSuperiorPermitido = "O Cálculo da Renda Média Mensal - {0} do cliente não deve ultrapassar os 30% do valor total da renda.";

      public static readonly string MsgLoginCPFNaoInformado = "CPF não informado.";
      public static readonly string MsgLoginCPFNaoValido = "CPF não é valido";

      public static readonly string MsgLoginCodigoSegurancaNaoInformado = "Código de Segurança não informado.";
   }
}