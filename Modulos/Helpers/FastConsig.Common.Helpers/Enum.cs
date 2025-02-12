using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   public enum TipoImagemTemplateEnum
   {
      Logotipo = 1,
      Background = 2,
      AssinaturaEmail = 3,
      TopoGeral = 6,
      BtnIniciarCadastro = 4,
      Rodape = 5
   }

   /// <summary>
   /// Tipos de templates para serem carregados na aplicação.
   /// </summary>
   public enum TipoEmailProcessamentoTemplateEnum
   {
      /// <summary>E-mail de conclusão de processamento.</summary>
      ConclusaoOk = 1,

      /// <summary>E-mail de processamento com críticas em registros.</summary>
      ConclusaoParcial = 2,

      /// <summary>E-mail de erro de processamento.</summary>
      Erro = 3,

      /// <summary>E-mail de Solicitação de Serviço.</summary>
      SolicitacaoServico = 4,

      /// <summary>E-mail de Informe de Rendimentos.</summary>
      InformeRendimentos = 5
   }
}
