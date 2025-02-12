using FastConsig.Consignado.Entity;
using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;

namespace FastConsig.Consignado.Model
{
   public class ConsignadoAutorizacaoModel : PropostaBaseModel, ICloneable
   {
      public int? Id { get; set; }

      #region *------------------------------------- DataPrev ---------------------------------------------------*

      public long? CpfRepresentante { get; set; }

      public long? NsuAutorizacaoDigital { get; set; }

      public DateTime? DataHoraAutorizacaoDigital { get; set; }

      public int? CanalAutorizacaoDigital { get; set; }

      public int? TipoDocumentoIdentificacao { get; set; }

      public byte[] DocumentoIdentificacao { get; set; }

      public long? ChaveIdentificadora { get; set; }

      public byte[] TermoAutorizacaoBeneficiario { get; set; }

      public bool PossuiAssinaturaRogo { get; set; }

      public string TituloTermo { get; set; }

      public string AutorTermo { get; set; }

      public string CidadeAssinaturaTermo { get; set; }

      public DateTime? DataHoraCriacaoTermo { get; set; }

      public string TokenAutorizacao { get; set; }

      /// <summary>
      /// UI
      /// </summary>
      public long NumeroBeneficio { get; set; }

      #endregion

      #region *------------------------------------- SIAPE ---------------------------------------------------*

      public int? CodigoOrgao { get; set; }

      public int? CodigoMatricula { get; set; }

      #endregion

      public int CodigoSolicitante { get; set; }

      public DateTime DataHoraExecucao { get; set; }

      public DateTime? DataValidadeAutorizacao { get; set; }

      /// <summary>
      /// UI
      /// </summary>
      public string UsuarioExecucao { get; set; }

      /// <summary>
      /// Consignado Detalhe (INSS DataPrev, INSS SIAPE)
      /// </summary>
      public ConsignadoDetalhe ConsignadoDetalhe { get; set; }

      /// <summary>
      /// Consignado DataPrev, SIAPE
      /// </summary>
      public int? TipoConsignado { get; set; }

      public DateTime DataEnvioProcessamento { get; set; }

      /// <summary>
      /// Converter entity ConsignadoAutorizacao para o modelo ConsignadoAutorizacaoModel.
      /// </summary>
      /// <param name="model"></param>
      public static implicit operator ConsignadoAutorizacaoModel(ConsignadoAutorizacao model)
      {
         if (model == null)
            return null;

         return new ConsignadoAutorizacaoModel
         {
            Id = model.Id,
            CpfCnpj = model.Cpf,
            CpfRepresentante = model.CpfRepresentante,
            CanalAutorizacaoDigital = model.CanalAutorizacaoDigital,
            ChaveIdentificadora = model.ChaveIdentificadora,
            NsuAutorizacaoDigital = model.NsuAutorizacaoDigital,
            TokenAutorizacao = model.TokenAutorizacao,
            DataHoraAutorizacaoDigital = model.DataHoraAutorizacaoDigital,
            DataValidadeAutorizacao = model.DataValidadeAutorizacao,
            DocumentoIdentificacao = model.DocumentoIdentificacao,
            TermoAutorizacaoBeneficiario = model.TermoAutorizacaoBeneficiario,
            DataHoraCriacaoTermo = model.DataHoraCriacaoTermo,
            AutorTermo = model.AutorTermo,
            CidadeAssinaturaTermo = model.CidadeAssinaturaTermo,
            PossuiAssinaturaRogo = model.PossuiAssinaturaRogo,
            TipoDocumentoIdentificacao = model.TipoDocumentoIdentificacao,
            TituloTermo = model.TituloTermo,
            ConsignadoDetalhe = model.ConsignadoDetalhe == null ? null : JsonConvert.DeserializeObject<ConsignadoDetalhe>(model.ConsignadoDetalhe),
            CodigoMatricula = model.CodigoMatricula,
            CodigoOrgao = model.CodigoOrgao,
            TipoConsignado = model.TipoConsignado
         };
      }

