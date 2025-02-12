using FastConsig.Consignado.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Serpro.Services.Validators
{
   public class SIAPEValidator : AbstractValidator<ConsignadoAutorizacaoModel>
   {
      public SIAPEValidator()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");

         RuleFor(c => c.CpfCnpj).NotNull().WithMessage("CPF CNPJ não pode ser nulo!");

         RuleFor(c => c.UsuarioExecucao).NotEmpty().WithMessage("Usuário não pode ser vazio!");
         RuleFor(c => c.UsuarioExecucao).NotNull().WithMessage("Usuário não pode ser nulo!");

         RuleFor(c => c.CodigoOrgao).NotNull().WithMessage("Código da Orgão não pode ser zero.");
         RuleFor(c => c.CodigoMatricula).NotNull().WithMessage("Código da Matrícula não pode ser zero.");
      }
   }
}
