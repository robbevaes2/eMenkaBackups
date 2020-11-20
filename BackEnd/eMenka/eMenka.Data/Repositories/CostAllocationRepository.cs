using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class CostAllocationRepository : GenericRepository<CostAllocation>, ICostAllocationRepository
    {
        public CostAllocationRepository(EfenkaContext context) : base(context)
        {
        }
    }
}