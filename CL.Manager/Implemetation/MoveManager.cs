using AutoMapper;
using CL.Core.Domain;
using CL.Core.DTO.Cliente;
using CL.Manager.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Implemetation
{
    public class MoveManager : IMoveManager
    {
        private readonly IMoveRepository repository;
        private readonly IMapper mapper;
        public MoveManager(IMoveRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<Movimentacao> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }

        public async Task<IEnumerable<Movimentacao>> GetAsync()
        {
            return await repository.GetAsync();
        }

        public async Task<Movimentacao> InsertAsync(NovoMove novoMove)
        {
            var move = mapper.Map<Movimentacao>(novoMove);
            return await repository.InsertAsync(move);
        }

        public async Task<Movimentacao> UpdateAsync(AlteraMove alteraMove)
        {
            var cliente = mapper.Map<Movimentacao>(alteraMove);
            return await repository.UpdateAsync(cliente);
        }
    }
}
