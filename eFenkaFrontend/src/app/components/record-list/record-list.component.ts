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
import { MotorType } from 'src/app/models/motor-type/motor-type';
import { Driver } from 'src/app/models/driver/driver';
import { Person } from '../../models/person/person';
import { Language } from '../../enums/language/language.enum';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.css']
})
export class RecordListComponent implements OnInit {
  records: Record[];

  page = 1;
  pageSize = 1;

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

  handlePageSizeChange(event): void {
    this.pageSize = event.target.value;
    this.page = 1;
    console.log(event.target.value);
    console.log(this.pageSize);
  }

  getRecordDummyList(): Record[] {
    return [
      {
        id: 1,
        fuelCard: new FuelCard(1, this.getVehicle(), new Driver(1, this.getPerson(), null, null, null),
          null, new Date('2020-01-16'), new Date('2022-01-16'), true),
        company: new Company(1, 'eMenKa', 'description', null, true, true, null, null, null),
        city: 'Hasselt',
        term: Term.Short,
        startDate: new Date('2020-01-16'),
        endDate: new Date('2022-01-16'),
        usage: Usage.Pool
      },
      {
        id: 2,
        fuelCard: new FuelCard(2, this.getVehicle(), new Driver(1, this.getPerson(), null, null, null),
          null, new Date('2020-01-20'), new Date('2022-01-20'), true),
        company: new Company(2, 'PXL', 'description', null, true, true, null, null, null),
        city: 'Hasselt',
        term: Term.Long,
        startDate: new Date('2020-01-20'),
        endDate: new Date('2022-01-20'),
        usage: Usage.Definitive
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
      motorType: new MotorType(1, '1.9 JTD'),
      doorType: new MotorType(1, '5-deurs'),
      fuelCard: new FuelCard(1, null, null, null, null, null, true),
      volume: 2000,
      fiscalePk: 50,
      emission: 1,
      power: 300,
      licensePlate: '1-abc-123',
      endData: new Date('2020-01-16'),
      isActive: true
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
