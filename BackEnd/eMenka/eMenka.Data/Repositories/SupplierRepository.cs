using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
