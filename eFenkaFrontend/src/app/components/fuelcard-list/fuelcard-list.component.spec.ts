import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { Router } from '@angular/router';
import { RouterTestingModule } from '@angular/router/testing';
import { MdbTableDirective } from 'angular-bootstrap-md';
import { appRoutes } from 'src/app/app.routes';
import { ApiService } from 'src/app/services/api.service';
import { DummyData } from 'src/app/services/dummy-data';
import { Location } from "@angular/common";

import { FuelcardListComponent } from './fuelcard-list.component';
import { of } from 'rxjs';

describe('FuelcardListComponent', () => {
  let component: FuelcardListComponent;
  let fixture: ComponentFixture<FuelcardListComponent>;

  let apiService: ApiService;
  let dummyData: DummyData;
  let spy: any;
  let location: Location;
  let router: Router;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        FuelcardListComponent,
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
    fixture = TestBed.createComponent(FuelcardListComponent);
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
    it('should set fuelCards  to all fuelCards  in database', () => {
      const fuelCards  = dummyData.getFuelCards();
      spy = spyOn(apiService, 'getAllFuelCards').and.returnValue(of(fuelCards));

      component.ngOnInit();

      expect(component.fuelCards ).toEqual(fuelCards);
      expect(component.mdbTable.getDataSource()).toEqual(fuelCards);
      expect(component.previous).toEqual(component.mdbTable.getDataSource());
    });
  });

  describe('#navigateToNewFuelCardComponent', () => {
    it('should navigate to new-fuelcard-item component', fakeAsync(() => {
      component.navigateToNewFuelCardComponent();

      tick();
      expect(location.path()).toBe('/fuelcards/new');
    }));
  });

  describe('#navigateToFuelCardDetailsComponent', () => {
    it('should navigate to fuelcard-details component of the selected fuelcard', fakeAsync(() => {
      let fuelCardId = 1;
      component.navigateToFuelCardDetailsComponent(fuelCardId);

      tick();
      expect(location.path()).toBe(`/fuelcards/${fuelCardId}`);
    }));
  });

  describe('#searchItems', () => {
    it('should only display fuelcards depending on the licenceplate', () => {
      const fuelCards = dummyData.getFuelCards();
      spy = spyOn(apiService, 'getAllFuelCards').and.returnValue(of(fuelCards));
      component.ngOnInit();

      component.searchText = '1-abc-123';
      fixture.detectChanges();

      expect(component.searchText).toBe('1-abc-123')

      component.searchItems();
      expect(component.fuelCards).toEqual([dummyData.getFuelCards()[0]]);
    });

    it('should display all fuelcards if you empty the search bar', () => {
      const fuelCards = dummyData.getFuelCards();
      spy = spyOn(apiService, 'getAllFuelCards').and.returnValue(of(fuelCards));
      component.ngOnInit();

      component.searchText = '1-abc-123';
      fixture.detectChanges();
      component.searchText = '';
      fixture.detectChanges();

      component.searchItems();
      expect(component.fuelCards).toEqual(fuelCards);
    });
  });

  describe('#getFullName', () => {
    it('should return fullname of person', () => {
      let person = dummyData.getPeople()[0];

      expect(component.getFullName(person)).toBe("joren vanderzande");
    });
  });
});
