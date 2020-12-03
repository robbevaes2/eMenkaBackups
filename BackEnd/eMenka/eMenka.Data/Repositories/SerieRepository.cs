using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class SerieRepository : GenericRepository<Series>, ISerieRepository
    {
        private readonly EfenkaContext _context;

        public SerieRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override Series GetById(int id)
        {
            return _context.Series.Include(s => s.Brand).FirstOrDefault(s => s.Id == id);
        }

        public override IEnumerable<Series> GetAll()
        {
            return _context.Series.Include(s => s.Brand).ToList();
        }

        public override IEnumerable<Series> Find(Expression<Func<Series, bool>> statement)
        {
            return _context.Series.Where(statement).Include(s => s.Brand).ToList();
        }
    }
}