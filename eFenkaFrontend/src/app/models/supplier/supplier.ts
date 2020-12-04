import { Type } from '@angular/core';

export class Supplier {
  id: number;
  name: string;
  active: boolean;
  internal: boolean;
  types: any[];

  constructor(id: number, name: string, active: boolean, internal: boolean) {
    this.id = id;
    this.name = name;
    this.active = active;
    this.internal = internal;
  }
}
