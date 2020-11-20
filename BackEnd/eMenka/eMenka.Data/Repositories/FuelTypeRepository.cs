using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class FuelTypeRepository : GenericRepository<FuelType>, IFuelTypeRepository
    {
        public FuelTypeRepository(EfenkaContext context) : base(context)
        {
        }
    }
}