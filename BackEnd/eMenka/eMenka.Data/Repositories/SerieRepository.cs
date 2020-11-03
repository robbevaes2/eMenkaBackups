using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;

namespace eMenka.Data.Repositories
{
    public class SerieRepository : GenericRepository<Serie>, ISerieRepository
    {
        public SerieRepository(EfenkaContext context) : base(context)
        {
        }
    }
}
