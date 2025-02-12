using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC928
{
   public class ACTC928Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC928.ACTC928 obj = (FastConsig.CTC.Model.ACTC928.ACTC928)new ACTC928Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTC928 ctc = new CTC928();

         ctc.DataReferencia = obj.BCARQ.DtRef;
         ctc.Arquivo = idArquivo;

         new CTC928Business().Incluir(ctc);

         foreach(var cliente in obj.SISARQ.Item.Grupo_ACTC928_Grupo_Cliente)
         {
            CTC928Clientes cli = new CTC928Clientes() { Arquivo = ctc.Id, NomeCliente = cliente.NomeCli, ISPB = cliente.ISPBCli, Cnpj = cliente.CnpjCli };

            new CTC928ClientesBusiness().Incluir(cli);

            foreach(var produto in cliente.Grupo_ACTC928_Produto)
            {
               CTC928ClienteProduto pro = new CTC928ClienteProduto() { Cliente = cli.Id, Produto = produto.DescricaoProduto };
               new CTC928ClienteProdutoBusiness().Incluir(pro);
            }
         }

         //Atualiza a Situação para Processado
         arquivo.Mensagem = "Processamento Concluído com Sucesso";
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}