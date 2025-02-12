using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC926
{
   public class ACTC926Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC926.ACTC926 obj = (FastConsig.CTC.Model.ACTC926.ACTC926)new ACTC926Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTC926 ctc = new CTC926();

         ctc.DataReferencia = obj.BCARQ.DtRef;
         ctc.Arquivo = idArquivo;
         ctc.DataInicio = obj.SISARQ.Item.DtIniApurc;
         ctc.DataFim = obj.SISARQ.Item.DtFimApurc;
         
         new CTC926Business().Incluir(ctc);

         foreach (var detalheArquivo in obj.SISARQ.Item.Grupo_ACTC926_DadRelcArqProcd)
         {
            CTC926Detalhes arq = new CTC926Detalhes() { CTC926 = ctc.Id, DataProcessamentoArquivo = detalheArquivo.DtHrProcArq, DataReferencia = detalheArquivo.DtRef, NomeArquivo = detalheArquivo.NomArq, ISPBDestinatario = detalheArquivo.ISPBDestinatario, ISPBEmissor = detalheArquivo.ISPBEmissor, TipoArquivo = detalheArquivo.TpArq };
            new CTC926DetalhesBusiness().Incluir(arq);
         }

         //Atualiza a Situação para Processado
         arquivo.Mensagem = "Processamento Concluído com Sucesso";
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}
