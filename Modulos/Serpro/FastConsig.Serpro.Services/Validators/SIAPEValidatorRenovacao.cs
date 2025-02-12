using FastConsig.Consignado.Model.Serpro;
using FluentValidation;

namespace FastConsig.Serpro.Services.Validators
{
   public class SIAPEValidatorRenovacao : AbstractValidator<RenovarContratoV2Request>
   {
      public SIAPEValidatorRenovacao()
      {
         RuleFor(c => c).NotNull().WithMessage("Modelo não pode ser nulo.");

         RuleFor(c => c.CdConsig).NotNull().NotEmpty().WithMessage("Código da consignatária não pode ser em branco ou nulo");

         RuleFor(c => c.CdSenhaConsig).NotNull().NotEmpty().WithMessage("Senha da consignatária não pode ser em branco ou nulo");

         RuleFor(c => c.NrCpf).NotNull().NotEmpty().WithMessage("CPF do servidor ou pensionista não pode ser em branco ou nulo");
         RuleFor(c => c.NrCpf).Must(ValidarCpf).WithMessage("CPF do servidor ou pensionista não é válido.");

         RuleFor(c => c.CdOrgao).NotNull().NotEmpty().WithMessage("Código do órgão não pode ser em branco ou nulo");

         RuleFor(c => c.CdMatricula).NotNull().NotEmpty().WithMessage("Matrícula do servidor ou pensionista não pode ser em branco ou nulo");

         RuleFor(c => c.CdConvenio).NotNull().NotEmpty().WithMessage("Código do convênio não pode ser em branco ou nulo");

         RuleFor(c => c.NrContrato).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");

         RuleFor(c => c.VlDesconto).NotNull().NotEmpty().WithMessage("Valor de desconto não pode ser em branco ou nulo");
         RuleFor(c => c.PzDesconto).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");
         RuleFor(c => c.VlBruto).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");
         RuleFor(c => c.VlLiquido).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");
         RuleFor(c => c.TxJurosMensal).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");
         RuleFor(c => c.Iof).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");
         RuleFor(c => c.Cet).NotNull().NotEmpty().WithMessage("Número do contrato não pode ser em branco ou nulo");

         RuleFor(c => c.DtValidadeAnuencia).NotNull().WithMessage("Data limite para o servidor aceitar ou rejeitar não pode ser em branco ou nulo");
      }

      /// <summary>
      /// Validar o Cpf
      /// </summary>
      /// <param name="NrCpf"></param>
      /// <returns></returns>
      bool ValidarCpf(string NrCpf) => Common.Helpers.UtilityHelper.IsCpf(NrCpf);
   }
}
