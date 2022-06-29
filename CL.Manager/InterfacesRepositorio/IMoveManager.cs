using CL.Core.Domain;
using CL.Core.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.InterfacesRepositorio
{
    public interface IMoveManager
    {
        Task<Movimentacao> GetAsync(int id);
        Task<IEnumerable<Movimentacao>> GetAsync();
        Task DeleteAsync(int id);
        Task<Movimentacao> InsertAsync(NovoMove move);
        Task<Movimentacao> UpdateAsync(AlteraMove cliente);
    }
}
