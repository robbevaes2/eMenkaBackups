import { ApiService } from './api.service';
import { TestBed, getTestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { DummyData } from './dummy-data';

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

  describe('#getAllAvailableVehicles', () => {
    it('should return an Observable<Vehicle[]>', () => {
      const vehicles = dummyData.getVehicles();

      service.getAllAvailableVehicles().subscribe(v => {
        expect(v.length).toBe(2);
        expect(v).toEqual(vehicles);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/available`);
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

  describe('#getAllAvailableVehiclesByBrandId', () => {
    it('should return an Observable<Vehicle[]>', () => {
      const brandId = 1;
      const vehicles = [dummyData.getVehicles()[0]];

      service.getAllAvailableVehiclesByBrandId(brandId).subscribe(v => {
        expect(v.length).toBe(1);
        expect(v).toEqual(vehicles);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}vehicle/available/brand/${brandId}`);
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

  describe('#addFuelcard', () => {
    it('should add record', () => {
      const newFuelCard = dummyData.getFuelCards()[0];

      service.addFuelcard(newFuelCard).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}fuelcard/`);
      expect(req.request.method).toBe('POST');
      req.flush(newFuelCard);
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

  describe('#deleteFuelCard', () => {
    it('should delete record', () => {
      const fuelCardId = 1;

      service.deleteFuelCard(fuelCardId).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}fuelcard/${fuelCardId}`);
      expect(req.request.method).toBe('DELETE');
      req.flush(fuelCardId);
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

  // Company

  describe('#getAllCompanies', () => {
    it('should return an Observable<Company[]>', () => {
      const companies = dummyData.getCompanies();

      service.getAllCompanies().subscribe(c => {
        expect(c.length).toBe(3);
        expect(c).toEqual(companies);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}company/`);
      expect(req.request.method).toBe('GET');
      req.flush(companies);
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

  // Driver

  describe('#getAllDrivers', () => {
    it('should return an Observable<Driver[]>', () => {
      const drivers = dummyData.getDrivers();

      service.getAllDrivers().subscribe(d => {
        expect(d.length).toBe(2);
        expect(d).toEqual(drivers);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/`);
      expect(req.request.method).toBe('GET');
      req.flush(drivers);
    });
  });

  describe('#getAllAvailableDrivers', () => {
    it('should return an Observable<Driver[]>', () => {
      const drivers = dummyData.getDrivers();

      service.getAllAvailableDrivers().subscribe(d => {
        expect(d.length).toBe(2);
        expect(d).toEqual(drivers);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/available`);
      expect(req.request.method).toBe('GET');
      req.flush(drivers);
    });
  });

  describe('#getDriverById', () => {
    it('should return a driver', () => {
      const driverId = 1;
      const driver = dummyData.getDrivers()[0];

      service.getDriverById(driverId).subscribe(d => {
        expect(d).toEqual(driver);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/${driverId}`);
      expect(req.request.method).toBe('GET');
      req.flush(driver);
    });
  });

  describe('#updateDriver', () => {
    it('should update driver', () => {
      const driverId = 1;
      const driverToUpdate = dummyData.getDrivers()[0];
      driverToUpdate.endDate = new Date('20-10-2010');

      service.updateDriver(driverId, driverToUpdate).subscribe();


      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/${driverId}`);
      expect(req.request.method).toBe('PUT');
      req.flush(driverToUpdate);
    });
  });

  describe('#addDriver', () => {
    it('should add driver', () => {
      const newDriver = dummyData.getDrivers()[0];

      service.addDriver(newDriver).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/`);
      expect(req.request.method).toBe('POST');
      req.flush(newDriver);
    });
  });

  describe('#deleteDriver', () => {
    it('should delete driver', () => {
      const driverId = 1;

      service.deleteDriver(driverId).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}driver/${driverId}`);
      expect(req.request.method).toBe('DELETE');
      req.flush(driverId);
    });
  });

  // Person

  describe('#getPersonById', () => {
    it('should return a person', () => {
      const personId = 1;
      const person = dummyData.getPeople()[0];

      service.getPersonById(personId).subscribe(p => {
        expect(p).toEqual(person);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}person/${personId}`);
      expect(req.request.method).toBe('GET');
      req.flush(person);
    });
  });

  describe('#updatePerson', () => {
    it('should update person', () => {
      const personId = 1;
      const personToUpdate = dummyData.getPeople()[0];
      personToUpdate.firstname = 'test';

      service.updatePerson(personId, personToUpdate).subscribe();


      const req = httpMock.expectOne(`${service.BASE_API_URL}person/${personId}`);
      expect(req.request.method).toBe('PUT');
      req.flush(personToUpdate);
    });
  });

  describe('#addPerson', () => {
    it('should add person', () => {
      const newPerson = dummyData.getPeople()[0];

      service.addPerson(newPerson).subscribe();

      const req = httpMock.expectOne(`${service.BASE_API_URL}person/`);
      expect(req.request.method).toBe('POST');
      req.flush(newPerson);
    });
  });

});
