import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { Router } from '@angular/router';
import { RouterTestingModule } from '@angular/router/testing';
import { MdbTableDirective } from 'angular-bootstrap-md';
import { appRoutes } from 'src/app/app.routes';
import { ApiService } from 'src/app/services/api.service';
import { DummyData } from 'src/app/services/dummy-data';
import { Location } from "@angular/common";

import { VehicleListComponent } from './vehicle-list.component';
import { of } from 'rxjs';

describe('VehicleListComponent', () => {
  let component: VehicleListComponent;
  let fixture: ComponentFixture<VehicleListComponent>;

  let apiService: ApiService;
  let dummyData: DummyData;
  let spy: any;
  let location: Location;
  let router: Router;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        VehicleListComponent,
        MdbTableDirective
      ],
      imports: [
        RouterTestingModule.withRoutes(appRoutes),
        HttpClientTestingModule,
      ],
      providers: [
        ApiService,
      ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VehicleListComponent);
    component = fixture.componentInstance;

    apiService = TestBed.get(ApiService);
    dummyData = new DummyData();
    router = TestBed.get(Router);
    location = TestBed.get(Location);

    router.initialNavigation();

    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  describe('#ngOnInit', () => {
    it('should set vehicles  to all vehicles in database', () => {
      const vehicles  = dummyData.getVehicles();
      spy = spyOn(apiService, 'getAllVehicles').and.returnValue(of(vehicles));

      component.ngOnInit();

      expect(component.vehicles).toEqual(vehicles);
      expect(component.mdbTable.getDataSource()).toEqual(vehicles);
      expect(component.previous).toEqual(component.mdbTable.getDataSource());
    });
  });

  describe('#navigateToNewVehicleComponent', () => {
    it('should navigate to new-vehicle-item component', fakeAsync(() => {
      component.navigateToNewVehicleComponent();

      tick();
      expect(location.path()).toBe('/vehicles/new');
    }));
  });

  describe('#navigateToVehicleDetailsComponent', () => {
    it('should navigate to vehicle-details component of the selected vehicle', fakeAsync(() => {
      let vehicleId = 1;
      component.navigateToVehicleDetailsComponent(vehicleId);

      tick();
      expect(location.path()).toBe(`/vehicles/${vehicleId}`);
    }));
  });

  describe('#searchItems', () => {
    it('should only vehicle record depending on the brand', () => {
      const vehicles = dummyData.getVehicles();
      spy = spyOn(apiService, 'getAllVehicles').and.returnValue(of(vehicles));
      component.ngOnInit();

      component.searchText = 'BMW';
      fixture.detectChanges();

      expect(component.searchText).toBe('BMW')

      component.searchItems();
      expect(component.vehicles).toEqual([dummyData.getVehicles()[0]]);
    });

    it('should display all vehicle if you empty the search bar', () => {
      const vehicles = dummyData.getVehicles();
      spy = spyOn(apiService, 'getAllVehicles').and.returnValue(of(vehicles));
      component.ngOnInit();

      component.searchText = 'BMW';
      fixture.detectChanges();
      component.searchText = '';
      fixture.detectChanges();

      component.searchItems();
      expect(component.vehicles).toEqual(vehicles);
    });
  });
});
