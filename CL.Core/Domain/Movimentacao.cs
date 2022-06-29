using System;

namespace CL.Core.Domain
{
    public class Movimentacao
    {
        public int ClienteId { get; set; }
        public string Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public Cliente Cliente { get; set; }
    }
}