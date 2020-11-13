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
    public class MotorTypeRepository : GenericRepository<MotorType>, IMotorTypeRepository
    {
        private readonly EfenkaContext _context;

        public MotorTypeRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override MotorType GetById(int id)
        {
            return _context.MotorTypes.Include(mt => mt.Brand).FirstOrDefault(mt => mt.Id == id);
        }

        public override IEnumerable<MotorType> GetAll()
        {
            return _context.MotorTypes.Include(mt => mt.Brand).ToList();
        }

        public override IEnumerable<MotorType> Find(Expression<Func<MotorType, bool>> statement)
        {
            return _context.MotorTypes.Where(statement).Include(mt => mt.Brand).ToList();
        }
    }
}
