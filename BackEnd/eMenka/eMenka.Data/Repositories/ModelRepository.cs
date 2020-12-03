using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class ModelRepository : GenericRepository<Model>, IModelRepository
    {
        private readonly EfenkaContext _context;

        public ModelRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override Model GetById(int id)
        {
            return _context.Models.Include(m => m.Brand).FirstOrDefault(m => m.Id == id);
        }

        public override IEnumerable<Model> GetAll()
        {
            return _context.Models.Include(m => m.Brand).ToList();
        }

        public override IEnumerable<Model> Find(Expression<Func<Model, bool>> statement)
        {
            return _context.Models.Where(statement).Include(m => m.Brand).ToList();
        }
    }
}