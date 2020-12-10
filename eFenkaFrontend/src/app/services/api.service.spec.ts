import { CostAllocation } from './../models/cost-allocatoin/cost-allocation';
import { FuelCard } from './../models/fuel-card/fuel-card';
import { Company } from './../models/company/company';
import { Corporation } from './../models/corporation/corporation';
import { Record } from 'src/app/models/record/record';
import { Vehicle } from './../models/vehicle/vehicle';
import { DoorType } from './../models/door-type/door-type';
import { FuelType } from './../models/fuel-type/fuel-type';
import { ApiService } from './api.service';
import { TestBed, getTestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Model } from '../models/model/model';
import { Serie } from '../models/serie/serie';
import { EngineType } from '../models/engine-type/engine-type';
import { ExteriorColor } from '../models/exterior-color/exterior-color';
import { InteriorColor } from '../models/interior-color/interior-color';
import { Brand } from '../models/brand/brand';
import { Category } from '../models/category/category';
import { Country } from '../models/country/country';
import { Driver } from '../models/driver/driver';
import { Person } from '../models/person/person';

describe('ApiService', () => {
  let injector: TestBed;
  let service: ApiService;
  let httpMock: HttpTestingController;
  let dummyData: DummyData;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ApiService]
    });
    injector = getTestBed();
    service = injector.get(ApiService);
    httpMock = injector.get(HttpTestingController);
    dummyData = new DummyData();
  });

  afterEach(() => {
    httpMock.verify();
  });

  // Vehicles

  describe('#getAllVehicles', () => {
    it('should return an Observable<Vehicle[]>', () => {
      const vehicles = dummyData.getVehicles();

      service.getAllVehicles().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(vehicles);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/`);
      expect(req.request.method).toBe('GET');
      req.flush(vehicles);
    });
  });

  describe('#getVehicleById', () => {
    it('should return a vehicle', () => {
      const vehicleId = 1;
      const vehicle = dummyData.getVehicles()[0];

      service.getVehicleById(vehicleId).subscribe(v => {
        expect(v).toEqual(vehicle);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/${vehicleId}`);
      expect(req.request.method).toBe('GET');
      req.flush(vehicle);
    });
  });

  describe('#getVehicleById', () => {
    it('should throw an error if vehicle was not found', () => {
      const vehicleId = 1;

      service.getVehicleById(vehicleId).subscribe(
        data => fail('Should have failed with nothing found'),
        err => {
          expect(err.status).toBe(404);
          expect(err.error).toContain('nothing found');
        }
      );
      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/${vehicleId}`);

      const msg = 'nothing found';
      req.flush(msg, {status: 404, statusText: 'Not Found'});
    });
  });

  describe('#getVehicleById', () => {
    it('should throw an error if something is wrong with the connection', () => {
      const vehicleId = 1;

      service.getVehicleById(vehicleId).subscribe(
        (res: any) => expect(res.failure.error.type).toBe('error'),
        err => {}
      );

      httpMock.expectOne(`${service.BASE_API_URL}vehicle/${vehicleId}`).error(new ErrorEvent('error'));
    });
  });

  describe('#updateVehicle', () => {
    it('should update vehicle', () => {
      const vehicleId = 1;
      const vehicleToUpdate = dummyData.getVehicles()[0];
      vehicleToUpdate.buildYear = 2010;

      service.updateVehicle(vehicleId, vehicleToUpdate).subscribe();


      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/${vehicleId}`);
      expect(req.request.method).toBe('PUT');
      req.flush(vehicleToUpdate);
    });
  });

  describe('#addVehicle', () => {
    it('should add vehicle', () => {
      const newVehicle = dummyData.getVehicles()[0];

      service.addVehicle(newVehicle).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/`);
      expect(req.request.method).toBe('POST');
      req.flush(newVehicle);
    });
  });

  describe('#deleteVehicle', () => {
    it('should delete vehicle', () => {
      const vehicleId = 1;

      service.deleteVehicle(vehicleId).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/${vehicleId}`);
      expect(req.request.method).toBe('DELETE');
      req.flush(vehicleId);
    });
  });

  // Records

  describe('#getAllRecords', () => {
    it('should return an Observable<Record[]>', () => {
      const record = dummyData.getRecords();

      service.getAllRecords().subscribe(r => {
        expect(r.length).toBe(2);
        expect(r).toEqual(record);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}record/`);
      expect(req.request.method).toBe('GET');
      req.flush(record);
    });
  });

  describe('#getRecordById', () => {
    it('should return a record', () => {
      const recordId = 1;
      const record = dummyData.getRecords()[0];

      service.getRecordById(recordId).subscribe(v => {
        expect(v).toEqual(record);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}record/${recordId}`);
      expect(req.request.method).toBe('GET');
      req.flush(record);
    });
  });

  describe('#updateRecord', () => {
    it('should update record', () => {
      const recordId = 1;
      const recordToUpdate = dummyData.getRecords()[0];
      recordToUpdate.term = 2;

      service.updateRecord(recordId, recordToUpdate).subscribe();


      const req = httpMock.expectOne(`${service.BASE_API_URL}record/${recordId}`);
      expect(req.request.method).toBe('PUT');
      req.flush(recordToUpdate);
    });
  });

  describe('#addRecord', () => {
    it('should add record', () => {
      const newRecord = dummyData.getRecords()[0];

      service.addRecord(newRecord).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}record/`);
      expect(req.request.method).toBe('POST');
      req.flush(newRecord);
    });
  });

  describe('#deleteRecord', () => {
    it('should delete record', () => {
      const recordId = 1;

      service.deleteRecord(recordId).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}record/${recordId}`);
      expect(req.request.method).toBe('DELETE');
      req.flush(recordId);
    });
  });

  // Brands

  describe('#getAllBrands', () => {
    it('should return an Observable<Brand[]>', () => {
      const brands = dummyData.getBrands();

      service.getAllBrands().subscribe(b => {
        expect(b.length).toBe(2);
        expect(b).toEqual(brands);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}brand/`);
      expect(req.request.method).toBe('GET');
      req.flush(brands);
    });
  });

  describe('#getBrandById', () => {
    it('should return a record', () => {
      const brandId = 1;
      const brand = dummyData.getBrands()[0];

      service.getBrandById(brandId).subscribe(v => {
        expect(v).toEqual(brand);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(brand);
    });
  });

  describe('#getAllModelsByBrandId', () => {
    it('should return an Observable<Model[]>', () => {
      const brandId = 1;
      const models = [dummyData.getModels()[0], dummyData.getModels()[1]];

      service.getAllModelsByBrandId(brandId).subscribe(m => {
        expect(m.length).toBe(2);
        expect(m).toEqual(models);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}model/brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(models);
    });
  });

  describe('#getAllSeriesByBrandId', () => {
    it('should return an Observable<Serie[]>', () => {
      const brandId = 1;
      const series = [dummyData.getSeries()[0], dummyData.getSeries()[1]];

      service.getAllSeriesByBrandId(brandId).subscribe(s => {
        expect(s.length).toBe(2);
        expect(s).toEqual(series);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}serie/brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(series);
    });
  });

  describe('#getAllEngineTypesByBrandId', () => {
    it('should return an Observable<EngineType[]>', () => {
      const brandId = 1;
      const engineTypes = [dummyData.getEnginTypes()[0], dummyData.getEnginTypes()[1]];

      service.getAllEngineTypesByBrandId(brandId).subscribe(e => {
        expect(e.length).toBe(2);
        expect(e).toEqual(engineTypes);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}enginetype/brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(engineTypes);
    });
  });

  describe('#getAllVehiclesByBrandId', () => {
    it('should return an Observable<Vehicle[]>', () => {
      const brandId = 1;
      const vehicles = [dummyData.getVehicles()[0]];

      service.getAllVehiclesByBrandId(brandId).subscribe(v => {
        expect(v.length).toBe(1);
        expect(v).toEqual(vehicles);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(vehicles);
    });
  });

  // FuelCard

  describe('#getAllFuelCards', () => {
    it('should return an Observable<FuelCard[]>', () => {
      const fuelCards = dummyData.getFuelCards();

      service.getAllFuelCards().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(fuelCards);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}fuelcard/`);
      expect(req.request.method).toBe('GET');
      req.flush(fuelCards);
    });
  });

  describe('#getFuelCardById', () => {
    it('should return a fuelCard', () => {
      const fuelCardId = 1;
      const fuelCard = dummyData.getFuelCards()[0];

      service.getFuelCardById(fuelCardId).subscribe(v => {
        expect(v).toEqual(fuelCard);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}fuelcard/${fuelCardId}`);
      expect(req.request.method).toBe('GET');
      req.flush(fuelCard);
    });
  });

  describe('#updateFuelCard', () => {
    it('should update fuelCard', () => {
      const fuelCardId = 1;
      const fuelCardToUpdate = dummyData.getFuelCards()[0];
      fuelCardToUpdate.fuelCardNumber = '2';

      service.updateFuelCard(fuelCardId, fuelCardToUpdate).subscribe();


      const req = httpMock.expectOne(`${service.BASE_API_URL}fuelcard/${fuelCardId}`);
      expect(req.request.method).toBe('PUT');
      req.flush(fuelCardToUpdate);
    });
  });

  // FuelType

  describe('#getAllFuelTypes', () => {
    it('should return an Observable<FuelType[]>', () => {
      const fuelTypes = dummyData.getFuelTypes();

      service.getAllFuelTypes().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(fuelTypes);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}fueltype/`);
      expect(req.request.method).toBe('GET');
      req.flush(fuelTypes);
    });
  });

  // DoorType

  describe('#getAllDoorTypes', () => {
    it('should return an Observable<DoorType[]>', () => {
      const DoorTypes = dummyData.getDoorTypes();

      service.getAllDoorTypes().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(DoorTypes);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}doortype/`);
      expect(req.request.method).toBe('GET');
      req.flush(DoorTypes);
    });
  });

  // Categorie

  describe('#getAllCategories', () => {
    it('should return an Observable<Category[]>', () => {
      const categories = dummyData.getCategories();

      service.getAllCategories().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(categories);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}category/`);
      expect(req.request.method).toBe('GET');
      req.flush(categories);
    });
  });

  // Corporation

  describe('#getAllCorporatoins', () => {
    it('should return an Observable<Corporation[]>', () => {
      const corporations = dummyData.getCorporations();

      service.getAllCorporations().subscribe(v => {
        expect(v.length).toBe(3);
        expect(v).toEqual(corporations);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}corporation/`);
      expect(req.request.method).toBe('GET');
      req.flush(corporations);
    });
  });

  // CostAllocation

  describe('#getAllCostAllocations', () => {
    it('should return an Observable<CostAllocation[]>', () => {
      const costAllocatoins = dummyData.getCostAllocations();

      service.getAllCostAllocations().subscribe(v => {
        expect(v.length).toBe(4);
        expect(v).toEqual(costAllocatoins);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}costallocation/`);
      expect(req.request.method).toBe('GET');
      req.flush(costAllocatoins);
    });
  });

});

