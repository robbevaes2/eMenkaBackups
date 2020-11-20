import { Model } from '../model/model';
import { Serie } from '../serie/serie';
import { ExteriorColor } from '../exterior-color/exterior-color';
import { InteriorColor } from '../interior-color/interior-color';
import { EngineType } from '../engine-type/engine-type';

export class Brand {
  id: number;
  name: string;
  models: Model[];
  series: Serie[];
  engineTypes: EngineType[];
  exteriorColors: ExteriorColor[];
  interiorColors: InteriorColor[];

  constructor(id: number, name: string) {
    this.id = id;
    this.name = name;
  }
}
