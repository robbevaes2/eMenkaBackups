using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class FuelCardController : GenericController<FuelCard, FuelCardModel, FuelCardReturnModel>
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IFuelCardRepository _fuelCardRepository;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository) : base(fuelCardRepository, new FuelCardMapper())
        {
            _fuelCardRepository = fuelCardRepository;
            _driverRepository = driverRepository;
        }

        [HttpPost]
        public IActionResult PostFuelCard([FromBody] FuelCardModel fuelCardModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (_driverRepository.GetById((int)fuelCardModel.DriverId) == null)
                return NotFound($"Driver with id {fuelCardModel.DriverId} not found");

            _fuelCardRepository.Add(FuelCardMappers.MapFuelCardModel(fuelCardModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuelCard([FromBody] FuelCardModel fuelCardModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != fuelCardModel.Id)
                return BadRequest("Id from model does not match query parameter id");

            if (_driverRepository.GetById((int)fuelCardModel.DriverId) == null)
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