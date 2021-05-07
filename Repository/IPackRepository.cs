using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public interface IPackRepository
    {
        Task<List<Pack>> GetPack();
        Task<Pack> GetPackById(int id);
        Task CreatePack(Pack Pack);
        Task UpdatePack(Pack Pack);
        Task DeletePack(int id);
    }
}