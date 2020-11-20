import { Record } from './../../models/record/record';
import { Component, OnInit } from '@angular/core';
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
import { DoorType } from 'src/app/models/door-type/door-type';
import { EngineType } from 'src/app/models/engine-type/engine-type';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.css']
})
export class RecordListComponent implements OnInit {
  records: Record[];
  pageAmounts = [5, 10, 25];

  ascDescBoolean: boolean;

  page = 1;
  selectedAmount = this.pageAmounts[0];

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.records = this.getRecordDummyList();
  }

  navigateToNewRecordComponent(): void {
    this.router.navigate(['/records/new']);
  }

  navigateToRecordDetailsComponent(index: number): void {
    this.router.navigate(['/records', index]);
  }

  switchPage(event): void {
    this.page = event;
  }

  getRecordDummyList(): Record[] {
    return [
      {
        id: 1,
        fuelCard: new FuelCard(1, 'feazfazefazefazef', this.getVehicle(), new Driver(1, this.getPerson(), null, null, null),
          null, new Date('2020-01-16'), new Date('2022-01-16'), true),
          corporation: new Corporation(1, 'test1', 't1', new Company(1, 'eMenKa', 'description', null, true, true, null, null, null),
          new Date('2022-01-16'), new Date('2022-01-16')),
        city: 'Hasselt',
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
        city: 'Hasselt',
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

  isUndefined() {
    if (this.ascDescBoolean == undefined) {
      this.ascDescBoolean = true;
    }
  }

  sort(type: string) {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.records.sort((t1, t2) => {
        const value1 = t1[type];
        const value2 = t2[type];

        console.log(type);

        if (value2 > value1) { return 1; }
        if (value2 < value1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.records.sort((t1, t2) => {
        const value1 = t1[type];
        const value2 = t2[type];

        if (value2 < value1) { return 1; }
        if (value2 > value1) { return -1; }
        return 0;
      });
    }
  }
}
