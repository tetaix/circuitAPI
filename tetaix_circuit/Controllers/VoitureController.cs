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
    [Route("Voiture")]

    public class VoitureController : Controller
    {
        private readonly IVoitureRepository _voiturerepository;
        private readonly IMapper _mapper;

        public VoitureController(IVoitureRepository voitureRepository, IMapper mapper)
        {
            _voiturerepository = voitureRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Voiture>>> GetVoiture()
        {
            return Ok( await _voiturerepository.GetVoiture());
        }

        //[Authorize(Roles = "admin")]
        [HttpGet("{voitureId}", Name = "GetVoiture")]

        public async Task<ActionResult<Voiture>> GetVoitureByID(int voitureid)
        {
            return Ok(await _voiturerepository.GetVoitureById(voitureid));
        }

        [HttpPost]
        public async Task<ActionResult> CreateVoiture(Voiture voiture)
        {
            await _voiturerepository.CreateVoiture(voiture);
            return Ok();
        }




    }
}
