using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class MotorTypeRepository : GenericRepository<MotorType>, IMotorTypeRepository
    {
        public MotorTypeRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
