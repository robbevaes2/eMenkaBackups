import { DummyData } from './../../services/dummy-data';
import { ApiService } from 'src/app/services/api.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { MdbTableDirective } from 'angular-bootstrap-md';
import { DriverListComponent } from './driver-list.component';
import { of } from 'rxjs';
import { Router } from '@angular/router';
import { Location } from "@angular/common";
import { appRoutes } from 'src/app/app.routes';

describe('DriverListComponent', () => {
  let component: DriverListComponent;
  let fixture: ComponentFixture<DriverListComponent>;

  let apiService: ApiService;
  let dummyData: DummyData;
  let spy: any;
  let location: Location;
  let router: Router;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        DriverListComponent,
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
    fixture = TestBed.createComponent(DriverListComponent);
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
    it('should set drivers to all drivers in database', () => {
      const drivers = dummyData.getDrivers();
      spy = spyOn(apiService, 'getAllDrivers').and.returnValue(of(drivers))

      component.ngOnInit();

      expect(component.drivers).toEqual(drivers);
      expect(component.mdbTable.getDataSource()).toEqual(drivers);
      expect(component.previous).toEqual(component.mdbTable.getDataSource());
    })
  })

  describe('#navigateToNewDriverComponent', () => {
    it('should navigate to new-drvier-item component', fakeAsync(() => {
      component.navigateToNewDriverComponent();

      tick();
      expect(location.path()).toBe('/drivers/new');
    }));
  });

  describe('#navigateToDriverDetailsComponent', () => {
    it('should navigate to driver-details component of the selected driver', fakeAsync(() => {
      let driverId = 1;
      component.navigateToDriverDetailsComponent(1);

      tick();
      expect(location.path()).toBe(`/drivers/${driverId}`);
    }));
  });

  describe('#isDriverActive', () => {
    it('should return true if startdate is before currentdate and enddate is after currentdate', () => {
      let before = new Date();
      before.setDate(before.getDate() - 1);
      let after = new Date();
      after.setDate(after.getDate() + 1);

      let driver = dummyData.getDrivers()[0];
      driver.startDate = before;
      driver.endDate = after;

      expect(component.isDriverActive(driver)).toBeTrue();
    });

    it('should return false if startdate is after currentdate and enddate is after currentdate', () => {
      let date = new Date();
      date.setDate(date.getDate() + 1);

      let driver = dummyData.getDrivers()[0];
      driver.startDate = date;
      driver.endDate = date;

      expect(component.isDriverActive(driver)).toBeFalse();
    });

    it('should return true if startdate is before currentdate and enddate is before currentdate', () => {
      let date = new Date();
      date.setDate(date.getDate() - 1);

      let driver = dummyData.getDrivers()[0];
      driver.startDate = date;
      driver.endDate = date;

      expect(component.isDriverActive(driver)).toBeFalse();
    });
  });

  describe('#getLanguageName', () => {
    it('should return language if language with that id exists', () => {
      let languageId = 1;
      let expectedLanguage = 'Nederlands';

      expect(component.getLanguageName(languageId)).toBe(expectedLanguage);
    })

    it('should return null if language with that id doesn\'t exists', () => {
      let languageId = 5;

      expect(component.getLanguageName(languageId)).toBe(null);
    })
  })

  describe('#searchItems', () => {
    it('should only display drivers depending on the firstname', () => {
      const drivers = dummyData.getDrivers();
      spy = spyOn(apiService, 'getAllDrivers').and.returnValue(of(drivers))
      component.ngOnInit();

      component.searchText = 'joren';
      fixture.detectChanges();

      expect(component.searchText).toBe('joren')

      component.searchItems();
      expect(component.drivers).toEqual([dummyData.getDrivers()[0]]);
    });

    it('should display all drivers if you empty the search bar', () => {
      const drivers = dummyData.getDrivers();
      spy = spyOn(apiService, 'getAllDrivers').and.returnValue(of(drivers))
      component.ngOnInit();

      component.searchText = 'joren';
      fixture.detectChanges();
      component.searchText = '';
      fixture.detectChanges();

      component.searchItems();
      expect(component.drivers).toEqual(drivers);
    });
  })
});
