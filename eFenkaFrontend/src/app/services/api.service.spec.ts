import { Vehicle } from 'src/app/models/vehicle/vehicle';
import { ApiService } from './api.service';
import { TestBed, getTestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Model } from '../models/model/model';
import { Serie } from '../models/serie/serie';
import { EngineType } from '../models/engine-type/engine-type';
import { ExteriorColor } from '../models/exterior-color/exterior-color';
import { InteriorColor } from '../models/interior-color/interior-color';
import { Brand } from '../models/brand/brand';

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

  describe('#getAllModelsByBrandId', () => {
    it('should return an Observable<Model[]>', () => {
      const brandId = 1;
      const models = [dummyData.getModels()[0], dummyData.getModels()[1]];

      service.getAllModelsByBrandId(1).subscribe(m => {
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

      service.getAllSeriesByBrandId(1).subscribe(s => {
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

      service.getAllEngineTypesByBrandId(1).subscribe(e => {
        expect(e.length).toBe(2);
        expect(e).toEqual(engineTypes);
      });

      const req = httpMock.expectOne(`${service.BASE_API_URL}enginetype/brand/${brandId}`);
      expect(req.request.method).toBe('GET');
      req.flush(engineTypes);
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

  brands = [
    new Brand(1, 'BMW'),
    new Brand(2, 'Ford'),
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
}
