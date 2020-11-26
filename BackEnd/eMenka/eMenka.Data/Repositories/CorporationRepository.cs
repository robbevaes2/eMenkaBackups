using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class CorporationRepository : GenericRepository<Corporation>, ICorporationRepository
    {
        private readonly EfenkaContext _context;

        public CorporationRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Corporation> GetAll()
        {
            return _context.Corporations
                .Include(c => c.Company)
                .ToList();
        }

        public override Corporation GetById(int id)
        {
            return _context.Corporations
                .Include(c => c.Company)
                .FirstOrDefault(c => c.Id == id);
        }

        public override IEnumerable<Corporation> Find(Expression<Func<Corporation, bool>> statement)
        {
            return _context.Corporations
                .Where(statement)
                .Include(c => c.Company)
                .ToList();
        }
    }
}