using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Core.DTO.Cliente
{
   public class NovoCliente
    {
        public string Clientes { get; set; }
        public string Numero { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }

        public ICollection<NovoEndereco> Endereco { get; set; }
       

    }
}
