using CL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.InterfacesRepositorio
{
    public interface IMoveRepository
    {
        Task DeleteAsync(int id);
        Task<Movimentacao> GetAsync(int id);
        Task<IEnumerable<Movimentacao>> GetAsync();
        Task<Movimentacao> InsertAsync(Movimentacao move);
        Task<Movimentacao> UpdateAsync(Movimentacao move);
    }
}
