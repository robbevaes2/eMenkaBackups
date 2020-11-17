using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class EngineTypeRepository : GenericRepository<EngineType>, IEngineTypeRepository
    {
        public EngineTypeRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
