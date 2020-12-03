using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        private readonly EfenkaContext _context;

        public VehicleRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override Vehicle GetById(int id)
        {
            var vehicle = _context.Vehicles
                .Include(v => v.Brand)
                .ThenInclude(b => b.InteriorColors)
                .Include(v => v.Brand)
                .ThenInclude(b => b.ExteriorColors)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.Series)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.Country)
                .Include(v => v.ExteriorColor)
                .Include(v => v.InteriorColor)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .FirstOrDefault(v => v.Id == id);
            return vehicle;
        }

        public override IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles
                .Include(v => v.Brand)
                .ThenInclude(b => b.InteriorColors)
                .Include(v => v.Brand)
                .ThenInclude(b => b.ExteriorColors)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.Country)
                .Include(v => v.ExteriorColor)
                .Include(v => v.InteriorColor)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(s => s.Series)
                .ToList();
        }

        public override IEnumerable<Vehicle> Find(Expression<Func<Vehicle, bool>> statement)
        {
            return _context.Vehicles
                .Where(statement)
                .Include(v => v.Brand)
                .ThenInclude(b => b.InteriorColors)
                .Include(v => v.Brand)
                .ThenInclude(b => b.ExteriorColors)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.Country)
                .Include(v => v.ExteriorColor)
                .Include(v => v.InteriorColor)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(s => s.Series)
                .ToList();
        }
    }
}