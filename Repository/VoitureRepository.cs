using System.Collections.Generic;
using System.Threading.Tasks;
using Api.PackDbContext;
using Microsoft.EntityFrameworkCore;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public class VoitureRepository : IVoitureRepository
    {

        public readonly PackContext _context;
        public VoitureRepository(PackContext context)
        {
            _context = context;
        }

        public async Task<List<Voiture>> GetVoiture()
        {
            return await _context.Voiture.ToListAsync();
        }

        public async Task<Voiture> GetVoitureById(int id)
        {
            return await _context.Voiture.FindAsync(id);
        }

        public async Task CreateVoiture(Voiture Voiture)
        {
            _context.Voiture.Add(Voiture);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVoiture(int id)
        {
            Voiture Voiture = await GetVoitureById(id);
            _context.Voiture.Remove(Voiture);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVoiture(Voiture Voiture)
        {
            _context.Voiture.Update(Voiture);
            await _context.SaveChangesAsync();
        }

    }
}
