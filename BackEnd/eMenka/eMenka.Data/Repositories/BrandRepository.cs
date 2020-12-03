using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        private readonly EfenkaContext _context;

        public BrandRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Brand> GetAll()
        {
            return _context.Brands
                .Include(b => b.ExteriorColors)
                .Include(b => b.InteriorColors)
                .ToList();
        }

        public override Brand GetById(int id)
        {
            return _context.Brands
                .Include(b => b.ExteriorColors)
                .Include(b => b.InteriorColors)
                .FirstOrDefault(b => b.Id == id);
        }

        public override IEnumerable<Brand> Find(Expression<Func<Brand, bool>> statement)
        {
            return _context.Brands.Where(statement)
                .Include(b => b.ExteriorColors)
                .Include(b => b.InteriorColors)
                .ToList();
        }
    }
}