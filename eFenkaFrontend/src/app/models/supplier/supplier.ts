import { SupplierType } from '../../enums/supplier-type/supplier-type.enum';

export class Supplier {
  id: number;
  name: string;
  active: boolean;
  internal: boolean;
  types: number[];

  constructor(id: number, name: string, active: boolean, internal: boolean, types: SupplierType[]) {
    this.id = id;
    this.name = name;
    this.active = active;
    this.internal = internal;
    this.types = types;
  }
}