class DummyData {
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
    new Corporation(1, 'eMenKa GmbH', 'Keulen', this.companies[1], new Date('10-10-2010'), new Date('12-10-2010')),
    new Corporation(1, 'eMenKa NV', 'Antwerpen', this.companies[2], new Date('10-10-2010'), new Date('12-10-2010')),
  ];

  costAllocations = [
    new CostAllocation(1, 'Gent', 'VL', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(1, 'Hasselt', 'Lim', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(1, 'Brussel', 'Bxl', new Date('10-10-2010'), new Date('12-10-2010')),
    new CostAllocation(1, 'Antwerpe', 'HQ', new Date('10-10-2010'), new Date('12-10-2010')),
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
      interiorColor: null,
      exteriorColor: null
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
      licensePlate: '1-abc-123',
      endDateDelivery: new Date('10-10-2010'),
      isActive: true,
      chassis: 'SJNFDAE11U2117752',
      registrationDate: new Date('10-10-2010'),
      country: this.countries[1],
      buildYear: 2008,
      kilometers: 20000,
      averageFuel: 20,
      interiorColor: null,
      exteriorColor: null
    }
  ];

  people = [
    new Person(1, 'joren', 'vanderzande', new Date('26-08-1999'), 1, 'number', 'A', new Date('10-10-2010'), new Date('12-10-2010'), 'male', 'dhr.'),
    new Person(2, 'john', 'doe', new Date('26-08-1999'), 1, 'number2', 'A', new Date('10-10-2010'), new Date('12-10-2010'), 'male', 'dhr.')
  ];

  drivers = [
    new Driver(1, this.people[0], null, new Date('10-10-2010'), new Date('12-10-2010')),
    new Driver(2, this.people[2], null, new Date('10-10-2010'), new Date('12-10-2010'))
  ];

  records = [
    new Record(1, null, this.corporations[0], 1, new Date('10-10-2010'), new Date('12-10-2010'), 1, this.costAllocations[0]),
    new Record(2, null, this.corporations[2], 1, new Date('10-10-2010'), new Date('12-10-2010'), 1, this.costAllocations[2])
  ];

  fuelCards = [
    new FuelCard(1, 'number1', this.vehicles[0], this.drivers[0], this.records[0], this.companies[0], new Date('10-10-2010'), new Date('12-10-2010'), true),
    new FuelCard(1, 'number1', this.vehicles[1], this.drivers[1], this.records[1], this.companies[1], new Date('10-10-2010'), new Date('12-10-2010'), true)
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

  getCorporations(): Corporation[] {
    return this.corporations;
  }

  getCostAllocations(): CostAllocation[] {
    return this.costAllocations;
  }
}
