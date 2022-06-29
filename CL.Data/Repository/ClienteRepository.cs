using CL.Core.Domain;
using CL.Data.Context;
using CL.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CLContext _context;

        public ClienteRepository(CLContext context)
        {
            _context = context;
        }

      

        public async Task<Cliente> GetCienteAsync(int id)
        {
            return await _context.Clientes.
                Include(p => p.Endereco).
                
                SingleOrDefaultAsync(p=> p.Id == id);
        }


        public async Task<IEnumerable<Cliente>> GetClienteAsync()
        {
            return await _context.Clientes.
                Include(p=>p.Endereco).
                
                AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await _context.AddAsync(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var consulta = await _context.Clientes.FindAsync(cliente.Id);

            if(consulta == null)
            {
                return null;
            }

            _context.Entry(consulta).CurrentValues.SetValues(cliente);

            await _context.SaveChangesAsync();
            return consulta;
            
        }

        public async Task DeleteClienteAsync(int id)
        {
            var consulta = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(consulta);
            await _context.SaveChangesAsync();
        }
    }
}
