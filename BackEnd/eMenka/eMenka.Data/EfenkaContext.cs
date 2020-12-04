using eMenka.Domain.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

namespace eMenka.Data
{
    public class EfenkaContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Primary Keys

            modelBuilder.Entity<Brand>().HasKey(b => b.Id);
            modelBuilder.Entity<Country>().HasKey(c => c.Id);
            modelBuilder.Entity<Company>().HasKey(c => c.Id);
            modelBuilder.Entity<Corporation>().HasKey(c => c.Id);
            modelBuilder.Entity<DoorType>().HasKey(dt => dt.Id);
            modelBuilder.Entity<Driver>().HasKey(d => d.Id);
            modelBuilder.Entity<FuelCard>().HasKey(fc => fc.Id);
            modelBuilder.Entity<Model>().HasKey(m => m.Id);
            modelBuilder.Entity<EngineType>().HasKey(mt => mt.Id);
            modelBuilder.Entity<Record>().HasKey(r => r.Id);
            modelBuilder.Entity<Series>().HasKey(s => s.Id);
            modelBuilder.Entity<Supplier>().HasKey(s => s.Id);
            modelBuilder.Entity<Vehicle>().HasKey(v => v.Id);
            modelBuilder.Entity<ExteriorColor>().HasKey(ec => ec.Id);
            modelBuilder.Entity<InteriorColor>().HasKey(ic => ic.Id);

            #endregion

            #region Relations

            /********************** One To Many *************************/
            //1 brand -> x EngineTypes
            modelBuilder.Entity<Brand>()
                .HasMany(b => b.EngineTypes)
                .WithOne(mt => mt.Brand)
                .HasForeignKey(mt => mt.BrandId);

            //1 brand -> x series
            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Series)
                .WithOne(s => s.Brand)
                .HasForeignKey(s => s.BrandId);

            //1 brand -> x models
            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Models)
                .WithOne(m => m.Brand)
                .HasForeignKey(m => m.BrandId);

            //1 brand -> x vehicles
            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Vehicles)
                .WithOne(v => v.Brand)
                .HasForeignKey(v => v.BrandId);

            //1 model -> x vehicles
            modelBuilder.Entity<Model>()
                .HasMany(m => m.Vehicles)
                .WithOne(v => v.Model)
                .HasForeignKey(v => v.ModelId);

            //1 doortype -> x vehicles
            modelBuilder.Entity<DoorType>()
                .HasMany(d => d.Vehicles)
                .WithOne(v => v.DoorType)
                .HasForeignKey(v => v.DoorTypeId);

            //1 EngineType -> x vehicles
            modelBuilder.Entity<EngineType>()
                .HasMany(m => m.Vehicles)
                .WithOne(v => v.EngineType)
                .HasForeignKey(v => v.EngineTypeId);

            //1 Fueltype -> x vehicles
            modelBuilder.Entity<FuelType>()
                .HasMany(f => f.Vehicles)
                .WithOne(v => v.FuelType)
                .HasForeignKey(v => v.FuelTypeId);

            //1 Vehicles - x ExteriorColor
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.ExteriorColor)
                .WithMany(ec => ec.Vehicles)
                .HasForeignKey(v => v.ExteriorColorId);


            //1 Vehicles - x InteriorColor
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.InteriorColor)
                .WithMany(ic => ic.Vehicles)
                .HasForeignKey(v => v.InteriorColorId);

            /***********************************************************/

            /********************** One To One *************************/
            //Vehicles - FuelCard
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.FuelCard)
                .WithOne(fc => fc.Vehicle)
                .HasForeignKey<FuelCard>(fc => fc.VehicleId);

            modelBuilder.Entity<FuelCard>()
                .HasOne(fc => fc.Vehicle)
                .WithOne(v => v.FuelCard)
                .HasForeignKey<Vehicle>(v => v.FuelCardId);

            //Driver - FuelCard
            modelBuilder.Entity<FuelCard>()
                .HasOne(fc => fc.Driver)
                .WithOne(d => d.FuelCard)
                .HasForeignKey<Driver>(d => d.FuelCardId);

            modelBuilder.Entity<Driver>()
                .HasOne(d => d.FuelCard)
                .WithOne(fc => fc.Driver)
                .HasForeignKey<FuelCard>(fc => fc.DriverId);

            //Record - FuelCard
            modelBuilder.Entity<Record>()
                .HasOne(r => r.FuelCard)
                .WithOne(fc => fc.Record)
                .HasForeignKey<FuelCard>(fc => fc.RecordId)
                .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<FuelCard>()
                .HasOne(fc => fc.Record)
                .WithOne(r => r.FuelCard)
                .HasForeignKey<Record>(r => r.FuelCardId)
                .OnDelete(DeleteBehavior.SetNull);


            /***********************************************************/

            #endregion

            DataBaseSeeder.SeedData(modelBuilder);

            //om een string bij te houden in database maar deze te splitsen op ',' bij het ophalen van data (dus string array): 
            var valueComparer = new ValueComparer<string[]>(
                (s1, s2) => s1.SequenceEqual(s2),
                s => s.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToArray());

            modelBuilder.Entity<Supplier>()
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