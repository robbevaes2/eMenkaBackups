export class CostAllocation {
  id: number;
  name: string;
  abbreviation: string;
  startDate: Date;
  endDate: Date;

  constructor(id: number, name: string, abbreviation: string, startDate: Date, endDate: Date) {
    this.id = id;
    this.name = name;
    this.abbreviation = abbreviation;
    this.startDate = startDate;
    this.endDate = endDate;
  }
}
