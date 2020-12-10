using eMenka.API.Mappers.SupplierMappers;
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
        public SupplierController(ISupplierRepository supplierRepository) : base(supplierRepository,
            new SupplierMapper())
        {
        }
    }
}
