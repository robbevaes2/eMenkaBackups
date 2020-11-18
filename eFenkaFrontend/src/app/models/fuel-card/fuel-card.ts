import { Record } from './../record/record';
import { Driver } from '../driver/driver';
import { Vehicle } from '../vehicle/vehicle';

export class FuelCard {
  id: number;
  vehicle: Vehicle;
  driver: Driver;
  record: Record;
  startDate: Date;
  endDate: Date;
  isActive: boolean;

  constructor(id: number, vehicle: Vehicle, driver: Driver, record: Record, startDate: Date, endDate: Date, active: boolean) {
    this.id = id;
    this.vehicle = vehicle;
    this.driver = driver;
    this.record = record;
    this.startDate = startDate;
    this.endDate = endDate;
  }
}
