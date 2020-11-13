import { Component, OnInit } from '@angular/core';
import { Brand } from '../models/brand';
import { DoorType } from '../models/door-type';
import { Model } from '../models/model';
import { MotorType } from '../models/motor-type';
import { Serie } from '../models/serie';
import { Vehicle } from '../models/vehicle';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];

  constructor() { }

  ngOnInit(): void {
    this.vehicles = this.getVehicleDummyList();
  }

  getVehicleDummyList(): Vehicle[] {
      return [
        {
          id: 1,
          brand: new Brand(1, 'BMW'),
          model: new Model(1, 'M4'),
          serie: new Serie(1, 'Eco'),
          fuelType: 1,
          motorType: new MotorType(1, '1.9 JTD'),
          doorType: new DoorType(1, '5-deurs'),
          fuelCard: 1,
          volume: 2000,
          fiscalePk: 50,
          emission: 1,
          power: 300,
          endData: new Date('2020-01-16'),
          isActive: true
        },
        {
          id: 1,
          brand: new Brand(2, 'Mercedes'),
          model: new Model(2, 'AMG GTR'),
          serie: new Serie(2, 'Sport'),
          fuelType: 1,
          motorType: new MotorType(2, '1.9 JTD'),
          doorType: new DoorType(2, '3-deurs'),
          fuelCard: 1,
          volume: 2000,
          fiscalePk: 50,
          emission: 1,
          power: 400,
          endData: new Date('2020-12-20'),
          isActive: true
        }
      ];
  }
}
