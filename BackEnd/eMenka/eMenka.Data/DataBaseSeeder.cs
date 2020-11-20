﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace eMenka.Data
{
    public class DataBaseSeeder
    {
        public static void SeedData(ModelBuilder builder)
        {

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
            builder.Entity<Series>().HasData(
                new Series { Id = 1, BrandId = 1, Name = "Touring" },
                new Series { Id = 2, BrandId = 1, Name = "Berline" },
                new Series { Id = 3, BrandId = 3, Name = "Rabbit" },
                new Series { Id = 4, BrandId = 4, Name = "Enjoy" },
                new Series { Id = 5, BrandId = 4, Name = "Cosmo" },
                new Series { Id = 6, BrandId = 4, Name = "Essentia" },
                new Series { Id = 7, BrandId = 4, Name = "OPC" },
                new Series { Id = 8, BrandId = 7, Name = "SW" },
                new Series { Id = 9, BrandId = 7, Name = "Coupé" },
                new Series { Id = 10, BrandId = 7, Name = "Berline" },
                new Series { Id = 11, BrandId = 8, Name = "Berline" },
                new Series { Id = 12, BrandId = 6, Name = "dd" },
                new Series { Id = 13, BrandId = 6, Name = "DCI" },
                new Series { Id = 14, BrandId = 1, Name = "Coupé" },
                new Series { Id = 15, BrandId = 1, Name = "Cabrio" },
                new Series { Id = 16, BrandId = 1, Name = "Hatch" },
                new Series { Id = 17, BrandId = 1, Name = "xDrive" },
                new Series { Id = 18, BrandId = 7, Name = "Urban" },
                new Series { Id = 19, BrandId = 8, Name = "Avant" },
                new Series { Id = 20, BrandId = 18, Name = "rerezrtrz" },
                new Series { Id = 21, BrandId = 1, Name = "test" },
                new Series { Id = 22, BrandId = 11, Name = "Basis" },
                new Series { Id = 23, BrandId = 11, Name = "Summum" },
                new Series { Id = 24, BrandId = 4, Name = "Edition" },
                new Series { Id = 25, BrandId = 8, Name = "Sportback" },
                new Series { Id = 26, BrandId = 12, Name = "Coupé" },
                new Series { Id = 27, BrandId = 12, Name = "Picasso" },
                new Series { Id = 28, BrandId = 12, Name = "Tourer" },
                new Series { Id = 29, BrandId = 12, Name = "Pluriel" },
                new Series { Id = 30, BrandId = 5, Name = "tt" },
                new Series { Id = 31, BrandId = 15, Name = "Hatchback" },
                new Series { Id = 32, BrandId = 12, Name = "Exclusive" },
                new Series { Id = 33, BrandId = 15, Name = "Trocadéro" },
                new Series { Id = 34, BrandId = 15, Name = "Base" },
                new Series { Id = 35, BrandId = 15, Name = "Facility Pack" },
                new Series { Id = 36, BrandId = 8, Name = "SUV" },
                new Series { Id = 37, BrandId = 4, Name = "Sport" },
                new Series { Id = 38, BrandId = 16, Name = "Acenta" },
                new Series { Id = 39, BrandId = 7, Name = "Acces" },
                new Series { Id = 40, BrandId = 9, Name = "Avantgarde" },
                new Series { Id = 41, BrandId = 9, Name = "Classic" },
                new Series { Id = 42, BrandId = 13, Name = "Break" },
                new Series { Id = 43, BrandId = 13, Name = "cabrio" },
                new Series { Id = 44, BrandId = 17, Name = "Eco" },
                new Series { Id = 45, BrandId = 17, Name = "Progression" },
                new Series { Id = 46, BrandId = 17, Name = "Progression Corp. Leder" },
                new Series { Id = 47, BrandId = 17, Name = "Distinctive" },
                new Series { Id = 48, BrandId = 8, Name = "Ambiente" },
                new Series { Id = 49, BrandId = 8, Name = "Attraction" },
                new Series { Id = 50, BrandId = 8, Name = "Sport Back Ambition" },
                new Series { Id = 51, BrandId = 8, Name = "Sportback Ambiente" },
                new Series { Id = 52, BrandId = 8, Name = "Sportback Attraction" },
                new Series { Id = 53, BrandId = 8, Name = "Allroad Quattro" },
                new Series { Id = 54, BrandId = 8, Name = "S line" },
                new Series { Id = 55, BrandId = 8, Name = "Start/Stop DPF" },
                new Series { Id = 56, BrandId = 8, Name = "DPF" },
                new Series { Id = 57, BrandId = 8, Name = "Quattro" },
                new Series { Id = 58, BrandId = 1, Name = "sDrive18d" },
                new Series { Id = 59, BrandId = 1, Name = "sDrive20d" },
                new Series { Id = 60, BrandId = 12, Name = "Grand Picasso" },
                new Series { Id = 61, BrandId = 12, Name = "Grand Picasso Bus+" },
                new Series { Id = 62, BrandId = 12, Name = "Grand Picasso Business" },
                new Series { Id = 63, BrandId = 12, Name = "Picasso Bus+" },
                new Series { Id = 64, BrandId = 12, Name = "Picasso Business" },
                new Series { Id = 65, BrandId = 12, Name = "Picasso Business GPS" },
                new Series { Id = 66, BrandId = 12, Name = "Picasso Exclusive" },
                new Series { Id = 67, BrandId = 12, Name = "Business" },
                new Series { Id = 68, BrandId = 12, Name = "Van" },
                new Series { Id = 69, BrandId = 2, Name = "Ghia DPF" },
                new Series { Id = 70, BrandId = 2, Name = "Titanium DPF" },
                new Series { Id = 71, BrandId = 2, Name = "Trend" },
                new Series { Id = 72, BrandId = 2, Name = "Ghia" },
                new Series { Id = 73, BrandId = 2, Name = "Trend DPF" },
                new Series { Id = 74, BrandId = 2, Name = "Titanium" },
                new Series { Id = 75, BrandId = 2, Name = "Econetic" },
                new Series { Id = 76, BrandId = 18, Name = "ST300" },
                new Series { Id = 77, BrandId = 19, Name = "Business" },
                new Series { Id = 78, BrandId = 9, Name = "Blue Efficience" },
                new Series { Id = 79, BrandId = 9, Name = "Elegance" },
                new Series { Id = 80, BrandId = 9, Name = "L Avantgarde" },
                new Series { Id = 81, BrandId = 4, Name = "Cosmo Sports Tourer" },
                new Series { Id = 82, BrandId = 4, Name = "Edition Sports Tourer" },
                new Series { Id = 83, BrandId = 7, Name = "Premium Coach" },
                new Series { Id = 84, BrandId = 7, Name = "Premium Pack FAP" },
                new Series { Id = 85, BrandId = 7, Name = "SW Premium Break" },
                new Series { Id = 86, BrandId = 7, Name = "Executive AUT." },
                new Series { Id = 87, BrandId = 7, Name = "Premium" },
                new Series { Id = 88, BrandId = 7, Name = "SW Executive" },
                new Series { Id = 89, BrandId = 7, Name = "Premium Pack" },
                new Series { Id = 90, BrandId = 7, Name = "ST Confort" },
                new Series { Id = 91, BrandId = 6, Name = "Latitude FAP" },
                new Series { Id = 92, BrandId = 6, Name = "Alyum FAP" },
                new Series { Id = 93, BrandId = 6, Name = "Dynamique" },
                new Series { Id = 94, BrandId = 6, Name = "Latitude" },
                new Series { Id = 95, BrandId = 6, Name = "Authentique" },
                new Series { Id = 96, BrandId = 6, Name = "FAP" },
                new Series { Id = 97, BrandId = 6, Name = "Family FAP" },
                new Series { Id = 98, BrandId = 20, Name = "Business" },
                new Series { Id = 99, BrandId = 20, Name = "Linear Advantage" },
                new Series { Id = 100, BrandId = 20, Name = "Vector" },
                new Series { Id = 101, BrandId = 21, Name = "Elegance" },
                new Series { Id = 102, BrandId = 22, Name = "Fun" },
                new Series { Id = 103, BrandId = 14, Name = "DPF" },
                new Series { Id = 104, BrandId = 14, Name = "Luna DPF" },
                new Series { Id = 105, BrandId = 14, Name = "1.8 Hybrid" },
                new Series { Id = 106, BrandId = 14, Name = "Linea Terra" },
                new Series { Id = 107, BrandId = 3, Name = "Van" },
                new Series { Id = 108, BrandId = 3, Name = "B2B-line" },
                new Series { Id = 109, BrandId = 3, Name = "Trend" },
                new Series { Id = 110, BrandId = 3, Name = "United DSG DPF" },
                new Series { Id = 111, BrandId = 3, Name = "United DPF" },
                new Series { Id = 112, BrandId = 3, Name = "Comfort" },
                new Series { Id = 113, BrandId = 3, Name = "Comfortline" },
                new Series { Id = 114, BrandId = 3, Name = "Conceptline DPF" },
                new Series { Id = 115, BrandId = 3, Name = "Highline" },
                new Series { Id = 116, BrandId = 3, Name = "BMT" },
                new Series { Id = 117, BrandId = 3, Name = "Edition" },
                new Series { Id = 118, BrandId = 3, Name = "Upgrade" },
                new Series { Id = 119, BrandId = 3, Name = "Trendline" },
                new Series { Id = 120, BrandId = 11, Name = "Kinetic" },
                new Series { Id = 121, BrandId = 11, Name = "DRIVe Start/Stop" },
                new Series { Id = 122, BrandId = 11, Name = "DRIVe Kinetic" },
                new Series { Id = 123, BrandId = 11, Name = "D4 Kinetic St/St" },
                new Series { Id = 124, BrandId = 11, Name = "DRIVe" },
                new Series { Id = 125, BrandId = 11, Name = "D3 Kinetic St/St" },
                new Series { Id = 126, BrandId = 11, Name = "DRIVe Start/Stop Kinetic" },
                new Series { Id = 127, BrandId = 11, Name = "Momentum" },
                new Series { Id = 128, BrandId = 4, Name = "Enjoy Active" },
                new Series { Id = 129, BrandId = 4, Name = "Business" },
                new Series { Id = 130, BrandId = 26, Name = "speedy" },
                new Series { Id = 131, BrandId = 27, Name = "azerty" },
                new Series { Id = 132, BrandId = 28, Name = "blablu" },
                new Series { Id = 133, BrandId = 28, Name = "ssss" }
            );
            #endregion

            #region ExteriorColors & InteriorColors
            builder.Entity<ExteriorColor>().HasData(
                new ExteriorColor { Id = 1, BrandId = 1, Name = "Saphirschwarz", Code = "" },
                new ExteriorColor { Id = 2, BrandId = 1, Name = "Titansilber" },
                new ExteriorColor { Id = 3, BrandId = 4, Name = "Technical Grey", Code = "GR" },
                new ExteriorColor { Id = 4, BrandId = 4, Name = "Black Sapphires", Code = "BLs" },
                new ExteriorColor { Id = 5, BrandId = 4, Name = "Olympic White", Code = "WH" },
                new ExteriorColor { Id = 6, BrandId = 4, Name = "Metro", Code = "MT" },
                new ExteriorColor { Id = 7, BrandId = 4, Name = "Ultra Blue", Code = "UB" },
                new ExteriorColor { Id = 8, BrandId = 8, Name = "Grijs", Code = "GR" },
                new ExteriorColor { Id = 9, BrandId = 6, Name = "Yellow", Code = "Y" },
                new ExteriorColor { Id = 10, BrandId = 12, Name = "Knalgeel" },
                new ExteriorColor { Id = 11, BrandId = 12, Name = "Groen", Code = "GRRR" },
                new ExteriorColor { Id = 12, BrandId = 4, Name = "Star Silver" },
                new ExteriorColor { Id = 13, BrandId = 4, Name = "Silver Lightning" },
                new ExteriorColor { Id = 14, BrandId = 5, Name = "Red", Code = "Fred" },
                new ExteriorColor { Id = 15, BrandId = 15, Name = "Grijs" },
                new ExteriorColor { Id = 16, BrandId = 1, Name = "Spacegrau", Code = "SG" },
                new ExteriorColor { Id = 17, BrandId = 8, Name = "Lavagrijs" },
                new ExteriorColor { Id = 18, BrandId = 4, Name = "Luxor", Code = "GU9" },
                new ExteriorColor { Id = 19, BrandId = 4, Name = "Carbon Flash Black" },
                new ExteriorColor { Id = 20, BrandId = 16, Name = "Zwart" },
                new ExteriorColor { Id = 21, BrandId = 7, Name = "Grijs" },
                new ExteriorColor { Id = 22, BrandId = 4, Name = "Asteroid Grey" },
                new ExteriorColor { Id = 23, BrandId = 4, Name = "Waterworld Blue" },
                new ExteriorColor { Id = 24, BrandId = 4, Name = "Deep Sky Blue", Code = "GJW" },
                new ExteriorColor { Id = 25, BrandId = 11, Name = "Savile Grey", Code = "492" },
                new ExteriorColor { Id = 26, BrandId = 4, Name = "Deep Espresso Brown", Code = "" },
                new ExteriorColor { Id = 27, BrandId = 8, Name = "Zwart" },
                new ExteriorColor { Id = 28, BrandId = 27, Name = "azerty", Code = "azerty" },
                new ExteriorColor { Id = 29, BrandId = 17, Name = "Test", Code = "ext" },
                new ExteriorColor { Id = 30, BrandId = 4, Name = "red", Code = "red" }
            );

            builder.Entity<InteriorColor>().HasData(
                new InteriorColor { Id = 1, BrandId = 6, Name = "Black", Code = "b" },
                new InteriorColor { Id = 2, BrandId = 1, Name = "Leder Dakota Schwarz" },
                new InteriorColor { Id = 3, BrandId = 4, Name = "Charcoal", Code = "CC" },
                new InteriorColor { Id = 4, BrandId = 4, Name = "Cable Anthraciet", Code = "CA" },
                new InteriorColor { Id = 5, BrandId = 7, Name = "Knalrood", Code = "KR" },
                new InteriorColor { Id = 6, BrandId = 4, Name = "Dune Black", Code = "DB" },
                new InteriorColor { Id = 7, BrandId = 12, Name = "Zwart leder" },
                new InteriorColor { Id = 8, BrandId = 1, Name = "Fluid Anthracit" },
                new InteriorColor { Id = 9, BrandId = 4, Name = "Anthraciet (Tabita/Elba)" },
                new InteriorColor { Id = 10, BrandId = 4, Name = "Cashmere beige/anthraciet" },
                new InteriorColor { Id = 11, BrandId = 4, Name = "Leder Sienna Anthraciet black" },
                new InteriorColor { Id = 12, BrandId = 4, Name = "groen", Code = "GR4" },
                new InteriorColor { Id = 13, BrandId = 7, Name = "Leder Beige" },
                new InteriorColor { Id = 14, BrandId = 8, Name = "Steppe Zwart Leder" },
                new InteriorColor { Id = 15, BrandId = 4, Name = "Lace/jet Black" },
                new InteriorColor { Id = 16, BrandId = 4, Name = "Dune Beige", Code = "TAAS" },
                new InteriorColor { Id = 17, BrandId = 4, Name = "Ribbon/Morrocana" },
                new InteriorColor { Id = 18, BrandId = 4, Name = "Mando/Atlantis cocoa" },
                new InteriorColor { Id = 19, BrandId = 4, Name = "Stof/leder morrocana" },
                new InteriorColor { Id = 20, BrandId = 4, Name = "Salta Jet black" },
                new InteriorColor { Id = 21, BrandId = 4, Name = "Lyra/Jet Black" },
                new InteriorColor { Id = 22, BrandId = 4, Name = "Ribbon/Jet Black" },
                new InteriorColor { Id = 23, BrandId = 11, Name = "Select Leder", Code = "G761" },
                new InteriorColor { Id = 24, BrandId = 4, Name = "Leder Jasmin Saddle Up" },
                new InteriorColor { Id = 25, BrandId = 16, Name = "Zwart" },
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
                new Company { Id = 1, Name = "Total Belgium", IsInternal = false, IsActive = false, AccountNumber = null },
                new Company { Id = 2, Name = "Esso", Description = "Esso", Reference = "Esso", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "123", AccountNumber = "123" },
                new Company { Id = 3, Name = "Shell", IsInternal = false, IsActive = false, AccountNumber = null },
                new Company { Id = 4, Name = "OpelPlus", Description = "Fictieve Opel garage", Reference = "Garage opel", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0456.565.667", AccountNumber = "333-7777777-22" },
                new Company { Id = 5, Name = "AVIS", Description = "KT leverancier ?", Reference = "AVIS", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0455664455556", AccountNumber = "123-1234567-98" },
                new Company { Id = 6, Name = "Texaco", Description = "Texaco", Reference = "Texaco", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "2", AccountNumber = "2" },
                new Company { Id = 7, Name = "Q8", IsInternal = false, IsActive = false, AccountNumber = null },
                new Company { Id = 8, Name = "CIACfleet", Description = "Multimerkverhuurder", Reference = "CIAC", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "xx", AccountNumber = "xx" },
                new Company { Id = 9, Name = "Sneyers", Description = "BMW Garage", Reference = "D", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 10, Name = "AXA", Description = "AXA", Reference = "AXA", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 11, Name = "VAB", Description = "VAB", Reference = "VAB", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "1", AccountNumber = "1" },
                new Company { Id = 12, Name = "Touring", Description = "Touring", Reference = "Touring", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "2", AccountNumber = "2" },
                new Company { Id = 13, Name = "Brocom", Description = "Brocom", Reference = "Brocom", IsInternal = false, IsActive = false, NonActiveRemark = "tijdelijk niet acief gezet", VAT = "BE 123233134234", AccountNumber = "123-123456789-12" },
                new Company { Id = 14, Name = "KBC Autolease", Description = "KBC", Reference = "KBC", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE 0422.562.385", AccountNumber = "BE30 4377 5013 7111" },
                new Company { Id = 15, Name = "Mercedes-Benz FS Belux NV", Description = "Daimler Fleet Management", Reference = "MBFS", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "BE0405816821", AccountNumber = "BE42 4829 0171 1154" },
                new Company { Id = 16, Name = "GMAN Antwerpen", IsInternal = false, IsActive = false, AccountNumber = null },
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
                new Company { Id = 34, Name = "Q8", IsInternal = false, IsActive = false, AccountNumber = null },
                new Company { Id = 35, Name = "Alphabet", Description = "", Reference = "ALP", IsInternal = false, IsActive = true, NonActiveRemark = "", VAT = "", AccountNumber = "" },
                new Company { Id = 36, AccountNumber = null }
            );

            builder.Entity<Corporation>().HasData(
                new Corporation { Id = 1, Name = "eMenKa BV", Abbreviation = "Holland", CompanyId = 32, StartDate = new DateTime(2010, 1, 1, 12, 0, 0) },
                new Corporation { Id = 2, Name = "eMenKa GmbH", Abbreviation = "Keulen", CompanyId = 31, StartDate = new DateTime(2010, 1, 1, 12, 0, 0) },
                new Corporation { Id = 3, Name = "eMenKa NV", Abbreviation = "Antwerpen", CompanyId = 29, StartDate = new DateTime(2010, 1, 1, 12, 0, 0) }
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

                    Language = (Language)1,
                    DriversLicenseNumber = "12345678-25",


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

                    StartDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2019, 9, 30, 12, 0, 0),



                    Picture = null
                },
                new Person
                {
                    Id = 51,
                    Firstname = "string",
                    Lastname = "string",

                    Language = (Language)2,






                    Picture = null
                },
                new Person
                {
                    Id = 52,
                    Firstname = "string",
                    Lastname = "string",

                    Language = (Language)2,






                    Picture = null
                },
                new Person
                {
                    Id = 53,
                    Firstname = "string",
                    Lastname = "string",

                    Language = (Language)2,






                    Picture = null
                },
                new Person
                {
                    Id = 54,
                    Firstname = "string",
                    Lastname = "string",

                    Language = (Language)2,






                    Picture = null
                },
                new Person
                {
                    Id = 55,
                    Firstname = "elvin",
                    Lastname = "lumani",

                    Language = (Language)2,
                    DriversLicenseNumber = "",


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

                    Language = (Language)2,
                    DriversLicenseNumber = "",


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

                    Language = (Language)2,
                    DriversLicenseNumber = "",


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

                    Language = (Language)2,
                    DriversLicenseNumber = "",


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

                    Language = (Language)2,



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

                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),

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

                    StartDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),
                    EndDateDriversLicense = new DateTime(2020, 1, 17, 12, 0, 0),



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

                    StartDateDriversLicense = new DateTime(2006, 11, 30, 12, 0, 0),


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

                    StartDateDriversLicense = new DateTime(2020, 2, 17, 12, 0, 0),


                    Gender = "M",

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

                    DriversLicenseType = "b",
                    Gender = "F",

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
                new Driver { Id = 1, PersonId = 2, StartDate = new DateTime(2007, 08, 1), FuelCardId = 1 },
                new Driver { Id = 2, PersonId = 6, StartDate = new DateTime(2007, 09, 1), EndDate = new DateTime(2009, 06, 25), FuelCardId = 2 },
                new Driver { Id = 3, PersonId = 9, StartDate = new DateTime(2009, 05, 13), EndDate = new DateTime(2011, 01, 13), FuelCardId = 3 },
                new Driver { Id = 4, PersonId = 4, StartDate = new DateTime(2008, 03, 16), EndDate = new DateTime(2010, 11, 30), FuelCardId = 4 },
                new Driver { Id = 5, PersonId = 1, StartDate = new DateTime(2008, 09, 16), EndDate = new DateTime(2015, 02, 28), FuelCardId = 5 },
                new Driver { Id = 6, PersonId = 10, StartDate = new DateTime(2007, 08, 5), EndDate = new DateTime(2010, 04, 16), FuelCardId = 6 },
                new Driver { Id = 7, PersonId = 3, StartDate = new DateTime(2007, 06, 1), FuelCardId = 7 },
                new Driver { Id = 8, PersonId = 11, StartDate = new DateTime(2009, 06, 15), EndDate = new DateTime(2011, 09, 30), FuelCardId = 8 },
                new Driver { Id = 9, PersonId = 12, StartDate = new DateTime(2008, 10, 6), EndDate = new DateTime(2010, 03, 1), FuelCardId = 9 },
                new Driver { Id = 10, PersonId = 13, StartDate = new DateTime(2009, 09, 14), FuelCardId = 10 },
                new Driver {Id = 11, PersonId = 14, StartDate = new DateTime(2007, 09, 17), EndDate = new DateTime(2008, 06, 30), FuelCardId = 11},
                new Driver
                {
                    Id = 12,
                    PersonId = 15,
                    StartDate = new DateTime(2007, 11, 1),
                    FuelCardId = 12
                },
                new Driver
                {
                    Id = 13,
                    PersonId = 16,
                    StartDate = new DateTime(2007, 05, 1),
                    FuelCardId = 13
                },
                new Driver
                {
                    Id = 14,
                    PersonId = 17,
                    StartDate = new DateTime(2009, 09, 25),
                    FuelCardId = 14
                },
                new Driver
                {
                    Id = 15,
                    PersonId = 18,
                    StartDate = new DateTime(2008, 08, 31),
                    FuelCardId = 15
                },
                new Driver
                {
                    Id = 16,
                    PersonId = 19,
                    StartDate = new DateTime(2011, 02, 1),
                    EndDate = new DateTime(2012, 12, 31),
                    FuelCardId = 16
                },
                new Driver
                {
                    Id = 17,
                    PersonId = 20,
                    StartDate = new DateTime(2011, 03, 30),
                    FuelCardId = 17
                },
                new Driver
                {
                    Id = 18,
                    PersonId = 21,
                    StartDate = new DateTime(2011, 03, 14),
                    EndDate = new DateTime(2014, 06, 13),
                    FuelCardId = 18
                },
                new Driver
                {
                    Id = 19,
                    PersonId = 22,
                    StartDate = new DateTime(2011, 04, 12),
                    EndDate = new DateTime(2012, 03, 5),
                    FuelCardId = 19
                },
                new Driver
                {
                    Id = 20,
                    PersonId = 23,
                    StartDate = new DateTime(2011, 05, 16),
                    EndDate = new DateTime(2015, 10, 9),
                    FuelCardId = 20
                },
                new Driver
                {
                    Id = 21,
                    PersonId = 24,
                    StartDate = new DateTime(2011, 06, 1),
                    FuelCardId = 21
                },
                new Driver
                {
                    Id = 22,
                    PersonId = 25,
                    StartDate = new DateTime(2008, 01, 2),
                    EndDate = new DateTime(2009, 01, 14),
                    FuelCardId = 22
                },
                new Driver
                {
                    Id = 23,
                    PersonId = 26,
                    StartDate = new DateTime(2007, 12, 3),
                    EndDate = new DateTime(2008, 05, 31),
                    FuelCardId = 23
                },
                new Driver
                {
                    Id = 24,
                    PersonId = 27,
                    StartDate = new DateTime(2012, 01, 1),
                    FuelCardId = 24
                },
                new Driver
                {
                    Id = 25,
                    PersonId = 28,
                    StartDate = new DateTime(2012, 03, 5),
                    FuelCardId = 25
                },
                new Driver
                {
                    Id = 26,
                    PersonId = 29,
                    StartDate = new DateTime(2012, 02, 6),
                    EndDate = new DateTime(2014, 10, 31),
                    FuelCardId = 26
                },
                new Driver
                {
                    Id = 27,
                    PersonId = 30,
                    StartDate = new DateTime(2012, 02, 27),
                    EndDate = new DateTime(2014, 08, 25),
                    FuelCardId = 27
                },
                new Driver
                {
                    Id = 28,
                    PersonId = 31,
                    StartDate = new DateTime(2012, 05, 14),
                    EndDate = new DateTime(2014, 10, 24),
                    FuelCardId = 28
                },
                new Driver
                {
                    Id = 29,
                    PersonId = 32,
                    StartDate = new DateTime(2012, 08, 13),
                    EndDate = new DateTime(2015, 02, 28),
                    FuelCardId = 29
                },
                new Driver
                {
                    Id = 30,
                    PersonId = 33,
                    StartDate = new DateTime(2012, 08, 20),
                    EndDate = new DateTime(2013, 12, 16),
                    FuelCardId = 30
                },
                new Driver
                {
                    Id = 31,
                    PersonId = 34,
                    StartDate = new DateTime(2013, 01, 23),
                    EndDate = new DateTime(2015, 08, 28),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 32,
                    PersonId = 35,
                    StartDate = new DateTime(2013, 09, 16),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 33,
                    PersonId = 36,
                    StartDate = new DateTime(2014, 01, 14),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 34,
                    PersonId = 37,
                    StartDate = new DateTime(2014, 08, 4),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 35,
                    PersonId = 38,
                    StartDate = new DateTime(2014, 10, 13),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 36,
                    PersonId = 39,
                    StartDate = new DateTime(2015, 07, 13),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 37,
                    PersonId = 40,
                    StartDate = new DateTime(2015, 01, 19),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 38,
                    PersonId = 41,
                    StartDate = new DateTime(2007, 03, 20),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 39,
                    PersonId = 42,
                    StartDate = new DateTime(2015, 07, 27),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 40,
                    PersonId = 43,
                    StartDate = new DateTime(2007, 05, 1),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 41,
                    PersonId = 46,
                    StartDate = new DateTime(2017, 07, 3),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 42,
                    PersonId = 49,
                    StartDate = new DateTime(2017, 09, 11),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 43,
                    PersonId = 80,
                    StartDate = new DateTime(2019, 09, 30),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 44,
                    PersonId = 84,
                    StartDate = new DateTime(2019, 11, 27),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 45,
                    PersonId = 86,
                    StartDate = new DateTime(2019, 11, 3),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 46,
                    PersonId = 92,
                    StartDate = new DateTime(2019, 11, 22),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 47,
                    PersonId = 93,
                    StartDate = new DateTime(2019, 11, 16),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 48,
                    PersonId = 94,
                    StartDate = new DateTime(2019, 11, 16),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 49,
                    PersonId = 97,
                    StartDate = new DateTime(2019, 11, 19),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 50,
                    PersonId = 116,
                    StartDate = new DateTime(2020, 01, 17),
                    FuelCardId = null
                },
                new Driver
                {
                    Id = 51,
                    PersonId = 119,
                    StartDate = new DateTime(2020, 02, 6),
                    FuelCardId = null
                },
                new Driver { Id = 52, PersonId = 122, StartDate = new DateTime(2020, 03, 2), FuelCardId = null },
                new Driver { Id = 53, PersonId = 123, StartDate = new DateTime(2020, 03, 4), FuelCardId = null },
                new Driver { Id = 54, PersonId = 124, StartDate = new DateTime(2020, 10, 7), FuelCardId = null }
            );
            #endregion

            #region Vehicles

            builder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Volume = 3112, CountryId = 1, BuildYear = 2005, LicensePlate = "1ABQ121", Chassis = "SJNFDAE11U2117751", Emission = 123, FuelCardId = 1, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 74, FiscalHP = 9, EndDateDelivery = new DateTime(2009, 12, 31), FuelTypeId = 10 },
                new Vehicle { Id = 2, Volume = 3117, CountryId = 1, BuildYear = 2001, LicensePlate = "1ACS122", Chassis = "0azerty", Emission = 134, FuelCardId = 3, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 1, EngineCapacity = 1995, EnginePower = 130, FiscalHP = 10, EndDateDelivery = new DateTime(2013, 12, 1), FuelTypeId = 10 },
                new Vehicle { Id = 3, Volume = 3113, CountryId = 1, BuildYear = 2002, LicensePlate = "1ADB123", Chassis = "W0LPE9EM4D2025752", Emission = 145, FuelCardId = 2, BrandId = 3, ModelId = 8, SeriesId = 3, EngineTypeId = 24, DoorTypeId = 2, EngineCapacity = 1577, EnginePower = 80, FiscalHP = 9, EndDateDelivery = new DateTime(2009, 05, 19), FuelTypeId = 9 },
                new Vehicle { Id = 4, Volume = 3116, CountryId = 1, BuildYear = 2003, LicensePlate = "1AEB124", Chassis = "7897456", Emission = 156, FuelCardId = 4, BrandId = 4, ModelId = 12, SeriesId = 5, EngineTypeId = 5, DoorTypeId = 2, EngineCapacity = 1910, EnginePower = 74, FiscalHP = 10, EndDateDelivery = new DateTime(2020, 01, 1), FuelTypeId = 10 },
                new Vehicle { Id = 5, Volume = 3114, CountryId = 1, BuildYear = 2004, LicensePlate = "1BFB125", Chassis = "547854", Emission = 167, FuelCardId = 6, BrandId = 4, ModelId = 14, SeriesId = 4, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1990, EnginePower = 124, FiscalHP = 11, EndDateDelivery = new DateTime(2014, 03, 4), FuelTypeId = 9 },
                new Vehicle { Id = 6, Volume = 3115, CountryId = 1, BuildYear = 2005, LicensePlate = "1BGB126", Chassis = "MKLI89Y77Y67UI", Emission = 178, FuelCardId = 5, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 1, DoorTypeId = 3, EngineCapacity = 1995, EnginePower = 90, FiscalHP = 10, EndDateDelivery = new DateTime(2011, 12, 31), FuelTypeId = 10 },
                new Vehicle { Id = 7, Volume = 3116, CountryId = 1, BuildYear = 2006, LicensePlate = "1BHB127", Chassis = "W0L0AHM759G027219", Emission = 189, FuelCardId = 9, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 2001, EnginePower = 165, FiscalHP = 12, EndDateDelivery = new DateTime(2013, 05, 15), FuelTypeId = 10 },
                new Vehicle { Id = 8, Volume = 3118, CountryId = 1, BuildYear = 2007, LicensePlate = "1BIB138", Chassis = "nvt", Emission = 196, FuelCardId = 8, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 10, DoorTypeId = 1, EngineCapacity = 2100, EnginePower = 120, FiscalHP = 10, EndDateDelivery = new DateTime(2012, 01, 1), FuelTypeId = 9 },
                new Vehicle { Id = 9, Volume = 3114, CountryId = 1, BuildYear = 2008, LicensePlate = "1CJB139", Chassis = "100", Emission = 103, FuelCardId = 7, BrandId = 7, ModelId = 18, SeriesId = 18, EngineTypeId = 9, DoorTypeId = 4, EngineCapacity = 1560, EnginePower = 123, FiscalHP = 9, EndDateDelivery = new DateTime(2013, 01, 1), FuelTypeId = 10 },
                new Vehicle { Id = 10, Volume = 3119, CountryId = 1, BuildYear = 2009, LicensePlate = "1CKB130", Chassis = "1515154", Emission = 112, FuelCardId = 10, BrandId = 6, ModelId = 17, SeriesId = 12, EngineTypeId = 14, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, EndDateDelivery = new DateTime(2013, 01, 1), FuelTypeId = 10 },
                new Vehicle { Id = 11, Volume = 3117, CountryId = 1, BuildYear = 2000, LicensePlate = "1CLB231", Chassis = "W0LPD6EW6DG097221", Emission = 121, FuelCardId = 12, BrandId = 1, ModelId = 1, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 1995, EnginePower = 120, FiscalHP = 11, EndDateDelivery = new DateTime(2013, 01, 1), FuelTypeId = 10 },
                new Vehicle { Id = 12, Volume = 3112, CountryId = 1, BuildYear = 2001, LicensePlate = "1CMB232", Chassis = "145", Emission = 130, FuelCardId = 11, BrandId = 4, ModelId = 13, SeriesId = 4, EngineTypeId = 15, DoorTypeId = 2, EngineCapacity = 1248, EnginePower = 66, FiscalHP = 7, FuelTypeId = 10 },
                new Vehicle { Id = 13, Volume = 3113, CountryId = 1, BuildYear = 2002, LicensePlate = "1CAB233", Chassis = "W0L0ZCF3581087846", Emission = 146, FuelCardId = 13, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 2, EngineCapacity = 1999, EnginePower = 90, FiscalHP = 11, EndDateDelivery = new DateTime(2014, 01, 1), FuelTypeId = 10 },
                new Vehicle { Id = 14, Volume = 3111, CountryId = 1, BuildYear = 2003, LicensePlate = "1DZB234", Chassis = "U5YZU81UABL093503", Emission = 122, FuelCardId = 15, BrandId = 11, ModelId = 24, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 4, EngineCapacity = 2000, EnginePower = 136, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 15, Volume = 3130, CountryId = 1, BuildYear = 2004, LicensePlate = "1DEB235", Chassis = "W0LGT8EL1D1035314", Emission = 131, FuelCardId = 14, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 16, Volume = 3131, CountryId = 1, BuildYear = 2005, LicensePlate = "1DRB236", Chassis = "W0L0AHL4898044253", Emission = 143, FuelCardId = 16, BrandId = 11, ModelId = 27, SeriesId = 23, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 3232, EnginePower = 168, FiscalHP = 13, FuelTypeId = 9 },
                new Vehicle { Id = 17, Volume = 3133, CountryId = 1, BuildYear = 2006, LicensePlate = "1DTB247", Chassis = null, Emission = 156, FuelCardId = 17, BrandId = 1, ModelId = 31, SeriesId = 16, EngineTypeId = 1, DoorTypeId = 4, EngineCapacity = 1800, EnginePower = 8, FiscalHP = 11, FuelTypeId = 9 },
                new Vehicle { Id = 18, Volume = 3132, CountryId = 1, BuildYear = 2007, LicensePlate = "1EYB349", Chassis = "WBAWY31SDFDSGEGF21", Emission = 165, FuelCardId = 19, BrandId = 12, ModelId = 34, SeriesId = 26, EngineTypeId = 21, DoorTypeId = 3, EngineCapacity = 1560, EnginePower = 66, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 19, Volume = 3131, CountryId = 1, BuildYear = 2008, LicensePlate = "1EUB348", Chassis = "NLHBB51RABZ026442", Emission = 184, FuelCardId = 18, BrandId = 5, ModelId = 15, SeriesId = 30, EngineTypeId = 25, DoorTypeId = 4, EngineCapacity = 4500, EnginePower = 233, FiscalHP = 19, FuelTypeId = 9 },
                new Vehicle { Id = 20, Volume = 3135, CountryId = 1, BuildYear = 2009, LicensePlate = "1EIX347", Chassis = null, Emission = 17, FuelCardId = 20, BrandId = 4, ModelId = 12, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 21, Volume = 3130, CountryId = 1, BuildYear = 2000, LicensePlate = "1EOS346", Chassis = "789", Emission = 111, FuelCardId = 21, BrandId = 4, ModelId = 14, SeriesId = 5, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1910, EnginePower = 88, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 22, Volume = 3236, CountryId = 1, BuildYear = 2001, LicensePlate = "1FPT345", Chassis = "W0LPF6EG8A8044691", Emission = 0, FuelCardId = 23, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 15, DoorTypeId = 1, EngineCapacity = 1296, EnginePower = 66, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 23, Volume = 3234, CountryId = 1, BuildYear = 2002, LicensePlate = "1FQR344", Chassis = "123456", Emission = 233, FuelCardId = 22, BrandId = 6, ModelId = 17, SeriesId = 13, EngineTypeId = 27, DoorTypeId = 3, EnginePower = 0, FiscalHP = 0, FuelTypeId = 10 },
                new Vehicle { Id = 24, Volume = 3230, CountryId = 1, BuildYear = 2003, LicensePlate = "1FSE343", Chassis = null, Emission = 244, FuelCardId = 24, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 16, DoorTypeId = 1, EngineCapacity = 2999, EnginePower = 150, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 25, Volume = 3232, CountryId = 1, BuildYear = 2004, LicensePlate = "1FDZ352", Chassis = "145", Emission = 2532, FuelCardId = 26, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 26, Volume = 3233, CountryId = 1, BuildYear = 2005, LicensePlate = "1FFD351", Chassis = "45414521451454125", Emission = 266, FuelCardId = 25, BrandId = 4, ModelId = 11, SeriesId = 37, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 27, Volume = 3231, CountryId = 1, BuildYear = 2006, LicensePlate = "1GGF450", Chassis = "SJNFDAE11U2159420", Emission = 217, FuelCardId = 28, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 28, Volume = 3235, CountryId = 1, BuildYear = 2007, LicensePlate = "1GHG451", Chassis = "123456789", Emission = 2382, FuelCardId = 27, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 29, Volume = 3236, CountryId = 1, BuildYear = 2008, LicensePlate = "1GJ?452", Chassis = "123458", Emission = 2493, FuelCardId = 29, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 96, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 30, Volume = 3234, CountryId = 1, BuildYear = 2009, LicensePlate = "1GKN453", Chassis = "454745747547", Emission = 251, FuelCardId = 30, BrandId = 6, ModelId = 17, SeriesId = 12, EngineTypeId = 40, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 31, Volume = 3239, CountryId = 1, BuildYear = 2000, LicensePlate = "1GLB454", Chassis = null, Emission = 216, FuelCardId = 32, BrandId = 1, ModelId = 1, SeriesId = 16, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 1, EnginePower = 1, FiscalHP = 1, FuelTypeId = 10 },
                new Vehicle { Id = 32, Volume = 3237, CountryId = 1, BuildYear = 2001, LicensePlate = "1HMV455", Chassis = "VF30U9HR8BS316981", Emission = 2732, FuelCardId = 31, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 95, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 33, Volume = 3236, CountryId = 1, BuildYear = 2002, LicensePlate = "1HWC456", Chassis = "WBAVC11040VG85589", Emission = 282, BrandId = 4, ModelId = 14, SeriesId = 4, EngineTypeId = 5, DoorTypeId = 1, EngineCapacity = 1910, EnginePower = 100, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 34, Volume = 3232, CountryId = 1, BuildYear = 2003, LicensePlate = "1HXX457", Chassis = "W0LPE6EW4C1078195", Emission = 293, BrandId = 12, ModelId = 33, SeriesId = 28, EngineTypeId = 21, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 43, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 35, Volume = 3241, CountryId = 1, BuildYear = 2004, LicensePlate = "1HCG456", Chassis = "123", Emission = 214, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 37, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 36, Volume = 3243, CountryId = 1, BuildYear = 2005, LicensePlate = "1HVB579", Chassis = null, Emission = 2255, BrandId = 3, ModelId = 8, SeriesId = 3, EngineTypeId = 3, DoorTypeId = 2, EnginePower = 0, FiscalHP = 0, FuelTypeId = 10 },
                new Vehicle { Id = 37, Volume = 3242, CountryId = 1, BuildYear = 2006, LicensePlate = "1IBA578", Chassis = null, Emission = 2366, BrandId = 1, ModelId = 4, SeriesId = 15, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 1900, EnginePower = 0, FiscalHP = 0, FuelTypeId = 10 },
                new Vehicle { Id = 38, Volume = 3241, CountryId = 1, BuildYear = 2007, LicensePlate = "1ILK577", Chassis = "4521", Emission = 2477, BrandId = 6, ModelId = 21, SeriesId = 12, EngineTypeId = 40, DoorTypeId = 1, EngineCapacity = 1229, EnginePower = 122, FiscalHP = 11, FuelTypeId = 9 },
                new Vehicle { Id = 39, Volume = 3240, CountryId = 1, BuildYear = 2008, LicensePlate = "1IML575", Chassis = "W0L0SDL6884193058", Emission = 3588, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 12, DoorTypeId = 2, EnginePower = 0, FiscalHP = 0, FuelTypeId = 3 },
                new Vehicle { Id = 40, Volume = 3244, CountryId = 1, BuildYear = 2009, LicensePlate = "1IOI576", Chassis = "W0LPE8EG2B8045397", Emission = 369, BrandId = 8, ModelId = 30, SeriesId = 49, EngineTypeId = 50, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 41, Volume = 3245, CountryId = 1, BuildYear = 2000, LicensePlate = "1IUM571", Chassis = "W0LGT8ELXD1044444", Emission = 371, BrandId = 8, ModelId = 30, SeriesId = 49, EngineTypeId = 51, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 75, FiscalHP = 9, FuelTypeId = 9 },
                new Vehicle { Id = 42, Volume = 3346, CountryId = 1, BuildYear = 2001, LicensePlate = "1JYP573", Chassis = null, Emission = 382, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 78, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 150, FiscalHP = 0, FuelTypeId = 5 },
                new Vehicle { Id = 43, Volume = 3347, CountryId = 1, BuildYear = 2002, LicensePlate = "1JTU570", Chassis = "W0LPE8EX7D8050002", Emission = 393, BrandId = 8, ModelId = 30, SeriesId = 51, EngineTypeId = 50, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 44, Volume = 3348, CountryId = 1, BuildYear = 2003, LicensePlate = "1JRL581", Chassis = "VF3CC8HROET203509", Emission = 314, BrandId = 8, ModelId = 30, SeriesId = 51, EngineTypeId = 10, DoorTypeId = 2, EngineCapacity = 1900, EnginePower = 77, FiscalHP = 10, EndDateDelivery = new DateTime(2019, 05, 15), FuelTypeId = 10 },
                new Vehicle { Id = 45, Volume = 3349, CountryId = 1, BuildYear = 2004, LicensePlate = "1JAO682", Chassis = "789789", Emission = 325, BrandId = 8, ModelId = 30, SeriesId = 52, EngineTypeId = 50, DoorTypeId = 4, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 46, Volume = 3345, CountryId = 1, BuildYear = 2005, LicensePlate = "1KZN683", Chassis = "12354", Emission = 336, BrandId = 8, ModelId = 16, SeriesId = 53, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 47, Volume = 3446, CountryId = 1, BuildYear = 2006, LicensePlate = "1KEB686", Chassis = "VF3LB9HPAES115707", Emission = 348, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 12, FuelTypeId = 10 },
                new Vehicle { Id = 48, Volume = 3444, CountryId = 1, BuildYear = 2007, LicensePlate = "1KRV685", Chassis = "100", Emission = 356, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 35, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 88, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 49, Volume = 3442, CountryId = 1, BuildYear = 2008, LicensePlate = "1KTC684", Chassis = "14521", Emission = 382, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 52, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 50, Volume = 3446, CountryId = 1, BuildYear = 2009, LicensePlate = "1LYX684", Chassis = "W0L0AHM758G153913", Emission = 37, BrandId = 8, ModelId = 16, SeriesId = 19, EngineTypeId = 53, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 51, Volume = 3443, CountryId = 1, BuildYear = 2000, LicensePlate = "1LQW687", Chassis = null, Emission = 412, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 54, DoorTypeId = 4, EngineCapacity = 1800, EnginePower = 120, FiscalHP = 10, FuelTypeId = 9 },
                new Vehicle { Id = 52, Volume = 3444, CountryId = 1, BuildYear = 2001, LicensePlate = "1LSD688", Chassis = null, Emission = 4231, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 54, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 120, FiscalHP = 10, FuelTypeId = 9 },
                new Vehicle { Id = 53, Volume = 3446, CountryId = 1, BuildYear = 2002, LicensePlate = "1LDA689", Chassis = "ezrtrra", Emission = 4322, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 3, EngineCapacity = 1900, EnginePower = 85, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 54, Volume = 3443, CountryId = 1, BuildYear = 2003, LicensePlate = "1MFZ696", Chassis = null, Emission = 4513, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 3, EngineCapacity = 1900, EnginePower = 84, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 55, Volume = 3442, CountryId = 1, BuildYear = 2004, LicensePlate = "1MGE695", Chassis = null, Emission = 464, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 35, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 56, Volume = 3441, CountryId = 1, BuildYear = 2005, LicensePlate = "1MHR694", Chassis = "W0LPE6EW9DG046079", Emission = 446, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 35, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 88, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 57, Volume = 3420, CountryId = 1, BuildYear = 2006, LicensePlate = "1MJT691", Chassis = "nvt", Emission = 476, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 52, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 58, Volume = 3421, CountryId = 1, BuildYear = 2007, LicensePlate = "1NAY792", Chassis = "W0LGM8EL3C1068598", Emission = 489, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 52, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 59, Volume = 3422, CountryId = 1, BuildYear = 2008, LicensePlate = "1NZS793", Chassis = null, Emission = 498, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 60, Volume = 3425, CountryId = 1, BuildYear = 2009, LicensePlate = "1NES794", Chassis = "W0LGM8ES4E1137406", Emission = 407, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 61, Volume = 3424, CountryId = 1, BuildYear = 2000, LicensePlate = "1NRW795", Chassis = "W0LJD7EL6EB615571", Emission = 414, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 62, Volume = 3428, CountryId = 1, BuildYear = 2001, LicensePlate = "1OTC796", Chassis = "zaer", Emission = 4256, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 53, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 63, Volume = 3429, CountryId = 1, BuildYear = 2002, LicensePlate = "1OYV797", Chassis = null, Emission = 432, BrandId = 8, ModelId = 20, SeriesId = 54, EngineTypeId = 55, DoorTypeId = 6, EngineCapacity = 2700, EnginePower = 120, FiscalHP = 14, FuelTypeId = 10 },
                new Vehicle { Id = 64, Volume = 3427, CountryId = 1, BuildYear = 2003, LicensePlate = "1OUB798", Chassis = null, Emission = 461, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 1968, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 65, Volume = 3426, CountryId = 1, BuildYear = 2004, LicensePlate = "1OIA799", Chassis = "147", Emission = 452, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 35, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 66, Volume = 3523, CountryId = 1, BuildYear = 2005, LicensePlate = "1POZ793", Chassis = "W0L0AHL3582099371", Emission = 5571, BrandId = 8, ModelId = 20, SeriesId = 25, EngineTypeId = 56, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 67, Volume = 3522, CountryId = 1, BuildYear = 2006, LicensePlate = "1PQT792", Chassis = "W0LPE8EX6C8095933", Emission = 5653, BrandId = 8, ModelId = 20, SeriesId = 55, EngineTypeId = 35, DoorTypeId = 7, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 68, Volume = 3521, CountryId = 1, BuildYear = 2007, LicensePlate = "1PSU761", Chassis = null, Emission = 5685, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 69, Volume = 3524, CountryId = 1, BuildYear = 2008, LicensePlate = "1PDL764", Chassis = "W0LGM8ES4E1181678", Emission = 5796, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 85, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 70, Volume = 3525, CountryId = 1, BuildYear = 2009, LicensePlate = "1RFK765", Chassis = null, Emission = 5861, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 71, Volume = 3526, CountryId = 1, BuildYear = 2000, LicensePlate = "1RGJ766", Chassis = "120142", Emission = 590, BrandId = 1, ModelId = 2, SeriesId = 2, EngineTypeId = 61, DoorTypeId = 3, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 72, Volume = 3529, CountryId = 1, BuildYear = 2001, LicensePlate = "1RWH764", Chassis = "W0LPD8EW9D8062050", Emission = 587, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 61, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 73, Volume = 3528, CountryId = 1, BuildYear = 2002, LicensePlate = "1RXG869", Chassis = "SJNFDAE11U2157331", Emission = 561, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 61, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 74, Volume = 3527, CountryId = 1, BuildYear = 2003, LicensePlate = "1SCF868", Chassis = "WBAVU11090K051447", Emission = 534, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 1999, EnginePower = 90, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 75, Volume = 3525, CountryId = 1, BuildYear = 2004, LicensePlate = "1SVD867", Chassis = "100", Emission = 523, BrandId = 1, ModelId = 2, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 1995, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 76, Volume = 3526, CountryId = 1, BuildYear = 2005, LicensePlate = "1SBN866", Chassis = "W0LGM57K391058231", Emission = 510, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 77, Volume = 3529, CountryId = 1, BuildYear = 2006, LicensePlate = "1SND863", Chassis = "WAUZZZ8R1BA081105", Emission = 691, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 78, Volume = 3628, CountryId = 1, BuildYear = 2007, LicensePlate = "1TAQ862", Chassis = "VF38ERHR8BL085484", Emission = 682, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 79, Volume = 3627, CountryId = 1, BuildYear = 2008, LicensePlate = "1TZG861", Chassis = "W0LPE8E63E8064049", Emission = 673, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 80, Volume = 3624, CountryId = 1, BuildYear = 2009, LicensePlate = "1TEG864", Chassis = "YV1DZ73CDE2608659", Emission = 664, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 13, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 10, EndDateDelivery = new DateTime(2019, 05, 7), FuelTypeId = 10 },
                new Vehicle { Id = 81, Volume = 3625, CountryId = 1, BuildYear = 2000, LicensePlate = "1TRH815", Chassis = "W0L0SDL6884314639", Emission = 655, BrandId = 1, ModelId = 4, SeriesId = 2, EngineTypeId = 13, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 82, Volume = 3656, CountryId = 1, BuildYear = 2001, LicensePlate = "1UTN818", Chassis = "blablubli", Emission = 646, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 1, EngineCapacity = 2001, EnginePower = 130, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 83, Volume = 3653, CountryId = 1, BuildYear = 2002, LicensePlate = "1UYN819", Chassis = "W0LJD7EL0EB618949", Emission = 617, BrandId = 1, ModelId = 4, SeriesId = 1, EngineTypeId = 13, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 84, Volume = 3652, CountryId = 1, BuildYear = 2003, LicensePlate = "1UUB817", Chassis = "123", Emission = 638, BrandId = 1, ModelId = 1, SeriesId = 16, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 85, Volume = 3651, CountryId = 1, BuildYear = 2004, LicensePlate = "1UQV816", Chassis = "2541", Emission = 629, BrandId = 1, ModelId = 1, SeriesId = 17, EngineTypeId = 13, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 135, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 86, Volume = 3656, CountryId = 1, BuildYear = 2005, LicensePlate = "1VSC813", Chassis = "JNA1U2117751", Emission = 610, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 3500, EnginePower = 210, FiscalHP = 15, FuelTypeId = 10 },
                new Vehicle { Id = 87, Volume = 3659, CountryId = 1, BuildYear = 2007, LicensePlate = "1VWX952", Chassis = "0arty", Emission = 601, BrandId = 1, ModelId = 5, SeriesId = 17, EngineTypeId = 12, DoorTypeId = 2, EngineCapacity = 3500, EnginePower = 240, FiscalHP = 15, FuelTypeId = 10 },
                new Vehicle { Id = 88, Volume = 3658, CountryId = 1, BuildYear = 2006, LicensePlate = "1VXW951", Chassis = "W09EM4D2025752", Emission = 622, BrandId = 12, ModelId = 34, SeriesId = 60, EngineTypeId = 63, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 110, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 89, Volume = 3657, CountryId = 1, BuildYear = 2007, LicensePlate = "1VCP955", Chassis = "7856", Emission = 633, BrandId = 12, ModelId = 34, SeriesId = 61, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 90, Volume = 3654, CountryId = 1, BuildYear = 2008, LicensePlate = "1VVO952", Chassis = "5454", Emission = 664, BrandId = 12, ModelId = 34, SeriesId = 62, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 91, Volume = 3655, CountryId = 1, BuildYear = 2009, LicensePlate = "1WBI951", Chassis = "MK89Y77Y67UI", Emission = 791, BrandId = 12, ModelId = 34, SeriesId = 27, EngineTypeId = 64, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 92, Volume = 3656, CountryId = 1, BuildYear = 2000, LicensePlate = "1WNU952", Chassis = "W0HM759G027219", Emission = 782, BrandId = 12, ModelId = 34, SeriesId = 63, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 93, Volume = 3653, CountryId = 1, BuildYear = 2001, LicensePlate = "1WPY953", Chassis = "nv", Emission = 763, BrandId = 12, ModelId = 34, SeriesId = 64, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 94, Volume = 3652, CountryId = 1, BuildYear = 2002, LicensePlate = "1WOT956", Chassis = "10", Emission = 774, BrandId = 12, ModelId = 34, SeriesId = 65, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 95, Volume = 3654, CountryId = 1, BuildYear = 2003, LicensePlate = "1XIR955", Chassis = "155154", Emission = 755, BrandId = 12, ModelId = 34, SeriesId = 66, EngineTypeId = 22, DoorTypeId = 2, EngineCapacity = 1560, EnginePower = 82, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 96, Volume = 2656, CountryId = 1, BuildYear = 2004, LicensePlate = "1XUE954", Chassis = "W06EW6DG097221", Emission = 746, BrandId = 2, ModelId = 7, SeriesId = 75, EngineTypeId = 68, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 85, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 97, Volume = 2655, CountryId = 1, BuildYear = 2005, LicensePlate = "1XYZ957", Chassis = "14", Emission = 737, BrandId = 2, ModelId = 7, SeriesId = 75, EngineTypeId = 70, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 84, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 98, Volume = 2652, CountryId = 2, BuildYear = 2005, LicensePlate = "1XKA958", Chassis = "W00ZC81087846", Emission = 738, BrandId = 2, ModelId = 7, SeriesId = 72, EngineTypeId = 73, DoorTypeId = 2, EngineCapacity = 1800, EnginePower = 92, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 99, Volume = 2653, CountryId = 2, BuildYear = 2006, LicensePlate = "1YAS956", Chassis = "U5YZUABL093503", Emission = 719, BrandId = 2, ModelId = 7, SeriesId = 72, EngineTypeId = 70, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 102, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 100, Volume = 2651, CountryId = 2, BuildYear = 2004, LicensePlate = "1YZW956", Chassis = "W0LGTL1D1035314", Emission = 710, BrandId = 2, ModelId = 7, SeriesId = 71, EngineTypeId = 72, DoorTypeId = 1, EngineCapacity = 1800, EnginePower = 92, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 101, Volume = 2654, CountryId = 2, BuildYear = 2006, LicensePlate = "1YEQ949", Chassis = "W0L0A898044253", Emission = 721, BrandId = 2, ModelId = 7, SeriesId = 73, EngineTypeId = 70, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 102, Volume = 2655, CountryId = 2, BuildYear = 2007, LicensePlate = "1YTA948", Chassis = null, Emission = 722, BrandId = 4, ModelId = 11, SeriesId = 5, EngineTypeId = 94, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 103, Volume = 2656, CountryId = 2, BuildYear = 2005, LicensePlate = "1ZRZ947", Chassis = "WBA1SDFDSGEGF21", Emission = 851, BrandId = 4, ModelId = 11, SeriesId = 81, EngineTypeId = 94, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 104, Volume = 2659, CountryId = 2, BuildYear = 2006, LicensePlate = "1ZQW946", Chassis = "NLHB1BZ026442", Emission = 843, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 59, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 105, Volume = 2658, CountryId = 2, BuildYear = 2003, LicensePlate = "1ZSZ142", Chassis = null, Emission = 8632, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 74, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 106, Volume = 2657, CountryId = 2, BuildYear = 2002, LicensePlate = "1ZDA149", Chassis = "789", Emission = 834, BrandId = 4, ModelId = 11, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 1, EngineCapacity = 1700, EnginePower = 73, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 107, Volume = 2744, CountryId = 2, BuildYear = 2001, LicensePlate = "1QFQ148", Chassis = "W0PE8844691", Emission = 825, BrandId = 4, ModelId = 11, SeriesId = 37, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1700, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 108, Volume = 2745, CountryId = 2, BuildYear = 2000, LicensePlate = "1QWB147", Chassis = "1265165134", Emission = 876, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 3, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 109, Volume = 2746, CountryId = 2, BuildYear = 2007, LicensePlate = "1QXV146", Chassis = "zeaeaz?", Emission = 899, BrandId = 4, ModelId = 29, SeriesId = 24, EngineTypeId = 20, DoorTypeId = 2, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 110, Volume = 2743, CountryId = 2, BuildYear = 2008, LicensePlate = "1QCC146", Chassis = "1489414", Emission = 828, BrandId = 4, ModelId = 29, SeriesId = 82, EngineTypeId = 20, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 111, Volume = 2746, CountryId = 2, BuildYear = 2009, LicensePlate = "1AVX142", Chassis = "45442141454125", Emission = 817, BrandId = 4, ModelId = 12, SeriesId = 5, EngineTypeId = 95, DoorTypeId = 2, EngineCapacity = 1700, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 112, Volume = 2742, CountryId = 2, BuildYear = 2006, LicensePlate = "1AHW143", Chassis = "SJFDEU2159420", Emission = 882, BrandId = 4, ModelId = 12, SeriesId = 4, EngineTypeId = 8, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 92, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 113, Volume = 2741, CountryId = 2, BuildYear = 2005, LicensePlate = "1AFF141", Chassis = "1246789", Emission = 811, BrandId = 7, ModelId = 23, SeriesId = 86, EngineTypeId = 96, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 114, Volume = 2744, CountryId = 2, BuildYear = 2004, LicensePlate = "1AAQ144", Chassis = "12458", Emission = 941, BrandId = 7, ModelId = 23, SeriesId = 87, EngineTypeId = 96, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 115, Volume = 2745, CountryId = 2, BuildYear = 2002, LicensePlate = "1AZE135", Chassis = "45745747547", Emission = 942, BrandId = 7, ModelId = 23, SeriesId = 88, EngineTypeId = 96, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 116, Volume = 2746, CountryId = 2, BuildYear = 2001, LicensePlate = "1AHR136", Chassis = null, Emission = 933, BrandId = 6, ModelId = 17, SeriesId = 91, EngineTypeId = 40, DoorTypeId = 4, EngineCapacity = 1233, EnginePower = 120, FiscalHP = 10, FuelTypeId = 10 },
                new Vehicle { Id = 117, Volume = 2749, CountryId = 2, BuildYear = 2003, LicensePlate = "1ABT138", Chassis = "VF09HR8BS316981", Emission = 936, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 118, Volume = 2748, CountryId = 2, BuildYear = 2004, LicensePlate = "1ANY231", Chassis = "WBV11040VG85589", Emission = 955, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 119, Volume = 2747, CountryId = 2, BuildYear = 2005, LicensePlate = "1AMU233", Chassis = "W0P6EW4C1078195", Emission = 954, BrandId = 3, ModelId = 10, SeriesId = 112, EngineTypeId = 110, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 120, Volume = 2744, CountryId = 2, BuildYear = 2006, LicensePlate = "1ALI232", Chassis = "15616512", Emission = 935, BrandId = 3, ModelId = 10, SeriesId = 113, EngineTypeId = 110, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 121, Volume = 2745, CountryId = 2, BuildYear = 2007, LicensePlate = "1AKK231", Chassis = null, Emission = 938, BrandId = 3, ModelId = 10, SeriesId = 113, EngineTypeId = 111, DoorTypeId = 1, EngineCapacity = 1968, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 122, Volume = 2746, CountryId = 2, BuildYear = 2008, LicensePlate = "1AJJ236", Chassis = null, Emission = 929, BrandId = 3, ModelId = 10, SeriesId = 114, EngineTypeId = 110, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 77, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 123, Volume = 2749, CountryId = 2, BuildYear = 2009, LicensePlate = "1AHH235", Chassis = "451", Emission = 996, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 112, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 124, Volume = 2748, CountryId = 2, BuildYear = 2006, LicensePlate = "1AGG234", Chassis = "W00SDL6884193058", Emission = 993, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 112, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 125, Volume = 2746, CountryId = 2, BuildYear = 2015, LicensePlate = "1AGW217", Chassis = "W08EG2B8045397", Emission = 962, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 111, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 81, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 126, Volume = 2749, CountryId = 2, BuildYear = 2014, LicensePlate = "1AYQ218", Chassis = "W08ELXD1044444", Emission = 961, BrandId = 3, ModelId = 10, SeriesId = 115, EngineTypeId = 108, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 103, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 127, Volume = 2748, CountryId = 2, BuildYear = 2011, LicensePlate = "1AAS219", Chassis = null, Emission = 924, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 128, Volume = 2727, CountryId = 2, BuildYear = 2012, LicensePlate = "1BZW216", Chassis = "W0EX7850002", Emission = 925, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 1999, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 129, Volume = 2724, CountryId = 2, BuildYear = 2014, LicensePlate = "1BER215", Chassis = "VFROE203509", Emission = 928, BrandId = 3, ModelId = 10, SeriesId = 109, EngineTypeId = 108, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 103, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 130, Volume = 2725, CountryId = 2, BuildYear = 2010, LicensePlate = "1BZU214", Chassis = "797165619", Emission = 929, BrandId = 11, ModelId = 28, SeriesId = 120, EngineTypeId = 114, DoorTypeId = 6, EngineCapacity = 2400, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 131, Volume = 2726, CountryId = 2, BuildYear = 2019, LicensePlate = "1BWY211", Chassis = "1566655614", Emission = 917, BrandId = 11, ModelId = 28, SeriesId = 120, EngineTypeId = 18, DoorTypeId = 9, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 132, Volume = 2823, CountryId = 2, BuildYear = 2018, LicensePlate = "1BST212", Chassis = "VF3LB9ES115707", Emission = 976, BrandId = 11, ModelId = 24, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 3, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 133, Volume = 2822, CountryId = 2, BuildYear = 2017, LicensePlate = "1BQR213", Chassis = "14565100", Emission = 975, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 17, DoorTypeId = 2, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 134, Volume = 2821, CountryId = 2, BuildYear = 2016, LicensePlate = "1BGF325", Chassis = "14525611", Emission = 974, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 135, Volume = 2825, CountryId = 3, BuildYear = 2015, LicensePlate = "1BHE326", Chassis = "W0HG153913", Emission = 911, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 136, Volume = 2826, CountryId = 3, BuildYear = 2014, LicensePlate = "1BFZ324", Chassis = null, Emission = 982, BrandId = 11, ModelId = 26, SeriesId = 22, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 137, Volume = 2824, CountryId = 3, BuildYear = 2011, LicensePlate = "1BDA327", Chassis = null, Emission = 983, BrandId = 11, ModelId = 26, SeriesId = 124, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 138, Volume = 2822, CountryId = 3, BuildYear = 2012, LicensePlate = "1BQS328", Chassis = "ezrra", Emission = 986, BrandId = 11, ModelId = 26, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 84, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 139, Volume = 2823, CountryId = 3, BuildYear = 2016, LicensePlate = "1BAS199", Chassis = null, Emission = 985, BrandId = 11, ModelId = 26, SeriesId = 121, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 140, Volume = 2826, CountryId = 3, BuildYear = 2013, LicensePlate = "1BZH268", Chassis = null, Emission = 912, BrandId = 11, ModelId = 27, SeriesId = 123, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 1984, EnginePower = 120, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 141, Volume = 2825, CountryId = 4, BuildYear = 2012, LicensePlate = "1BEG357", Chassis = "W0EE9G046079", Emission = 911, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 18, DoorTypeId = 2, EngineCapacity = 1984, EnginePower = 120, FiscalHP = 163, FuelTypeId = 10 },
                new Vehicle { Id = 142, Volume = 2824, CountryId = 4, BuildYear = 2011, LicensePlate = "1BFO446", Chassis = "nvt", Emission = 912, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 143, Volume = 2822, CountryId = 4, BuildYear = 2012, LicensePlate = "1BFI535", Chassis = "W0LGM8LC68598", Emission = 131, BrandId = 11, ModelId = 27, SeriesId = 122, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1560, EnginePower = 85, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 144, Volume = 2823, CountryId = 4, BuildYear = 2013, LicensePlate = "1BFU624", Chassis = "nbefzzf", Emission = 1322, BrandId = 11, ModelId = 27, SeriesId = 120, EngineTypeId = 17, DoorTypeId = 1, EngineCapacity = 1600, EnginePower = 80, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 145, Volume = 2816, CountryId = 4, BuildYear = 2014, LicensePlate = "1BFY713", Chassis = "W0LM8E1137406", Emission = 1335, BrandId = 11, ModelId = 27, SeriesId = 127, EngineTypeId = 18, DoorTypeId = 1, EngineCapacity = 2000, EnginePower = 100, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 146, Volume = 2815, CountryId = 4, BuildYear = 2015, LicensePlate = "1BFT892", Chassis = "W0LJD7EB615571", Emission = 1357, BrandId = 4, ModelId = 29, SeriesId = 5, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 96, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 147, Volume = 2814, CountryId = 4, BuildYear = 2016, LicensePlate = "1BER981", Chassis = "za4561htger", Emission = 1348, BrandId = 4, ModelId = 11, SeriesId = 128, EngineTypeId = 39, DoorTypeId = 2, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 148, Volume = 2812, CountryId = 4, BuildYear = 2017, LicensePlate = "1BEE072", Chassis = null, Emission = 1369, BrandId = 4, ModelId = 11, SeriesId = 128, EngineTypeId = 39, DoorTypeId = 1, EngineCapacity = 1686, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 149, Volume = 2813, CountryId = 5, BuildYear = 2018, LicensePlate = "1CEZ163", Chassis = "nfezf654b", Emission = 1399, BrandId = 4, ModelId = 29, SeriesId = 129, EngineTypeId = 38, DoorTypeId = 1, EngineCapacity = 1956, EnginePower = 103, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 150, Volume = 2811, CountryId = 5, BuildYear = 2019, LicensePlate = "1CEA254", Chassis = "146517", Emission = 1385, BrandId = 4, ModelId = 11, SeriesId = 81, EngineTypeId = 115, DoorTypeId = 1, EngineCapacity = 1598, EnginePower = 81, FiscalHP = 9, FuelTypeId = 10 },
                new Vehicle { Id = 151, Volume = 2917, CountryId = 5, BuildYear = 2016, LicensePlate = "1CEF345", Chassis = "W0L0AH599371", Emission = 137, BrandId = 1, ModelId = 19, SeriesId = 2, EngineTypeId = 11, DoorTypeId = 3, EngineCapacity = 2000, EnginePower = 150, FiscalHP = 11, FuelTypeId = 10 },
                new Vehicle { Id = 152, Volume = 2918, CountryId = 5, BuildYear = 2013, LicensePlate = "1CDF436", Chassis = "W0LPEC8095933", Emission = 135, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 6, EngineCapacity = 1200, EnginePower = 70, FiscalHP = 80, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 05, 2), FuelTypeId = 9 },
                new Vehicle { Id = 153, Volume = 2919, CountryId = 5, BuildYear = 2012, LicensePlate = "1CDD527", Chassis = null, Emission = 131, BrandId = 1, ModelId = 5, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 5, EngineCapacity = 789, EnginePower = 7894, FiscalHP = 7894, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16), FuelTypeId = 9 },
                new Vehicle { Id = 154, Volume = 2916, CountryId = 5, BuildYear = 2011, LicensePlate = "1CDX618", Chassis = "W0LME418678", Emission = 122, BrandId = 7, ModelId = 23, SeriesId = 39, EngineTypeId = 117, DoorTypeId = 2, EngineCapacity = 0, EnginePower = 25, FiscalHP = 25, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 30), FuelTypeId = 3 },
                new Vehicle { Id = 155, Volume = 2915, CountryId = 5, BuildYear = 2014, LicensePlate = "1CEW499", Chassis = "nf56ez1fb", Emission = 1236, BrandId = 7, ModelId = 18, SeriesId = 39, EngineTypeId = 34, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, FuelTypeId = 10 },
                new Vehicle { Id = 156, Volume = 2914, CountryId = 5, BuildYear = 2015, LicensePlate = "1CEL781", Chassis = "12056142", Emission = 122, BrandId = 7, ModelId = 23, SeriesId = 9, EngineTypeId = 34, DoorTypeId = 4, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, FuelTypeId = 9 },
                new Vehicle { Id = 157, Volume = 2916, CountryId = 5, BuildYear = 2016, LicensePlate = "1CEF872", Chassis = "W0LEW9D8062050", Emission = 126, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 2, EngineCapacity = 789, EnginePower = 789, FiscalHP = 789, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16), FuelTypeId = 9 },
                new Vehicle { Id = 158, Volume = 2912, CountryId = 5, BuildYear = 2019, LicensePlate = "1CAJ963", Chassis = "SJDE11U2157331", Emission = 128, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 1, DoorTypeId = 5, EngineCapacity = 789, EnginePower = 789, FiscalHP = 789, AverageFuel = 0, EndDateDelivery = new DateTime(2020, 01, 16), FuelTypeId = 9 },
                new Vehicle { Id = 159, Volume = 2911, CountryId = 5, BuildYear = 2018, LicensePlate = "1CAG654", Chassis = "WBA1090K051447", Emission = 129, BrandId = 12, ModelId = 33, SeriesId = 27, EngineTypeId = 36, DoorTypeId = 2, EngineCapacity = 0, EnginePower = 100, FiscalHP = 100, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 15), FuelTypeId = 9 },
                new Vehicle { Id = 160, Volume = 2916, CountryId = 5, BuildYear = 2017, LicensePlate = "1CAD345", Chassis = "100zda4545", Emission = 128, BrandId = 8, ModelId = 16, SeriesId = 11, EngineTypeId = 10, DoorTypeId = 6, EngineCapacity = 0, EnginePower = 120, FiscalHP = 50, AverageFuel = 0, EndDateDelivery = new DateTime(2019, 03, 15), FuelTypeId = 9 },
                new Vehicle { Id = 161, Volume = 2919, CountryId = 5, BuildYear = 2011, LicensePlate = "1CZK236", Chassis = "W0LGM57K39231", Emission = 172, BrandId = 7, ModelId = 22, SeriesId = 9, EngineTypeId = 9, DoorTypeId = 4, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, FuelTypeId = 3 },
                new Vehicle { Id = 162, Volume = 2918, CountryId = 5, BuildYear = 2012, LicensePlate = "1CZI127", Chassis = "WAUZZZ8R81105", Emission = 122, BrandId = 1, ModelId = 1, SeriesId = 1, EngineTypeId = 2, DoorTypeId = 3, EngineCapacity = 0, EnginePower = 0, FiscalHP = 0, AverageFuel = 0, FuelTypeId = 10 }
            );




            #endregion

            #region FuelCards

            builder.Entity<FuelCard>().HasData(
                new FuelCard { Id = 1, DriverId = 1, Number = "188395479", CompanyId = 16, StartDate = new DateTime(2008, 11, 6, 11, 0, 0, 0), EndDate = new DateTime(2008, 12, 20), IsBlocked = true, BlockingDate = new DateTime(2009, 3, 25), BlockingReason = "kaart niet meer geldig", PinCode = "1011" },
                new FuelCard { Id = 2, DriverId = 2, Number = "0008 Tankkaartje 555", CompanyId = 4, StartDate = new DateTime(2007, 12, 12), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "****888" },
                new FuelCard { Id = 3, DriverId = 3, Number = "0005 AANLOOP 4", CompanyId = 6, StartDate = new DateTime(2007, 9, 14), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2020, 6, 3), BlockingReason = "", PinCode = "****" },
                new FuelCard { Id = 4, DriverId = 4, Number = "0004 AANLOOP 3", CompanyId = 4, StartDate = new DateTime(2007, 8, 13), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 3, 18), BlockingReason = "vervanging", PinCode = "7293" },
                new FuelCard { Id = 5, DriverId = 5, Number = "0010 AANLOOP 88", CompanyId = 4, StartDate = new DateTime(2008, 1, 17), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2020, 4, 3), BlockingReason = "", PinCode = "****" },
                new FuelCard { Id = 6, DriverId = 6, Number = "0009 AANLOOP 7", CompanyId = 4, StartDate = new DateTime(2009, 4, 1), EndDate = new DateTime(2010, 5, 18), IsBlocked = false, BlockingDate = new DateTime(2020, 3, 3), BlockingReason = "", PinCode = "14589" },
                new FuelCard { Id = 7, DriverId = 7, Number = "0002 AANLOOP 1", CompanyId = 4, StartDate = new DateTime(2007, 5, 22), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "2937" },
                new FuelCard { Id = 8, DriverId = 8, Number = "0003 AANLOOP 2", CompanyId = 4, StartDate = new DateTime(2007, 8, 1), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "3177" },
                new FuelCard { Id = 9, DriverId = 9, Number = "0001 LUVA", CompanyId = 4, StartDate = new DateTime(2007, 5, 22), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "7846" },
                new FuelCard { Id = 10, DriverId = 10, Number = "0006 SALES", CompanyId = 23, StartDate = new DateTime(2007, 9, 19), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 11, DriverId = 11, Number = "0007 AANLOOP 5", CompanyId = 4, StartDate = new DateTime(2007, 10, 31), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 12, DriverId = 12, Number = "0011 AANLOOP 9", CompanyId = 4, StartDate = new DateTime(2008, 2, 7), EndDate = new DateTime(2010, 5, 18), IsBlocked = true, BlockingDate = new DateTime(2010, 5, 18), BlockingReason = "vervanging", PinCode = "****" },
                new FuelCard { Id = 13, DriverId = 13, Number = "0012 AANLOOP 10", CompanyId = 4, StartDate = new DateTime(2008, 9, 12), EndDate = new DateTime(2011, 11, 9), IsBlocked = true, BlockingDate = new DateTime(2009, 4, 21), BlockingReason = "verloren", PinCode = "604" },
                new FuelCard { Id = 14, DriverId = 14, Number = "0009", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "7008" },
                new FuelCard { Id = 15, DriverId = 15, Number = "0002", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "2938" },
                new FuelCard { Id = 16, DriverId = 16, Number = "0003", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), EndDate = new DateTime(2018, 8, 17), IsBlocked = false, BlockingReason = "", PinCode = "3177" },
                new FuelCard { Id = 17, DriverId = 17, Number = "0004", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), EndDate = new DateTime(2019, 2, 1), IsBlocked = false, BlockingReason = "", PinCode = "7293" },
                new FuelCard { Id = 18, DriverId = 18, Number = "0005", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = true, BlockingDate = new DateTime(2017, 8, 23), BlockingReason = "test", PinCode = "321" },
                new FuelCard { Id = 19, DriverId = 19, Number = "0006", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "4606" },
                new FuelCard { Id = 20, DriverId = 20, Number = "0007", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "6491" },
                new FuelCard { Id = 21, DriverId = 21, Number = "0008", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "401" },
                new FuelCard { Id = 22, DriverId = 22, Number = "0010", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "7861" },
                new FuelCard { Id = 23, DriverId = 23, Number = "0011", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = true, BlockingDate = new DateTime(2017, 8, 23), BlockingReason = "ok", PinCode = "9714" },
                new FuelCard { Id = 24, DriverId = 24, Number = "0139", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "9183" },
                new FuelCard { Id = 25, DriverId = 25, Number = "0014", CompanyId = 4, StartDate = new DateTime(2010, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "6325" },
                new FuelCard { Id = 26, DriverId = 26, Number = "0019", CompanyId = 4, StartDate = new DateTime(2012, 8, 13), IsBlocked = false, BlockingReason = "", PinCode = "3030" },
                new FuelCard { Id = 27, DriverId = 27, Number = "0020", CompanyId = 4, StartDate = new DateTime(2012, 8, 20), IsBlocked = false, BlockingReason = "", PinCode = "3315" },
                new FuelCard { Id = 28, DriverId = 28, Number = "0100", CompanyId = 4, StartDate = new DateTime(2013, 12, 9), IsBlocked = false, BlockingReason = "", PinCode = "7491" },
                new FuelCard { Id = 29, DriverId = 29, Number = "0021", CompanyId = 4, StartDate = new DateTime(2013, 9, 12), IsBlocked = false, PinCode = "9363" },
                new FuelCard { Id = 30, DriverId = 30, Number = "0017", CompanyId = 4, StartDate = new DateTime(2012, 2, 24), IsBlocked = false, PinCode = "1312" },
                new FuelCard { Id = 31, DriverId = null, Number = "0129", CompanyId = 4, StartDate = new DateTime(2012, 2, 24), IsBlocked = false, BlockingReason = "", PinCode = "2765" },
                new FuelCard { Id = 32, DriverId = null, Number = "0016", CompanyId = 4, StartDate = new DateTime(2011, 5, 19), IsBlocked = false, BlockingReason = "", PinCode = "535" },
                new FuelCard { Id = 33, DriverId = null, Number = "0023", CompanyId = 4, StartDate = new DateTime(2016, 1, 1), IsBlocked = false, PinCode = "****" },
                new FuelCard { Id = 34, DriverId = null, Number = "0001", CompanyId = 15, StartDate = new DateTime(2017, 4, 25), EndDate = new DateTime(2020, 5, 4), IsBlocked = true, BlockingDate = new DateTime(2020, 4, 20), BlockingReason = "Vervangen door nieuwe tankkaart", PinCode = "123456" },
                new FuelCard { Id = 35, DriverId = null, Number = "1234", CompanyId = 4, StartDate = new DateTime(2014, 4, 26), IsBlocked = false, BlockingReason = "", PinCode = "1234" },
                new FuelCard { Id = 36, DriverId = null, Number = "Test", CompanyId = 24, StartDate = new DateTime(2020, 4, 3), IsBlocked = false, PinCode = "12345678" },
                new FuelCard { Id = 37, DriverId = null, Number = "008", CompanyId = 19, StartDate = new DateTime(2020, 3, 25), IsBlocked = false, PinCode = "88" },
                new FuelCard { Id = 38, DriverId = null, Number = "Test Nummer", CompanyId = 19, StartDate = new DateTime(2020, 1, 3), IsBlocked = false, PinCode = "1234" },
                new FuelCard { Id = 39, DriverId = null, Number = "123456789", CompanyId = 19, StartDate = new DateTime(2020, 3, 14), EndDate = new DateTime(2022, 3, 7), IsBlocked = false, PinCode = "8896" }
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
                new Record { Id = 1, CorporationId = 2, CostAllocationId = 4, FuelCardId = 1, Term = Term.Long, Usage = Usage.Pool },
                new Record { Id = 2, CorporationId = 3, CostAllocationId = 4, FuelCardId = 4, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 3, FuelCardId = 5, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 4, CorporationId = 3, CostAllocationId = 2, FuelCardId = 6, Term = Term.Short, Usage = Usage.RunIn },
                new Record { Id = 5, CorporationId = 1, CostAllocationId = 2, FuelCardId = 8, Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 6, CorporationId = 3, CostAllocationId = 2, FuelCardId = 9, StartDate = new DateTime(2020, 1, 20), EndDate = new DateTime(2023, 1, 20), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 7, CostAllocationId = 2, FuelCardId = 11, StartDate = new DateTime(2013, 7, 24), EndDate = new DateTime(2021, 7, 23), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 8, CostAllocationId = 4, FuelCardId = 3, EndDate = new DateTime(2015, 12, 26), Term = Term.Short, Usage = Usage.RunIn },
                new Record { Id = 9, CostAllocationId = 4, FuelCardId = 7, StartDate = new DateTime(2014, 11, 28), EndDate = new DateTime(2018, 11, 27), Term = Term.Long, Usage = 0 },
                new Record { Id = 10, CostAllocationId = 2, FuelCardId = 2, StartDate = new DateTime(2014, 7, 15), EndDate = new DateTime(2022, 7, 14), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 11, CostAllocationId = 4, FuelCardId = 12, StartDate = new DateTime(2014, 7, 2), EndDate = new DateTime(2018, 7, 1), Term = Term.Long, Usage = 0 },
                new Record { Id = 12, CostAllocationId = 4, FuelCardId = 19, StartDate = new DateTime(2014, 4, 9), EndDate = new DateTime(2018, 4, 8), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 13, CostAllocationId = 3, FuelCardId = 17, StartDate = new DateTime(2014, 3, 5), EndDate = new DateTime(2021, 3, 4), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 14, CorporationId = 3, CostAllocationId = 4, FuelCardId = 18, StartDate = new DateTime(2014, 3, 5), EndDate = new DateTime(2018, 3, 4), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 15, CostAllocationId = 1, FuelCardId = 16, StartDate = new DateTime(2013, 7, 24), EndDate = new DateTime(2017, 7, 23), Term = Term.Long, Usage = Usage.Replacement },
                new Record { Id = 16, CostAllocationId = 4, FuelCardId = 15, StartDate = new DateTime(2013, 5, 7), EndDate = new DateTime(2020, 5, 6), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 17, CostAllocationId = 4, FuelCardId = 14, StartDate = new DateTime(2013, 3, 4), EndDate = new DateTime(2017, 3, 3), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 18, CostAllocationId = 4, FuelCardId = 13, StartDate = new DateTime(2013, 2, 8), EndDate = new DateTime(2017, 2, 7), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 19, CostAllocationId = 2, FuelCardId = 20, StartDate = new DateTime(2013, 1, 18), EndDate = new DateTime(2017, 1, 17), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 20, CostAllocationId = 4, FuelCardId = 21, StartDate = new DateTime(2012, 11, 28), EndDate = new DateTime(2016, 11, 27), Term = Term.Long, Usage = 0 },
                new Record { Id = 21, CostAllocationId = 4, FuelCardId = 22, StartDate = new DateTime(2012, 6, 28), EndDate = new DateTime(2016, 6, 27), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 22, CostAllocationId = 4, FuelCardId = 23, StartDate = new DateTime(2012, 3, 19), EndDate = new DateTime(2016, 3, 18), Term = Term.Long, Usage = 0 },
                new Record { Id = 23, CorporationId = 1, CostAllocationId = 4, FuelCardId = 24, StartDate = new DateTime(2012, 4, 1), EndDate = new DateTime(2017, 4, 1), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 24, CostAllocationId = 3, FuelCardId = 25, StartDate = new DateTime(2012, 2, 21), EndDate = new DateTime(2016, 2, 20), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 25, CostAllocationId = 2, FuelCardId = 26, StartDate = new DateTime(2012, 1, 15), EndDate = new DateTime(2017, 1, 14), Term = Term.Privé, Usage = Usage.Definitive },
                new Record { Id = 26, CostAllocationId = 3, FuelCardId = 27, StartDate = new DateTime(2012, 1, 19), EndDate = new DateTime(2017, 1, 18), Term = Term.Privé, Usage = Usage.Definitive },
                new Record { Id = 27, CostAllocationId = 4, FuelCardId = 28, StartDate = new DateTime(2012, 10, 27), EndDate = new DateTime(2015, 10, 27), Term = Term.Long, Usage = Usage.Definitive },
                new Record { Id = 28, CostAllocationId = 1, FuelCardId = 29, Term = Term.Privé, Usage = Usage.Definitive }

                );


            #endregion

            #region Categories

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Personenwagen" },
                new Category { Id = 2, Name = "Bestelwagen" },
                new Category { Id = 3, Name = "Heftruck" },
                new Category { Id = 4, Name = "Vrachtwagen" }
            );
            #endregion
        }
    }
}