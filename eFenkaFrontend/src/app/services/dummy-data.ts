import { Brand } from '../models/brand/brand';
import { Category } from '../models/category/category';
import { Company } from '../models/company/company';
import { Corporation } from '../models/corporation/corporation';
import { CostAllocation } from '../models/cost-allocatoin/cost-allocation';
import { Country } from '../models/country/country';
import { DoorType } from '../models/door-type/door-type';
import { Driver } from '../models/driver/driver';
import { EngineType } from '../models/engine-type/engine-type';
import { ExteriorColor } from '../models/exterior-color/exterior-color';
import { FuelCard } from '../models/fuel-card/fuel-card';
import { FuelType } from '../models/fuel-type/fuel-type';
import { InteriorColor } from '../models/interior-color/interior-color';
import { Model } from "../models/model/model";
import { Person } from '../models/person/person';
import { Record } from '../models/record/record';
import { Serie } from '../models/serie/serie';
import { Vehicle } from '../models/vehicle/vehicle';


export class DummyData {
  models = [
    new Model(1, 'X3'),
    new Model(2, '318d'),
    new Model(3, 'Escort'),
    new Model(4, 'Mondeo')
  ];

  series = [
    new Serie(1, 'Touring'),
    new Serie(2, 'Berline'),
    new Serie(3, 'Ghia'),
    new Serie(4, 'Econetic')
  ];

  fuelTypes = [
    new FuelType(1, 'Diesel'),
    new FuelType(2, 'Benzine')
  ];

  engineTypes = [
    new EngineType(1, '1.9'),
    new EngineType(2, '2'),
    new EngineType(3, '1.8 TDCI'),
    new EngineType(4, '1.8 TDCI Turbo')
  ];

  exteriorColors = [
    new ExteriorColor(1, 'Saphirschwarz'),
    new ExteriorColor(2, 'Titansilber'),
    new ExteriorColor(3, 'Deep Espresso Brown'),
    new ExteriorColor(4, 'Asteroid Grey')
  ];

  interiorColors = [
    new InteriorColor(1, 'Leder Dakota Schwarz'),
    new InteriorColor(2, 'Fluid Anthracit'),
    new InteriorColor(3, 'Lace/jet Black'),
    new InteriorColor(4, 'Lyra/jet Black')
  ];

  doorTypes = [
    new DoorType(1, '4-Deurs'),
    new DoorType(1, '5-Deurs')
  ];

  categories = [
    new Category(1, 'personenwagen'),
    new Category(2, 'bestelwagen')
  ];

  countries = [
    new Country(1, 'België', 'BE', 'Belg', false, true),
    new Country(2, 'Nederland', 'NL', 'Nederlandse', true, true),
    new Country(3, 'Duitsland', 'DE', 'Duitse', false, true),
    new Country(4, 'Frankrijk', 'FR', 'Franse', false, true),
    new Country(5, 'Spanje', 'ES', 'Spaanse', false, false),
  ];

  companies = [
    new Company(1, 'eMenKa BV', '', '', true, true, '', '', ''),
    new Company(2, 'eMenKa GmbH', '', '', true, true, '', '', ''),
    new Company(3, 'eMenKa NV', '', '', true, true, '', '', ''),
  ]

  corporations = [
    new Corporation(1, 'eMenKa BV', 'Holland', this.companies[0], new Date('10-10-2010'), new Date('12-10-2010')),
    new Corporation(2, 'eMenKa GmbH', 'Keulen', this.companies[1], new Date('10-10-2010'), new Date('12-10-2010')),
    new Corporation(3, 'eMenKa NV', 'Antwerpen', this.companies[2], new Date('10-10-2010'), new Date('12-10-2010')),
  ];

