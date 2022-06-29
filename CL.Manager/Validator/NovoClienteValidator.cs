using CL.Core.Domain;
using CL.Core.DTO.Cliente;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Validator
{
    public class NovoClienteValidator : AbstractValidator<NovoCliente>
    {
        public NovoClienteValidator()
        {
            
            RuleFor(x => x.Status)
               .NotNull()
               .NotEmpty()
               .Must(IsStatus).WithMessage("Status precisar ser Vazio ou Cheio");

            RuleFor(x => x.Tipo)
              .NotNull()
              .NotEmpty()
              .Must(IsTipo).WithMessage("Tipo precisar ser 20 ou 40");

            RuleFor(x => x.Categoria)
              .NotNull()
              .NotEmpty()
              .Must(IsCategoria).WithMessage("Categoria precisar ser Importação ou Exportação");
            RuleFor(x => x.Numero)
                .NotNull()
                .NotEmpty()
                .Matches(@"\w{4}\d{7}")
                .MaximumLength(11)
                .WithMessage("O formato está incorreto (Formato correto : TEST1234567 ");


            RuleForEach(p => p.Endereco).SetValidator(new EnderecoValidador());
            RuleFor(x => x.Endereco).NotEmpty().NotNull();

        }

        private bool IsStatus(string status)
        {
            return status == "Vazio"|| status == "Cheio";
        }

        private bool IsCategoria(string categoria)
        {
            return categoria == "Exportação" || categoria == "Importação";
        }
        private bool IsTipo(string tipo)
        {
            return tipo == "20" || tipo == "40";
        }


    }
}
