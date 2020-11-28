export class Country {
  id: number;
  name: string;
  code: string;
  nationality: string;
  POD: boolean;
  isActive: boolean;

  constructor(id: number, name: string, code: string, nationality: string, POD: boolean, isActive: boolean){
    this.id = id;
    this.name = name;
    this.code = code;
    this.nationality = nationality;
    this.POD = POD;
    this.isActive = isActive;
  }
}
