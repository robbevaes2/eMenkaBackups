using System;
using System.Linq;
using eMenka.Domain;
using eMenka.Domain.Classes;
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
        public DbSet<ExteriorColor> ExteriorColors { get; set; }
        public DbSet<InteriorColor> InteriorColors { get; set; }

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
                .WithOne(v => v.Model)
                .HasForeignKey(v => v.ModelId);

            //1 doortype -> x vehicles
            builder.Entity<DoorType>()
                .HasMany(d => d.Vehicles)
                .WithOne(v => v.DoorType)
                .HasForeignKey(v => v.DoorTypeId);

            //1 motortype -> x vehicles
            builder.Entity<MotorType>()
                .HasMany(m => m.Vehicles)
                .WithOne(v => v.MotorType)
                .HasForeignKey(v => v.MotorTypeId);

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
            /*
            #region seeding data

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

            builder.Entity<MotorType>().HasData(
                new MotorType { BrandId = 1, Name = "1.9" },
                new MotorType { BrandId = 1, Name = "2" },
                new MotorType { BrandId = 3, Name = "1.9 TDI" },
                new MotorType { BrandId = 4, Name = "1.8 ECOTEC" },
                new MotorType { BrandId = 4, Name = "1.9 CDTI" },
                new MotorType { BrandId = 4, Name = "1.6 CNG" },
                new MotorType { BrandId = 4, Name = "1.6 CNG ECOTEC" },
                new MotorType { BrandId = 4, Name = "1.7 CDTI" },
                new MotorType { BrandId = 7, Name = "1.6 HDi" },
                new MotorType { BrandId = 8, Name = "1.9 Tdi" },
                new MotorType { BrandId = 1, Name = "30d" },
                new MotorType { BrandId = 1, Name = "35d" },
                new MotorType { BrandId = 1, Name = "20d" },
                new MotorType { BrandId = 6, Name = "1,6" },
                new MotorType { BrandId = 4, Name = "1.3 CDTi 16v" },
                new MotorType { BrandId = 4, Name = "3.0 CDTI" },
                new MotorType { BrandId = 11, Name = "1.6 D" },
                new MotorType { BrandId = 11, Name = "2.0 D" },
                new MotorType { BrandId = 11, Name = "2.4 D" },
                new MotorType { BrandId = 4, Name = "2.0 DPF CDTi" },
                new MotorType { BrandId = 12, Name = "1.6 HDi 92" },
                new MotorType { BrandId = 12, Name = "1.6 HDi 110" },
                new MotorType { BrandId = 12, Name = "2.0 HDi 138" },
                new MotorType { BrandId = 3, Name = "1.6" },
                new MotorType { BrandId = 5, Name = "3456" },
                new MotorType { BrandId = 15, Name = "1,5" },
                new MotorType { BrandId = 6, Name = "1.5" },
                new MotorType { BrandId = 15, Name = "1.4 Crdi" },
                new MotorType { BrandId = 15, Name = "1.7 CRDi" },
                new MotorType { BrandId = 15, Name = "1.6 GDi" },
                new MotorType { BrandId = 15, Name = "2.0 CRDi" },
                new MotorType { BrandId = 7, Name = "2" },
                new MotorType { BrandId = 8, Name = "2.0 Tdi" },
                new MotorType { BrandId = 12, Name = "2.2 ESS" },
                new MotorType { BrandId = 4, Name = "1.7 CDTI ECOTEC" },
                new MotorType { BrandId = 4, Name = "2.0 CDTI ecoflex S/S DPF" },
                new MotorType { BrandId = 4, Name = "1.7 CDTI ecoflex S/S DPF" },
                new MotorType { BrandId = 6, Name = "16D" },
                new MotorType { BrandId = 9, Name = "200 CDI" },
                new MotorType { BrandId = 9, Name = "220 CDI" },
                new MotorType { BrandId = 9, Name = "180 CDI" },
                new MotorType { BrandId = 13, Name = "1500" },
                new MotorType { BrandId = 9, Name = "160 CDI" },
                new MotorType { BrandId = 13, Name = "1600" },
                new MotorType { BrandId = 17, Name = "1.9 JTDm" },
                new MotorType { BrandId = 17, Name = "1.9 JTD" },
                new MotorType { BrandId = 17, Name = "2,0 JTDM 163PK" },
                new MotorType { BrandId = 8, Name = "1.6 TDI" },
                new MotorType { BrandId = 8, Name = "1.6 Tiptronic" },
                new MotorType { BrandId = 8, Name = "2.0 TDi DPF" },
                new MotorType { BrandId = 8, Name = "2.0 TDI e" },
                new MotorType { BrandId = 8, Name = "1.8 T" },
                new MotorType { BrandId = 8, Name = "2.7 TDI" },
                new MotorType { BrandId = 8, Name = "2.0 TDi Multitronic" },
                new MotorType { BrandId = 8, Name = "2.8 V6 Multitronic" },
                new MotorType { BrandId = 8, Name = "3.0 TDI" },
                new MotorType { BrandId = 1, Name = "16d" },
                new MotorType { BrandId = 1, Name = "1,6" },
                new MotorType { BrandId = 1, Name = "18d" },
                new MotorType { BrandId = 1, Name = "25d" },
                new MotorType { BrandId = 12, Name = "2.0 HDi" },
                new MotorType { BrandId = 12, Name = "2.0 HDi 136" },
                new MotorType { BrandId = 12, Name = "2.2 HDI" },
                new MotorType { BrandId = 12, Name = "2.2 HDI 74" },
                new MotorType { BrandId = 2, Name = "2.0 TDCi AUT" },
                new MotorType { BrandId = 2, Name = "1.6 TDCi Turbo" },
                new MotorType { BrandId = 2, Name = "1.6 TDCI ECOnetic" },
                new MotorType { BrandId = 2, Name = "2.0 TDCi Turbo" },
                new MotorType { BrandId = 2, Name = "2.2 TDCi Turbo" },
                new MotorType { BrandId = 2, Name = "1.8 TDCi" },
                new MotorType { BrandId = 2, Name = "1.8 TDCi Turbo" },
                new MotorType { BrandId = 2, Name = "2.0 Monovol 6v" },
                new MotorType { BrandId = 16, Name = "1.5 dCi" },
                new MotorType { BrandId = 18, Name = "300cc" },
                new MotorType { BrandId = 19, Name = "Hybrid 2.0" },
                new MotorType { BrandId = 8, Name = "PowerPlus" },
                new MotorType { BrandId = 9, Name = "B 180 CDI" },
                new MotorType { BrandId = 9, Name = "B 200 CDI" },
                new MotorType { BrandId = 9, Name = "C 200 CDI" },
                new MotorType { BrandId = 9, Name = "C 220 CDI" },
                new MotorType { BrandId = 9, Name = "C 180 CDI" },
                new MotorType { BrandId = 9, Name = "C 200" },
                new MotorType { BrandId = 9, Name = "E 350 CDI" },
                new MotorType { BrandId = 9, Name = "E 200 CDI" },
                new MotorType { BrandId = 9, Name = "GLK 220 CDI 4matic" },
                new MotorType { BrandId = 9, Name = "ML 300 CDI" },
                new MotorType { BrandId = 9, Name = "ML 300 CDI Blue Efficiency" },
                new MotorType { BrandId = 9, Name = "350 CDI Bluetec" },
                new MotorType { BrandId = 9, Name = "S 320 CDI" },
                new MotorType { BrandId = 16, Name = "1.5dCi" },
                new MotorType { BrandId = 4, Name = "2.0 CDTI" },
                new MotorType { BrandId = 4, Name = "1.7 CDTI DPF" },
                new MotorType { BrandId = 4, Name = "1.7 CDTi ecoFLEX" },
                new MotorType { BrandId = 7, Name = "2.0 HDi" },
                new MotorType { BrandId = 6, Name = "2.0 dCi" },
                new MotorType { BrandId = 6, Name = "1.5 dCi" },
                new MotorType { BrandId = 6, Name = "1.9 dCi FAP" },
                new MotorType { BrandId = 20, Name = "1.9 TiD" },
                new MotorType { BrandId = 21, Name = "1.6 TD" },
                new MotorType { BrandId = 21, Name = "2.0 TD" },
                new MotorType { BrandId = 10, Name = "0.8 CDI" },
                new MotorType { BrandId = 14, Name = "2.0 D" },
                new MotorType { BrandId = 14, Name = "1.8" },
                new MotorType { BrandId = 14, Name = "1.4 D4D" },
                new MotorType { BrandId = 3, Name = "1.6 TDi" },
                new MotorType { BrandId = 3, Name = "2.0 TDi" },
                new MotorType { BrandId = 3, Name = "1.9 TDI BlueMotion" },
                new MotorType { BrandId = 3, Name = "1.6 CR TDI" },
                new MotorType { BrandId = 3, Name = "2.0 CR Tdi bluemotion" },
                new MotorType { BrandId = 3, Name = "2.0 CR TDi" },
                new MotorType { BrandId = 3, Name = "2.0 TDI BlueMotion" },
                new MotorType { BrandId = 11, Name = "2.4 D5 GEARTRONIC" },
                new MotorType { BrandId = 4, Name = "1.6 CDTi ecoFLEX" },
                new MotorType { BrandId = 17, Name = "2.4 JTDm" },
                new MotorType { BrandId = 7, Name = "1.4 HDi" },
                new MotorType { BrandId = 26, Name = "whosh" },
                new MotorType { BrandId = 2, Name = "blablu" },
                new MotorType { BrandId = 27, Name = "azerty" },
                new MotorType { BrandId = 29, Name = "blob" },
                new MotorType { BrandId = 29, Name = "blasterx" }
            );

            builder.Entity<DoorType>().HasData(
                new DoorType { Name = "Break" },
                new DoorType { Name = "5-Deurs" },
                new DoorType { Name = "4-Deurs" },
                new DoorType { Name = "3-Deurs" },
                new DoorType { Name = "Monovolume" },
                new DoorType { Name = "2-Deurs" },
                new DoorType { Name = "Coupé" },
                new DoorType { Name = "Moto" },
                new DoorType { Name = "Cabrio" }
            );

            builder.Entity<FuelType>().HasData(
                new FuelType { Name = "Diesel", Code = "DSL" },
                new FuelType { Name = "Liquefied Petroleum Gas", Code = "LPG" },
                new FuelType { Name = "Compressed Natural Gas", Code = "CNG" },
                new FuelType { Name = "Liquefied Natural Gas", Code = "LNG" },
                new FuelType { Name = "Methanol", Code = "M85" },
                new FuelType { Name = "Ethanol", Code = "E85" },
                new FuelType { Name = "Biodiesel", Code = "B20" },
                new FuelType { Name = "Diesel International", Code = "DSL INT" },
                new FuelType { Name = "Multifuel", Code = "MULTI" },
                new FuelType { Name = "Diesel", Code = "DSL" }
            );

            builder.Entity<Serie>().HasData(
                new Serie { BrandId = 1, Name = "Touring" },
                new Serie { BrandId = 1, Name = "Berline" },
                new Serie { BrandId = 3, Name = "Rabbit" },
                new Serie { BrandId = 4, Name = "Enjoy" },
                new Serie { BrandId = 4, Name = "Cosmo" },
                new Serie { BrandId = 4, Name = "Essentia" },
                new Serie { BrandId = 4, Name = "OPC" },
                new Serie { BrandId = 7, Name = "SW" },
                new Serie { BrandId = 7, Name = "Coupé" },
                new Serie { BrandId = 7, Name = "Berline" },
                new Serie { BrandId = 8, Name = "Berline" },
                new Serie { BrandId = 6, Name = "dd" },
                new Serie { BrandId = 6, Name = "DCI" },
                new Serie { BrandId = 1, Name = "Coupé" },
                new Serie { BrandId = 1, Name = "Cabrio" },
                new Serie { BrandId = 1, Name = "Hatch" },
                new Serie { BrandId = 1, Name = "xDrive" },
                new Serie { BrandId = 7, Name = "Urban" },
                new Serie { BrandId = 8, Name = "Avant" },
                new Serie { BrandId = 18, Name = "rerezrtrz" },
                new Serie { BrandId = 1, Name = "test" },
                new Serie { BrandId = 11, Name = "Basis" },
                new Serie { BrandId = 11, Name = "Summum" },
                new Serie { BrandId = 4, Name = "Edition" },
                new Serie { BrandId = 8, Name = "Sportback" },
                new Serie { BrandId = 12, Name = "Coupé" },
                new Serie { BrandId = 12, Name = "Picasso" },
                new Serie { BrandId = 12, Name = "Tourer" },
                new Serie { BrandId = 12, Name = "Pluriel" },
                new Serie { BrandId = 5, Name = "tt" },
                new Serie { BrandId = 15, Name = "Hatchback" },
                new Serie { BrandId = 12, Name = "Exclusive" },
                new Serie { BrandId = 15, Name = "Trocadéro" },
                new Serie { BrandId = 15, Name = "Base" },
                new Serie { BrandId = 15, Name = "Facility Pack" },
                new Serie { BrandId = 8, Name = "SUV" },
                new Serie { BrandId = 4, Name = "Sport" },
                new Serie { BrandId = 16, Name = "Acenta" },
                new Serie { BrandId = 7, Name = "Acces" },
                new Serie { BrandId = 9, Name = "Avantgarde" },
                new Serie { BrandId = 9, Name = "Classic" },
                new Serie { BrandId = 13, Name = "Break" },
                new Serie { BrandId = 13, Name = "cabrio" },
                new Serie { BrandId = 17, Name = "Eco" },
                new Serie { BrandId = 17, Name = "Progression" },
                new Serie { BrandId = 17, Name = "Progression Corp. Leder" },
                new Serie { BrandId = 17, Name = "Distinctive" },
                new Serie { BrandId = 8, Name = "Ambiente" },
                new Serie { BrandId = 8, Name = "Attraction" },
                new Serie { BrandId = 8, Name = "Sport Back Ambition" },
                new Serie { BrandId = 8, Name = "Sportback Ambiente" },
                new Serie { BrandId = 8, Name = "Sportback Attraction" },
                new Serie { BrandId = 8, Name = "Allroad Quattro" },
                new Serie { BrandId = 8, Name = "S line" },
                new Serie { BrandId = 8, Name = "Start/Stop DPF" },
                new Serie { BrandId = 8, Name = "DPF" },
                new Serie { BrandId = 8, Name = "Quattro" },
                new Serie { BrandId = 1, Name = "sDrive18d" },
                new Serie { BrandId = 1, Name = "sDrive20d" },
                new Serie { BrandId = 12, Name = "Grand Picasso" },
                new Serie { BrandId = 12, Name = "Grand Picasso Bus+" },
                new Serie { BrandId = 12, Name = "Grand Picasso Business" },
                new Serie { BrandId = 12, Name = "Picasso Bus+" },
                new Serie { BrandId = 12, Name = "Picasso Business" },
                new Serie { BrandId = 12, Name = "Picasso Business GPS" },
                new Serie { BrandId = 12, Name = "Picasso Exclusive" },
                new Serie { BrandId = 12, Name = "Business" },
                new Serie { BrandId = 12, Name = "Van" },
                new Serie { BrandId = 2, Name = "Ghia DPF" },
                new Serie { BrandId = 2, Name = "Titanium DPF" },
                new Serie { BrandId = 2, Name = "Trend" },
                new Serie { BrandId = 2, Name = "Ghia" },
                new Serie { BrandId = 2, Name = "Trend DPF" },
                new Serie { BrandId = 2, Name = "Titanium" },
                new Serie { BrandId = 2, Name = "Econetic" },
                new Serie { BrandId = 18, Name = "ST300" },
                new Serie { BrandId = 19, Name = "Business" },
                new Serie { BrandId = 9, Name = "Blue Efficience" },
                new Serie { BrandId = 9, Name = "Elegance" },
                new Serie { BrandId = 9, Name = "L Avantgarde" },
                new Serie { BrandId = 4, Name = "Cosmo Sports Tourer" },
                new Serie { BrandId = 4, Name = "Edition Sports Tourer" },
                new Serie { BrandId = 7, Name = "Premium Coach" },
                new Serie { BrandId = 7, Name = "Premium Pack FAP" },
                new Serie { BrandId = 7, Name = "SW Premium Break" },
                new Serie { BrandId = 7, Name = "Executive AUT." },
                new Serie { BrandId = 7, Name = "Premium" },
                new Serie { BrandId = 7, Name = "SW Executive" },
                new Serie { BrandId = 7, Name = "Premium Pack" },
                new Serie { BrandId = 7, Name = "ST Confort" },
                new Serie { BrandId = 6, Name = "Latitude FAP" },
                new Serie { BrandId = 6, Name = "Alyum FAP" },
                new Serie { BrandId = 6, Name = "Dynamique" },
                new Serie { BrandId = 6, Name = "Latitude" },
                new Serie { BrandId = 6, Name = "Authentique" },
                new Serie { BrandId = 6, Name = "FAP" },
                new Serie { BrandId = 6, Name = "Family FAP" },
                new Serie { BrandId = 20, Name = "Business" },
                new Serie { BrandId = 20, Name = "Linear Advantage" },
                new Serie { BrandId = 20, Name = "Vector" },
                new Serie { BrandId = 21, Name = "Elegance" },
                new Serie { BrandId = 22, Name = "Fun" },
                new Serie { BrandId = 14, Name = "DPF" },
                new Serie { BrandId = 14, Name = "Luna DPF" },
                new Serie { BrandId = 14, Name = "1.8 Hybrid" },
                new Serie { BrandId = 14, Name = "Linea Terra" },
                new Serie { BrandId = 3, Name = "Van" },
                new Serie { BrandId = 3, Name = "B2B-line" },
                new Serie { BrandId = 3, Name = "Trend" },
                new Serie { BrandId = 3, Name = "United DSG DPF" },
                new Serie { BrandId = 3, Name = "United DPF" },
                new Serie { BrandId = 3, Name = "Comfort" },
                new Serie { BrandId = 3, Name = "Comfortline" },
                new Serie { BrandId = 3, Name = "Conceptline DPF" },
                new Serie { BrandId = 3, Name = "Highline" },
                new Serie { BrandId = 3, Name = "BMT" },
                new Serie { BrandId = 3, Name = "Edition" },
                new Serie { BrandId = 3, Name = "Upgrade" },
                new Serie { BrandId = 3, Name = "Trendline" },
                new Serie { BrandId = 11, Name = "Kinetic" },
                new Serie { BrandId = 11, Name = "DRIVe Start/Stop" },
                new Serie { BrandId = 11, Name = "DRIVe Kinetic" },
                new Serie { BrandId = 11, Name = "D4 Kinetic St/St" },
                new Serie { BrandId = 11, Name = "DRIVe" },
                new Serie { BrandId = 11, Name = "D3 Kinetic St/St" },
                new Serie { BrandId = 11, Name = "DRIVe Start/Stop Kinetic" },
                new Serie { BrandId = 11, Name = "Momentum" },
                new Serie { BrandId = 4, Name = "Enjoy Active" },
                new Serie { BrandId = 4, Name = "Business" },
                new Serie { BrandId = 26, Name = "speedy" },
                new Serie { BrandId = 27, Name = "azerty" },
                new Serie { BrandId = 29, Name = "blablu" },
                new Serie { BrandId = 29, Name = "ssss" }
            );
            #endregion
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