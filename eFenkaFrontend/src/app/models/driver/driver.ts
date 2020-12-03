import {FuelCard} from './../fuel-card/fuel-card';
import {Person} from '../person/person';

export class Driver {
  id: number;
  person: Person;
  fuelCard: FuelCard;
  startDate: Date;
  endDate: Date;

  constructor(id: number, person: Person, fuelCard: FuelCard, startDate: Date, endDate: Date) {
    this.id = id;
    this.person = person;
    this.fuelCard = fuelCard;
    this.startDate = startDate;
    this.endDate = endDate;
  }
}
