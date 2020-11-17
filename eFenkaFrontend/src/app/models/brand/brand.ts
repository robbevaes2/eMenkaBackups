import { Model } from '../model/model';
import { Serie } from '../serie/serie';
import { MotorType } from '../motor-type/motor-type';
import { ExteriorColor } from '../exterior-color/exterior-color';
import { InteriorColor } from '../interior-color/interior-color';

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
