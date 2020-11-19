import { Brand } from '../brand/brand';
import { Model } from '../model/model';
import { MotorType } from '../motor-type/motor-type';
import { DoorType } from '../door-type/door-type';
import { Serie } from '../serie/serie';
import { FuelType } from '../FuelType/fuel-type';

export class Vehicle {
  id: number;
  brand: Brand;
  model: Model;
  serie: Serie;
  fuelType: FuelType;
  motorType: MotorType;
  doorType: DoorType;
  fuelCard: number;
  volume: number;
  fiscalePk: number;
  emission: number;
  power: number;
  licensePlate: string;
  endData: Date;
  isActive: boolean;
}