      /// <summary>
      /// Converter o modelo ConsignadoAutorizacaoModel para a entity ConsignadoAutorizacao.
      /// </summary>
      /// <param name="model"></param>
      public static implicit operator ConsignadoAutorizacao(ConsignadoAutorizacaoModel model)
      {
         if (model == null)
            return null;

         return new ConsignadoAutorizacao
         {
            Id = model.Id,
            Cpf = model.CpfCnpj,
            CpfRepresentante = model.CpfRepresentante,
            CanalAutorizacaoDigital = model.CanalAutorizacaoDigital,
            ChaveIdentificadora = model.ChaveIdentificadora,
            NsuAutorizacaoDigital = model.NsuAutorizacaoDigital,
            TokenAutorizacao = model.TokenAutorizacao,
            DataHoraAutorizacaoDigital = model.DataHoraAutorizacaoDigital,
            DataValidadeAutorizacao = model.DataValidadeAutorizacao,
            DocumentoIdentificacao = model.DocumentoIdentificacao ?? new byte[0],
            TermoAutorizacaoBeneficiario = model.TermoAutorizacaoBeneficiario ?? new byte[0],
            DataHoraCriacaoTermo = model.DataHoraCriacaoTermo,
            AutorTermo = model.AutorTermo,
            CidadeAssinaturaTermo = model.CidadeAssinaturaTermo,
            PossuiAssinaturaRogo = model.PossuiAssinaturaRogo,
            TipoDocumentoIdentificacao = model.TipoDocumentoIdentificacao,
            TituloTermo = model.TituloTermo,
            ConsignadoDetalhe = model.ConsignadoDetalhe == null ? null : JsonConvert.SerializeObject(model.ConsignadoDetalhe),
            TipoConsignado = model.TipoConsignado,
            CodigoOrgao = model.CodigoOrgao,
            CodigoMatricula = model.CodigoMatricula
         };
      }

      /// <summary>
      /// Converter modelo SimulacaoPropostaModel para o modelo ConsignadoAutorizacaoModel.
      /// </summary>
      /// <param name="model"></param>
      public static implicit operator ConsignadoAutorizacaoModel(SimulacaoPropostaModel model)
      {
         return new ConsignadoAutorizacaoModel
         {
            Id = model.Id,
            CpfCnpj = long.Parse(model.Proponente.CpfCnpj),
            NumeroBeneficio = long.Parse(model.Proponente.NumeroBeneficio),
            ConsignadoDetalhe = null
         };
      }

      /// <summary>
      /// Clonar objeto sem refêrencias.
      /// </summary>
      /// <returns></returns>
      public object Clone()
      {
         return new ConsignadoAutorizacaoModel
         {
            Id = this.Id,
            Proposta = this.Proposta,
            UsuarioExecucao = this.UsuarioExecucao,
            AutorTermo = this.AutorTermo,
            CanalAutorizacaoDigital = this.CanalAutorizacaoDigital,
            ChaveIdentificadora = this.ChaveIdentificadora,
            CidadeAssinaturaTermo = this.CidadeAssinaturaTermo,
            CodigoSolicitante = this.CodigoSolicitante,
            ConsignadoDetalhe = this.ConsignadoDetalhe,
            CpfCnpj = this.CpfCnpj,
            CpfRepresentante = this.CpfRepresentante,
            DataHoraAutorizacaoDigital = this.DataHoraAutorizacaoDigital,
            DataHoraCriacaoTermo = this.DataHoraCriacaoTermo,
            DataHoraExecucao = this.DataHoraExecucao,
            DataValidadeAutorizacao = this.DataValidadeAutorizacao,
            DocumentoIdentificacao = this.DocumentoIdentificacao,
            Fase = this.Fase,
            Simulacao = this.Simulacao,
            NsuAutorizacaoDigital = this.NsuAutorizacaoDigital,
            NumeroBeneficio = this.NumeroBeneficio,
            PossuiAssinaturaRogo = this.PossuiAssinaturaRogo,
            TermoAutorizacaoBeneficiario = this.TermoAutorizacaoBeneficiario,
            TipoDocumentoIdentificacao = this.TipoDocumentoIdentificacao,
            TituloTermo = this.TituloTermo,
            TokenAutorizacao = this.TokenAutorizacao
         };
      }

      /// <summary>
      /// Preparando o modelo para autorização digital.
      /// </summary>
      public void AutorizacaoDigital()
      {
         /*
            Campos para validação da Autorização com envio de PDF/A
               tipoDocumentoIdentificacao
               documentoIdentificacao
               chaveIdentificadora
               termoAutorizacaoBeneficiario
               possuiAssinaturaRogo
               tituloTermo
               autorTermo
               cidadeAssinaturaTermo
               dataHoraCriacaoTermo
         */

         this.TipoDocumentoIdentificacao = null;
         this.DocumentoIdentificacao = null;
         this.TermoAutorizacaoBeneficiario = null;
         this.ChaveIdentificadora = null;
         this.TituloTermo = null;
         this.AutorTermo = null;
         this.CidadeAssinaturaTermo = null;
         this.DataHoraCriacaoTermo = null;
      }

      /// <summary>
      /// Preparando o modelo para autorização PDFA.
      /// </summary>
      public void AutorizacaoPDFA()
      {
         /*
          Campos para validação da Autorização Digital
               nsuAutorizacaoDigital
               dataHoraAutorizacaoDigital
               canalAutorizacaoDigital
         */

         this.NsuAutorizacaoDigital = null;
         this.DataHoraAutorizacaoDigital = null;
         this.CanalAutorizacaoDigital = null;
      }
   }
}
