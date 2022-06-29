
using CL.Core.Domain;
using AutoMapper;
using CL.Core.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.AutoMapper
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>();
                

            CreateMap<NovoEndereco, Movimentacao>();

            CreateMap<NovoMove, Movimentacao>();
            
            

        }
    }
}
