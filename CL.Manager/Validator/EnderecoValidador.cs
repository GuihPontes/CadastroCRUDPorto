using CL.Core.DTO.Cliente;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Validator
{
   public class EnderecoValidador : AbstractValidator<NovoEndereco>
    {
        public EnderecoValidador()
        {
            RuleFor(x => x.Tipo)
             .NotNull()
             .NotEmpty()
             .Must(IsTipo).WithMessage("Tipo errado");

        }

        private bool IsTipo(string tipo)
        {
            return tipo == "Embarque" || tipo == "Descarga" || tipo == "Gate in" || tipo == "Gate out" || tipo == "Reposicionamento" || tipo == "Pesagem" || tipo == "Scanner";
        }

    }
}
