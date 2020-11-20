﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data.Repositories
{
    public class RecordRepository : GenericRepository<Record>, IRecordRepository
    {
        private readonly EfenkaContext _context;

        public RecordRepository(EfenkaContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Record> GetAll()
        {
            return _context.Records
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Category)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Vehicle)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(r => r.Corporation)
                .ThenInclude(c => c.Company)
                .Include(r => r.CostAllocation)
                .ToList();
        }

        public override Record GetById(int id)
        {
            return _context.Records
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Category)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Vehicle)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(r => r.Corporation)
                .ThenInclude(c => c.Company)
                .Include(r => r.CostAllocation)
                .FirstOrDefault(r => r.Id == id);
        }

        public override IEnumerable<Record> Find(Expression<Func<Record, bool>> statement)
        {
            return _context.Records
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Brand)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Model)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.FuelType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.EngineType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.DoorType)
                .Include(r => r.FuelCard)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(v => v.Category)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Vehicle)
                .Include(r => r.FuelCard)
                .ThenInclude(fc => fc.Driver)
                .ThenInclude(d => d.Person)
                .Include(r => r.Corporation)
                .ThenInclude(c => c.Company)
                .Include(r => r.CostAllocation)
                .ToList();
        }
    }
}
