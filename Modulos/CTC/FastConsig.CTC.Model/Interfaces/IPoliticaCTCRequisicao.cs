using FastConsig.CTC.Entity;

namespace FastConsig.CTC.Model.Interfaces
{
   public interface IPoliticaCTCRequisicao
   {
      void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica);
   }
}
