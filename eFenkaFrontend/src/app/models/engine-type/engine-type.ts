import { Brand } from '../brand/brand';

export class EngineType {
  id: number;
  name: string;
  brand: Brand;

  constructor(id: number, name: string) {
    this.id = id;
    this.name = name;
  }
}
