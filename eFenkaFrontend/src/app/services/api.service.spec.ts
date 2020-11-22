import { getTestBed, inject, TestBed } from '@angular/core/testing';
import { Vehicle } from '../models/vehicle/vehicle';

import { ApiService } from './api.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Brand } from '../models/brand/brand';
import { Model } from '../models/model/model';

describe('ApiService', () => {
  let injector: TestBed;
  let service: ApiService;
  let httpMock: HttpTestingController;
  const BASE_API_URL = 'https://localhost:44356/api/';

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ApiService]
    });
    injector = getTestBed();
    service = injector.get(ApiService);
    httpMock = injector.get(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  describe('getAllVehicles', () => {
    it('should return an Observable<Vehicle[]>', () => {
      const dummyVehicles = [
        new Vehicle(),
        new Vehicle()
      ];

      service.getAllVehicles().subscribe(vehicles => {
        expect(vehicles.length).toBe(2);
        expect(vehicles).toEqual(dummyVehicles);
      });

      const req = httpMock.expectOne(BASE_API_URL + 'vehicle/');
      expect(req.request.method).toBe('GET');
      req.flush(dummyVehicles);
    });
  });

  describe('getAllBrands', () => {
    it('should return an Observable<Brand[]>', () => {
      const dummyBrands = [
        new Brand(null, null),
        new Brand(null, null)
      ];

      service.getAllBrands().subscribe(brands => {
        expect(brands.length).toBe(2);
        expect(brands).toEqual(dummyBrands);
      });

      const req = httpMock.expectOne(BASE_API_URL + 'brand/');
      expect(req.request.method).toBe('GET');
      req.flush(dummyBrands);
    });
  });

  describe('getAllModelsByBrandId', () => {
    it('should return an Observable<Model[]>', () => {
      const dummyModels = [
        new Model(null, null),
        new Model(null, null)
      ];
      const brandId = 1;

      service.getAllModelsByBrandId(brandId).subscribe(models => {
        expect(models.length).toBe(2);
        expect(models).toEqual(dummyModels);
      });

      const req = httpMock.expectOne(BASE_API_URL + 'model/brand/' + brandId);
      expect(req.request.method).toBe('GET');
      req.flush(dummyModels);
    });
  });
});


