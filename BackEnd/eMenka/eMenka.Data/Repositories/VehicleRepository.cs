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
            return _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.Series)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .FirstOrDefault(v => v.Id == id);
        }

        public override IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .ToList();
        }

        public override IEnumerable<Vehicle> Find(Expression<Func<Vehicle, bool>> statement)
        {
            return _context.Vehicles
                .Where(statement)
                .Include(v => v.Brand)
                .Include(v => v.Model)
                .Include(v => v.FuelType)
                .Include(v => v.EngineType)
                .Include(v => v.DoorType)
                .Include(v => v.Category)
                .Include(v => v.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .ToList();
        }
    }
}