  costAllocations = [
    new CostAllocation(1, 'Gent', 'VL', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(2, 'Hasselt', 'Lim', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(3, 'Brussel', 'Bxl', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(4, 'Antwerpe', 'HQ', new Date('10-10-2010'), new Date('12-10-2010')),
  ];

  brands = [
    new Brand(1, 'BMW'),
    new Brand(2, 'Ford'),
  ];

  vehicles: Vehicle[] = [
    {
      id: 1,
      brand: this.brands[0],
      model: this.models[0],
      serie: this.series[0],
      fuelType: this.fuelTypes[0],
      engineType: this.engineTypes[0],
      engineCapacity: 20,
      enginePower: 20,
      doorType: this.doorTypes[0],
      fuelCard: null,
      volume: 20,
      category: this.categories[0],
      fiscalHP: 20,
      emission: 20,
      licensePlate: '1-abc-123',
      endDateDelivery: new Date('10-10-2010'),
      isActive: true,
      chassis: 'SJNFDAE11U2117752',
      registrationDate: new Date('10-10-2010'),
      country: this.countries[0],
      buildYear: 2008,
      kilometers: 20000,
      averageFuel: 20,
      interiorColor: this.interiorColors[0],
      exteriorColor: this.exteriorColors[0]
    },
    {
      id: 2,
      brand: this.brands[1],
      model: this.models[2],
      serie: this.series[2],
      fuelType: this.fuelTypes[2],
      engineType: this.engineTypes[2],
      engineCapacity: 20,
      enginePower: 20,
      doorType: this.doorTypes[1],
      fuelCard: null,
      volume: 20,
      category: this.categories[1],
      fiscalHP: 20,
      emission: 20,
      licensePlate: '1-abc-124',
      endDateDelivery: new Date('10-10-2010'),
      isActive: true,
      chassis: 'SJNFDAE11U2117752',
      registrationDate: new Date('10-10-2010'),
      country: this.countries[1],
      buildYear: 2008,
      kilometers: 20000,
      averageFuel: 20,
      interiorColor: this.interiorColors[2],
      exteriorColor: this.exteriorColors[2]
    }
  ];

  people = [
    new Person(1, 'joren', 'vanderzande', new Date('26-08-1999'), 1, 'number', 'A', new Date('10-10-2010'), new Date('12-10-2010'), 'male', 'dhr.'),
    new Person(2, 'john', 'doe', new Date('26-08-1999'), 1, 'number2', 'A', new Date('10-10-2010'), new Date('12-10-2010'), 'male', 'dhr.')
  ];

  drivers = [
    new Driver(1, this.people[0], null, new Date('10-10-2010'), new Date('12-10-2010')),
    new Driver(2, this.people[1], null, new Date('10-10-2010'), new Date('12-10-2010'))
  ];

  records = [
    new Record(1, null, this.corporations[0], 1, new Date('10-10-2010'), new Date('12-10-2010'), 1, this.costAllocations[0]),
    new Record(2, null, this.corporations[2], 1, new Date('10-10-2010'), new Date('12-10-2010'), 1, this.costAllocations[2])
  ];

  fuelCards = [
    new FuelCard(1, 'number1', this.vehicles[0], this.drivers[0], this.records[0], this.companies[0], new Date('10-10-2010'), new Date('12-10-2010'), true),
    new FuelCard(1, 'number2', this.vehicles[1], this.drivers[1], this.records[1], this.companies[1], new Date('10-10-2010'), new Date('12-10-2010'), true)
  ];

  getBrands(): Brand[] {
    return this.brands;
  }

  getModels(): Model[] {
    return this.models;
  }

  getSeries(): Serie[] {
    return this.series;
  }

  getEnginTypes(): EngineType[] {
    return this.engineTypes;
  }

  getVehicles(): Vehicle[] {
    return this.vehicles;
  }

  getRecords(): Record[] {
    return this.records;
  }

  getFuelTypes(): FuelType[] {
    return this.fuelTypes;
  }

  getFuelCards(): FuelCard[] {
    return this.fuelCards;
  }

  getDoorTypes(): DoorType[] {
    return this.doorTypes;
  }

  getCategories(): Category[] {
    return this.categories;
  }

  getCompanies(): Company [] {
    return this.companies;
  }

  getCorporations(): Corporation[] {
    return this.corporations;
  }

  getCostAllocations(): CostAllocation[] {
    return this.costAllocations;
  }

  getDrivers(): Driver[] {
    return this.drivers;
  }

  getPeople(): Person[] {
    return this.people;
  }
}
