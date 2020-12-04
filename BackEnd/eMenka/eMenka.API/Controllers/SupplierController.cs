using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers.SupplierMappers;
using eMenka.API.Models.SupplierModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    public class SupplierController : GenericController<Supplier, SupplierModel, SupplierReturnModel>
    {
        public SupplierController(ISupplierRepository supplierRepository) : base(supplierRepository,
            new SupplierMapper())
        {
        }
    }
}
