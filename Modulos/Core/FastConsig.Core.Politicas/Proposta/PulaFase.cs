using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using FastConsig.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Politicas.Proposta
{
   public class PulaFase : IPolitica
   {
      public void Execute(PropostaModel proposta, int? fase, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Pular de Fase para a Proposta: " + proposta.Id.ToString() + " - Fase Entrada: " + proposta.Fase);
         //Gravando a Saida de Fase
         PropostaService.GetInstance().GravarHistoricoProposta(proposta, "SubmeterProposta");

         var faseProposta = PropostaService.GetInstance().ObtemFase(proposta.Fase);

         var proximaFase = PropostaService.GetInstance().BuscaProximaFase(proposta.Operacoes.Produto, fase);

         //Muda a Proposta para a Nova Fase
         var entrada = false;
         var saida = true;

         //SUBMETIDA
         if (proposta.Status == 12)
         {
            entrada = false;
            saida = false;
         }

         proposta.Fase = PropostaService.GetInstance().ObtemFase(proximaFase).Id;
         proposta.Status = 8; //PROCESSANDO

         //TODO: Liberar o usuário que está usuando a proposta

         // Gravando histórico de cada alteração de fase da proposta.
         PropostaService.GetInstance().GravarHistoricoProposta(proposta, "");

         //Salva a Proposta na nova Fase
         PropostaService.GetInstance().AtualizaProposta(proposta);

         //Verifica as Politicas de Saída
         var politicas = PropostaService.GetInstance().ListarPoliticasFase(fase, proposta.Operacoes.Produto, proposta.Status, entrada, saida);

         //Roda as Politicas de Saída
         foreach (PoliticaConfiguracaoExecucao p in politicas)
         {
            if (proposta.Proponente.TipoPessoa == p.TipoPessoaCodigo)
            {
               try
               {
                  PropostaService.GetInstance().ExecutaPolitica(p.Metodo, proposta, fase, p.TipoPessoaCodigo);
               }
               catch (Exception ex)
               {
                  throw new Exception(ex.Message, ex);
               }
            }
         }

         //Submete e Proposta para a Nova Fase
         PropostaService.GetInstance().SubmeterProposta(proposta);
         LogService.GetInstance().GravarLogDebug("Término do Processamento da Politica de Pular de Fase para a Proposta: " + proposta.Id.ToString() + " Fase Saida: " + proposta.Fase);

      }
   }
}
