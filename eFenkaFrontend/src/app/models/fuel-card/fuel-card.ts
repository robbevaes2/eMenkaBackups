import {Record} from '../record/record';
import {Driver} from '../driver/driver';
import {Vehicle} from '../vehicle/vehicle';
import {Company} from '../company/company';
import {FuelType} from '../fuel-type/fuel-type';

export class FuelCard {
  id: number;
  fuelCardNumber: string;
  vehicle: Vehicle;
  driver: Driver;
  record: Record;
  company: Company;
  fuelType: FuelType;
  startDate: Date;
  endDate: Date;
  isActive: boolean;
  blockingDate: Date;
  blockingReason: string;
  isBlocked: boolean;
  pinCode: string;

  constructor(id: number, fuelCardNumber: string, vehicle: Vehicle, driver: Driver,
              record: Record, company: Company, startDate: Date, endDate: Date, isActive: boolean) {
    this.id = id;
    this.fuelCardNumber = fuelCardNumber;
    this.vehicle = vehicle;
    this.driver = driver;
    this.record = record;
    this.company = company;
    this.startDate = startDate;
    this.endDate = endDate;
    this.isActive = isActive;
  }
}
