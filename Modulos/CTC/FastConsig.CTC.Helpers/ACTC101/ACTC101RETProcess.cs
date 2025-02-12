using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System.Linq;

namespace FastConsig.CTC.Helpers.ACTC101
{
   public class ACTC101RETProcess : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         CTCArquivos arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC101.ACTC101 obj = (FastConsig.CTC.Model.ACTC101.ACTC101)new ACTC101RETParser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTCArquivos arquivoOrigem = CTCService.GetInstance().BuscarArquivo(obj.BCARQ.NomArq.Substring(0, 31));

         arquivoOrigem.SituacaoArquivo = 2;
         arquivoOrigem.Status = "CONCLUIDO";

         if (arquivo.Conteudo.Contains("CodErro"))
         {
            
            arquivoOrigem.Status = "COM CRITICA";
            arquivoOrigem.CodigoErro = arquivo.Conteudo.Substring(arquivo.Conteudo.IndexOf("CodErro") + 09, 8);
         }

         CTCService.GetInstance().AlterarArquivo(arquivoOrigem);

         arquivo.Identificador = arquivoOrigem.Identificador;
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";

         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}