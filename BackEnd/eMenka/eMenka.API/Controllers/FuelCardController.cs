using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class FuelCardController : GenericController<FuelCard, FuelCardModel, FuelCardReturnModel>
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly FuelCardMapper _fuelCardMapper;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository, ICompanyRepository companyRepository,
            IVehicleRepository vehicleRepository) : base(fuelCardRepository, new FuelCardMapper())
        {
            _fuelCardRepository = fuelCardRepository;
            _driverRepository = driverRepository;
            _vehicleRepository = vehicleRepository;
            _companyRepository = companyRepository;
            _fuelCardMapper = new FuelCardMapper();
        }

        public override IActionResult PostEntity(FuelCardModel model)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var driver = _driverRepository.GetById((int)model.DriverId);

            if (driver == null)
                return NotFound($"Bestuurder met id {model.DriverId} niet gevonden");

            var vehicle = _vehicleRepository.GetById((int)model.VehicleId);

            if (vehicle == null)
                return NotFound($"Voertuig met id {model.VehicleId} niet gevonden");

            var company = _companyRepository.GetById((int)model.CompanyId);

            if (company == null)
                return NotFound($"Bedrijf met id {model.CompanyId} niet gevonden");

            var entity = _fuelCardMapper.MapModelToEntity(model);

            _fuelCardRepository.Add(entity);

            vehicle.FuelCardId = entity.Id;
            driver.FuelCardId = entity.Id;
            _vehicleRepository.Update(vehicle.Id, vehicle);

            return Ok(_fuelCardMapper.MapEntityToReturnModel(entity));
        }

        public override IActionResult UpdateEntity(FuelCardModel model, int id)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Bestuurder met id {model.DriverId} niet gevonden");

            if (_vehicleRepository.GetById((int)model.VehicleId) == null)
                return NotFound($"Voertuig met id {model.VehicleId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}