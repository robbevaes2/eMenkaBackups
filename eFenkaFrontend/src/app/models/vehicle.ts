import { Brand } from './brand';
import { Model } from './model';
import { MotorType } from './motor-type';
import { DoorType } from './door-type';

export class Vehicle {
  id: number;
  brand: Brand;
  model: Model;
  motorType: MotorType;
  doorType: DoorType;
  volume: number;
  fiscalePk: number;
  emission: number;
  power: number;
  endData: Date;
  isActive: boolean;
}
