using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.PackDbContext;
using Microsoft.EntityFrameworkCore;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public class PackRepository : IPackRepository
    {

        public readonly PackContext _context;
        public PackRepository(PackContext context)
        {
            _context = context;
        }

        public async Task<List<Pack>> GetPack()
        {
            return await _context.Pack.ToListAsync();
        }

        public async Task<Pack> GetPackById(int id)
        {
            return await _context.Pack.FindAsync(id);
        }

        public async Task CreatePack(Pack Pack)
        {
            _context.Pack.Add(Pack);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePack(int id)
        {
            Pack Pack = await GetPackById(id);
            _context.Pack.Remove(Pack);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePack(Pack Pack)
        {
            _context.Pack.Update(Pack);
            await _context.SaveChangesAsync();
        }

    }
}
