using FastConsig.Consignado.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.DataPrev.Services.Validators
{
   public class DataPrevValidatorBeneficioMargem : AbstractValidator<ConsignadoAutorizacaoModel>
   {
      public DataPrevValidatorBeneficioMargem()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");
         RuleFor(c => c.CpfCnpj).NotNull().WithMessage("CPF CNPJ não pode ser nulo!");
         //RuleFor(c => c.Proposta).NotNull().WithMessage("Número da proposta não pode ser nulo!");
         RuleFor(c => c.NumeroBeneficio).NotNull().WithMessage("Número do Benefício não pode ser nulo!");
      }
   }
}
