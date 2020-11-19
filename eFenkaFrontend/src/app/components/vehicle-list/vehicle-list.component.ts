import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { MotorType } from '../../models/motor-type/motor-type';
import { Serie } from '../../models/serie/serie';
import { Vehicle } from '../../models/vehicle/vehicle';
import { from } from 'rxjs';
import { FuelType } from 'src/app/models/FuelType/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];

  page = 1;
  pageSize = 1;

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.vehicles = this.getVehicleDummyList();
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
          serie: new Serie(1, 'Eco'),
          fuelType: new FuelType(1, 'Benzine'),
          motorType: new MotorType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: new FuelCard(1, null, null, null, null, null, true),
          volume: 2000,
          fiscalePk: 50,
          emission: 1,
          power: 300,
          licensePlate: '1-abc-123',
          endData: new Date('2020-01-16'),
          isActive: true
        },
        {
          id: 2,
          brand: new Brand(2, 'Mercedes'),
          model: new Model(2, 'AMG GTR'),
          serie: new Serie(2, 'Sport'),
          fuelType: new FuelType(2, 'Diesel'),
          motorType: new MotorType(2, '1.9 JTD'),
          doorType: new DoorType(2, '3-deurs'),
          fuelCard: new FuelCard(1, null, null, null, null, null, true),
          volume: 2000,
          fiscalePk: 50,
          emission: 3,
          power: 400,
          licensePlate: '1-abc-124',
          endData: new Date('2020-12-20'),
          isActive: true
        }
      ];
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
}
