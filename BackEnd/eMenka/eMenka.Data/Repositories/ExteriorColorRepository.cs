using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class ExteriorColorRepository : GenericRepository<ExteriorColor>, IExteriorColorRepository
    {
        public ExteriorColorRepository(EfenkaContext context) : base(context)
        {
        }
    }
}