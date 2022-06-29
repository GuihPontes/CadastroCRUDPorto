using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Clientes { get; set; }
        public string Numero { get; set; }

        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }

        public ICollection<Movimentacao> Endereco { get; set; }


    }
}
