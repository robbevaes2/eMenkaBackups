using eMenka.Domain;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

namespace eMenka.Data
{
    public class EfenkaContext : IdentityDbContext<User, Role, int>
    {
        public EfenkaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<DoorType> DoorTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<FuelCard> FuelCards { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ExteriorColor> ExteriorColors { get; set; }
        public DbSet<InteriorColor> InteriorColors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Primary Keys

            builder.Entity<Brand>().HasKey(b => b.Id);
            builder.Entity<Country>().HasKey(c => c.Id);
            builder.Entity<Company>().HasKey(c => c.Id);
            builder.Entity<Corporation>().HasKey(c => c.Id);
            builder.Entity<DoorType>().HasKey(dt => dt.Id);
            builder.Entity<Driver>().HasKey(d => d.Id);
            builder.Entity<FuelCard>().HasKey(fc => fc.Id);
            builder.Entity<Model>().HasKey(m => m.Id);
            builder.Entity<EngineType>().HasKey(mt => mt.Id);
            builder.Entity<Record>().HasKey(r => r.Id);
            builder.Entity<Series>().HasKey(s => s.Id);
            builder.Entity<Supplier>().HasKey(s => s.Id);
            builder.Entity<Vehicle>().HasKey(v => v.Id);
            builder.Entity<ExteriorColor>().HasKey(ec => ec.Id);
            builder.Entity<InteriorColor>().HasKey(ic => ic.Id);

            #endregion

            #region Relations

            /********************** One To Many *************************/
            //1 brand -> x EngineTypes
            builder.Entity<Brand>()
                .HasMany(b => b.EngineTypes)
                .WithOne(mt => mt.Brand)
                .HasForeignKey(mt => mt.BrandId);

            //1 brand -> x series
            builder.Entity<Brand>()
                .HasMany(b => b.Series)
                .WithOne(s => s.Brand)
                .HasForeignKey(s => s.BrandId);

            //1 brand -> x models
            builder.Entity<Brand>()
                .HasMany(b => b.Models)
                .WithOne(m => m.Brand)
                .HasForeignKey(m => m.BrandId);

            //1 brand -> x vehicles
            builder.Entity<Brand>()
                .HasMany(b => b.Vehicles)
                .WithOne(v => v.Brand)
                .HasForeignKey(v => v.BrandId);

            //1 model -> x vehicles
            builder.Entity<Model>()
                .HasMany(m => m.Vehicles)
                .WithOne(v => v.Model)
                .HasForeignKey(v => v.ModelId);

            //1 doortype -> x vehicles
            builder.Entity<DoorType>()
                .HasMany(d => d.Vehicles)
                .WithOne(v => v.DoorType)
                .HasForeignKey(v => v.DoorTypeId);

            //1 EngineType -> x vehicles
            builder.Entity<EngineType>()
                .HasMany(m => m.Vehicles)
                .WithOne(v => v.EngineType)
                .HasForeignKey(v => v.EngineTypeId);

            //1 Fueltype -> x vehicles
            builder.Entity<FuelType>()
                .HasMany(f => f.Vehicles)
                .WithOne(v => v.FuelType)
                .HasForeignKey(v => v.FuelTypeId);

            //1 Vehicles - x ExteriorColor
            builder.Entity<Vehicle>()
                .HasOne(v => v.ExteriorColor)
                .WithMany(ec => ec.Vehicles)
                .HasForeignKey(v => v.ExteriorColorId);


            //1 Vehicles - x InteriorColor
            builder.Entity<Vehicle>()
                .HasOne(v => v.InteriorColor)
                .WithMany(ic => ic.Vehicles)
                .HasForeignKey(v => v.InteriorColorId);

            /***********************************************************/

            /********************** One To One *************************/
            //Vehicles - FuelCard
            builder.Entity<Vehicle>()
                .HasOne(v => v.FuelCard)
                .WithOne(fc => fc.Vehicle)
                .HasForeignKey<FuelCard>(fc => fc.VehicleId);

            builder.Entity<FuelCard>()
                .HasOne(fc => fc.Vehicle)
                .WithOne(v => v.FuelCard)
                .HasForeignKey<Vehicle>(v => v.FuelCardId);

            //Driver - FuelCard
            builder.Entity<FuelCard>()
                .HasOne(fc => fc.Driver)
                .WithOne(d => d.FuelCard)
                .HasForeignKey<Driver>(d => d.FuelCardId);

            builder.Entity<Driver>()
                .HasOne(d => d.FuelCard)
                .WithOne(fc => fc.Driver)
                .HasForeignKey<FuelCard>(fc => fc.DriverId);

            //Record - FuelCard
            builder.Entity<Record>()
                .HasOne(r => r.FuelCard)
                .WithOne(fc => fc.Record)
                .HasForeignKey<FuelCard>(fc => fc.RecordId);

            builder.Entity<FuelCard>()
                .HasOne(fc => fc.Record)
                .WithOne(r => r.FuelCard)
                .HasForeignKey<Record>(r => r.FuelCardId);


            /***********************************************************/

            #endregion

            DataBaseSeeder.SeedData(builder);

            //om een string bij te houden in database maar deze te splitsen op ',' bij het ophalen van data (dus string array): 
            var valueComparer = new ValueComparer<string[]>(
                (s1, s2) => s1.SequenceEqual(s2),
                s => s.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToArray());

            builder.Entity<Supplier>()
                .Property(s => s.Types)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                ).Metadata.SetValueComparer(valueComparer);
        }

        /*
         This may help later. Detaches entries from the changetracker
        to avoid conflicts when changing linked entities.
        */
        public void DetachEntries()
        {
            foreach (var entityEntry in ChangeTracker.Entries()) Entry(entityEntry.Entity).State = EntityState.Detached;
        }
    }
}