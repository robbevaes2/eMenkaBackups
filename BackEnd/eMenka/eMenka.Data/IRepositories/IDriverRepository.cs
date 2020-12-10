using System.Collections.Generic;
using eMenka.Domain.Classes;

namespace eMenka.Data.IRepositories
{
    public interface IDriverRepository : IGenericRepository<Driver>
    {
        IEnumerable<Driver> GetAllAvailableDrivers();
    }
}