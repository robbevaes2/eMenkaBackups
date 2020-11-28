using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMenka.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Tests.Utils
{
    public static class EfenkaContextTestFactory
    {
        public const string EMenka = "Server=(localdb)\\mssqllocaldb;Database=efenkaPXLTest;Trusted_Connection=True;";
        public static EfenkaContext EfenkaContext { get; set; }

        public static void Create()
        {
            if (EfenkaContext == null)
            {
                var dbContextOptions = new DbContextOptionsBuilder<EfenkaContext>().UseSqlServer(EMenka).Options;
                EfenkaContext = new EfenkaContext(dbContextOptions);

                //ensures database is up to date with the latest migration
                EfenkaContext.Database.EnsureDeleted();
                EfenkaContext.Database.EnsureCreated();
            }
        }
    }
}
