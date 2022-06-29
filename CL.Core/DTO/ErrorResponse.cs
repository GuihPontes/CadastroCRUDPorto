using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Core.DTO
{
   public class ErrorResponse
    {
        public string Id { get; set; }

        public string RequistId { get; set; }
        public DateTime Data { get; set; }
        public string Mensagem { get; set; }

        public ErrorResponse(string id,string requistId)
        {
            Id = id;
            RequistId = requistId;
            Data = DateTime.Now;
            Mensagem = "Erro inseperado";
        }
    }
}
