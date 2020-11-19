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
                .Include(r => r.Company)
                .ToList();
        }

        public override Record GetById(int id)
        {
            return _context.Records
                .Include(r => r.Company)
                .FirstOrDefault(r => r.Id == id);
        }

        public override IEnumerable<Record> Find(Expression<Func<Record, bool>> statement)
        {
            return _context.Records
                .Where(statement)
                .Include(r => r.Company)
                .ToList();
        }
    }
}
