using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class DoorTypeRepository : GenericRepository<DoorType>, IDoorTypeRepository
    {
        public DoorTypeRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
