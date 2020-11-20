import { Brand } from '../brand/brand';

export class ExteriorColor {
  id: number;
  name: string;
  code: string;
  brand: Brand;

  constructor(id: number, name: string) {
    this.id = id;
    this.name = name;
  }
}
