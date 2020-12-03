using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class EngineTypeRepository : GenericRepository<EngineType>, IEngineTypeRepository
    {
        private readonly EfenkaContext _context;

        public EngineTypeRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override EngineType GetById(int id)
        {
            return _context.EngineTypes.Include(mt => mt.Brand).FirstOrDefault(mt => mt.Id == id);
        }

        public override IEnumerable<EngineType> GetAll()
        {
            return _context.EngineTypes.Include(mt => mt.Brand).ToList();
        }

        public override IEnumerable<EngineType> Find(Expression<Func<EngineType, bool>> statement)
        {
            return _context.EngineTypes.Where(statement).Include(mt => mt.Brand).ToList();
        }
    }
}