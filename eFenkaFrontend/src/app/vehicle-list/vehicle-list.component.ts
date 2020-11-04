import { Component, OnInit } from '@angular/core';
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
          brand: null,
          model: null,
          motorType: null,
          doorType: null,
          volume: 1000,
          fiscalePk: 50,
          emission: 1,
          power: 90,
          endData: null,
          isActive: true
        },
        {
          id: 2,
          brand: null,
          model: null,
          motorType: null,
          doorType: null,
          volume: 1400,
          fiscalePk: 80,
          emission: 3,
          power: 110,
          endData: null,
          isActive: false
        }
      ];
  }
}
