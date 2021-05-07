using System.Collections.Generic;
using System.Threading.Tasks;
using Api.PackDbContext;
using Microsoft.EntityFrameworkCore;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public class CircuitRepository : ICircuitRepository
    {

        public readonly PackContext _context;
        public CircuitRepository(PackContext context)
        {
            _context = context;
        }

        public async Task<List<Circuit>> GetCircuit()
        {
            return await _context.Circuit.ToListAsync();
        }

        public async Task<Circuit> GetCircuitById(int id)
        {
            return await _context.Circuit.FindAsync(id);
        }

        public async Task CreateCircuit(Circuit Circuit)
        {
            _context.Circuit.Add(Circuit);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCircuit(int id)
        {
            Circuit Circuit = await GetCircuitById(id);
            _context.Circuit.Remove(Circuit);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCircuit(Circuit Circuit)
        {
            _context.Circuit.Update(Circuit);
            await _context.SaveChangesAsync();
        }

    }
}
