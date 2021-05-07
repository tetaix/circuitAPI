using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tetaix_circuit.Modele;

namespace Api.Repositories
{
    public interface ICircuitRepository
    {
        Task<List<Circuit>> GetCircuit();
        Task<Circuit> GetCircuitById(int id);
        Task CreateCircuit(Circuit Circuit);
        Task UpdateCircuit(Circuit Circuit);
        Task DeleteCircuit(int id);
    }
}