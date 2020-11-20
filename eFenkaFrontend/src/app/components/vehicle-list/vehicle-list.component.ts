import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { MotorType } from '../../models/motor-type/motor-type';
import { Serie } from '../../models/serie/serie';
import { Vehicle } from '../../models/vehicle/vehicle';
import { from } from 'rxjs';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Country } from 'src/app/models/country/country';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];
  headNames  = ["Merk", "Model", "brandstof", "type motor", "aantal deuren", "volume", "fiscale Pk", "vermogen", "Einddatum"];
  headElements  = ["brand.name", "model.name", "fuelType.name", "motorType.name", "doorType.name", "volume", "fiscalePk", "power", "endData"];

  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', { static: true }) row: ElementRef;

  searchText: string = '';
  previous: string;

  maxVisibleItems: number = 3;

  constructor(private router: Router, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.vehicles = this.getVehicleDummyList();

    this.mdbTable.setDataSource(this.vehicles);
    this.vehicles = this.mdbTable.getDataSource();
    this.previous = this.mdbTable.getDataSource();
  }

  ngAfterViewInit() {
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(this.maxVisibleItems);

    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    this.cdRef.detectChanges();
  }

  navigateToNewVehicleComponent(): void {
    this.router.navigate(['/vehicles/new']);
  }

  navigateToVehicleDetailsComponent(index: number): void {
    this.router.navigate(['/vehicles', index]);
  }

  searchItems() {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
        this.mdbTable.setDataSource(this.previous);
        this.vehicles = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
        this.vehicles = this.mdbTable.searchLocalDataBy(this.searchText);
        this.mdbTable.setDataSource(prev);
    }
  }

  getVehicleDummyList(): Vehicle[] {
      return [
        {
          id: 1,
          brand: new Brand(1, 'BMW'),
          model: new Model(1, 'M4'),
          serie: new Serie(1, 'Eco'),
          fuelType: new FuelType(1, 'Benzine'),
          motorType: new MotorType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscaleHp: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endData: new Date('2020-01-16'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          country: new Country(1, 'België', 'BE', 'Belg', false, true),
          buildYear: 2012,
          kilometers: 5000
        },
        {
          id: 2,
          brand: new Brand(2, 'Mercedes'),
          model: new Model(2, 'AMG GTR'),
          serie: new Serie(2, 'Sport'),
          fuelType: new FuelType(2, 'Diesel'),
          motorType: new MotorType(2, '1.9 JTD'),
          doorType: new DoorType(2, '3-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscaleHp: 50,
          emission: 3,
          power: 400,
          licensePlate: '1-abc-124',
          endData: new Date('2020-12-20'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          country: new Country(1, 'België', 'BE', 'Belg', false, true),
          buildYear: 2012,
          kilometers: 5000
        },
        {
          id: 3,
          brand: new Brand(2, 'Audi'),
          model: new Model(2, 'RS7'),
          serie: new Serie(2, 'Sport'),
          fuelType: new FuelType(2, 'Diesel'),
          motorType: new MotorType(2, '1.9 JTD'),
          doorType: new DoorType(2, '5-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscaleHp: 50,
          emission: 3,
          power: 500,
          licensePlate: '1-abc-124',
          endData: new Date('2020-12-20'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          country: new Country(1, 'België', 'BE', 'Belg', false, true),
          buildYear: 2012,
          kilometers: 5000
        }
      ];
  }
}
