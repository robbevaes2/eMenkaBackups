import { Term } from 'src/app/enums/term/term.enum';
import { Usage } from 'src/app/enums/usage/usage.enum';
import { Corporation } from '../corporation/corporation';
import { CostAllocation } from '../cost-allocatoin/cost-allocation';
import { FuelCard } from './../fuel-card/fuel-card';

export class Record {
  id: number;
  fuelCard: FuelCard;
  corporation: Corporation;
  costAllocation: CostAllocation;
  term: Term;
  startDate: Date;
  endDate: Date;
  usage: Usage;

  constructor(id: number, fuelCard: FuelCard, corporatoin: Corporation, term: Term, startDate: Date, endDate: Date,
              usage: Usage, costAllocation: CostAllocation) {
    this.id = id;
    this.fuelCard = fuelCard;
    this.corporation = corporatoin;
    this.term = term;
    this.startDate = startDate;
    this.endDate = endDate;
    this.usage = usage;
    this.costAllocation = costAllocation;
  }
}
