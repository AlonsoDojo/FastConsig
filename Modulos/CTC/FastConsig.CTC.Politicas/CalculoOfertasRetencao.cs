using FastConsig.Common.Loggin;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.CTC.Politicas
{
   public class CalculoOfertasRetencao : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Rodando a Politica de Calculo de Ofertas para a Requisição ID " + requisicao.Id);

         //TODO: Ajustar
         ////Busca o Produto
         //var produtoRetencao = CTCService.GetInstance().ListarTipoContratoProdutoRetencao().Where(x => x.TipoContrato == requisicao.TipoContrato && x.EnteConsignante == requisicao.EnteConsignante.PadLeft(2, '0') && x.ProdutoOrigem == requisicao.ProdutoOrigem).FirstOrDefault();

         //if (produtoRetencao == null)
         //{
         //   CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico()
         //   {
         //      Requisicao = requisicao.Id,
         //      DataOcorrencia = DateTime.Now,
         //      Usuario = "System",
         //      Ocorrencia = 5
         //      ,
         //      Complemento = "Produto de Retenção não localizado para o Tipo de Contrato: " + requisicao.TipoContrato + " - Ente Consignante: " + requisicao.EnteConsignante + " - Produto Origem: " + requisicao.ProdutoOrigem
         //   });

         //   LogService.GetInstance().GravarLogDebug("Produto de Retenção não Localizado para a Requisição ID " + requisicao.Id);
         //}
         //else
         //{
         //   var produto = PropostaService.GetInstance().ObtemProduto(produtoRetencao.ProdutoRetencao);

         //   //Efetua a Simulação com as Tabelas Disponíveis
         //   dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);
         //   List<Planos> tabelas = SICREDServices.GetInstance().ListarPlanos(parametros.empresa.ToString(), "0001", parametros.produto.ToString());

         //   List<Prazos> prazos = SICREDServices.GetInstance().ListarTabelasComPrazo(parametros.empresa.ToString(), requisicao.QtdParcelasContrato.Value.ToString("000"));

         //   tabelas = tabelas.Where(s => prazos.Any(y => s.Plano.Contains(y.Plano))).ToList();
         //   tabelas = tabelas.Where(s => s.Lojista == "000001").Where(s => s.Loja == "0001").ToList();

         //   LogService.GetInstance().GravarLogDebug("Localizadas " + tabelas.Count() + " Para a Simulação das Ofertas de Retenção para a Requisição ID " + requisicao.Id);

         //   foreach (var t in tabelas)
         //   {
         //      //Grava a Simulação
         //      SimulacaoPropostaModel simulacao = new SimulacaoPropostaModel()
         //      {
         //         Cedida = false,
         //         Celular = requisicao.Telefone.Replace(")", ") "),
         //         DataCriacao = DateTime.Now,
         //         ContratosREFIN = new List<FastConsig.Core.Entity.SimulacaoContratosREFIN>(),
         //         EspecieBeneficio = requisicao.EspecieBeneficio,
         //         Operacoes = new CreditManager.Entity.SimulacaoOperacao() { RedeLojas = "000001", Loja = "0001", Tabela = t.Plano, Prazo = requisicao.QtdParcelasContrato, ValorOperacao = requisicao.SaldoDevedor, Produto = produtoRetencao.ProdutoRetencao, DataEmissao = requisicao.DataReferenciaSaldo },
         //         Usuario = "System",
         //         Tabela = t.Plano,
         //         Promotora = new CreditManager.Entity.Promotoras() { Id = 1 },
         //         TipoComunicacao = 1,
         //         Proponente = new CreditManager.Entity.SimulacaoPessoa() { CpfCnpj = requisicao.CpfCnpjCliente, Nome = requisicao.NomeCliente, DataNascimento = requisicao.DataNascimento, Celular = int.Parse(requisicao.Telefone.Split(')')[1]) }
         //      };

         //      simulacao.ContratosREFIN.Add(new CreditManager.Entity.SimulacaoContratosREFIN() { Empresa = "01", Agencia = "0001", Contrato = requisicao.ContratoFormatado, CpfCnpj = requisicao.CpfCnpjCliente, DataSaldoDevedor = requisicao.DataReferenciaSaldo, SaldoDevedor = requisicao.SaldoDevedor, Produto = requisicao.ProdutoOrigem, Utilizado = true, Matricula = requisicao.NumeroBeneficio });
         //      PropostaService.GetInstance().SalvarSimulacao(simulacao);

         //      try
         //      {
         //         PropostaService.GetInstance().SubmeterSimulacao(simulacao);
         //         CTCRequisicaoSimulacao simulacaoRequisicao = new CTCRequisicaoSimulacao()
         //         {
         //            CET = simulacao.Operacoes.CETAno,
         //            DataReferencia = simulacao.Operacoes.DataEmissao,
         //            Parcelas = simulacao.Operacoes.Prazo,
         //            PrimeiroVencimento = simulacao.Operacoes.DataPrimeiroVencimento,
         //            Requisicao = requisicao.Id,
         //            Simulacao = simulacao.Id,
         //            SaldoDevedor = simulacao.Operacoes.ValorOperacao,
         //            Tabela = simulacao.Operacoes.Tabela,
         //            Taxa = simulacao.Operacoes.TaxaAno,
         //            Tipo = 3,
         //            ValorParcela = simulacao.Operacoes.ValorParcela,
         //            UltimoVencimento = simulacao.Operacoes.DataPrimeiroVencimento.Value.AddMonths((int)simulacao.Operacoes.Prazo).Date
         //         };

         //         CTCService.GetInstance().InserirRequesicaoSimulacao(simulacaoRequisicao);
         //      }
         //      catch (Exception ex)
         //      {
         //         if (ex.Message == "Cliente sem autorização válida. Antes de submeter a simulação coletar a autorização!")
         //         {
         //            CTCRequisicaoSimulacao simulacaoRequisicao = new CTCRequisicaoSimulacao()
         //            {
         //               CET = simulacao.Operacoes.CETAno,
         //               DataReferencia = simulacao.Operacoes.DataEmissao,
         //               Parcelas = simulacao.Operacoes.Prazo,
         //               PrimeiroVencimento = simulacao.Operacoes.DataPrimeiroVencimento,
         //               Requisicao = requisicao.Id,
         //               Simulacao = simulacao.Id,
         //               SaldoDevedor = simulacao.Operacoes.ValorOperacao,
         //               Tabela = simulacao.Operacoes.Tabela,
         //               Taxa = simulacao.Operacoes.TaxaAno,
         //               Tipo = 3,
         //               ValorParcela = simulacao.Operacoes.ValorParcela,
         //               UltimoVencimento = simulacao.Operacoes.DataPrimeiroVencimento.Value.AddMonths((int)simulacao.Operacoes.Prazo).Date
         //            };
         //            CTCService.GetInstance().InserirRequesicaoSimulacao(simulacaoRequisicao);
         //         }
         //         else
         //         {
         //            LogService.GetInstance().GravarLogErro(ex, "Falha ao Calcular a Oferta para a Requisição ID " + requisicao.Id + " - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace, requisicao);
         //         }
         //      }
         //   }
         //}
      }
   }
}
