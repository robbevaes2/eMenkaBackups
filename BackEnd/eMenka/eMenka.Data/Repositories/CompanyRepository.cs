using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(EfenkaContext context) : base(context)
        {
        }
    }
}