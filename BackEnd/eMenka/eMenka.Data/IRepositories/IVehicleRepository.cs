using System.Collections.Generic;
using eMenka.Domain.Classes;

namespace eMenka.Data.IRepositories
{
    public interface IVehicleRepository : IGenericRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetAllAvailableVehicles();
        IEnumerable<Vehicle> GetAllAvailableVehiclesByBrandId(int brandId, List<int?> fuelCardIdsInRecord);
    }
}