using FastConsig.Core.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Services.Validators
{
   public class PropostaValidator : AbstractValidator<PropostaModel>
   {
      public PropostaValidator()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");
         RuleFor(c => c.Id).NotNull().NotEmpty().WithMessage("Titulo não pode ser nulo ou vazio!");
         RuleFor(c => c.Proponente.Nome).NotNull().NotEmpty().WithMessage("Titulo não pode ser nulo ou vazio!");

         //When(c => c.DataVigenciaInicial.HasValue, () =>
         //{
         //   RuleFor(c => c.DataVigenciaInicial.Value.Date > c.DataVigenciaFinal.Value.Date).NotNull().WithMessage("Campo Data Final da Vigência não pode ser menor que a data inicial.");
         //});

         // validação do modelo
         //var validate = new ComunicadoValidator().Validate(comunicado);

         //if (!validate.IsValid)
         //   throw new ComunicadoException(String.Join("\r", validate.Errors.Select(c => c.ErrorMessage)));

      }
   }
}
