import { Company } from '../company/company';

export class Corporation {
  id: number;
  name: string;
  abbreviation: string;
  company: Company;
  startDate: Date;
  endDate: Date;

  constructor(id: number, name: string, abbreviation: string, company: Company, startDate: Date, endDate: Date) {
    this.id = id;
    this.name = name;
    this.abbreviation = abbreviation;
    this.company = company;
    this.startDate = startDate;
    this.endDate = endDate;
  }
}
