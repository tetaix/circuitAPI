using System.Collections.Generic;
using Api.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tetaix_circuit.Modele;
using tetaix_circuit.Dtos;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("Circuit")]

    public class CircuitController : Controller
    {
        private readonly ICircuitRepository _circuitrepository;
        private readonly IMapper _mapper;

        public CircuitController(ICircuitRepository circuitRepository, IMapper mapper)
        {
            _circuitrepository = circuitRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Circuit>>> GetCircuit()
        {
            return Ok( await _circuitrepository.GetCircuit());
        }

        //[Authorize(Roles = "admin")]
        [HttpGet("{circuitId}", Name = "GetCircuit")]

        public async Task<ActionResult<Circuit>> GetCircuitByID(int circuitid)
        {
            return Ok(await _circuitrepository.GetCircuitById(circuitid));
        }




    }
}
