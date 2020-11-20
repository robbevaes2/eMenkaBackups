import { Record } from './../../models/record/record';
import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Term } from '../../enums/term/term.enum';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Company } from 'src/app/models/company/company';
import { faCity } from '@fortawesome/free-solid-svg-icons';
import { Usage } from 'src/app/enums/usage/usage.enum';
import { Vehicle } from 'src/app/models/vehicle/vehicle';
import { Brand } from 'src/app/models/brand/brand';
import { Model } from 'src/app/models/model/model';
import { Serie } from 'src/app/models/serie/serie';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { Driver } from 'src/app/models/driver/driver';
import { Person } from '../../models/person/person';
import { Language } from '../../enums/language/language.enum';
import { Country } from 'src/app/models/country/country';
import { Corporation } from 'src/app/models/corporation/corporation';
import { CostAllocation } from 'src/app/models/cost-allocatoin/cost-allocation';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { DoorType } from 'src/app/models/door-type/door-type';
import { EngineType } from 'src/app/models/engine-type/engine-type';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.css']
})
export class RecordListComponent implements OnInit {
  records: Record[];

  headNames  = ['Nummerplaat', 'Bestuurder', 'Vennootschap', 'Kostenplaats', 'Merk', 'Wagen', 'Type', 'Gebruik', 'Eerse registartie', 'Einde'];
  headElements  = ['fuelCard.vehicle.licensePlate', 'fuelCard.driver.person.firstname', '', '', 'fuelCard.vehicle.brand.name', 'fuelCard.vehicle.model.name', 'term', '', '', 'usage', 'fuelCard.vehicle.fuelType.name', 'startDate', 'endDate'];

  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', { static: true }) row: ElementRef;

  searchText: string = '';
  previous: string;

  maxVisibleItems: number = 3;

  constructor(private router: Router, private cdRef: ChangeDetectorRef, private apiService: ApiService) { }

  ngOnInit(): void {
    this.apiService.getAllRecords().subscribe(data => {this.records = data; console.log(this.records);});

    this.mdbTable.setDataSource(this.records);
    this.records = this.mdbTable.getDataSource();
    this.previous = this.mdbTable.getDataSource();
  }

  ngAfterViewInit() {
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(this.maxVisibleItems);

    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    this.cdRef.detectChanges();
  }

  navigateToNewRecordComponent(): void {
    this.router.navigate(['/records/new']);
  }

  searchItems() {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
        this.mdbTable.setDataSource(this.previous);
        this.records = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
        this.records = this.mdbTable.searchLocalDataBy(this.searchText);
        this.mdbTable.setDataSource(prev);
    }
  }

  navigateToRecordDetailsComponent(index: number): void {
    this.router.navigate(['/records', index]);
  }

  getRecordDummyList(): Record[] {
    return [
      {
        id: 1,
        fuelCard: new FuelCard(1, 'feazfazefazefazef', this.getVehicle(), new Driver(1, this.getPerson(), null, null, null),
          null, new Date('2020-01-16'), new Date('2022-01-16'), true),
          corporation: new Corporation(1, 'test1', 't1', new Company(1, 'eMenKa', 'description', null, true, true, null, null, null),
          new Date('2022-01-16'), new Date('2022-01-16')),
        term: Term.Short,
        startDate: new Date('2020-01-16'),
        endDate: new Date('2022-01-16'),
        usage: Usage.Pool,
        costAllocatoin: new CostAllocation(1, 'Gent', 'VL', new Date('2022-01-20'), new Date('2022-01-20'))
      },
      {
        id: 2,
        fuelCard: new FuelCard(2, 'feazfazefazefazef', this.getVehicle(), new Driver(1, this.getPerson(), null, null, null),
          null, new Date('2020-01-20'), new Date('2022-01-20'), true),
        corporation: new Corporation(2, 'test2', 't2', new Company(2, 'PXL', 'description', null, true, true, null, null, null),
         new Date('2022-01-16'), new Date('2022-01-16')),
        term: Term.Long,
        startDate: new Date('2020-01-20'),
        endDate: new Date('2022-01-20'),
        usage: Usage.Definitive,
        costAllocatoin: new CostAllocation(1, 'Gent', 'VL', new Date('2022-01-20'), new Date('2022-01-20'))
      }
    ]
  }

  getVehicle(): Vehicle {
    return {
      id: 1,
      brand: new Brand(1, 'BMW'),
      model: new Model(1, 'M4'),
      serie: new Serie(1, 'Eco'),
      fuelType: new FuelType(1, 'Benzine'),
      engineType: new EngineType(1, '1.9 JTD'),
      doorType: new DoorType(1, '5-deurs'),
      fuelCard: new FuelCard(1, null, null, null, null, null, null, true),
      volume: 2000,
      fiscalHP: 50,
      emission: 1,
      power: 300,
      licensePlate: '1-abc-123',
      endDateDelivery: new Date('2020-01-16'),
      isActive: true,
      chassis: 'feoipajfpoaezfjipio',
      registrationDate: new Date('2020-01-16'),
      country: new Country(1, 'België', 'BE', 'Belg', false, true),
      buildYear: 2012,
      kilometers: 5000,
      engineCapacity: null,
      enginePower: null,
      category: null,
      averageFuel: null
    };
  }

  getPerson(): Person {
    return {
      id: 1,
      firstname: 'Joske',
      lastname: 'Termalen',
      birthDate: new Date('1999-02-22'),
      language: Language.Dutch,
      driversLicenseNumber: null,
      driversLicenseType: null,
      startDateDriversLicense: null,
      endDateDriversLicense: null,
      gender: null,
      title: null
    }
  }

}
