using FastConsig.Consignado.Model.DataPrev;
using FluentValidation;

namespace FastConsig.DataPrev.Services.Validators
{
   public class DataPrevValidatorInformacaoComplementarContrato : AbstractValidator<InformacaoContratoRequestModel>
   {
      public DataPrevValidatorInformacaoComplementarContrato()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");
         RuleFor(c => c.NumeroBeneficio).NotNull().WithMessage("Número do benefício não pode ser nulo!");
         RuleFor(c => c.NumeroContrato).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser nulo ou em branco!");
      }
   }
}
