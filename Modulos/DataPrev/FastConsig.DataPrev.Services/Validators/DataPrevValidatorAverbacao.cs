using FastConsig.Consignado.Model.DataPrev;
using FluentValidation;

namespace FastConsig.DataPrev.Services.Validators
{
   public class DataPrevValidatorAverbacao : AbstractValidator<AverbacaoEmprestimoConsignadoModel>
   {
      public DataPrevValidatorAverbacao()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");
         RuleFor(c => c.NumeroBeneficio).NotNull().WithMessage("Número do benefício não pode ser nulo!");
         //RuleFor(c => c.CompetenciaInicioDesconto).NotNull().WithMessage("Competência do inicio do desconto não pode ser nulo!");
         RuleFor(c => c.NumeroContrato).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser nulo ou em branco!");
         RuleFor(c => c.CpfMutuario).NotNull().NotEmpty().WithMessage("CPF Mutuário não pode ser nulo ou em branco!");
         RuleFor(c => c.NomeMutuario).NotNull().NotEmpty().WithMessage("Nome do Mutuário não pode ser nulo ou em branco!");
         RuleFor(c => c.NomeMutuario).NotNull().NotEmpty().WithMessage("Nome do Mutuário não pode ser nulo ou em branco!");
         RuleFor(c => c.Ufaps).NotNull().NotEmpty().WithMessage("Sigla do Estado do favorecido inválida não pode ser nulo ou em branco!");

         RuleFor(c => c.ClassificadorModalidade).NotNull().WithMessage("Classificador de modalidade de consignação não pode ser nulo ou em branco!");

         RuleFor(c => c.DataInicioContrato).NotNull().WithMessage("Data de início do contrato não pode ser nulo ou em branco!");
         RuleFor(c => c.DataFimContrato).NotNull().WithMessage("Data fim do contrato não pode ser nulo ou em branco!");

         RuleFor(c => c.NumeroParcelas).NotNull().WithMessage("Quantidade de parcelas não pode ser nulo!");
         RuleFor(c => c.ValorLiberado).NotNull().WithMessage("Valor da parcela não pode ser nulo!");
         RuleFor(c => c.ValorEmprestimo).NotNull().WithMessage("O valor do empréstimo não pode ser nulo!");
         RuleFor(c => c.ValorParcela).NotNull().WithMessage("O valor do empréstimo não pode ser nulo!");
         RuleFor(c => c.ValorParcela).NotNull().WithMessage("O valor do empréstimo não pode ser nulo!");

         //RuleFor(c => c.CnpjCorrespondente).NotNull().WithMessage("Classificador de modalidade de consignação não pode ser nulo ou em branco!");

         RuleFor(c => c.ValorTaxaAnual).NotNull().WithMessage("Valor Taxa Anual não pode ser nulo!");
         RuleFor(c => c.ValorCetAnual).NotNull().WithMessage("Valor CET Anual não pode ser nulo!");

         RuleFor(c => c.CbcIfPagadora).NotNull().WithMessage("CBC da IF pagadora não pode ser nulo!");

         RuleFor(c => c.AgenciaPagadora).NotNull().WithMessage("Agência pagadora não pode ser nulo!");
         RuleFor(c => c.ContaCorrente).NotNull().WithMessage("Conta Corrente não pode ser nulo!");
         RuleFor(c => c.DvContaCorrente).NotNull().WithMessage("Dígito verificador da conta corrente não pode ser nulo!");

         RuleFor(c => c.CanalAtendimento).NotNull().WithMessage("Canal do atendimento não pode ser nulo!");
      }
   }
}
