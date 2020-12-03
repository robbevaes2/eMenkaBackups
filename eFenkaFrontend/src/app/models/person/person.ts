import {Language} from '../../enums/language/language.enum';

export class Person {
  id: number;
  firstname: string;
  lastname: string;
  birthDate: Date;
  language: Language;
  driversLicenseNumber: string;
  driversLicenseType: string;
  startDateDriversLicense: Date;
  endDateDriversLicense: Date;
  gender: string;
  title: string;
  picture: Int8Array;

  constructor(id: number, firstname: string, lastname: string, birthDate: Date, language: Language,
              driversLicenseNumber: string, driversLicenseType: string, startDateDriversLicense: Date, endDateDriversLicense: Date,
              gender: string, title: string) {
    this.id = id;
    this.firstname = firstname;
    this.lastname = lastname;
    this.birthDate = birthDate;
    this.language = language;
    this.driversLicenseNumber = driversLicenseNumber;
    this.driversLicenseType = driversLicenseType;
    this.startDateDriversLicense = startDateDriversLicense;
    this.endDateDriversLicense = endDateDriversLicense;
    this.gender = gender;
    this.title = title;
  }

}
