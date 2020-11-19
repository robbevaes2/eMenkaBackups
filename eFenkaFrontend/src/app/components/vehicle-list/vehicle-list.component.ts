import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { Vehicle } from '../../models/vehicle/vehicle';
import { from } from 'rxjs';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { VehicleService } from '../../services/vehicle-service';
import { EngineType } from 'src/app/models/engine-type/engine-type';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];
  pageAmounts = [5,10,25];

  ascDescBoolean: boolean;

  page = 1;
  selectedAmount = 5;

  constructor(private router: Router, private vehicleService: VehicleService) { }

  ngOnInit(): void {
    //this.vehicles = this.getVehicleDummyList();
    this.vehicleService.getAllVehicles().subscribe(data => {
      this.vehicles = data;
      console.log(data);
    });
  }

  navigateToNewVehicleComponent(): void {
    this.router.navigate(['/vehicles/new']);
  }

  navigateToVehicleDetailsComponent(index: number): void {
    this.router.navigate(['/vehicles', index]);
  }

  getVehicleDummyList(): Vehicle[] {
      return [
        {
          id: 1,
          brand: new Brand(1, 'BMW'),
          model: new Model(1, 'M4'),
          fuelType: new FuelType(1, 'Benzine'),
          engineType: new EngineType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, null, null, null, null, null, true),
          volume: 2000,
          fiscalHp: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endDataDelivery: new Date('2020-01-16'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null
        },
        {
          id: 2,
          brand: new Brand(2, 'Mercedes'),
          model: new Model(2, 'AMG GTR'),
          fuelType: new FuelType(2, 'Diesel'),
          engineType: new EngineType(2, '1.9 JTD'),
          doorType: new DoorType(2, '3-deurs'),
          fuelCard: new FuelCard(1, null, null, null, null, null, true),
          volume: 2000,
          fiscalHp: 50,
          emission: 3,
          power: 400,
          licensePlate: '1-abc-124',
          endDataDelivery: new Date('2020-12-20'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null
        },
        {
          id: 3,
          brand: new Brand(2, 'Audi'),
          model: new Model(2, 'RS7'),
          fuelType: new FuelType(2, 'Diesel'),
          engineType: new EngineType(2, '1.9 JTD'),
          doorType: new DoorType(2, '5-deurs'),
          fuelCard: new FuelCard(1, null, null, null, null, null, true),
          volume: 2000,
          fiscalHp: 50,
          emission: 3,
          power: 400,
          licensePlate: '1-abc-124',
          endDataDelivery: new Date('2020-12-20'),
          isActive: true,
          chassis: 'feoipajfpoaezfjipio',
          registrationDate: new Date('2020-01-16'),
          engineCapacity: null,
          enginePower: null,
          category: null,
          averageFuel: null
        }
      ];
  }

  switchPage(event): void {
    this.page = event;
  }

  sortByBrand() {
    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const name1 = t1.brand.name.toLowerCase();
        const name2 = t2.brand.name.toLowerCase();
        if (name2 > name1) { return 1; }
        if (name2 < name1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const name1 = t1.brand.name.toLowerCase();
        const name2 = t2.brand.name.toLowerCase();
        if (name1 > name2) { return 1; }
        if (name1 < name2) { return -1; }
        return 0;
      });
    }
  }

  sortByDate() {
    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const date1 = t1.endDataDelivery;
        const date2 = t2.endDataDelivery;

        if (date2 > date1) { return 1; }
        if (date2 < date1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const date1 = t1.endDataDelivery;
        const date2 = t2.endDataDelivery;
        if (date1 > date2) { return 1; }
        if (date1 < date2) { return -1; }
        return 0;
      });
    }

  }
}
