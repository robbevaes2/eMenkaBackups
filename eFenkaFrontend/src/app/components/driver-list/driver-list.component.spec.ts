import { DummyData } from './../../services/dummy-data';
import { ApiService } from 'src/app/services/api.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { MdbTableDirective } from 'angular-bootstrap-md';
import { DriverListComponent } from './driver-list.component';
import { of } from 'rxjs';

describe('DriverListComponent', () => {
  let component: DriverListComponent;
  let fixture: ComponentFixture<DriverListComponent>;
  let apiService: ApiService;
  let dummyData: DummyData;
  let spy: any;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        DriverListComponent,
        MdbTableDirective
      ],
      imports: [
        RouterTestingModule,
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
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('test', () => {
    const drivers = dummyData.getDrivers();
    spy = spyOn(apiService, 'getAllDrivers').and.returnValue(of(drivers))

    component.ngOnInit();

    expect(component.drivers).toEqual(drivers);
    expect(component.mdbTable.getDataSource()).toEqual(drivers);
    expect(component.previous).toEqual(component.mdbTable.getDataSource());
  })
});
