using System.Linq;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FuelCardController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IFuelCardRepository _fuelCardRepository;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository)
        {
            _fuelCardRepository = fuelCardRepository;
            _driverRepository = driverRepository;
        }

        [HttpGet]
        public IActionResult GetAllFuelCards()
        {
            var fuelCards = _fuelCardRepository.GetAll();

            return Ok(fuelCards.ToList().Select(FuelCardMappers.MapFuelCardEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetFuelCardById(int id)
        {
            var fuelCard = _fuelCardRepository.GetById(id);
            if (fuelCard == null)
                return NotFound();

            return Ok(FuelCardMappers.MapFuelCardEntity(fuelCard));
        }

        [HttpPost]
        public IActionResult PostFuelCard([FromBody] FuelCardModel fuelCardModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (_driverRepository.GetById((int) fuelCardModel.DriverId) == null)
                return NotFound($"Driver with id {fuelCardModel.DriverId} not found");

            _fuelCardRepository.Add(FuelCardMappers.MapFuelCardModel(fuelCardModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuelCard([FromBody] FuelCardModel fuelCardModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != fuelCardModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_driverRepository.GetById((int) fuelCardModel.DriverId) == null)
                return NotFound($"Driver with id {fuelCardModel.DriverId} not found");

            var isUpdated = _fuelCardRepository.Update(id, FuelCardMappers.MapFuelCardModel(fuelCardModel));

            if (!isUpdated)
                return NotFound($"No Fuel card found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFuelCard(int id)
        {
            var fuelCard = _fuelCardRepository.GetById(id);
            if (fuelCard == null)
                return NotFound();

            _fuelCardRepository.Remove(fuelCard);
            return Ok();
        }
    }
}