﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
