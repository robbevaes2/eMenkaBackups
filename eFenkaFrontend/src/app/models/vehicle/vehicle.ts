import { Brand } from '../brand/brand';
import { Model } from '../model/model';
import { MotorType } from '../motor-type/motor-type';
import { DoorType } from '../door-type/door-type';
import { Serie } from '../serie/serie';

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
  licensePlate: string;
  endData: Date;
  isActive: boolean;
}
