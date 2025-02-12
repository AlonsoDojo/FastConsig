using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Politicas
{
   public class EnviaRequisicaoParaPagamento : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         requisicao.Fase = 5;
         requisicao.TipoFluxo = 5;
         requisicao.Status = "AGUARDANDO";
         CTCService.GetInstance().AlterarRequesicao(requisicao);
      }
   }
}
