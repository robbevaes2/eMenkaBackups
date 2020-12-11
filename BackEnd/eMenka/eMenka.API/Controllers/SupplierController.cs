using System.Linq;
using AutoMapper;
using eMenka.API.Models.SupplierModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class SupplierController : GenericController<Supplier, SupplierModel, SupplierReturnModel>
    {
        private ISupplierRepository _supplierRepository;
        public SupplierController(ISupplierRepository supplierRepository, IMapper mapper) : base(supplierRepository,
            mapper)
        {
            _supplierRepository = supplierRepository;
        }

        public override IActionResult PostEntity(SupplierModel model)
        {
            var supplier = _supplierRepository.Find(s => s.Name == model.Name).FirstOrDefault();

            if (supplier != null)
            {
                return BadRequest($"Leverancier '{model.Name}' bestaat al.");
            }
            return base.PostEntity(model);
        }
    }
}
