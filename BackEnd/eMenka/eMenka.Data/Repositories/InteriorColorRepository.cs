using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class InteriorColorRepository : GenericRepository<InteriorColor>, IInteriorColorRepository
    {
        public InteriorColorRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
