using FastConsig.Consignado.Model;
using FluentValidation;

namespace FastConsig.DataPrev.Services.Validators
{
   public class DataPrevValidator : AbstractValidator<ConsignadoAutorizacaoModel>
   {
      public DataPrevValidator()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");

         RuleFor(c => c.CpfCnpj).NotNull().WithMessage("CPF CNPJ não pode ser nulo!");
         //RuleFor(c => c.Proposta).NotNull().WithMessage("Número da proposta não pode ser nulo!");

         //RuleFor(c => c.CodigoSolicitante).NotNull().WithMessage("Código Solicitante não pode ser nulo!");

         RuleFor(c => c.UsuarioExecucao).NotEmpty().WithMessage("Usuário não pode ser vazio!");
         RuleFor(c => c.UsuarioExecucao).NotNull().WithMessage("Usuário não pode ser nulo!");

         /*
            Campos para validação da Autorização Digital
               nsuAutorizacaoDigital
               dataHoraAutorizacaoDigital
               canalAutorizacaoDigital
         */

         When(c => c.NsuAutorizacaoDigital.HasValue, () =>
         {

            RuleFor(p => p.NsuAutorizacaoDigital).NotNull().WithMessage("Para autorização digital o campo Nsu Autorizacao Digital não pode ser nulo!");
            RuleFor(p => p.DataHoraAutorizacaoDigital).NotNull().WithMessage("Para autorização digital o campo Data Hora Autorizacao Digital não pode ser nulo!");
            RuleFor(p => p.CanalAutorizacaoDigital).NotNull().WithMessage("Para autorização digital o campo Canal Autorizacao Digital não pode ser nulo!");
         });

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

         When(c => !c.NsuAutorizacaoDigital.HasValue && c.ChaveIdentificadora.HasValue, () =>
         {

            RuleFor(p => p.TipoDocumentoIdentificacao).NotNull().WithMessage("Para autorização PDF/A o campo Tipo Documento Identificacao não pode ser nulo!");
            RuleFor(p => p.DocumentoIdentificacao).NotNull().WithMessage("Para autorização PDF/A o campo Documento Identificacao não pode ser nulo!");
            RuleFor(p => p.ChaveIdentificadora).NotNull().WithMessage("Para autorização PDF/A o campo Chave Identificadora não pode ser nulo!");
            RuleFor(p => p.TermoAutorizacaoBeneficiario).NotNull().WithMessage("Para autorização PDF/A o campo TermoAutorizacaoBeneficiario não pode ser nulo!");
            RuleFor(p => p.TituloTermo).NotNull().WithMessage("Para autorização PDF/A o campo TituloTermo não pode ser nulo!");
            RuleFor(p => p.AutorTermo).NotNull().WithMessage("Para autorização PDF/A o campo AutorTermo não pode ser nulo!");
            RuleFor(p => p.CidadeAssinaturaTermo).NotNull().WithMessage("Para autorização PDF/A o campo CidadeAssinaturaTermo não pode ser nulo!");
            RuleFor(p => p.DataHoraCriacaoTermo).NotNull().WithMessage("Para autorização PDF/A o campo DataHoraCriacaoTermo não pode ser nulo!");
         });
      }
   }
}
