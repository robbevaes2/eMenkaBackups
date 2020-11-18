export class Company {
  id: number;
  name: string;
  description: string;
  reference: string;
  isInternal: boolean;
  isActive: boolean;
  nonActiveRemark: string;
  VAT: string;
  accountNumber: string;

  constructor(id: number, name: string, description: string, reference: string, isInternal: boolean, isActive: boolean,
              nonActiveRemark: string, VAT: string, accountNumber: string) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.reference = reference;
    this.isInternal = isInternal;
    this.isActive = isActive;
    this.nonActiveRemark = nonActiveRemark;
    this.VAT = VAT;
    this.accountNumber = accountNumber;
  }
}
