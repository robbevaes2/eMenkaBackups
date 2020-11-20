using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data.Repositories
{
    public class DriverRepository : GenericRepository<Driver>, IDriverRepository
    {
        private readonly EfenkaContext _context;

        public DriverRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Driver> GetAll()
        {
            return _context.Drivers
                .Include(d => d.Person)
                .ToList();
        }

        public override Driver GetById(int id)
        {
            return _context.Drivers
                .Include(d => d.Person)
                .FirstOrDefault(d => d.Id == id);
        }

        public override IEnumerable<Driver> Find(Expression<Func<Driver, bool>> statement)
        {
            return _context.Drivers
                .Where(statement)
                .Include(d => d.Person)
                .ToList();
        }
    }
}