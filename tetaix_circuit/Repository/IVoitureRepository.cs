using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public interface IVoitureRepository
    {
        Task<List<Voiture>> GetVoiture();
        Task<Voiture> GetVoitureById(int id);
        Task CreateVoiture(Voiture Voiture);
        Task UpdateVoiture(Voiture Voiture);
        Task DeleteVoiture(int id);
    }
}