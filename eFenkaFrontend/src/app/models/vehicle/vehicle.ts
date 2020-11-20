import { Brand } from '../brand/brand';
import { Model } from '../model/model';
import { DoorType } from '../door-type/door-type';
import { Serie } from '../serie/serie';
import { FuelType } from '../fuel-type/fuel-type';
import { FuelCard } from '../fuel-card/fuel-card';
import { EngineType } from '../engine-type/engine-type';
import { Category } from '../category/category';
import { Country } from '../country/country';

export class Vehicle {
  id: number;
  brand: Brand;
  model: Model;
  serie: Serie;
  fuelType: FuelType;
  engineType: EngineType;
  engineCapacity: number;
  enginePower: number;
  doorType: DoorType;
  fuelCard: FuelCard;
  volume: number;
  category: Category;
  fiscalHP: number;
  emission: number;
  power: number;
  licensePlate: string;
  endDateDelivery: Date;
  isActive: boolean;
  chassis: string;
  registrationDate: Date;
  country: Country;
  buildYear: number;
  kilometers: number;
  averageFuel: number;
}
