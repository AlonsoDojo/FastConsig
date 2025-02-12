using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC900
{
   public class ACTC900PROProcess : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         CTCArquivos arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC900.ACTC900PRO obj = (FastConsig.CTC.Model.ACTC900.ACTC900PRO)new ACTC900PROParser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTCArquivos arquivoOrigem = CTCService.GetInstance().BuscarArquivo(obj.BCARQ.NomArq.Substring(0, 31));
         arquivoOrigem.SituacaoArquivo = 2;
         arquivoOrigem.Status = "CONCLUIDO";

         arquivo.Identificador = arquivoOrigem.Identificador;
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";

         CTCService.GetInstance().AlterarArquivo(arquivo);

         CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = arquivo.Id, Requisicao = arquivoOrigem.Identificador });
      }
   }
}