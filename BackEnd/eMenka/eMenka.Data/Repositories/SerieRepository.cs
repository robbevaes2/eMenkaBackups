using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data.Repositories
{
    public class SerieRepository : GenericRepository<Serie>, ISerieRepository
    {
        private readonly EfenkaContext _context;

        public SerieRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override Serie GetById(int id)
        {
            return _context.Series.Include(s => s.Brand).FirstOrDefault(s => s.Id == id);
        }

        public override IEnumerable<Serie> GetAll()
        {
            return _context.Series.Include(s => s.Brand).ToList();
        }

        public override IEnumerable<Serie> Find(Expression<Func<Serie, bool>> statement)
        {
            return _context.Series.Where(statement).Include(s => s.Brand).ToList();
        }
    }
}
