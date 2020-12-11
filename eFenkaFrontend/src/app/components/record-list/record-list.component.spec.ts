import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { Router } from '@angular/router';
import { RouterTestingModule } from '@angular/router/testing';
import { MdbTableDirective } from 'angular-bootstrap-md';
import { appRoutes } from 'src/app/app.routes';
import { ApiService } from 'src/app/services/api.service';
import { DummyData } from 'src/app/services/dummy-data';
import { Location } from "@angular/common";

import { RecordListComponent } from './record-list.component';
import { of } from 'rxjs';

describe('RecordListComponent', () => {
  let component: RecordListComponent;
  let fixture: ComponentFixture<RecordListComponent>;

  let apiService: ApiService;
  let dummyData: DummyData;
  let spy: any;
  let location: Location;
  let router: Router;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        RecordListComponent,
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
    fixture = TestBed.createComponent(RecordListComponent);
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
    it('should set records  to all records in database', () => {
      const records  = dummyData.getRecords();
      spy = spyOn(apiService, 'getAllRecords').and.returnValue(of(records));

      component.ngOnInit();

      expect(component.records).toEqual(records);
      expect(component.mdbTable.getDataSource()).toEqual(records);
      expect(component.previous).toEqual(component.mdbTable.getDataSource());
    });

    describe('#navigateToNewRecordComponent', () => {
      it('should navigate to new-record-item component', fakeAsync(() => {
        component.navigateToNewRecordComponent();

        tick();
        expect(location.path()).toBe('/records/new');
      }));
    });

    describe('#navigateToRecordDetailsComponent', () => {
      it('should navigate to record-details component of the selected record', fakeAsync(() => {
        let recordId = 1;
        component.navigateToRecordDetailsComponent(recordId);

        tick();
        expect(location.path()).toBe(`/records/${recordId}`);
      }));
    });

    describe('#searchItems', () => {
      it('should only display record depending on the corporation', () => {
        const records = dummyData.getRecords();
        spy = spyOn(apiService, 'getAllRecords').and.returnValue(of(records));
        component.ngOnInit();

        component.searchText = 'eMenKa BV';
        fixture.detectChanges();

        expect(component.searchText).toBe('eMenKa BV')

        component.searchItems();
        expect(component.records).toEqual([dummyData.getRecords()[0]]);
      });

      it('should display all record if you empty the search bar', () => {
        const records = dummyData.getRecords();
        spy = spyOn(apiService, 'getAllRecords').and.returnValue(of(records));
        component.ngOnInit();

        component.searchText = 'eMenKa BV';
        fixture.detectChanges();
        component.searchText = '';
        fixture.detectChanges();

        component.searchItems();
        expect(component.records).toEqual(records);
      });
    });
  });
});
