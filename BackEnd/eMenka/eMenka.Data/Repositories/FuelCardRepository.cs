using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data.Repositories
{
    public class FuelCardRepository : GenericRepository<FuelCard>, IFuelCardRepository
    {
        private readonly EfenkaContext _context;

        public FuelCardRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<FuelCard> GetAll()
        {
            return _context.FuelCards
                .Include(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Series)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Category)
                .ToList();
        }

        public override FuelCard GetById(int id)
        {
            return _context.FuelCards
                .Include(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Series)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Category)
                .FirstOrDefault(fc => fc.Id == id);
        }

        public override IEnumerable<FuelCard> Find(Expression<Func<FuelCard, bool>> statement)
        {
            return _context.FuelCards
                .Include(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Series)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(fc => fc.Vehicle)
                .ThenInclude(v => v.Category)
                .ToList();
        }
    }
}