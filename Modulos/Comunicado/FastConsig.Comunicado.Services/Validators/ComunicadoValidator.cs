using FastConsig.Comunicado.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Comunicado.Services.Validators
{
   public class ComunicadoValidator : AbstractValidator<Comunicados>
   {
      public ComunicadoValidator()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo!");

         RuleFor(c => c.Titulo).NotNull().NotEmpty().WithMessage("Titulo não pode ser nulo ou vazio!");

         RuleFor(c => c.Status).NotNull().NotEmpty().WithMessage("Status não pode ser nulo ou vazio!");

         RuleFor(c => c.Conteudo).NotNull().NotEmpty().WithMessage("Conteúdo não pode ser nulo ou vazio!");

         RuleFor(c => c.Usuario).NotNull().NotEmpty().WithMessage("Usuario que esta criando o comunicado não pode ser nulo ou vazio!");

         RuleFor(c => c.DataVigenciaInicial).Must(c => c.HasValue).WithMessage("Data Início Vigência não pode ser nulo ou vazio!");

         RuleFor(c => c.DataVigenciaFinal).Must(c => c.HasValue).WithMessage("Data Fim Vigência não pode ser nulo ou vazio!");

         When(c => c.DataVigenciaInicial.HasValue, () =>
         {
            RuleFor(c => c.DataVigenciaInicial).NotNull().Must(c => c.Value.Date >= DateTime.Now.Date).WithMessage("Não é permitido criar um comunicado com data de início menor do que hoje.");
         });

         When(c => c.DataVigenciaInicial.HasValue, () =>
         {
            RuleFor(c => c.DataVigenciaInicial.Value.Date > c.DataVigenciaFinal.Value.Date).NotNull().WithMessage("Campo Data Final da Vigência não pode ser menor que a data inicial.");
         });
      }
   }
}
