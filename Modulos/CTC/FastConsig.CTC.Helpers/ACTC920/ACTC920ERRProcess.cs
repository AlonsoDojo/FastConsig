using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC920
{
   public class ACTC920ERRProcess : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         CTCArquivos arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC920.ACTC920ERR obj = (FastConsig.CTC.Model.ACTC920.ACTC920ERR)new ACTC920ERRParser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTCArquivos arquivoOrigem = CTCService.GetInstance().BuscarArquivo(obj.BCARQ.NomArq.Value.Substring(0, 31));

         arquivoOrigem.SituacaoArquivo = 2;
         arquivoOrigem.Status = "COM ERRO";
         arquivoOrigem.CodigoErro = obj.BCARQ.NomArq.CodErro;

         CTCService.GetInstance().AlterarArquivo(arquivoOrigem);

         arquivo.Identificador = arquivoOrigem.Identificador;
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";

         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}