using eMenka.Domain;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data
{
    public class EfenkaContext : IdentityDbContext<User, Role, int>
    {

        public EfenkaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region Primary Keys
            builder.Entity<Brand>().HasKey(b => b.Id);
            builder.Entity<Company>().HasKey(c => c.Id);
            builder.Entity<DoorType>().HasKey(dt => dt.Id);
            builder.Entity<Driver>().HasKey(d=>d.Id);
            builder.Entity<DriversLicense>().HasKey(dl=>dl.Id);
            builder.Entity<Model>().HasKey(c => c.Id);
            builder.Entity<MotorType>().HasKey(mt=>mt.Id);
            builder.Entity<Record>().HasKey(r => r.Id);
            builder.Entity<Serie>().HasKey(s => s.Id);
            builder.Entity<Vehicle>().HasKey(v => v.Id);
            #endregion

            //TODO: Add relations
            #region Relations

            #endregion
        }

        public void DetachEntries()
        {
            foreach (var entityEntry in ChangeTracker.Entries())
            {
                Entry(entityEntry.Entity).State = EntityState.Detached;
            }
        }
    }
}