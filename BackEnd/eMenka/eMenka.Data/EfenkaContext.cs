using System;
using System.Linq;
using eMenka.Domain;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eMenka.Data
{
    public class EfenkaContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<DoorType> DoorTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriversLicense> DriversLicenses { get; set; }
        public DbSet<FuelCard> FuelCards { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<MotorType> MotorTypes { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

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
            builder.Entity<Driver>().HasKey(d => d.Id);
            builder.Entity<DriversLicense>().HasKey(dl => dl.Id);
            builder.Entity<FuelCard>().HasKey(fc => fc.Id);
            builder.Entity<Model>().HasKey(m => m.Id);
            builder.Entity<MotorType>().HasKey(mt => mt.Id);
            builder.Entity<Record>().HasKey(r => r.Id);
            builder.Entity<Serie>().HasKey(s => s.Id);
            builder.Entity<Supplier>().HasKey(s => s.Id);
            builder.Entity<Vehicle>().HasKey(v => v.Id);
            #endregion

            #region Relations
            /********************** One To Many *************************/
            //1 brand -> x motortypes
            builder.Entity<Brand>()
                .HasMany(b => b.MotorTypes)
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
                .WithOne(v=>v.Model)
                .HasForeignKey(v=>v.ModelId);

            //1 doortype -> x vehicles
            builder.Entity<DoorType>()
                .HasMany(d => d.Vehicles)
                .WithOne(v=>v.DoorType)
                .HasForeignKey(v=>v.DoorTypeId);

            //1 motortype -> x vehicles
            builder.Entity<MotorType>()
                .HasMany(m => m.Vehicles)
                .WithOne(v=>v.MotorType)
                .HasForeignKey(v=>v.MotorTypeId);

            //1 Fueltype -> x vehicles
            builder.Entity<FuelType>()
                .HasMany(f => f.Vehicles)
                .WithOne(v=>v.FuelType)
                .HasForeignKey(v=>v.FuelTypeId);
            /***********************************************************/

            /********************** One To One *************************/
            //Vehicle - FuelCard
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

            //Driver - DriversLicense
            builder.Entity<Driver>()
                .HasOne(d => d.DriversLicense)
                .WithOne(dl => dl.Driver)
                .HasForeignKey<DriversLicense>(dl => dl.DriverId);

            builder.Entity<DriversLicense>()
                .HasOne(dl => dl.Driver)
                .WithOne(d => d.DriversLicense)
                .HasForeignKey<Driver>(d => d.DriversLicenseId);

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

            //Seeding data
            /*
            builder.Entity<Brand>().HasData(
                new Brand { Name = "BMW" },
                new Brand { Name = "Ford" },
                new Brand { Name = "Volkswagen" },
                new Brand { Name = "Opel" },
                new Brand { Name = "Ferrari" },
                new Brand { Name = "Peugeot" },
                new Brand { Name = "Audi" },
                new Brand { Name = "Mercedes" },
                new Brand { Name = "KIA" },
                new Brand { Name = "Volvo" },
                new Brand { Name = "Citroën" },
                new Brand { Name = "Fiat" },
                new Brand { Name = "Toyota" },
                new Brand { Name = "Hyundai" },
                new Brand { Name = "Nissan" },
                new Brand { Name = "Alfa Romeo" },
                new Brand { Name = "Honda" },
                new Brand { Name = "Lexus" },
                new Brand { Name = "Saab" },
                new Brand { Name = "Skoda" },
                new Brand { Name = "Smart" },
                new Brand { Name = "Porsche" },
                new Brand { Name = "Mini" },
                new Brand { Name = "TestMerk1" },
                new Brand { Name = "Blastxsx" },
                new Brand { Name = "azerty" },
                new Brand { Name = "aTest" },
                new Brand { Name = "blub" }
            );

            builder.Entity<Model>().HasData(
                new Model { Name = "X3", BrandId = 1 },
                new Model { Name = "318d", BrandId = 1 },
                new Model { Name = "320i", BrandId = 1 },
                new Model { Name = "520d", BrandId = 1 },
                new Model { Name = "X5", BrandId = 1 },
                new Model { Name = "Escort", BrandId = 2 },
                new Model { Name = "Mondeo", BrandId = 2 },
                new Model { Name = "Golf", BrandId = 3 },
                new Model { Name = "Bora", BrandId = 3 },
                new Model { Name = "Passat", BrandId = 3 },
                new Model { Name = "Astra", BrandId = 4 },
                new Model { Name = "Zafira", BrandId = 4 },
                new Model { Name = "Corsa", BrandId = 4 },
                new Model { Name = "Vectra", BrandId = 4 },
                new Model { Name = "456 GT", BrandId = 5 },
                new Model { Name = "A4", BrandId = 8 },
                new Model { Name = "Clio", BrandId = 6 },
                new Model { Name = "207", BrandId = 7 },
                new Model { Name = "725D", BrandId = 1 },
                new Model { Name = "A5", BrandId = 8 },
                new Model { Name = "Laguna", BrandId = 6 },
                new Model { Name = "307", BrandId = 7 },
                new Model { Name = "407", BrandId = 7 },
                new Model { Name = "540", BrandId = 11 },
                new Model { Name = "C30", BrandId = 11 },
                new Model { Name = "V50", BrandId = 11 },
                new Model { Name = "V70", BrandId = 11 },
                new Model { Name = "C70", BrandId = 11 },
                new Model { Name = "Insignia", BrandId = 4 },
                new Model { Name = "A3", BrandId = 8 },
                new Model { Name = "118i", BrandId = 1 },
                new Model { Name = "C1", BrandId = 12 },
                new Model { Name = "C2", BrandId = 12 },
                new Model { Name = "C3", BrandId = 12 },
                new Model { Name = "C4", BrandId = 12 },
                new Model { Name = "C5", BrandId = 12 },
                new Model { Name = "C6", BrandId = 12 },
                new Model { Name = "C8", BrandId = 12 },
                new Model { Name = "Prius", BrandId = 14 },
                new Model { Name = "Fiesta", BrandId = 2 },
                new Model { Name = "Getz", BrandId = 15 },
                new Model { Name = "Mégane", BrandId = 6 },
                new Model { Name = "i20", BrandId = 15 },
                new Model { Name = "ix35", BrandId = 15 },
                new Model { Name = "i10", BrandId = 15 },
                new Model { Name = "i30", BrandId = 15 },
                new Model { Name = "ix20", BrandId = 15 },
                new Model { Name = "H1", BrandId = 15 },
                new Model { Name = "i40", BrandId = 15 },
                new Model { Name = "ix55", BrandId = 15 },
                new Model { Name = "508", BrandId = 7 },
                new Model { Name = "Q5", BrandId = 8 },
                new Model { Name = "Note", BrandId = 16 },
                new Model { Name = "3008", BrandId = 7 },
                new Model { Name = "C - klasse", BrandId = 9 },
                new Model { Name = "E - klasse", BrandId = 9 },
                new Model { Name = "Punto", BrandId = 13 },
                new Model { Name = "A - klasse", BrandId = 9 },
                new Model { Name = "kevin", BrandId = 13 },
                new Model { Name = "testFiat", BrandId = 13 },
                new Model { Name = "159", BrandId = 17 },
                new Model { Name = "Giulietta", BrandId = 17 },
                new Model { Name = "A6", BrandId = 8 },
                new Model { Name = "Q7", BrandId = 8 },
                new Model { Name = "116d", BrandId = 1 },
                new Model { Name = "118d", BrandId = 1 },
                new Model { Name = "316d", BrandId = 1 },
                new Model { Name = "320d", BrandId = 1 },
                new Model { Name = "525d", BrandId = 1 },
                new Model { Name = "530d", BrandId = 1 },
                new Model { Name = "X1", BrandId = 1 },
                new Model { Name = "Jumper", BrandId = 12 },
                new Model { Name = "C - Max", BrandId = 2 },
                new Model { Name = "Focus", BrandId = 2 },
                new Model { Name = "Focus C - Max", BrandId = 2 },
                new Model { Name = "Galaxy", BrandId = 2 },
                new Model { Name = "Grand C - Max", BrandId = 2 },
                new Model { Name = "S - Max", BrandId = 2 },
                new Model { Name = "Transit Connect", BrandId = 2 },
                new Model { Name = "Moto", BrandId = 18 },
                new Model { Name = "CT", BrandId = 19 },
                new Model { Name = "IS", BrandId = 19 },
                new Model { Name = "B - klasse", BrandId = 9 },
                new Model { Name = "G - klasse", BrandId = 9 },
                new Model { Name = "M - klasse", BrandId = 9 },
                new Model { Name = "S - klasse", BrandId = 9 },
                new Model { Name = "Qashqai", BrandId = 16 },
                new Model { Name = "Antara", BrandId = 4 },
                new Model { Name = "Meriva", BrandId = 4 },
                new Model { Name = "Zafira tourer", BrandId = 4 },
                new Model { Name = "308", BrandId = 7 },
                new Model { Name = "5008", BrandId = 7 },
                new Model { Name = "807", BrandId = 7 },
                new Model { Name = "Espace", BrandId = 6 },
                new Model { Name = "Grand Espace", BrandId = 6 },
                new Model { Name = "Grand Scénic", BrandId = 6 },
                new Model { Name = "Koleos", BrandId = 6 },
                new Model { Name = "Mégane Grandtour", BrandId = 6 },
                new Model { Name = "Meganescenic", BrandId = 6 },
                new Model { Name = "Scénic", BrandId = 6 },
                new Model { Name = "Scénic II Phase II", BrandId = 6 },
                new Model { Name = "9 - mrt", BrandId = 20 },
                new Model { Name = "9 - mei", BrandId = 20 },
                new Model { Name = "Octavia Combi", BrandId = 21 },
                new Model { Name = "Superb", BrandId = 21 },
                new Model { Name = "Fortwo", BrandId = 22 },
                new Model { Name = "Auris", BrandId = 14 },
                new Model { Name = "Yaris", BrandId = 14 },
                new Model { Name = "Caddy", BrandId = 3 },
                new Model { Name = "Golf Plus", BrandId = 3 },
                new Model { Name = "Golf V", BrandId = 3 },
                new Model { Name = "Golf VI", BrandId = 3 },
                new Model { Name = "Jetta", BrandId = 3 },
                new Model { Name = "Passat CC", BrandId = 3 },
                new Model { Name = "Polo", BrandId = 3 },
                new Model { Name = "Sharan", BrandId = 3 },
                new Model { Name = "Tiguan", BrandId = 3 },
                new Model { Name = "Touran", BrandId = 3 },
                new Model { Name = "S60", BrandId = 11 },
                new Model { Name = "S80", BrandId = 11 },
                new Model { Name = "V60", BrandId = 11 },
                new Model { Name = "XC60", BrandId = 11 },
                new Model { Name = "XC70", BrandId = 11 },
                new Model { Name = "208", BrandId = 7 },
                new Model { Name = "DS3", BrandId = 12 },
                new Model { Name = "Ecoliner", BrandId = 9 },
                new Model { Name = "Mokka", BrandId = 4 },
                new Model { Name = "Brera", BrandId = 17 },
                new Model { Name = "Adam", BrandId = 4 },
                new Model { Name = "ttttt", BrandId = 18 },
                new Model { Name = "Talisman", BrandId = 6 },
                new Model { Name = "TEst", BrandId = 23 },
                new Model { Name = "X6", BrandId = 1 },
                new Model { Name = "lightning", BrandId = 26 },
                new Model { Name = "azerty", BrandId = 27 },
                new Model { Name = "qsdf", BrandId = 29 },
                new Model { Name = "baz", BrandId = 29 }
            );
            */


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
            foreach (var entityEntry in ChangeTracker.Entries())
            {
                Entry(entityEntry.Entity).State = EntityState.Detached;
            }
        }
    }
}