using CL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Interfaces
{
    public interface IClienteRepository
    {
        Task DeleteClienteAsync(int id);
        Task<Cliente> GetCienteAsync(int id);
        Task<IEnumerable<Cliente>> GetClienteAsync();
        Task<Cliente> InsertClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);
    }
}
