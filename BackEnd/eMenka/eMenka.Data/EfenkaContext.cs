using eMenka.Domain;
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
            #region PK
            //TODO: add primary keys
            #endregion

            //TODO: Add relations
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