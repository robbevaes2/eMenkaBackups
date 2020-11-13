import { Brand } from './brand';
import { Model } from './model';
import { MotorType } from './motor-type';
import { DoorType } from './door-type';
import { Serie } from './serie';

export class Vehicle {
  id: number;
  brand: Brand;
  model: Model;
  serie: Serie;
  fuelType: number;
  motorType: MotorType;
  doorType: DoorType;
  fuelCard: number;
  volume: number;
  fiscalePk: number;
  emission: number;
  power: number;
  endData: Date;
  isActive: boolean;
}
