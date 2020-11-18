import { Term } from 'src/app/enums/term/term.enum';
import { Usage } from 'src/app/enums/usage/usage.enum';
import { Company } from '../company/company';
import { FuelCard } from './../fuel-card/fuel-card';

export class Record {
  id: number;
  fuelCard: FuelCard;
  company: Company;
  city: string;
  term: Term;
  startDate: Date;
  endDate: Date;
  usage: Usage;

  constructor(id: number, fuelCard: FuelCard, city: string, term: Term, startDate: Date, endDate: Date, usage: Usage) {
    this.id = id;
    this.fuelCard = fuelCard;
    this.city = city;
    this.term = term;
    this.startDate = startDate;
    this.endDate = endDate;
    this.usage = usage;
  }
}
