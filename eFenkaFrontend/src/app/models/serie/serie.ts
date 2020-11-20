import { Brand } from '../brand/brand';
export class Serie {
  id: number;
  name: string;
  brand: Brand;

  constructor(id: number, name: string) {
    this.id = id;
    this.name = name;
  }
}
