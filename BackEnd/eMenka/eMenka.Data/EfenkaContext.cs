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
        public DbSet<Serie> Series { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ExteriorColor> ExteriorColors { get; set; }
        public DbSet<InteriorColor> InteriorColors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EfenkaContext(DbContextOptions options) : base(options)
        {

        }

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
            builder.Entity<Serie>().HasKey(s => s.Id);
            builder.Entity<Supplier>().HasKey(s => s.Id);
            builder.Entity<Vehicle>().HasKey(v => v.Id);
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
            #region seeding data

            #region Brands
            builder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "BMW" },
                new Brand { Id = 2, Name = "Ford" },
                new Brand { Id = 3, Name = "Volkswagen" },
                new Brand { Id = 4, Name = "Opel" },
                new Brand { Id = 5, Name = "Ferrari" },
                new Brand { Id = 6, Name = "Peugeot" },
                new Brand { Id = 7, Name = "Audi" },
                new Brand { Id = 8, Name = "Mercedes" },
                new Brand { Id = 9, Name = "KIA" },
                new Brand { Id = 10, Name = "Volvo" },
                new Brand { Id = 11, Name = "Citroën" },
                new Brand { Id = 12, Name = "Fiat" },
                new Brand { Id = 13, Name = "Toyota" },
                new Brand { Id = 14, Name = "Hyundai" },
                new Brand { Id = 15, Name = "Nissan" },
                new Brand { Id = 16, Name = "Alfa Romeo" },
                new Brand { Id = 17, Name = "Honda" },
                new Brand { Id = 18, Name = "Lexus" },
                new Brand { Id = 19, Name = "Saab" },
                new Brand { Id = 20, Name = "Skoda" },
                new Brand { Id = 21, Name = "Smart" },
                new Brand { Id = 22, Name = "Porsche" },
                new Brand { Id = 23, Name = "Mini" },
                new Brand { Id = 24, Name = "TestMerk1" },
                new Brand { Id = 25, Name = "Blastxsx" },
                new Brand { Id = 26, Name = "azerty" },
                new Brand { Id = 27, Name = "aTest" },
                new Brand { Id = 28, Name = "blub" }
            );

            #endregion

            #region Models
            builder.Entity<Model>().HasData(
                new Model { Id = 1, Name = "X3", BrandId = 1 },
                new Model { Id = 2, Name = "318d", BrandId = 1 },
                new Model { Id = 3, Name = "320i", BrandId = 1 },
                new Model { Id = 4, Name = "520d", BrandId = 1 },
                new Model { Id = 5, Name = "X5", BrandId = 1 },
                new Model { Id = 6, Name = "Escort", BrandId = 2 },
                new Model { Id = 7, Name = "Mondeo", BrandId = 2 },
                new Model { Id = 8, Name = "Golf", BrandId = 3 },
                new Model { Id = 9, Name = "Bora", BrandId = 3 },
                new Model { Id = 10, Name = "Passat", BrandId = 3 },
                new Model { Id = 11, Name = "Astra", BrandId = 4 },
                new Model { Id = 12, Name = "Zafira", BrandId = 4 },
                new Model { Id = 13, Name = "Corsa", BrandId = 4 },
                new Model { Id = 14, Name = "Vectra", BrandId = 4 },
                new Model { Id = 15, Name = "456 GT", BrandId = 5 },
                new Model { Id = 16, Name = "A4", BrandId = 8 },
                new Model { Id = 17, Name = "Clio", BrandId = 6 },
                new Model { Id = 18, Name = "207", BrandId = 7 },
                new Model { Id = 19, Name = "725D", BrandId = 1 },
                new Model { Id = 20, Name = "A5", BrandId = 8 },
                new Model { Id = 21, Name = "Laguna", BrandId = 6 },
                new Model { Id = 22, Name = "307", BrandId = 7 },
                new Model { Id = 23, Name = "407", BrandId = 7 },
                new Model { Id = 24, Name = "540", BrandId = 11 },
                new Model { Id = 25, Name = "C30", BrandId = 11 },
                new Model { Id = 26, Name = "V50", BrandId = 11 },
                new Model { Id = 27, Name = "V70", BrandId = 11 },
                new Model { Id = 28, Name = "C70", BrandId = 11 },
                new Model { Id = 29, Name = "Insignia", BrandId = 4 },
                new Model { Id = 30, Name = "A3", BrandId = 8 },
                new Model { Id = 31, Name = "118i", BrandId = 1 },
                new Model { Id = 32, Name = "C1", BrandId = 12 },
                new Model { Id = 33, Name = "C2", BrandId = 12 },
                new Model { Id = 34, Name = "C3", BrandId = 12 },
                new Model { Id = 35, Name = "C4", BrandId = 12 },
                new Model { Id = 36, Name = "C5", BrandId = 12 },
                new Model { Id = 37, Name = "C6", BrandId = 12 },
                new Model { Id = 38, Name = "C8", BrandId = 12 },
                new Model { Id = 39, Name = "Prius", BrandId = 14 },
                new Model { Id = 40, Name = "Fiesta", BrandId = 2 },
                new Model { Id = 41, Name = "Getz", BrandId = 15 },
                new Model { Id = 42, Name = "Mégane", BrandId = 6 },
                new Model { Id = 43, Name = "i20", BrandId = 15 },
                new Model { Id = 44, Name = "ix35", BrandId = 15 },
                new Model { Id = 45, Name = "i10", BrandId = 15 },
                new Model { Id = 46, Name = "i30", BrandId = 15 },
                new Model { Id = 47, Name = "ix20", BrandId = 15 },
                new Model { Id = 48, Name = "H1", BrandId = 15 },
                new Model { Id = 49, Name = "i40", BrandId = 15 },
                new Model { Id = 50, Name = "ix55", BrandId = 15 },
                new Model { Id = 51, Name = "508", BrandId = 7 },
                new Model { Id = 52, Name = "Q5", BrandId = 8 },
                new Model { Id = 53, Name = "Note", BrandId = 16 },
                new Model { Id = 54, Name = "3008", BrandId = 7 },
                new Model { Id = 55, Name = "C - klasse", BrandId = 9 },
                new Model { Id = 56, Name = "E - klasse", BrandId = 9 },
                new Model { Id = 57, Name = "Punto", BrandId = 13 },
                new Model { Id = 58, Name = "A - klasse", BrandId = 9 },
                new Model { Id = 59, Name = "kevin", BrandId = 13 },
                new Model { Id = 60, Name = "testFiat", BrandId = 13 },
                new Model { Id = 61, Name = "159", BrandId = 17 },
                new Model { Id = 62, Name = "Giulietta", BrandId = 17 },
                new Model { Id = 63, Name = "A6", BrandId = 8 },
                new Model { Id = 64, Name = "Q7", BrandId = 8 },
                new Model { Id = 65, Name = "116d", BrandId = 1 },
                new Model { Id = 66, Name = "118d", BrandId = 1 },
                new Model { Id = 67, Name = "316d", BrandId = 1 },
                new Model { Id = 68, Name = "320d", BrandId = 1 },
                new Model { Id = 69, Name = "525d", BrandId = 1 },
                new Model { Id = 70, Name = "530d", BrandId = 1 },
                new Model { Id = 71, Name = "X1", BrandId = 1 },
                new Model { Id = 72, Name = "Jumper", BrandId = 12 },
                new Model { Id = 73, Name = "C - Max", BrandId = 2 },
                new Model { Id = 74, Name = "Focus", BrandId = 2 },
                new Model { Id = 75, Name = "Focus C - Max", BrandId = 2 },
                new Model { Id = 76, Name = "Galaxy", BrandId = 2 },
                new Model { Id = 77, Name = "Grand C - Max", BrandId = 2 },
                new Model { Id = 78, Name = "S - Max", BrandId = 2 },
                new Model { Id = 79, Name = "Transit Connect", BrandId = 2 },
                new Model { Id = 80, Name = "Moto", BrandId = 18 },
                new Model { Id = 81, Name = "CT", BrandId = 19 },
                new Model { Id = 82, Name = "IS", BrandId = 19 },
                new Model { Id = 83, Name = "B - klasse", BrandId = 9 },
                new Model { Id = 84, Name = "G - klasse", BrandId = 9 },
                new Model { Id = 85, Name = "M - klasse", BrandId = 9 },
                new Model { Id = 86, Name = "S - klasse", BrandId = 9 },
                new Model { Id = 87, Name = "Qashqai", BrandId = 16 },
                new Model { Id = 88, Name = "Antara", BrandId = 4 },
                new Model { Id = 89, Name = "Meriva", BrandId = 4 },
                new Model { Id = 90, Name = "Zafira tourer", BrandId = 4 },
                new Model { Id = 91, Name = "308", BrandId = 7 },
                new Model { Id = 92, Name = "5008", BrandId = 7 },
                new Model { Id = 93, Name = "807", BrandId = 7 },
                new Model { Id = 94, Name = "Espace", BrandId = 6 },
                new Model { Id = 95, Name = "Grand Espace", BrandId = 6 },
                new Model { Id = 96, Name = "Grand Scénic", BrandId = 6 },
                new Model { Id = 97, Name = "Koleos", BrandId = 6 },
                new Model { Id = 98, Name = "Mégane Grandtour", BrandId = 6 },
                new Model { Id = 99, Name = "Meganescenic", BrandId = 6 },
                new Model { Id = 100, Name = "Scénic", BrandId = 6 },
                new Model { Id = 101, Name = "Scénic II Phase II", BrandId = 6 },
                new Model { Id = 102, Name = "9 - mrt", BrandId = 20 },
                new Model { Id = 103, Name = "9 - mei", BrandId = 20 },
                new Model { Id = 104, Name = "Octavia Combi", BrandId = 21 },
                new Model { Id = 105, Name = "Superb", BrandId = 21 },
                new Model { Id = 106, Name = "Fortwo", BrandId = 22 },
                new Model { Id = 107, Name = "Auris", BrandId = 14 },
                new Model { Id = 108, Name = "Yaris", BrandId = 14 },
                new Model { Id = 109, Name = "Caddy", BrandId = 3 },
                new Model { Id = 110, Name = "Golf Plus", BrandId = 3 },
                new Model { Id = 111, Name = "Golf V", BrandId = 3 },
                new Model { Id = 112, Name = "Golf VI", BrandId = 3 },
                new Model { Id = 113, Name = "Jetta", BrandId = 3 },
                new Model { Id = 114, Name = "Passat CC", BrandId = 3 },
                new Model { Id = 115, Name = "Polo", BrandId = 3 },
                new Model { Id = 116, Name = "Sharan", BrandId = 3 },
                new Model { Id = 117, Name = "Tiguan", BrandId = 3 },
                new Model { Id = 118, Name = "Touran", BrandId = 3 },
                new Model { Id = 119, Name = "S60", BrandId = 11 },
                new Model { Id = 120, Name = "S80", BrandId = 11 },
                new Model { Id = 121, Name = "V60", BrandId = 11 },
                new Model { Id = 122, Name = "XC60", BrandId = 11 },
                new Model { Id = 123, Name = "XC70", BrandId = 11 },
                new Model { Id = 124, Name = "208", BrandId = 7 },
                new Model { Id = 125, Name = "DS3", BrandId = 12 },
                new Model { Id = 126, Name = "Ecoliner", BrandId = 9 },
                new Model { Id = 127, Name = "Mokka", BrandId = 4 },
                new Model { Id = 128, Name = "Brera", BrandId = 17 },
                new Model { Id = 129, Name = "Adam", BrandId = 4 },
                new Model { Id = 130, Name = "ttttt", BrandId = 18 },
                new Model { Id = 131, Name = "Talisman", BrandId = 6 },
                new Model { Id = 132, Name = "TEst", BrandId = 23 },
                new Model { Id = 133, Name = "X6", BrandId = 1 },
                new Model { Id = 134, Name = "lightning", BrandId = 26 },
                new Model { Id = 135, Name = "azerty", BrandId = 27 },
                new Model { Id = 136, Name = "qsdf", BrandId = 28 },
                new Model { Id = 137, Name = "baz", BrandId = 28 }
            );

            #endregion

            #region EngineTypes
            builder.Entity<EngineType>().HasData(
                new EngineType { Id = 1, BrandId = 1, Name = "1.9" },
                new EngineType { Id = 2, BrandId = 1, Name = "2" },
                new EngineType { Id = 3, BrandId = 3, Name = "1.9 TDI" },
                new EngineType { Id = 4, BrandId = 4, Name = "1.8 ECOTEC" },
                new EngineType { Id = 5, BrandId = 4, Name = "1.9 CDTI" },
                new EngineType { Id = 6, BrandId = 4, Name = "1.6 CNG" },
                new EngineType { Id = 7, BrandId = 4, Name = "1.6 CNG ECOTEC" },
                new EngineType { Id = 8, BrandId = 4, Name = "1.7 CDTI" },
                new EngineType { Id = 9, BrandId = 7, Name = "1.6 HDi" },
                new EngineType { Id = 10, BrandId = 8, Name = "1.9 Tdi" },
                new EngineType { Id = 11, BrandId = 1, Name = "30d" },
                new EngineType { Id = 12, BrandId = 1, Name = "35d" },
                new EngineType { Id = 13, BrandId = 1, Name = "20d" },
                new EngineType { Id = 14, BrandId = 6, Name = "1,6" },
                new EngineType { Id = 15, BrandId = 4, Name = "1.3 CDTi 16v" },
                new EngineType { Id = 16, BrandId = 4, Name = "3.0 CDTI" },
                new EngineType { Id = 17, BrandId = 11, Name = "1.6 D" },
                new EngineType { Id = 18, BrandId = 11, Name = "2.0 D" },
                new EngineType { Id = 19, BrandId = 11, Name = "2.4 D" },
                new EngineType { Id = 20, BrandId = 4, Name = "2.0 DPF CDTi" },
                new EngineType { Id = 21, BrandId = 12, Name = "1.6 HDi 92" },
                new EngineType { Id = 22, BrandId = 12, Name = "1.6 HDi 110" },
                new EngineType { Id = 23, BrandId = 12, Name = "2.0 HDi 138" },
                new EngineType { Id = 24, BrandId = 3, Name = "1.6" },
                new EngineType { Id = 25, BrandId = 5, Name = "3456" },
                new EngineType { Id = 26, BrandId = 15, Name = "1,5" },
                new EngineType { Id = 27, BrandId = 6, Name = "1.5" },
                new EngineType { Id = 28, BrandId = 15, Name = "1.4 Crdi" },
                new EngineType { Id = 29, BrandId = 15, Name = "1.7 CRDi" },
                new EngineType { Id = 30, BrandId = 15, Name = "1.6 GDi" },
                new EngineType { Id = 31, BrandId = 15, Name = "2.0 CRDi" },
                new EngineType { Id = 32, BrandId = 7, Name = "2" },
                new EngineType { Id = 33, BrandId = 8, Name = "2.0 Tdi" },
                new EngineType { Id = 34, BrandId = 12, Name = "2.2 ESS" },
                new EngineType { Id = 35, BrandId = 4, Name = "1.7 CDTI ECOTEC" },
                new EngineType { Id = 36, BrandId = 4, Name = "2.0 CDTI ecoflex S/S DPF" },
                new EngineType { Id = 37, BrandId = 4, Name = "1.7 CDTI ecoflex S/S DPF" },
                new EngineType { Id = 38, BrandId = 6, Name = "16D" },
                new EngineType { Id = 39, BrandId = 9, Name = "200 CDI" },
                new EngineType { Id = 40, BrandId = 9, Name = "220 CDI" },
                new EngineType { Id = 41, BrandId = 9, Name = "180 CDI" },
                new EngineType { Id = 42, BrandId = 13, Name = "1500" },
                new EngineType { Id = 43, BrandId = 9, Name = "160 CDI" },
                new EngineType { Id = 44, BrandId = 13, Name = "1600" },
                new EngineType { Id = 45, BrandId = 17, Name = "1.9 JTDm" },
                new EngineType { Id = 46, BrandId = 17, Name = "1.9 JTD" },
                new EngineType { Id = 47, BrandId = 17, Name = "2,0 JTDM 163PK" },
                new EngineType { Id = 48, BrandId = 8, Name = "1.6 TDI" },
                new EngineType { Id = 49, BrandId = 8, Name = "1.6 Tiptronic" },
                new EngineType { Id = 50, BrandId = 8, Name = "2.0 TDi DPF" },
                new EngineType { Id = 51, BrandId = 8, Name = "2.0 TDI e" },
                new EngineType { Id = 52, BrandId = 8, Name = "1.8 T" },
                new EngineType { Id = 53, BrandId = 8, Name = "2.7 TDI" },
                new EngineType { Id = 54, BrandId = 8, Name = "2.0 TDi Multitronic" },
                new EngineType { Id = 55, BrandId = 8, Name = "2.8 V6 Multitronic" },
                new EngineType { Id = 56, BrandId = 8, Name = "3.0 TDI" },
                new EngineType { Id = 57, BrandId = 1, Name = "16d" },
                new EngineType { Id = 58, BrandId = 1, Name = "1,6" },
                new EngineType { Id = 59, BrandId = 1, Name = "18d" },
                new EngineType { Id = 60, BrandId = 1, Name = "25d" },
                new EngineType { Id = 61, BrandId = 12, Name = "2.0 HDi" },
                new EngineType { Id = 62, BrandId = 12, Name = "2.0 HDi 136" },
                new EngineType { Id = 63, BrandId = 12, Name = "2.2 HDI" },
                new EngineType { Id = 64, BrandId = 12, Name = "2.2 HDI 74" },
                new EngineType { Id = 65, BrandId = 2, Name = "2.0 TDCi AUT" },
                new EngineType { Id = 66, BrandId = 2, Name = "1.6 TDCi Turbo" },
                new EngineType { Id = 67, BrandId = 2, Name = "1.6 TDCI ECOnetic" },
                new EngineType { Id = 68, BrandId = 2, Name = "2.0 TDCi Turbo" },
                new EngineType { Id = 69, BrandId = 2, Name = "2.2 TDCi Turbo" },
                new EngineType { Id = 70, BrandId = 2, Name = "1.8 TDCi" },
                new EngineType { Id = 71, BrandId = 2, Name = "1.8 TDCi Turbo" },
                new EngineType { Id = 72, BrandId = 2, Name = "2.0 Monovol 6v" },
                new EngineType { Id = 73, BrandId = 16, Name = "1.5 dCi" },
                new EngineType { Id = 74, BrandId = 18, Name = "300cc" },
                new EngineType { Id = 75, BrandId = 19, Name = "Hybrid 2.0" },
                new EngineType { Id = 76, BrandId = 8, Name = "PowerPlus" },
                new EngineType { Id = 77, BrandId = 9, Name = "B 180 CDI" },
                new EngineType { Id = 78, BrandId = 9, Name = "B 200 CDI" },
                new EngineType { Id = 79, BrandId = 9, Name = "C 200 CDI" },
                new EngineType { Id = 80, BrandId = 9, Name = "C 220 CDI" },
                new EngineType { Id = 81, BrandId = 9, Name = "C 180 CDI" },
                new EngineType { Id = 82, BrandId = 9, Name = "C 200" },
                new EngineType { Id = 83, BrandId = 9, Name = "E 350 CDI" },
                new EngineType { Id = 84, BrandId = 9, Name = "E 200 CDI" },
                new EngineType { Id = 85, BrandId = 9, Name = "GLK 220 CDI 4matic" },
                new EngineType { Id = 86, BrandId = 9, Name = "ML 300 CDI" },
                new EngineType { Id = 87, BrandId = 9, Name = "ML 300 CDI Blue Efficiency" },
                new EngineType { Id = 88, BrandId = 9, Name = "350 CDI Bluetec" },
                new EngineType { Id = 89, BrandId = 9, Name = "S 320 CDI" },
                new EngineType { Id = 90, BrandId = 16, Name = "1.5dCi" },
                new EngineType { Id = 91, BrandId = 4, Name = "2.0 CDTI" },
                new EngineType { Id = 92, BrandId = 4, Name = "1.7 CDTI DPF" },
                new EngineType { Id = 93, BrandId = 4, Name = "1.7 CDTi ecoFLEX" },
                new EngineType { Id = 94, BrandId = 7, Name = "2.0 HDi" },
                new EngineType { Id = 95, BrandId = 6, Name = "2.0 dCi" },
                new EngineType { Id = 96, BrandId = 6, Name = "1.5 dCi" },
                new EngineType { Id = 97, BrandId = 6, Name = "1.9 dCi FAP" },
                new EngineType { Id = 98, BrandId = 20, Name = "1.9 TiD" },
                new EngineType { Id = 99, BrandId = 21, Name = "1.6 TD" },
                new EngineType { Id = 100, BrandId = 21, Name = "2.0 TD" },
                new EngineType { Id = 101, BrandId = 10, Name = "0.8 CDI" },
                new EngineType { Id = 102, BrandId = 14, Name = "2.0 D" },
                new EngineType { Id = 103, BrandId = 14, Name = "1.8" },
                new EngineType { Id = 104, BrandId = 14, Name = "1.4 D4D" },
                new EngineType { Id = 105, BrandId = 3, Name = "1.6 TDi" },
                new EngineType { Id = 106, BrandId = 3, Name = "2.0 TDi" },
                new EngineType { Id = 107, BrandId = 3, Name = "1.9 TDI BlueMotion" },
                new EngineType { Id = 108, BrandId = 3, Name = "1.6 CR TDI" },
                new EngineType { Id = 109, BrandId = 3, Name = "2.0 CR Tdi bluemotion" },
                new EngineType { Id = 110, BrandId = 3, Name = "2.0 CR TDi" },
                new EngineType { Id = 111, BrandId = 3, Name = "2.0 TDI BlueMotion" },
                new EngineType { Id = 112, BrandId = 11, Name = "2.4 D5 GEARTRONIC" },
                new EngineType { Id = 113, BrandId = 4, Name = "1.6 CDTi ecoFLEX" },
                new EngineType { Id = 114, BrandId = 17, Name = "2.4 JTDm" },
                new EngineType { Id = 115, BrandId = 7, Name = "1.4 HDi" },
                new EngineType { Id = 116, BrandId = 26, Name = "whosh" },
                new EngineType { Id = 117, BrandId = 2, Name = "blablu" },
                new EngineType { Id = 118, BrandId = 27, Name = "azerty" },
                new EngineType { Id = 119, BrandId = 28, Name = "blob" },
                new EngineType { Id = 120, BrandId = 28, Name = "blasterx" }
            );

            #endregion

            #region DoorTypes & FuelTypes
            builder.Entity<DoorType>().HasData(
                new DoorType { Id = 1, Name = "Break" },
                new DoorType { Id = 2, Name = "5-Deurs" },
                new DoorType { Id = 3, Name = "4-Deurs" },
                new DoorType { Id = 4, Name = "3-Deurs" },
                new DoorType { Id = 5, Name = "Monovolume" },
                new DoorType { Id = 6, Name = "2-Deurs" },
                new DoorType { Id = 7, Name = "Coupé" },
                new DoorType { Id = 8, Name = "Moto" },
                new DoorType { Id = 9, Name = "Cabrio" }
            );

            builder.Entity<FuelType>().HasData(
                new FuelType { Id = 1, Name = "Diesel", Code = "DSL" },
                new FuelType { Id = 2, Name = "Liquefied Petroleum Gas", Code = "LPG" },
                new FuelType { Id = 3, Name = "Compressed Natural Gas", Code = "CNG" },
                new FuelType { Id = 4, Name = "Liquefied Natural Gas", Code = "LNG" },
                new FuelType { Id = 5, Name = "Methanol", Code = "M85" },
                new FuelType { Id = 6, Name = "Ethanol", Code = "E85" },
                new FuelType { Id = 7, Name = "Biodiesel", Code = "B20" },
                new FuelType { Id = 8, Name = "Diesel International", Code = "DSL INT" },
                new FuelType { Id = 9, Name = "Multifuel", Code = "MULTI" },
                new FuelType { Id = 10, Name = "Diesel", Code = "DSL" }
            );

            #endregion

            #region Series
            builder.Entity<Serie>().HasData(
                new Serie { Id = 1, BrandId = 1, Name = "Touring" },
                new Serie { Id = 2, BrandId = 1, Name = "Berline" },
                new Serie { Id = 3, BrandId = 3, Name = "Rabbit" },
                new Serie { Id = 4, BrandId = 4, Name = "Enjoy" },
                new Serie { Id = 5, BrandId = 4, Name = "Cosmo" },
                new Serie { Id = 6, BrandId = 4, Name = "Essentia" },
                new Serie { Id = 7, BrandId = 4, Name = "OPC" },
                new Serie { Id = 8, BrandId = 7, Name = "SW" },
                new Serie { Id = 9, BrandId = 7, Name = "Coupé" },
                new Serie { Id = 10, BrandId = 7, Name = "Berline" },
                new Serie { Id = 11, BrandId = 8, Name = "Berline" },
                new Serie { Id = 12, BrandId = 6, Name = "dd" },
                new Serie { Id = 13, BrandId = 6, Name = "DCI" },
                new Serie { Id = 14, BrandId = 1, Name = "Coupé" },
                new Serie { Id = 15, BrandId = 1, Name = "Cabrio" },
                new Serie { Id = 16, BrandId = 1, Name = "Hatch" },
                new Serie { Id = 17, BrandId = 1, Name = "xDrive" },
                new Serie { Id = 18, BrandId = 7, Name = "Urban" },
                new Serie { Id = 19, BrandId = 8, Name = "Avant" },
                new Serie { Id = 20, BrandId = 18, Name = "rerezrtrz" },
                new Serie { Id = 21, BrandId = 1, Name = "test" },
                new Serie { Id = 22, BrandId = 11, Name = "Basis" },
                new Serie { Id = 23, BrandId = 11, Name = "Summum" },
                new Serie { Id = 24, BrandId = 4, Name = "Edition" },
                new Serie { Id = 25, BrandId = 8, Name = "Sportback" },
                new Serie { Id = 26, BrandId = 12, Name = "Coupé" },
                new Serie { Id = 27, BrandId = 12, Name = "Picasso" },
                new Serie { Id = 28, BrandId = 12, Name = "Tourer" },
                new Serie { Id = 29, BrandId = 12, Name = "Pluriel" },
                new Serie { Id = 30, BrandId = 5, Name = "tt" },
                new Serie { Id = 31, BrandId = 15, Name = "Hatchback" },
                new Serie { Id = 32, BrandId = 12, Name = "Exclusive" },
                new Serie { Id = 33, BrandId = 15, Name = "Trocadéro" },
                new Serie { Id = 34, BrandId = 15, Name = "Base" },
                new Serie { Id = 35, BrandId = 15, Name = "Facility Pack" },
                new Serie { Id = 36, BrandId = 8, Name = "SUV" },
                new Serie { Id = 37, BrandId = 4, Name = "Sport" },
                new Serie { Id = 38, BrandId = 16, Name = "Acenta" },
                new Serie { Id = 39, BrandId = 7, Name = "Acces" },
                new Serie { Id = 40, BrandId = 9, Name = "Avantgarde" },
                new Serie { Id = 41, BrandId = 9, Name = "Classic" },
                new Serie { Id = 42, BrandId = 13, Name = "Break" },
                new Serie { Id = 43, BrandId = 13, Name = "cabrio" },
                new Serie { Id = 44, BrandId = 17, Name = "Eco" },
                new Serie { Id = 45, BrandId = 17, Name = "Progression" },
                new Serie { Id = 46, BrandId = 17, Name = "Progression Corp. Leder" },
                new Serie { Id = 47, BrandId = 17, Name = "Distinctive" },
                new Serie { Id = 48, BrandId = 8, Name = "Ambiente" },
                new Serie { Id = 49, BrandId = 8, Name = "Attraction" },
                new Serie { Id = 50, BrandId = 8, Name = "Sport Back Ambition" },
                new Serie { Id = 51, BrandId = 8, Name = "Sportback Ambiente" },
                new Serie { Id = 52, BrandId = 8, Name = "Sportback Attraction" },
                new Serie { Id = 53, BrandId = 8, Name = "Allroad Quattro" },
                new Serie { Id = 54, BrandId = 8, Name = "S line" },
                new Serie { Id = 55, BrandId = 8, Name = "Start/Stop DPF" },
                new Serie { Id = 56, BrandId = 8, Name = "DPF" },
                new Serie { Id = 57, BrandId = 8, Name = "Quattro" },
                new Serie { Id = 58, BrandId = 1, Name = "sDrive18d" },
                new Serie { Id = 59, BrandId = 1, Name = "sDrive20d" },
                new Serie { Id = 60, BrandId = 12, Name = "Grand Picasso" },
                new Serie { Id = 61, BrandId = 12, Name = "Grand Picasso Bus+" },
                new Serie { Id = 62, BrandId = 12, Name = "Grand Picasso Business" },
                new Serie { Id = 63, BrandId = 12, Name = "Picasso Bus+" },
                new Serie { Id = 64, BrandId = 12, Name = "Picasso Business" },
                new Serie { Id = 65, BrandId = 12, Name = "Picasso Business GPS" },
                new Serie { Id = 66, BrandId = 12, Name = "Picasso Exclusive" },
                new Serie { Id = 67, BrandId = 12, Name = "Business" },
                new Serie { Id = 68, BrandId = 12, Name = "Van" },
                new Serie { Id = 69, BrandId = 2, Name = "Ghia DPF" },
                new Serie { Id = 70, BrandId = 2, Name = "Titanium DPF" },
                new Serie { Id = 71, BrandId = 2, Name = "Trend" },
                new Serie { Id = 72, BrandId = 2, Name = "Ghia" },
                new Serie { Id = 73, BrandId = 2, Name = "Trend DPF" },
                new Serie { Id = 74, BrandId = 2, Name = "Titanium" },
                new Serie { Id = 75, BrandId = 2, Name = "Econetic" },
                new Serie { Id = 76, BrandId = 18, Name = "ST300" },
                new Serie { Id = 77, BrandId = 19, Name = "Business" },
                new Serie { Id = 78, BrandId = 9, Name = "Blue Efficience" },
                new Serie { Id = 79, BrandId = 9, Name = "Elegance" },
                new Serie { Id = 80, BrandId = 9, Name = "L Avantgarde" },
                new Serie { Id = 81, BrandId = 4, Name = "Cosmo Sports Tourer" },
                new Serie { Id = 82, BrandId = 4, Name = "Edition Sports Tourer" },
                new Serie { Id = 83, BrandId = 7, Name = "Premium Coach" },
                new Serie { Id = 84, BrandId = 7, Name = "Premium Pack FAP" },
                new Serie { Id = 85, BrandId = 7, Name = "SW Premium Break" },
                new Serie { Id = 86, BrandId = 7, Name = "Executive AUT." },
                new Serie { Id = 87, BrandId = 7, Name = "Premium" },
                new Serie { Id = 88, BrandId = 7, Name = "SW Executive" },
                new Serie { Id = 89, BrandId = 7, Name = "Premium Pack" },
                new Serie { Id = 90, BrandId = 7, Name = "ST Confort" },
                new Serie { Id = 91, BrandId = 6, Name = "Latitude FAP" },
                new Serie { Id = 92, BrandId = 6, Name = "Alyum FAP" },
                new Serie { Id = 93, BrandId = 6, Name = "Dynamique" },
                new Serie { Id = 94, BrandId = 6, Name = "Latitude" },
                new Serie { Id = 95, BrandId = 6, Name = "Authentique" },
                new Serie { Id = 96, BrandId = 6, Name = "FAP" },
                new Serie { Id = 97, BrandId = 6, Name = "Family FAP" },
                new Serie { Id = 98, BrandId = 20, Name = "Business" },
                new Serie { Id = 99, BrandId = 20, Name = "Linear Advantage" },
                new Serie { Id = 100, BrandId = 20, Name = "Vector" },
                new Serie { Id = 101, BrandId = 21, Name = "Elegance" },
                new Serie { Id = 102, BrandId = 22, Name = "Fun" },
                new Serie { Id = 103, BrandId = 14, Name = "DPF" },
                new Serie { Id = 104, BrandId = 14, Name = "Luna DPF" },
                new Serie { Id = 105, BrandId = 14, Name = "1.8 Hybrid" },
                new Serie { Id = 106, BrandId = 14, Name = "Linea Terra" },
                new Serie { Id = 107, BrandId = 3, Name = "Van" },
                new Serie { Id = 108, BrandId = 3, Name = "B2B-line" },
                new Serie { Id = 109, BrandId = 3, Name = "Trend" },
                new Serie { Id = 110, BrandId = 3, Name = "United DSG DPF" },
                new Serie { Id = 111, BrandId = 3, Name = "United DPF" },
                new Serie { Id = 112, BrandId = 3, Name = "Comfort" },
                new Serie { Id = 113, BrandId = 3, Name = "Comfortline" },
                new Serie { Id = 114, BrandId = 3, Name = "Conceptline DPF" },
                new Serie { Id = 115, BrandId = 3, Name = "Highline" },
                new Serie { Id = 116, BrandId = 3, Name = "BMT" },
                new Serie { Id = 117, BrandId = 3, Name = "Edition" },
                new Serie { Id = 118, BrandId = 3, Name = "Upgrade" },
                new Serie { Id = 119, BrandId = 3, Name = "Trendline" },
                new Serie { Id = 120, BrandId = 11, Name = "Kinetic" },
                new Serie { Id = 121, BrandId = 11, Name = "DRIVe Start/Stop" },
                new Serie { Id = 122, BrandId = 11, Name = "DRIVe Kinetic" },
                new Serie { Id = 123, BrandId = 11, Name = "D4 Kinetic St/St" },
                new Serie { Id = 124, BrandId = 11, Name = "DRIVe" },
                new Serie { Id = 125, BrandId = 11, Name = "D3 Kinetic St/St" },
                new Serie { Id = 126, BrandId = 11, Name = "DRIVe Start/Stop Kinetic" },
                new Serie { Id = 127, BrandId = 11, Name = "Momentum" },
                new Serie { Id = 128, BrandId = 4, Name = "Enjoy Active" },
                new Serie { Id = 129, BrandId = 4, Name = "Business" },
                new Serie { Id = 130, BrandId = 26, Name = "speedy" },
                new Serie { Id = 131, BrandId = 27, Name = "azerty" },
                new Serie { Id = 132, BrandId = 28, Name = "blablu" },
                new Serie { Id = 133, BrandId = 28, Name = "ssss" }
            );
            #endregion

            #region ExteriorColors & InteriorColors
            builder.Entity<ExteriorColor>().HasData(
                new ExteriorColor { Id = 1, BrandId = 1, Name = "Saphirschwarz", Code = "" },
                new ExteriorColor { Id = 2, BrandId = 1, Name = "Titansilber", Code = null },
                new ExteriorColor { Id = 3, BrandId = 4, Name = "Technical Grey", Code = "GR" },
                new ExteriorColor { Id = 4, BrandId = 4, Name = "Black Sapphires", Code = "BLs" },
                new ExteriorColor { Id = 5, BrandId = 4, Name = "Olympic White", Code = "WH" },
                new ExteriorColor { Id = 6, BrandId = 4, Name = "Metro", Code = "MT" },
                new ExteriorColor { Id = 7, BrandId = 4, Name = "Ultra Blue", Code = "UB" },
                new ExteriorColor { Id = 8, BrandId = 8, Name = "Grijs", Code = "GR" },
                new ExteriorColor { Id = 9, BrandId = 6, Name = "Yellow", Code = "Y" },
                new ExteriorColor { Id = 10, BrandId = 12, Name = "Knalgeel", Code = null },
                new ExteriorColor { Id = 11, BrandId = 12, Name = "Groen", Code = "GRRR" },
                new ExteriorColor { Id = 12, BrandId = 4, Name = "Star Silver", Code = null },
                new ExteriorColor { Id = 13, BrandId = 4, Name = "Silver Lightning", Code = null },
                new ExteriorColor { Id = 14, BrandId = 5, Name = "Red", Code = "Fred" },
                new ExteriorColor { Id = 15, BrandId = 15, Name = "Grijs", Code = null },
                new ExteriorColor { Id = 16, BrandId = 1, Name = "Spacegrau", Code = "SG" },
                new ExteriorColor { Id = 17, BrandId = 8, Name = "Lavagrijs", Code = null },
                new ExteriorColor { Id = 18, BrandId = 4, Name = "Luxor", Code = "GU9" },
                new ExteriorColor { Id = 19, BrandId = 4, Name = "Carbon Flash Black", Code = null },
                new ExteriorColor { Id = 20, BrandId = 16, Name = "Zwart", Code = null },
                new ExteriorColor { Id = 21, BrandId = 7, Name = "Grijs", Code = null },
                new ExteriorColor { Id = 22, BrandId = 4, Name = "Asteroid Grey", Code = null },
                new ExteriorColor { Id = 23, BrandId = 4, Name = "Waterworld Blue", Code = null },
                new ExteriorColor { Id = 24, BrandId = 4, Name = "Deep Sky Blue", Code = "GJW" },
                new ExteriorColor { Id = 25, BrandId = 11, Name = "Savile Grey", Code = "492" },
                new ExteriorColor { Id = 26, BrandId = 4, Name = "Deep Espresso Brown", Code = "" },
                new ExteriorColor { Id = 27, BrandId = 8, Name = "Zwart", Code = null },
                new ExteriorColor { Id = 28, BrandId = 27, Name = "azerty", Code = "azerty" },
                new ExteriorColor { Id = 29, BrandId = 17, Name = "Test", Code = "ext" },
                new ExteriorColor { Id = 30, BrandId = 4, Name = "red", Code = "red" }
            );

            builder.Entity<InteriorColor>().HasData(
                new InteriorColor { Id = 1, BrandId = 6, Name = "Black", Code = "b" },
                new InteriorColor { Id = 2, BrandId = 1, Name = "Leder Dakota Schwarz", Code = null },
                new InteriorColor { Id = 3, BrandId = 4, Name = "Charcoal", Code = "CC" },
                new InteriorColor { Id = 4, BrandId = 4, Name = "Cable Anthraciet", Code = "CA" },
                new InteriorColor { Id = 5, BrandId = 7, Name = "Knalrood", Code = "KR" },
                new InteriorColor { Id = 6, BrandId = 4, Name = "Dune Black", Code = "DB" },
                new InteriorColor { Id = 7, BrandId = 12, Name = "Zwart leder", Code = null },
                new InteriorColor { Id = 8, BrandId = 1, Name = "Fluid Anthracit", Code = null },
                new InteriorColor { Id = 9, BrandId = 4, Name = "Anthraciet (Tabita/Elba)", Code = null },
                new InteriorColor { Id = 10, BrandId = 4, Name = "Cashmere beige/anthraciet", Code = null },
                new InteriorColor { Id = 11, BrandId = 4, Name = "Leder Sienna Anthraciet black", Code = null },
                new InteriorColor { Id = 12, BrandId = 4, Name = "groen", Code = "GR4" },
                new InteriorColor { Id = 13, BrandId = 7, Name = "Leder Beige", Code = null },
                new InteriorColor { Id = 14, BrandId = 8, Name = "Steppe Zwart Leder", Code = null },
                new InteriorColor { Id = 15, BrandId = 4, Name = "Lace/jet Black", Code = null },
                new InteriorColor { Id = 16, BrandId = 4, Name = "Dune Beige", Code = "TAAS" },
                new InteriorColor { Id = 17, BrandId = 4, Name = "Ribbon/Morrocana", Code = null },
                new InteriorColor { Id = 18, BrandId = 4, Name = "Mando/Atlantis cocoa", Code = null },
                new InteriorColor { Id = 19, BrandId = 4, Name = "Stof/leder morrocana", Code = null },
                new InteriorColor { Id = 20, BrandId = 4, Name = "Salta Jet black", Code = null },
                new InteriorColor { Id = 21, BrandId = 4, Name = "Lyra/Jet Black", Code = null },
                new InteriorColor { Id = 22, BrandId = 4, Name = "Ribbon/Jet Black", Code = null },
                new InteriorColor { Id = 23, BrandId = 11, Name = "Select Leder", Code = "G761" },
                new InteriorColor { Id = 24, BrandId = 4, Name = "Leder Jasmin Saddle Up", Code = null },
                new InteriorColor { Id = 25, BrandId = 16, Name = "Zwart", Code = null },
                new InteriorColor { Id = 26, BrandId = 27, Name = "azerty", Code = "azerty" },
                new InteriorColor { Id = 27, BrandId = 8, Name = "pikzwart", Code = "AO23" },
                new InteriorColor { Id = 28, BrandId = 28, Name = "cccc", Code = "ssss" }
            );
            #endregion

            #region Countries
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "België", Code = "BE", Nationality = "Belg", POD = false, IsActive = true },
                new Country { Id = 2, Name = "Nederland", Code = "NL", Nationality = "Nederlandse", POD = true, IsActive = true },
                new Country { Id = 3, Name = "Duitsland", Code = "DE", Nationality = "Duitse", POD = false, IsActive = true },
                new Country { Id = 4, Name = "Frankrijk", Code = "FR", Nationality = "Franse", POD = false, IsActive = true },
                new Country { Id = 5, Name = "Spanje", Code = "ES", Nationality = "Spaanse", POD = false, IsActive = false }
            );
            #endregion

            #region Companies & Corporations
            builder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Total Belgium", Description = null, Reference = null, IsInternal = false, IsActive = false, NonActiveRemark = null, VAT = null, AccountNumber = null },
                new Company { Id = 2, Name = "Esso", Description = "Esso", Reference = "Esso", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "123", AccountNumber = "123" },
                new Company { Id = 3, Name = "Shell", Description = null, Reference = null, IsInternal = false, IsActive = false, NonActiveRemark = null, VAT = null, AccountNumber = null },
                new Company { Id = 4, Name = "OpelPlus", Description = "Fictieve Opel garage", Reference = "Garage opel", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0456.565.667", AccountNumber = "333-7777777-22" },
                new Company { Id = 5, Name = "AVIS", Description = "KT leverancier ?", Reference = "AVIS", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0455664455556", AccountNumber = "123-1234567-98" },
                new Company { Id = 6, Name = "Texaco", Description = "Texaco", Reference = "Texaco", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "2", AccountNumber = "2" },
                new Company { Id = 7, Name = "Q8", Description = null, Reference = null, IsInternal = false, IsActive = false, NonActiveRemark = null, VAT = null, AccountNumber = null },
                new Company { Id = 8, Name = "CIACfleet", Description = "Multimerkverhuurder", Reference = "CIAC", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "xx", AccountNumber = "xx" },
                new Company { Id = 9, Name = "Sneyers", Description = "BMW Garage", Reference = "D", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 10, Name = "AXA", Description = "AXA", Reference = "AXA", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 11, Name = "VAB", Description = "VAB", Reference = "VAB", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 12, Name = "Touring", Description = "Touring", Reference = "Touring", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "2", AccountNumber = "2" },
                new Company { Id = 13, Name = "Brocom", Description = "Brocom", Reference = "Brocom", IsInternal = false, IsActive = false, NonActiveRemark = "tijdelijk niet acief gezet", VAT = "BE 123233134234", AccountNumber = "123-123456789-12" },
                new Company { Id = 14, Name = "KBC Autolease", Description = "KBC", Reference = "KBC", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0422.562.385", AccountNumber = "BE30 4377 5013 7111" },
                new Company { Id = 15, Name = "Mercedes-Benz FS Belux NV", Description = "Daimler Fleet Management", Reference = "MBFS", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0405816821", AccountNumber = "BE42 4829 0171 1154" },
                new Company { Id = 16, Name = "GMAN Antwerpen", Description = null, Reference = null, IsInternal = false, IsActive = false, NonActiveRemark = null, VAT = null, AccountNumber = null },
                new Company { Id = 17, Name = "Mercator Verzekeringen NV", Description = "", Reference = "Mercator", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0400.048.883", AccountNumber = "BE31 4100 0007 1155" },
                new Company { Id = 18, Name = "KAVEDE NV", Description = "", Reference = "KAVEDE", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0429.270.926", AccountNumber = "" },
                new Company { Id = 19, Name = "Peter DAENINCK NV", Description = "BMW dealer", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 20, Name = "Carglass", Description = "Carglass", Reference = "CAR", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0432.023.845", AccountNumber = "335-0431795-94" },
                new Company { Id = 21, Name = "FodFin", Description = "Federale overheidsdienst Financiën", Reference = "FODFIN", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 22, Name = "Patrick Smets NV", Description = "Gar BMW Smets", Reference = "SMETS", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0418.022.587", AccountNumber = "001-4327984-17" },
                new Company { Id = 23, Name = "Beerens", Description = "", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 24, Name = "Jespers", Description = "Bandencentrale", Reference = "TYRECENTER", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE39416100572119", AccountNumber = "" },
                new Company { Id = 25, Name = "Autokeuring", Description = "algemeen naam", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 26, Name = "Euromex", Description = "rechtsbijstand", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0404493859", AccountNumber = "" },
                new Company { Id = 27, Name = "DAS", Description = "rechtsbijstandsverzekering", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 28, Name = "Maecon", Description = "Maecon", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 29, Name = "eMenKa NV", Description = "", Reference = "", IsInternal = true, IsActive = true, NonActiveRemark = "", VAT = "BE 0888.140.116", AccountNumber = "" },
                new Company { Id = 30, Name = "Moereels", Description = "banden donckers", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE80230013411177", AccountNumber = "" },
                new Company { Id = 31, Name = "eMenKa GmbH", Description = "", Reference = "", IsInternal = true, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 32, Name = "eMenKa BV", Description = "<p><span><span>Antwerpen is de hoofdstad van <span class=\"comment - copy\">This works fine, but be aware that copying a</span></span><span><span class=\"comment - copy\">nd </span></span><span><span class=\"comment - copy\">pasting </span></span></span></p>", Reference = "", IsInternal = true, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 33, Name = "test", Description = "test", Reference = "", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 34, Name = "Q8", Description = null, Reference = null, IsInternal = false, IsActive = false, NonActiveRemark = null, VAT = null, AccountNumber = null },
                new Company { Id = 35, Name = "Alphabet", Description = "", Reference = "ALP", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 36, Name = null, Description = null, Reference = null, IsInternal = null, IsActive = null, NonActiveRemark = null, VAT = null, AccountNumber = null }
            );

            builder.Entity<Corporation>().HasData(
                new Corporation { Id = 1, Name = "eMenKa BV", Abbreviation = "Holland", CompanyId = 32, StartDate = new DateTime(2010, 1, 1, 12, 0, 0), EndDate = null },
                new Corporation { Id = 2, Name = "eMenKa GmbH", Abbreviation = "Keulen", CompanyId = 31, StartDate = new DateTime(2010, 1, 1, 12, 0, 0), EndDate = null },
                new Corporation { Id = 3, Name = "eMenKa NV", Abbreviation = "Antwerpen", CompanyId = 29, StartDate = new DateTime(2010, 1, 1, 12, 0, 0), EndDate = null }
            );

            #endregion

            #region Persons
            builder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    Firstname = "Kevin",
                    Lastname = "Borremans",
                    BirthDate = new DateTime(1985, 1, 29, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2005, 2, 22, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 2,
                    Firstname = "Tim",
                    Lastname = "Van Lierde",
                    BirthDate = new DateTime(1982, 1, 22, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2007, 11, 6, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr.",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 3,
                    Firstname = "Luk",
                    Lastname = "Vandenweghe",
                    BirthDate = new DateTime(1979, 2, 27, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1999, 10, 14, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr.",
                    Picture = null
                },
                new Person
                {
                    Id = 4,
                    Firstname = "Frederik",
                    Lastname = "Vanwijck",
                    BirthDate = new DateTime(1977, 7, 20, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1996, 7, 20, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr.",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 5,
                    Firstname = "Joris",
                    Lastname = "Lambaerts",
                    BirthDate = new DateTime(1985, 5, 8, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2004, 4, 7, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2009, 4, 9, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr.",
                    Picture = null
                },
                new Person
                {
                    Id = 6,
                    Firstname = "Johan",
                    Lastname = "Petermans",
                    BirthDate = new DateTime(1962, 4, 28, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1983, 2, 24, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr.",
                    Picture = null
                },
                new Person
                {
                    Id = 7,
                    Firstname = "Mark",
                    Lastname = "Poels",
                    BirthDate = new DateTime(1982, 9, 14, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 8,
                    Firstname = "Peter",
                    Lastname = "Roefs",
                    BirthDate = new DateTime(1989, 5, 22, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 9,
                    Firstname = "Daan",
                    Lastname = "Seymens",
                    BirthDate = new DateTime(1987, 7, 6, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2007, 1, 1, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr.",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 10,
                    Firstname = "Gert",
                    Lastname = "Corten",
                    BirthDate = new DateTime(1979, 10, 5, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1998, 9, 5, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "BCD",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 11,
                    Firstname = "Steven",
                    Lastname = "Van Lierde",
                    BirthDate = new DateTime(1977, 1, 1, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2009, 3, 8, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 12,
                    Firstname = "Joris",
                    Lastname = "Hultermans",
                    BirthDate = new DateTime(1982, 2, 28, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2001, 1, 3, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 13,
                    Firstname = "Bart",
                    Lastname = "Boeckmans",
                    BirthDate = new DateTime(1982, 9, 20, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1999, 12, 23, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr.",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 14,
                    Firstname = "Kristof",
                    Lastname = "Van den berk",
                    BirthDate = new DateTime(1984, 3, 31, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2003, 4, 4, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 15,
                    Firstname = "Yannick",
                    Lastname = "Hammelinx",
                    BirthDate = new DateTime(1975, 3, 12, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1994, 3, 16, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 16,
                    Firstname = "Marc",
                    Lastname = "Agten",
                    BirthDate = new DateTime(1985, 4, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1977, 8, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 23, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 17,
                    Firstname = "Joeri",
                    Lastname = "Jansens",
                    BirthDate = new DateTime(1987, 9, 9, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2006, 9, 14, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 18,
                    Firstname = "Steve",
                    Lastname = "Baeyens",
                    BirthDate = new DateTime(1976, 5, 12, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1997, 1, 23, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 19,
                    Firstname = "Benoit",
                    Lastname = "Geeraerts",
                    BirthDate = new DateTime(1974, 11, 29, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1993, 12, 1, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 20,
                    Firstname = "Michaël",
                    Lastname = "Borremans",
                    BirthDate = new DateTime(1978, 10, 26, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1996, 10, 29, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "de heer",
                    Picture = null
                },
                new Person
                {
                    Id = 21,
                    Firstname = "Gien",
                    Lastname = "Verschoten",
                    BirthDate = new DateTime(1985, 5, 28, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2004, 4, 8, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "V",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 22,
                    Firstname = "Korneel",
                    Lastname = "Vandijck",
                    BirthDate = new DateTime(1980, 10, 15, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1999, 6, 23, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 23,
                    Firstname = "Tom",
                    Lastname = "Van der Meersch",
                    BirthDate = new DateTime(1984, 7, 2, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2008, 7, 28, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 24,
                    Firstname = "Pieter",
                    Lastname = "Van Vlaanderen",
                    BirthDate = new DateTime(1985, 1, 23, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2004, 11, 8, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 25,
                    Firstname = "Bart",
                    Lastname = "Billemoons",
                    BirthDate = null,
                    Language = (Language)1,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 26,
                    Firstname = "Arnaud",
                    Lastname = "Verstrepen",
                    BirthDate = new DateTime(1978, 6, 26, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "Meneer",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 27,
                    Firstname = "Mario",
                    Lastname = "Van Genth",
                    BirthDate = new DateTime(1985, 4, 29, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1987, 12, 28, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 28,
                    Firstname = "Jorn",
                    Lastname = "Hens",
                    BirthDate = new DateTime(1987, 4, 2, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2000, 3, 8, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 29,
                    Firstname = "Sep",
                    Lastname = "Feyaerts",
                    BirthDate = new DateTime(1989, 5, 12, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2007, 7, 12, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 30,
                    Firstname = "Marc",
                    Lastname = "Hens",
                    BirthDate = new DateTime(1973, 12, 13, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1998, 2, 19, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 31,
                    Firstname = "Bert",
                    Lastname = "Lernout",
                    BirthDate = new DateTime(1985, 11, 15, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2009, 3, 13, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 32,
                    Firstname = "Kevin",
                    Lastname = "Cloostermans",
                    BirthDate = new DateTime(1990, 5, 21, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2010, 5, 10, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 33,
                    Firstname = "Geoffrey",
                    Lastname = "Lagagne",
                    BirthDate = new DateTime(1989, 9, 20, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2012, 5, 22, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 34,
                    Firstname = "Kevin",
                    Lastname = "Cleymans",
                    BirthDate = new DateTime(1987, 4, 26, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2011, 6, 20, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 35,
                    Firstname = "Yoeri",
                    Lastname = "Depraeter",
                    BirthDate = new DateTime(1989, 11, 25, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2007, 11, 28, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 36,
                    Firstname = "Cobe",
                    Lastname = "Laplage",
                    BirthDate = new DateTime(1989, 5, 31, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 37,
                    Firstname = "Marco",
                    Lastname = "Jans",
                    BirthDate = new DateTime(1986, 11, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 38,
                    Firstname = "Maria",
                    Lastname = "Geldermans",
                    BirthDate = new DateTime(1998, 11, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2011, 7, 18, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "V",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 39,
                    Firstname = "Yannick",
                    Lastname = "Jespers",
                    BirthDate = new DateTime(1989, 11, 14, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2015, 9, 8, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2025, 9, 8, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 40,
                    Firstname = "Gunther",
                    Lastname = "Schuiten",
                    BirthDate = new DateTime(1978, 1, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1996, 7, 26, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 41,
                    Firstname = "Tjorven",
                    Lastname = "Broers",
                    BirthDate = new DateTime(1985, 7, 6, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "C",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 42,
                    Firstname = "Wouter",
                    Lastname = "Van Zeeland",
                    BirthDate = new DateTime(1990, 6, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 43,
                    Firstname = "Steven",
                    Lastname = "Claas",
                    BirthDate = new DateTime(1970, 10, 24, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(1988, 11, 1, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 44,
                    Firstname = "Be",
                    Lastname = "Ve",
                    BirthDate = new DateTime(1991, 12, 14, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "hgjj",
                    StartDateDriversLicense = new DateTime(2017, 2, 6, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = null
                },
                new Person
                {
                    Id = 45,
                    Firstname = "Frederik",
                    Lastname = "Hermans",
                    BirthDate = new DateTime(1984, 8, 2, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 46,
                    Firstname = "Kevin",
                    Lastname = "Rousseeuw",
                    BirthDate = new DateTime(1999, 9, 9, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "123/123456",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 47,
                    Firstname = "Stijn",
                    Lastname = "Ceunen",
                    BirthDate = new DateTime(1993, 5, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = new DateTime(2017, 9, 1, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 48,
                    Firstname = "Stijn",
                    Lastname = "Ceunen",
                    BirthDate = new DateTime(1993, 5, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = new DateTime(2017, 8, 24, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "",
                    Picture = null
                },
                new Person
                {
                    Id = 49,
                    Firstname = "Stijn",
                    Lastname = "Claeys",
                    BirthDate = new DateTime(1995, 8, 14, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "12345678-25",
                    StartDateDriversLicense = new DateTime(2017, 9, 1, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr",
                    Picture = null
                },
                new Person
                {
                    Id = 50,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = new DateTime(2019, 9, 30, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = null
                },
                new Person
                {
                    Id = 51,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = null
                },
                new Person
                {
                    Id = 52,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = null
                },
                new Person
                {
                    Id = 53,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = null
                },
                new Person
                {
                    Id = 54,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = null
                },
                new Person
                {
                    Id = 55,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 56,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 57,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 58,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 59,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 60,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 61,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 62,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 63,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "b",
                    Gender = "",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 64,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "b",
                    Gender = "M",
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 65,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "b",
                    Gender = "M",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 66,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "b",
                    Gender = "M",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 67,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2019, 10, 3, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "azerty",
                    StartDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    DriversLicenseType = "b",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 68,
                    Firstname = "super",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 10, 2, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "azerty",
                    StartDateDriversLicense = new DateTime(2019, 10, 2, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "a",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 69,
                    Firstname = "super",
                    Lastname = "woman",
                    BirthDate = new DateTime(2019, 10, 10, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "aazear",
                    StartDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 1, 12, 0, 0),
                    DriversLicenseType = "a",
                    Gender = "F",
                    Title = "mss",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 70,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = new DateTime(2019, 10, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = "a",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 71,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = new DateTime(2019, 10, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    DriversLicenseType = "a",
                    Gender = "a",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 72,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = new DateTime(2019, 10, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "a",
                    StartDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    DriversLicenseType = "a",
                    Gender = "a",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 73,
                    Firstname = "string",
                    Lastname = "string",
                    BirthDate = new DateTime(2019, 10, 4, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "string",
                    StartDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 4, 12, 0, 0),
                    DriversLicenseType = "a",
                    Gender = "a",
                    Title = "string",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 74,
                    Firstname = "super",
                    Lastname = "man",
                    BirthDate = new DateTime(1994, 12, 31, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "1452145214",
                    StartDateDriversLicense = new DateTime(2019, 10, 10, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 3, 12, 0, 0),
                    DriversLicenseType = "SIHFi",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 75,
                    Firstname = "seinfield",
                    Lastname = "larry",
                    BirthDate = new DateTime(2019, 10, 14, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "144445584",
                    StartDateDriversLicense = new DateTime(2019, 10, 1, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 10, 12, 0, 0),
                    DriversLicenseType = "Az",
                    Gender = "M",
                    Title = "mister",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 76,
                    Firstname = "super",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 10, 1, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "32585",
                    StartDateDriversLicense = new DateTime(2019, 10, 8, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 8, 12, 0, 0),
                    DriversLicenseType = "ABc",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 77,
                    Firstname = "bla",
                    Lastname = "bla",
                    BirthDate = null,
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = "AZERT",
                    Gender = "M",
                    Title = "bla",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 78,
                    Firstname = "azerty",
                    Lastname = "azerty",
                    BirthDate = new DateTime(2019, 10, 1, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "214521",
                    StartDateDriversLicense = new DateTime(2019, 10, 10, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 15, 12, 0, 0),
                    DriversLicenseType = "AZV",
                    Gender = "F",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 79,
                    Firstname = "elvin",
                    Lastname = "azerty",
                    BirthDate = new DateTime(2019, 10, 8, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "254854152",
                    StartDateDriversLicense = new DateTime(2019, 10, 2, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 80,
                    Firstname = "Joeri",
                    Lastname = "Jans",
                    BirthDate = new DateTime(1987, 9, 8, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "45456456456",
                    StartDateDriversLicense = new DateTime(1998, 2, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2034, 7, 11, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Mr.",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 81,
                    Firstname = "lord",
                    Lastname = "dark",
                    BirthDate = new DateTime(2019, 10, 9, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "azert",
                    StartDateDriversLicense = new DateTime(2019, 10, 28, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 10, 30, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 82,
                    Firstname = "Joeri",
                    Lastname = "Jans",
                    BirthDate = new DateTime(2019, 10, 9, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "23",
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 83,
                    Firstname = "beast",
                    Lastname = "60000",
                    BirthDate = new DateTime(2019, 10, 31, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "3545632",
                    StartDateDriversLicense = new DateTime(2019, 11, 5, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 5, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 84,
                    Firstname = "az",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 11, 14, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = "4521",
                    StartDateDriversLicense = new DateTime(2019, 11, 7, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 7, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "sir",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 85,
                    Firstname = "beast",
                    Lastname = "6000",
                    BirthDate = new DateTime(2019, 11, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "2145",
                    StartDateDriversLicense = new DateTime(2019, 10, 31, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 1, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 86,
                    Firstname = "james",
                    Lastname = "john",
                    BirthDate = new DateTime(2019, 10, 24, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "2562",
                    StartDateDriversLicense = new DateTime(2019, 11, 1, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 2, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 87,
                    Firstname = "azerty",
                    Lastname = "qwerty",
                    BirthDate = new DateTime(2019, 11, 11, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "241562",
                    StartDateDriversLicense = new DateTime(2019, 11, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 13, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "hello",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 88,
                    Firstname = "beast",
                    Lastname = "60000",
                    BirthDate = new DateTime(2019, 11, 21, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "4554",
                    StartDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 89,
                    Firstname = "beast",
                    Lastname = "7895",
                    BirthDate = new DateTime(2019, 11, 21, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "12456",
                    StartDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    DriversLicenseType = "ABCD",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 90,
                    Firstname = "beast",
                    Lastname = "6000",
                    BirthDate = new DateTime(2019, 11, 18, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "21452",
                    StartDateDriversLicense = new DateTime(2019, 11, 18, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 18, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 91,
                    Firstname = "beast",
                    Lastname = "7000",
                    BirthDate = new DateTime(2019, 11, 8, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = "21521",
                    StartDateDriversLicense = new DateTime(2019, 11, 8, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 8, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 92,
                    Firstname = "hero",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 11, 22, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = "5545",
                    StartDateDriversLicense = new DateTime(2019, 11, 22, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 22, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 93,
                    Firstname = "super",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 11, 19, 12, 0, 0),
                    Language = (Language)4,
                    DriversLicenseNumber = "524152",
                    StartDateDriversLicense = new DateTime(2019, 11, 19, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 19, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 94,
                    Firstname = "super",
                    Lastname = "man",
                    BirthDate = new DateTime(2019, 11, 16, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = "2145",
                    StartDateDriversLicense = new DateTime(2019, 11, 16, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 16, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 95,
                    Firstname = "azerty",
                    Lastname = "azerty",
                    BirthDate = new DateTime(2019, 11, 7, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "2521",
                    StartDateDriversLicense = new DateTime(2019, 11, 22, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 22, 12, 0, 0),
                    DriversLicenseType = "A",
                    Gender = null,
                    Title = "",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 96,
                    Firstname = "beast",
                    Lastname = "7000",
                    BirthDate = new DateTime(2019, 11, 21, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "123",
                    StartDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 11, 21, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 97,
                    Firstname = "azzeeer",
                    Lastname = "azerty",
                    BirthDate = null,
                    Language = (Language)1,
                    DriversLicenseNumber = "456",
                    StartDateDriversLicense = new DateTime(2019, 11, 23, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 3, 27, 12, 0, 0),
                    DriversLicenseType = "A",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 98,
                    Firstname = "super",
                    Lastname = "woman",
                    BirthDate = new DateTime(2020, 1, 12, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "457865",
                    StartDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "F",
                    Title = "ms",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 99,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 11, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "456",
                    StartDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 100,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 11, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "12345",
                    StartDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 101,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 11, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "123456",
                    StartDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 102,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 12, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "124",
                    StartDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "F",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 103,
                    Firstname = "elvin",
                    Lastname = "lumani411",
                    BirthDate = new DateTime(1995, 7, 1, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "123",
                    StartDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 11, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 104,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 12, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "223",
                    StartDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 105,
                    Firstname = "elvinxxxxxxxxxx",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 12, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "152312313212",
                    StartDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 12, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 106,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(1995, 7, 2, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "789541",
                    StartDateDriversLicense = new DateTime(2020, 1, 13, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 4, 24, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 107,
                    Firstname = "0azerty",
                    Lastname = "0azerty",
                    BirthDate = new DateTime(2020, 1, 14, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "0azerty",
                    StartDateDriversLicense = new DateTime(2020, 1, 14, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 14, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 108,
                    Firstname = "0azerty0azerty",
                    Lastname = "0azerty",
                    BirthDate = new DateTime(2020, 1, 14, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "0azerty",
                    StartDateDriversLicense = new DateTime(2020, 1, 14, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 14, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 109,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 16, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "7894685",
                    StartDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 110,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 16, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "789",
                    StartDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    DriversLicenseType = "ABC",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 111,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 16, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "789456",
                    StartDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 16, 12, 0, 0),
                    DriversLicenseType = "AB",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 112,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 17, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "789",
                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    DriversLicenseType = "78789",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 113,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 17, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    DriversLicenseType = null,
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 114,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 10, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    DriversLicenseType = null,
                    Gender = null,
                    Title = null,
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 115,
                    Firstname = "elvin",
                    Lastname = "lumani",
                    BirthDate = new DateTime(2020, 1, 17, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "789",
                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    DriversLicenseType = "789",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 116,
                    Firstname = "larry",
                    Lastname = "jame",
                    BirthDate = new DateTime(1995, 7, 19, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "7897897-78",
                    StartDateDriversLicense = new DateTime(2020, 1, 18, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 31, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 117,
                    Firstname = "joeri",
                    Lastname = "jans17",
                    BirthDate = new DateTime(2019, 12, 16, 12, 0, 0),
                    Language = (Language)1,
                    DriversLicenseNumber = "456456456",
                    StartDateDriversLicense = new DateTime(2019, 12, 16, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 12, 17, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "F",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 118,
                    Firstname = "Stijn",
                    Lastname = "Lenaerts",
                    BirthDate = new DateTime(1993, 6, 18, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = new DateTime(2006, 11, 30, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = "M",
                    Title = "dhr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 119,
                    Firstname = "Stijn",
                    Lastname = "Lenaerts",
                    BirthDate = new DateTime(1985, 5, 19, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "ja",
                    StartDateDriversLicense = new DateTime(2000, 5, 20, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2025, 5, 20, 12, 0, 0),
                    DriversLicenseType = "B52",
                    Gender = "M",
                    Title = "Dhr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 120,
                    Firstname = "driver",
                    Lastname = "test1",
                    BirthDate = new DateTime(2020, 2, 19, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = null,
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = "F",
                    Title = "mr",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 121,
                    Firstname = "driver",
                    Lastname = "test",
                    BirthDate = new DateTime(2020, 2, 18, 12, 0, 0),
                    Language = (Language)3,
                    DriversLicenseNumber = null,
                    StartDateDriversLicense = new DateTime(2020, 2, 17, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = null,
                    Gender = "M",
                    Title = null,
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 122,
                    Firstname = "Jelle",
                    Lastname = "Cox",
                    BirthDate = new DateTime(1997, 2, 6, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "123456789",
                    StartDateDriversLicense = new DateTime(2015, 9, 19, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Doctor",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 123,
                    Firstname = "J",
                    Lastname = "C",
                    BirthDate = new DateTime(2020, 3, 3, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "e",
                    StartDateDriversLicense = new DateTime(2020, 3, 3, 12, 0, 0),
                    EndDateDriversLicense = null,
                    DriversLicenseType = "b",
                    Gender = "F",
                    Title = null,
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 124,
                    Firstname = "abc",
                    Lastname = "def",
                    BirthDate = new DateTime(2016, 6, 8, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "123456789",
                    StartDateDriversLicense = new DateTime(2017, 2, 6, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2025, 6, 2, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Test",
                    Picture = new byte[] { 0x0 }
                },
                new Person
                {
                    Id = 125,
                    Firstname = "Jamie",
                    Lastname = "Luyten",
                    BirthDate = new DateTime(1999, 4, 19, 12, 0, 0),
                    Language = (Language)2,
                    DriversLicenseNumber = "123465",
                    StartDateDriversLicense = new DateTime(2020, 10, 13, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2021, 6, 14, 12, 0, 0),
                    DriversLicenseType = "B",
                    Gender = "M",
                    Title = "Test",
                    Picture = new byte[] { 0x0 }
                }
            );
            #endregion

            #region Drivers
            builder.Entity<Driver>().HasData(
                new Driver
                {
                    Id = 1,
                    PersonId = 2,
                    StartDate = new DateTime(2007, 08, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 2,
                    PersonId = 6,
                    StartDate = new DateTime(2007, 09, 1, 0, 0, 0),
                    EndDate = new DateTime(2009, 06, 25, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 3,
                    PersonId = 9,
                    StartDate = new DateTime(2009, 05, 13, 0, 0, 0),
                    EndDate = new DateTime(2011, 01, 13, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 4,
                    PersonId = 4,
                    StartDate = new DateTime(2008, 03, 16, 0, 0, 0),
                    EndDate = new DateTime(2010, 11, 30, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 5,
                    PersonId = 1,
                    StartDate = new DateTime(2008, 09, 16, 0, 0, 0),
                    EndDate = new DateTime(2015, 02, 28, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 6,
                    PersonId = 10,
                    StartDate = new DateTime(2007, 08, 5, 0, 0, 0),
                    EndDate = new DateTime(2010, 04, 16, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 7,
                    PersonId = 3,
                    StartDate = new DateTime(2007, 06, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 8,
                    PersonId = 11,
                    StartDate = new DateTime(2009, 06, 15, 0, 0, 0),
                    EndDate = new DateTime(2011, 09, 30, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 9,
                    PersonId = 12,
                    StartDate = new DateTime(2008, 10, 6, 0, 0, 0),
                    EndDate = new DateTime(2010, 03, 1, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 10,
                    PersonId = 13,
                    StartDate = new DateTime(2009, 09, 14, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 11,
                    PersonId = 14,
                    StartDate = new DateTime(2007, 09, 17, 0, 0, 0),
                    EndDate = new DateTime(2008, 06, 30, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 12,
                    PersonId = 15,
                    StartDate = new DateTime(2007, 11, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 13,
                    PersonId = 16,
                    StartDate = new DateTime(2007, 05, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 14,
                    PersonId = 17,
                    StartDate = new DateTime(2009, 09, 25, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 15,
                    PersonId = 18,
                    StartDate = new DateTime(2008, 08, 31, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 16,
                    PersonId = 19,
                    StartDate = new DateTime(2011, 02, 1, 0, 0, 0),
                    EndDate = new DateTime(2012, 12, 31, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 17,
                    PersonId = 20,
                    StartDate = new DateTime(2011, 03, 30, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 18,
                    PersonId = 21,
                    StartDate = new DateTime(2011, 03, 14, 0, 0, 0),
                    EndDate = new DateTime(2014, 06, 13, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 19,
                    PersonId = 22,
                    StartDate = new DateTime(2011, 04, 12, 0, 0, 0),
                    EndDate = new DateTime(2012, 03, 5, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 20,
                    PersonId = 23,
                    StartDate = new DateTime(2011, 05, 16, 0, 0, 0),
                    EndDate = new DateTime(2015, 10, 9, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 21,
                    PersonId = 24,
                    StartDate = new DateTime(2011, 06, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 22,
                    PersonId = 25,
                    StartDate = new DateTime(2008, 01, 2, 0, 0, 0),
                    EndDate = new DateTime(2009, 01, 14, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 23,
                    PersonId = 26,
                    StartDate = new DateTime(2007, 12, 3, 0, 0, 0),
                    EndDate = new DateTime(2008, 05, 31, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 24,
                    PersonId = 27,
                    StartDate = new DateTime(2012, 01, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 25,
                    PersonId = 28,
                    StartDate = new DateTime(2012, 03, 5, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 26,
                    PersonId = 29,
                    StartDate = new DateTime(2012, 02, 6, 0, 0, 0),
                    EndDate = new DateTime(2014, 10, 31, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 27,
                    PersonId = 30,
                    StartDate = new DateTime(2012, 02, 27, 0, 0, 0),
                    EndDate = new DateTime(2014, 08, 25, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 28,
                    PersonId = 31,
                    StartDate = new DateTime(2012, 05, 14, 0, 0, 0),
                    EndDate = new DateTime(2014, 10, 24, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 29,
                    PersonId = 32,
                    StartDate = new DateTime(2012, 08, 13, 0, 0, 0),
                    EndDate = new DateTime(2015, 02, 28, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 30,
                    PersonId = 33,
                    StartDate = new DateTime(2012, 08, 20, 0, 0, 0),
                    EndDate = new DateTime(2013, 12, 16, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 31,
                    PersonId = 34,
                    StartDate = new DateTime(2013, 01, 23, 0, 0, 0),
                    EndDate = new DateTime(2015, 08, 28, 0, 0, 0),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 32,
                    PersonId = 35,
                    StartDate = new DateTime(2013, 09, 16, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 33,
                    PersonId = 36,
                    StartDate = new DateTime(2014, 01, 14, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 34,
                    PersonId = 37,
                    StartDate = new DateTime(2014, 08, 4, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 35,
                    PersonId = 38,
                    StartDate = new DateTime(2014, 10, 13, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 36,
                    PersonId = 39,
                    StartDate = new DateTime(2015, 07, 13, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 37,
                    PersonId = 40,
                    StartDate = new DateTime(2015, 01, 19, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 38,
                    PersonId = 41,
                    StartDate = new DateTime(2007, 03, 20, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 39,
                    PersonId = 42,
                    StartDate = new DateTime(2015, 07, 27, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 40,
                    PersonId = 43,
                    StartDate = new DateTime(2007, 05, 1, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 41,
                    PersonId = 46,
                    StartDate = new DateTime(2017, 07, 3, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 42,
                    PersonId = 49,
                    StartDate = new DateTime(2017, 09, 11, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 43,
                    PersonId = 80,
                    StartDate = new DateTime(2019, 09, 30, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 44,
                    PersonId = 84,
                    StartDate = new DateTime(2019, 11, 27, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 45,
                    PersonId = 86,
                    StartDate = new DateTime(2019, 11, 3, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 46,
                    PersonId = 92,
                    StartDate = new DateTime(2019, 11, 22, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 47,
                    PersonId = 93,
                    StartDate = new DateTime(2019, 11, 16, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 48,
                    PersonId = 94,
                    StartDate = new DateTime(2019, 11, 16, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 49,
                    PersonId = 97,
                    StartDate = new DateTime(2019, 11, 19, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 50,
                    PersonId = 116,
                    StartDate = new DateTime(2020, 01, 17, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 51,
                    PersonId = 119,
                    StartDate = new DateTime(2020, 02, 6, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 52,
                    PersonId = 122,
                    StartDate = new DateTime(2020, 03, 2, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 53,
                    PersonId = 123,
                    StartDate = new DateTime(2020, 03, 4, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 54,
                    PersonId = 124,
                    StartDate = new DateTime(2020, 10, 7, 0, 0, 0),
                    EndDate = null,
                    FuelCardId = null
                }
            );
            #endregion

            #region Vehicles

            builder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 74, FiscalHP = 9, AverageFuel = null, EndDateDelivery = new DateTime(2009, 12, 31, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 2, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 1, EngineCapacity = 1995, EnginePower = 130, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2013, 12, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 3, BrandId = 3, ModelId = 8, SeriesId = 3, EngineTypeId = 24, DoorTypeId = 2, EngineCapacity = 1577, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = new DateTime(2009, 05, 19, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 4, BrandId = 4, ModelId = 12, SeriesId = 5, EngineTypeId = 5, DoorTypeId = 2, EngineCapacity = 1910, EnginePower = 74, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2020, 01, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 5, BrandId = 4, ModelId = 14, SeriesId = 4, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1990, EnginePower = 124, FiscalHP = 11, AverageFuel = null, EndDateDelivery = new DateTime(2014, 03, 4, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 6, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 1, DoorTypeId = 3, EngineCapacity = 1995, EnginePower = 90, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2011, 12, 31, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 7, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 2001, EnginePower = 165, FiscalHP = 12, AverageFuel = null, EndDateDelivery = new DateTime(2013, 05, 15, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 8, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 10, DoorTypeId = 1, EngineCapacity = 2100, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2012, 01, 1, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 9, BrandId = 7, ModelId = 18, SeriesId = 18, EngineTypeId = 9, DoorTypeId = 4, EngineCapacity = 1560, EnginePower = 123, FiscalHP = 9, AverageFuel = null, EndDateDelivery = new DateTime(2013, 01, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 10, BrandId = 6, ModelId = 17, SeriesId = 12, EngineTypeId = 14, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2013, 01, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 11, BrandId = 1, ModelId = 1, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 1995, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = new DateTime(2013, 01, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 12, BrandId = 4, ModelId = 13, SeriesId = 4, EngineTypeId = 15, DoorTypeId = 2, EngineCapacity = 1248, EnginePower = 66, FiscalHP = 7, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 13, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 2, EngineCapacity = 1999, EnginePower = 90, FiscalHP = 11, AverageFuel = null, EndDateDelivery = new DateTime(2014, 01, 1, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 14, BrandId = 11, ModelId = 24, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 4, EngineCapacity = 2000, EnginePower = 136, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 15, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 16, BrandId = 11, ModelId = 27, SeriesId = 23, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 3232, EnginePower = 168, FiscalHP = 13, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 17, BrandId = 1, ModelId = 31, SeriesId = 16, EngineTypeId = 1, DoorTypeId = 4, EngineCapacity = 1800, EnginePower = 8, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 18, BrandId = 12, ModelId = 34, SeriesId = 26, EngineTypeId = 21, DoorTypeId = 3, EngineCapacity = 1560, EnginePower = 66, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 19, BrandId = 5, ModelId = 15, SeriesId = 30, EngineTypeId = 25, DoorTypeId = 4, EngineCapacity = 4500, EnginePower = 233, FiscalHP = 19, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 20, BrandId = 4, ModelId = 12, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 21, BrandId = 4, ModelId = 14, SeriesId = 5, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1910, EnginePower = 88, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 22, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 15, DoorTypeId = 1, EngineCapacity = 1296, EnginePower = 66, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 23, BrandId = 6, ModelId = 17, SeriesId = 13, EngineTypeId = 27, DoorTypeId = 3, EngineCapacity = null, EnginePower = 0, FiscalHP = 0, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 24, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 16, DoorTypeId = 1, EngineCapacity = 2999, EnginePower = 150, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 25, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 26, BrandId = 4, ModelId = 11, SeriesId = 37, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 27, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 28, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 29, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 96, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 30, BrandId = 6, ModelId = 17, SeriesId = 12, EngineTypeId = 40, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 31, BrandId = 1, ModelId = 1, SeriesId = 16, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 1, EnginePower = 1, FiscalHP = 1, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 32, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 95, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 33, BrandId = 4, ModelId = 14, SeriesId = 4, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1910, EnginePower = 100, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 34, BrandId = 12, ModelId = 33, SeriesId = 28, EngineTypeId = 21, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 43, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 35, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 37, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 36, BrandId = 3, ModelId = 8, SeriesId = 3, EngineTypeId = 3, DoorTypeId = 2, EngineCapacity = null, EnginePower = 0, FiscalHP = 0, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 37, BrandId = 1, ModelId = 4, SeriesId = 15, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 1900, EnginePower = 0, FiscalHP = 0, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 38, BrandId = 6, ModelId = 21, SeriesId = 12, EngineTypeId = 40, DoorTypeId = 1, EngineCapacity = 1229, EnginePower = 122, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 39, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = null, EnginePower = 0, FiscalHP = 0, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 3 },
                new Vehicle { Id = 40, BrandId = 8, ModelId = 30, SeriesId = 49, EngineTypeId = 50, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 41, BrandId = 8, ModelId = 30, SeriesId = 49, EngineTypeId = 51, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 75, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 42, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 78, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 150, FiscalHP = 0, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 5 },
                new Vehicle { Id = 43, BrandId = 8, ModelId = 30, SeriesId = 51, EngineTypeId = 50, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 44, BrandId = 8, ModelId = 30, SeriesId = 51, EngineTypeId = 10, DoorTypeId = 2, EngineCapacity = 1900, EnginePower = 77, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2019, 05, 15, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 45, BrandId = 8, ModelId = 30, SeriesId = 52, EngineTypeId = 50, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 46, BrandId = 8, ModelId = 16, SeriesId = 53, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 47, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 12, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 48, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 35, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 88, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 49, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 52, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 50, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 53, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 51, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 54, DoorTypeId = 4, EngineCapacity = 1800, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 52, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 54, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 53, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 3, EngineCapacity = 1900, EnginePower = 85, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 54, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 3, EngineCapacity = 1900, EnginePower = 84, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 55, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 35, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 56, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 35, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 88, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 57, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 52, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 58, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 52, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 59, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 60, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 61, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 62, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 63, BrandId = 8, ModelId = 20, SeriesId = 54, EngineTypeId = 55, DoorTypeId = 6, EngineCapacity = 2700, EnginePower = 120, FiscalHP = 14, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 64, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 1968, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 65, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 66, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 56, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 67, BrandId = 8, ModelId = 20, SeriesId = 55, EngineTypeId = 35, DoorTypeId = 7, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 68, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 69, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 85, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 70, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 71, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 72, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 61, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 73, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 61, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 74, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 1999, EnginePower = 90, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 75, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 1995, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 76, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 77, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 78, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 79, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 80, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 13, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 10, AverageFuel = null, EndDateDelivery = new DateTime(2019, 05, 7, 0, 0, 0), FuelTypeId = 10 },
                new Vehicle { Id = 81, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 13, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 82, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 2001, EnginePower = 130, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 83, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 13, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 84, BrandId = 1, ModelId = 1, SeriesId = 16, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 85, BrandId = 1, ModelId = 1, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 86, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 3500, EnginePower = 210, FiscalHP = 15, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 87, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 3500, EnginePower = 240, FiscalHP = 15, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 88, BrandId = 12, ModelId = 34, SeriesId = 60, EngineTypeId = 63, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 110, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 89, BrandId = 12, ModelId = 34, SeriesId = 61, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 90, BrandId = 12, ModelId = 34, SeriesId = 62, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 91, BrandId = 12, ModelId = 34, SeriesId = 27, EngineTypeId = 64, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 92, BrandId = 12, ModelId = 34, SeriesId = 63, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 93, BrandId = 12, ModelId = 34, SeriesId = 64, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 94, BrandId = 12, ModelId = 34, SeriesId = 65, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 95, BrandId = 12, ModelId = 34, SeriesId = 66, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 96, BrandId = 2, ModelId = 7, SeriesId = 75, EngineTypeId = 68, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 85, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 97, BrandId = 2, ModelId = 7, SeriesId = 75, EngineTypeId = 70, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 84, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 98, BrandId = 2, ModelId = 7, SeriesId = 72, EngineTypeId = 73, DoorTypeId = 2, EngineCapacity = 1800, EnginePower = 92, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 99, BrandId = 2, ModelId = 7, SeriesId = 72, EngineTypeId = 70, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 102, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 100, BrandId = 2, ModelId = 7, SeriesId = 71, EngineTypeId = 72, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 92, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 101, BrandId = 2, ModelId = 7, SeriesId = 73, EngineTypeId = 70, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 102, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 94, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 103, BrandId = 4, ModelId = 11, SeriesId = 81, EngineTypeId = 94, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 104, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 59, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 105, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 74, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 106, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 1, EngineCapacity = 1700, EnginePower = 73, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 107, BrandId = 4, ModelId = 11, SeriesId = 37, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1700, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 108, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 109, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 2, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 110, BrandId = 4, ModelId = 29, SeriesId = 82, EngineTypeId = 20, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 111, BrandId = 4, ModelId = 12, SeriesId = 5, EngineTypeId = 95, DoorTypeId = 2, EngineCapacity = 1700, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 112, BrandId = 4, ModelId = 12, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 113, BrandId = 7, ModelId = 23, SeriesId = 86, EngineTypeId = 96, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 114, BrandId = 7, ModelId = 23, SeriesId = 87, EngineTypeId = 96, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 115, BrandId = 7, ModelId = 23, SeriesId = 88, EngineTypeId = 96, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 116, BrandId = 6, ModelId = 17, SeriesId = 91, EngineTypeId = 40, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 117, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 118, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 119, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 120, BrandId = 3, ModelId = 10, SeriesId = 113, EngineTypeId = 110, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 121, BrandId = 3, ModelId = 10, SeriesId = 113, EngineTypeId = 111, DoorTypeId = 1, EngineCapacity = 1968, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 122, BrandId = 3, ModelId = 10, SeriesId = 114, EngineTypeId = 110, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 77, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 123, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 112, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 124, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 112, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 125, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 111, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 81, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 126, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 108, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 103, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 127, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 128, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 129, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 103, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 130, BrandId = 11, ModelId = 28, SeriesId = 120, EngineTypeId = 114, DoorTypeId = 6, EngineCapacity = 2400, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 131, BrandId = 11, ModelId = 28, SeriesId = 120, EngineTypeId = 18, DoorTypeId = 9, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 132, BrandId = 11, ModelId = 24, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 133, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 17, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 134, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 135, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 136, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 137, BrandId = 11, ModelId = 26, SeriesId = 124, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 138, BrandId = 11, ModelId = 26, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 84, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 139, BrandId = 11, ModelId = 26, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 140, BrandId = 11, ModelId = 27, SeriesId = 123, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 1984, EnginePower = 120, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 141, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 1984, EnginePower = 120, FiscalHP = 163, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 142, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 143, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1560, EnginePower = 85, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 144, BrandId = 11, ModelId = 27, SeriesId = 120, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 145, BrandId = 11, ModelId = 27, SeriesId = 127, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 146, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 147, BrandId = 4, ModelId = 11, SeriesId = 128, EngineTypeId = 39, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 148, BrandId = 4, ModelId = 11, SeriesId = 128, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 149, BrandId = 4, ModelId = 29, SeriesId = 129, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 103, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 150, BrandId = 4, ModelId = 11, SeriesId = 81, EngineTypeId = 115, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 81, FiscalHP = 9, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 151, BrandId = 1, ModelId = 19, SeriesId = 2, EngineTypeId = 11, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 150, FiscalHP = 11, AverageFuel = null, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 152, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 6, EngineCapacity = 1200, EnginePower = 70, FiscalHP = 80, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 05, 2, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 153, BrandId = 1, ModelId = 5, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 5, EngineCapacity = 789, EnginePower = 7894, FiscalHP = 7894, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 154, BrandId = 7, ModelId = 23, SeriesId = 39, EngineTypeId = 117, DoorTypeId = 2, EngineCapacity = 0, EnginePower = 25, FiscalHP = 25, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 30, 0, 0, 0), FuelTypeId = 3 },
                new Vehicle { Id = 155, BrandId = 7, ModelId = 18, SeriesId = 39, EngineTypeId = 34, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, EndDateDelivery = null, FuelTypeId = 10 },
                new Vehicle { Id = 156, BrandId = 7, ModelId = 23, SeriesId = 9, EngineTypeId = 34, DoorTypeId = 4, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, EndDateDelivery = null, FuelTypeId = 9 },
                new Vehicle { Id = 157, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 2, EngineCapacity = 789, EnginePower = 789, FiscalHP = 789, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 158, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 5, EngineCapacity = 789, EnginePower = 789, FiscalHP = 789, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 159, BrandId = 12, ModelId = 33, SeriesId = 27, EngineTypeId = 36, DoorTypeId = 2, EngineCapacity = 0, EnginePower = 100, FiscalHP = 100, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 15, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 160, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 120, FiscalHP = 50, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 15, 0, 0, 0), FuelTypeId = 9 },
                new Vehicle { Id = 161, BrandId = 7, ModelId = 22, SeriesId = 9, EngineTypeId = 9, DoorTypeId = 4, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, EndDateDelivery = null, FuelTypeId = 3 },
                new Vehicle { Id = 162, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, EndDateDelivery = null, FuelTypeId = 10 }
            );


            #endregion

            #region FuelCards

            builder.Entity<FuelCard>().HasData(
                new FuelCard { Id = 1, Number = "188395479", CompanyId = 16, StartDate = new DateTime(2008, 11, 6, 11, 0, 0, 0), EndDate = new DateTime(2008, 12, 20, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2009, 3, 25, 0, 0, 0), BlockingReason = "kaart niet meer geldig", PinCode = "1011" },
                new FuelCard { Id = 2, Number = "0008 Tankkaartje 555", CompanyId = 4, StartDate = new DateTime(2007, 12, 12, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "****888" },
                new FuelCard { Id = 3, Number = "0005 AANLOOP 4", CompanyId = 6, StartDate = new DateTime(2007, 9, 14, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2020, 6, 3, 0, 0, 0), BlockingReason = "", PinCode = "****" },
                new FuelCard { Id = 4, Number = "0004 AANLOOP 3", CompanyId = 4, StartDate = new DateTime(2007, 8, 13, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 3, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "7293" },
                new FuelCard { Id = 5, Number = "0010 AANLOOP 88", CompanyId = 4, StartDate = new DateTime(2008, 1, 17, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2020, 4, 3, 0, 0, 0), BlockingReason = "", PinCode = "****" },
                new FuelCard { Id = 6, Number = "0009 AANLOOP 7", CompanyId = 4, StartDate = new DateTime(2009, 4, 1, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = false, BlockingDate = new DateTime(2020, 3, 3, 0, 0, 0), BlockingReason = "", PinCode = "14589" },
                new FuelCard { Id = 7, Number = "0002 AANLOOP 1", CompanyId = 4, StartDate = new DateTime(2007, 5, 22, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "2937" },
                new FuelCard { Id = 8, Number = "0003 AANLOOP 2", CompanyId = 4, StartDate = new DateTime(2007, 8, 1, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "3177" },
                new FuelCard { Id = 9, Number = "0001 LUVA", CompanyId = 4, StartDate = new DateTime(2007, 5, 22, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "7846" },
                new FuelCard { Id = 10, Number = "0006 SALES", CompanyId = 23, StartDate = new DateTime(2007, 9, 19, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 11, Number = "0007 AANLOOP 5", CompanyId = 4, StartDate = new DateTime(2007, 10, 31, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 12, Number = "0011 AANLOOP 9", CompanyId = 4, StartDate = new DateTime(2008, 2, 7, 0, 0, 0), EndDate = new DateTime(2010, 5, 18, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18, 0, 0, 0), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 13, Number = "0012 AANLOOP 10", CompanyId = 4, StartDate = new DateTime(2008, 9, 12, 0, 0, 0), EndDate = new DateTime(2011, 11, 9, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2009, 4, 21, 0, 0, 0), BlockingReason = "verloren", PinCode = "604" },
                new FuelCard { Id = 14, Number = "0009", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "7008" },
                new FuelCard { Id = 15, Number = "0002", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "2938" },
                new FuelCard { Id = 16, Number = "0003", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = new DateTime(2018, 8, 17, 0, 0, 0), IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "3177" },
                new FuelCard { Id = 17, Number = "0004", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = new DateTime(2019, 2, 1, 0, 0, 0), IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "7293" },
                new FuelCard { Id = 18, Number = "0005", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = true, BlockingDate = new DateTime(2017, 8, 23, 0, 0, 0), BlockingReason = "test", PinCode = "321" },
                new FuelCard { Id = 19, Number = "0006", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "4606" },
                new FuelCard { Id = 20, Number = "0007", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "6491" },
                new FuelCard { Id = 21, Number = "0008", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "401" },
                new FuelCard { Id = 22, Number = "0010", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "7861" },
                new FuelCard { Id = 23, Number = "0011", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = true, BlockingDate = new DateTime(2017, 8, 23, 0, 0, 0), BlockingReason = "ok", PinCode = "9714" },
                new FuelCard { Id = 24, Number = "0139", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "9183" },
                new FuelCard { Id = 25, Number = "0014", CompanyId = 4, StartDate = new DateTime(2010, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "6325" },
                new FuelCard { Id = 26, Number = "0019", CompanyId = 4, StartDate = new DateTime(2012, 8, 13, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "3030" },
                new FuelCard { Id = 27, Number = "0020", CompanyId = 4, StartDate = new DateTime(2012, 8, 20, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "3315" },
                new FuelCard { Id = 28, Number = "0100", CompanyId = 4, StartDate = new DateTime(2013, 12, 9, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "7491" },
                new FuelCard { Id = 29, Number = "0021", CompanyId = 4, StartDate = new DateTime(2013, 9, 12, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "9363" },
                new FuelCard { Id = 30, Number = "0017", CompanyId = 4, StartDate = new DateTime(2012, 2, 24, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "1312" },
                new FuelCard { Id = 31, Number = "0129", CompanyId = 4, StartDate = new DateTime(2012, 2, 24, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "2765" },
                new FuelCard { Id = 32, Number = "0016", CompanyId = 4, StartDate = new DateTime(2011, 5, 19, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "535" },
                new FuelCard { Id = 33, Number = "0023", CompanyId = 4, StartDate = new DateTime(2016, 1, 1, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "****" },
                new FuelCard { Id = 34, Number = "0001", CompanyId = 15, StartDate = new DateTime(2017, 4, 25, 0, 0, 0), EndDate = new DateTime(2020, 5, 4, 0, 0, 0), IsBlocked = true, BlockingDate = new DateTime(2020, 4, 20, 0, 0, 0), BlockingReason = "Vervangen door nieuwe tankkaart", PinCode = "123456" },
                new FuelCard { Id = 35, Number = "1234", CompanyId = 4, StartDate = new DateTime(2014, 4, 26, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = "", PinCode = "1234" },
                new FuelCard { Id = 36, Number = "Test", CompanyId = 24, StartDate = new DateTime(2020, 4, 3, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "12345678" },
                new FuelCard { Id = 37, Number = "008", CompanyId = 19, StartDate = new DateTime(2020, 3, 25, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "88" },
                new FuelCard { Id = 38, Number = "Test Nummer", CompanyId = 19, StartDate = new DateTime(2020, 1, 3, 0, 0, 0), EndDate = null, IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "1234" },
                new FuelCard { Id = 39, Number = "123456789", CompanyId = 19, StartDate = new DateTime(2020, 3, 14, 0, 0, 0), EndDate = new DateTime(2022, 3, 7, 0, 0, 0), IsBlocked = false, BlockingDate = null, BlockingReason = null, PinCode = "8896" }
            );
            #endregion

            #region

            builder.Entity<CostAllocation>().HasData(
                new CostAllocation { Id = 1, Name = "Gent", Abbreviation = "VL", StartDate = new DateTime(), EndDate = new DateTime() },
                new CostAllocation { Id = 2, Name = "Hasselt", Abbreviation = "Lim", StartDate = new DateTime(), EndDate = new DateTime() },
                new CostAllocation { Id = 3, Name = "Brussel", Abbreviation = "Bxl", StartDate = new DateTime(), EndDate = new DateTime() },
                new CostAllocation { Id = 4, Name = "Antwerpen", Abbreviation = "HQ", StartDate = new DateTime(), EndDate = new DateTime() }
                );


            #endregion

            #region Records

            builder.Entity<Record>().HasData(
                new Record { Id = 1, CorporationId = 2, CostAllocationId = 4, FuelCardId =1, StartDate = null, EndDate = null, Term = Term.Long, Usage = Usage.Pool },
                new Record { Id = 2, CorporationId = 3, CostAllocationId = 4, FuelCardId =4, StartDate = null, EndDate = null, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 3, CorporationId = null, CostAllocationId = null, FuelCardId =5, StartDate = null, EndDate = null, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 4, CorporationId = 3, CostAllocationId = 2, FuelCardId =6, StartDate = null, EndDate = null, Term = Term.Short, Usage = Usage.RunIn },
                new Record { Id = 5, CorporationId = 1, CostAllocationId = 2, FuelCardId =8, StartDate = null, EndDate = null, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 6, CorporationId = 3, CostAllocationId = 2, FuelCardId =9, StartDate = new DateTime(2020, 1, 20), EndDate = new DateTime(2023, 1, 20), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 7, CorporationId = null, CostAllocationId = 2, FuelCardId =11, StartDate = new DateTime(2013, 7, 24), EndDate = new DateTime(2021, 7, 23), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 8, CorporationId = null, CostAllocationId = 4, FuelCardId =3, StartDate = null, EndDate = new DateTime(2015, 12, 26), Term = Term.Short, Usage = Usage.RunIn },
                new Record { Id = 9, CorporationId = null, CostAllocationId = 4, FuelCardId =7, StartDate = new DateTime(2014, 11, 28), EndDate = new DateTime(2018, 11, 27), Term = Term.Long, Usage = 0 },
                new Record { Id = 10, CorporationId = null, CostAllocationId = 2, FuelCardId =2, StartDate = new DateTime(2014, 7, 15), EndDate = new DateTime(2022, 7, 14), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 11, CorporationId = null, CostAllocationId = 4, FuelCardId =12, StartDate = new DateTime(2014, 7, 2), EndDate = new DateTime(2018, 7, 1), Term = Term.Long, Usage = 0 },
                new Record { Id = 12, CorporationId = null, CostAllocationId = 4, FuelCardId =19, StartDate = new DateTime(2014, 4, 9), EndDate = new DateTime(2018, 4, 8), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 13, CorporationId = null, CostAllocationId = 3, FuelCardId =17, StartDate = new DateTime(2014, 3, 5), EndDate = new DateTime(2021, 3, 4), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 14, CorporationId = 3, CostAllocationId = 4, FuelCardId =18, StartDate = new DateTime(2014, 3, 5), EndDate = new DateTime(2018, 3, 4), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 15, CorporationId = null, CostAllocationId = 1, FuelCardId =16, StartDate = new DateTime(2013, 7, 24), EndDate = new DateTime(2017, 7, 23), Term = Term.Long, Usage = Usage.Replacement },
                new Record { Id = 16, CorporationId = null, CostAllocationId = 4, FuelCardId =15, StartDate = new DateTime(2013, 5, 7), EndDate = new DateTime(2020, 5, 6), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 17, CorporationId = null, CostAllocationId = 4, FuelCardId =14, StartDate = new DateTime(2013, 3, 4), EndDate = new DateTime(2017, 3, 3), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 18, CorporationId = null, CostAllocationId = 4, FuelCardId =13, StartDate = new DateTime(2013, 2, 8), EndDate = new DateTime(2017, 2, 7), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 19, CorporationId = null, CostAllocationId = 2, FuelCardId =20, StartDate = new DateTime(2013, 1, 18), EndDate = new DateTime(2017, 1, 17), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 20, CorporationId = null, CostAllocationId = 4, FuelCardId =21, StartDate = new DateTime(2012, 11, 28), EndDate = new DateTime(2016, 11, 27), Term = Term.Long, Usage = 0 },
                new Record { Id = 21, CorporationId = null, CostAllocationId = 4, FuelCardId =22, StartDate = new DateTime(2012, 6, 28), EndDate = new DateTime(2016, 6, 27), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 22, CorporationId = null, CostAllocationId = 4, FuelCardId =23, StartDate = new DateTime(2012, 3, 19), EndDate = new DateTime(2016, 3, 18), Term = Term.Long, Usage = 0 },
                new Record { Id = 23, CorporationId = 1, CostAllocationId = 4, FuelCardId =24, StartDate = new DateTime(2012, 4, 1), EndDate = new DateTime(2017, 4, 1), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 24, CorporationId = null, CostAllocationId = 3, FuelCardId =25, StartDate = new DateTime(2012, 2, 21), EndDate = new DateTime(2016, 2, 20), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 25, CorporationId = null, CostAllocationId = 2, FuelCardId =26, StartDate = new DateTime(2012, 1, 15), EndDate = new DateTime(2017, 1, 14), Term = Term.Privé, Usage = Usage.Definitive },
                new Record { Id = 26, CorporationId = null, CostAllocationId = 3, FuelCardId =27, StartDate = new DateTime(2012, 1, 19), EndDate = new DateTime(2017, 1, 18), Term = Term.Privé, Usage = Usage.Definitive },
                new Record { Id = 27, CorporationId = null, CostAllocationId = 4, FuelCardId =28, StartDate = new DateTime(2012, 10, 27), EndDate = new DateTime(2015, 10, 27), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 28, CorporationId = null, CostAllocationId = 1, FuelCardId =29, StartDate = null, EndDate = null, Term = Term.Privé, Usage = Usage.Definitive }

                );


            #endregion

            #endregion

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