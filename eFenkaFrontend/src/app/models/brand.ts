import { Model } from './model';
import { Serie } from './serie';
import { MotorType } from './motor-type';
import { ExteriorColor } from './exterior-color';
import { InteriorColor } from './interior-color';

export class Brand {
  id: number;
  name: string;
  models: Model[];
  series: Serie[];
  motorTypes: MotorType[];
  exteriorColors: ExteriorColor[];
  interiorColors: InteriorColor[];

  constructor(id: number, name: string) {
    this.id = id;
    this.name = name;
  }
}
