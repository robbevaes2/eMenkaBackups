import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { Vehicle } from '../../models/vehicle/vehicle';
import { from } from 'rxjs';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Country } from 'src/app/models/country/country';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { VehicleService } from '../../services/vehicle-service';
import { EngineType } from 'src/app/models/engine-type/engine-type';
import { ApiService } from '../../services/api.service';
import { Serie } from 'src/app/models/serie/serie';


@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];
  headNames  = ["Merk", "Model", "brandstof", "type motor", "aantal deuren", "volume", "fiscale Pk", "vermogen", "Einddatum"];
  headElements  = ["brand.name", "model.name", "fuelType.name", "motorType.name", "doorType.name", "volume", "fiscalHP", "power", "endDateDelivery"];

  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', { static: true }) row: ElementRef;

  searchText: string = '';
  previous: string;

  maxVisibleItems: number = 3;

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.apiService.getAllVehicles().subscribe(data => this.vehicles = data);
    //this.vehicles = this.getVehicleDummyList();

  }

  ngAfterViewInit() {

    this.mdbTable.setDataSource(this.vehicles);
    this.vehicles = this.mdbTable.getDataSource();
    this.previous = this.mdbTable.getDataSource();
    /*
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(this.maxVisibleItems);

    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    */
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
          model: new Model(1, 'M5'),
          fuelType: new FuelType(1, 'Benzine'),
          engineType: new EngineType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscalHP: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endDateDelivery: new Date('2020-01-16'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null,
          serie: new Serie(1, 'test'),
          country: new Country(1, 'test', 'set', 'test', true, true),
          buildYear: 1990,
          kilometers: 100000
        },
        {
          id: 2,
          brand: new Brand(1, 'BMW'),
          model: new Model(1, 'M4'),
          fuelType: new FuelType(1, 'Benzine'),
          engineType: new EngineType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscalHP: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endDateDelivery: new Date('2020-01-16'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null,
          serie: new Serie(1, 'test'),
          country: new Country(1, 'test', 'set', 'test', true, true),
          buildYear: 1990,
          kilometers: 100000
        },
        {
          id: 3,
          brand: new Brand(1, 'BMW'),
          model: new Model(1, 'M4'),
          fuelType: new FuelType(1, 'Benzine'),
          engineType: new EngineType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
          volume: 2000,
          fiscalHP: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endDateDelivery: new Date('2020-01-16'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null,
          serie: new Serie(1, 'test'),
          country: new Country(1, 'test', 'set', 'test', true, true),
          buildYear: 1990,
          kilometers: 100000
        }
      ];
  }

  dateToStringConverter(date: string) {
    return new Date(date).toLocaleDateString();
  }
}
