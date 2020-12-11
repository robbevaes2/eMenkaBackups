using System;
using System.Linq;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository, ICompanyRepository companyRepository,
            IVehicleRepository vehicleRepository, IMapper mapper) : base(fuelCardRepository, mapper)
        {
            _fuelCardRepository = fuelCardRepository;
            _driverRepository = driverRepository;
            _vehicleRepository = vehicleRepository;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        [HttpGet("enddate/{range}")]
        public IActionResult GetFuelcardByEndDate(int range)
        {
            var fuelcards = _fuelCardRepository.Find(v => v.EndDate >= DateTime.Now.Date && v.EndDate <= DateTime.Now.Date.AddDays(range));

            return Ok(fuelcards.Select(_mapper.Map<FuelCardReturnModel>).ToList());
        }

        public override IActionResult PostEntity(FuelCardModel model)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var driver = _driverRepository.GetById((int)model.DriverId);

            if (driver == null)
                return NotFound($"Bestuurder met id {model.DriverId} niet gevonden");

            if (_fuelCardRepository.Find(r => r.Driver.Id == model.DriverId).FirstOrDefault() != null)
                return BadRequest($"Een tankkaart met bestuurder id {model.DriverId} bestaat al");

            var vehicle = _vehicleRepository.GetById((int)model.VehicleId);

            if (vehicle == null)
                return NotFound($"Voertuig met id {model.VehicleId} niet gevonden");

            if (_fuelCardRepository.Find(r => r.Vehicle.Id == model.VehicleId).FirstOrDefault() != null)
                return BadRequest($"Een tankkaart met voertuig id {model.VehicleId} bestaat al");

            var company = _companyRepository.GetById((int)model.CompanyId);

            if (company == null)
                return NotFound($"Bedrijf met id {model.CompanyId} niet gevonden");

            var entity = _mapper.Map<FuelCard>(model);

            _fuelCardRepository.Add(entity);

            vehicle.FuelCardId = entity.Id;
            driver.FuelCardId = entity.Id;
            _vehicleRepository.Update(vehicle.Id, vehicle);

            return Ok(_mapper.Map<FuelCardReturnModel>(entity));
        }

        public override IActionResult UpdateEntity(FuelCardModel model, int id)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Bestuurder met id {model.DriverId} niet gevonden");

            if (_fuelCardRepository.Find(r => r.Driver.Id == model.DriverId).FirstOrDefault() != null)
                return BadRequest($"Een tankkaart met bestuurder id {model.DriverId} bestaat al");

            if (_vehicleRepository.GetById((int)model.VehicleId) == null)
                return NotFound($"Voertuig met id {model.VehicleId} niet gevonden");

            if (_fuelCardRepository.Find(r => r.Vehicle.Id == model.VehicleId).FirstOrDefault() != null)
                return BadRequest($"Een tankkaart met voertuig id {model.VehicleId} bestaat al");

            return base.UpdateEntity(model, id);
        }
    }
}