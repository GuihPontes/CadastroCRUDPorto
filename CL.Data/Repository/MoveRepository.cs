using CL.Core.Domain;
using CL.Data.Context;
using CL.Manager.InterfacesRepositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Data.Repository
{
    public class MoveRepository : IMoveRepository
    {
        private readonly CLContext _context;

        public MoveRepository(CLContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            var consulta = await _context.Enderecos.FindAsync(id);
            _context.Enderecos.Remove(consulta);
            await _context.SaveChangesAsync();
        }

        public async Task<Movimentacao> GetAsync(int id)
        {
            return await _context.Enderecos.
               Include(p => p.Cliente).

               SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Movimentacao>> GetAsync()
        {
            return await _context.Enderecos.
               Include(p => p.Cliente).

               AsNoTracking().ToListAsync();
        }

        public async Task<Movimentacao> InsertAsync(Movimentacao move)
        {
            await _context.AddAsync(move);
            await _context.SaveChangesAsync();

            return move;
        }

        public async Task<Movimentacao> UpdateAsync(Movimentacao move)
        {
            var consulta = await _context.Enderecos.FindAsync(move.Id);

            if (consulta == null)
            {
                return null;
            }

            _context.Entry(consulta).CurrentValues.SetValues(move);

            await _context.SaveChangesAsync();
            return consulta;
        }
    }
}
