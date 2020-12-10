import {Language} from '../../enums/language/language.enum';
import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {ApiService} from 'src/app/services/api.service';
import {Gender} from '../../enums/gender/gender.enum';
import { fromToDate } from 'src/app/services/from-to-date.validator';
import { birthDateValidator } from 'src/app/services/birthdate.validator';

@Component({
  selector: 'app-new-driver-item',
  templateUrl: './new-driver-item.component.html',
  styleUrls: ['./new-driver-item.component.css']
})
export class NewDriverItemComponent implements OnInit {
  form: FormGroup;
  genders = Object.values(Gender).filter(value => typeof value === 'string');
  languages = Object.values(Language).filter(value => typeof value === 'string');

  constructor(private router: Router, private apiService: ApiService) {
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      title: new FormControl(null, [Validators.required]),
      firstName: new FormControl(null, [Validators.required]),
      lastName: new FormControl(null, [Validators.required]),
      birthDate: new FormControl(null, [Validators.required, birthDateValidator]),
      gender: new FormControl(null, [Validators.required]),
      language: new FormControl(null, [Validators.required]),
      driverLicenseNumber: new FormControl(null, [Validators.required]),
      driverLicenseType: new FormControl(null, [Validators.required]),
      duration: new FormGroup({
        startDate: new FormControl(null, [Validators.required]),
        endDate: new FormControl(null, [Validators.required]),
      }, {validators: fromToDate}),
    });
  }

  mapToPersonModel(values: any): any {
    if (values?.gender === 'Man') {
      values.gender = 'M';
    } else if (values?.gender === 'Vrouw') {
      values.gender = 'V';
    } else if (values?.gender === 'Ander') {
      values.gender = 'A';
    }

    return {
      title: values.title,
      firstName: values.firstName,
      lastName: values.lastName,
      birthDate: new Date(values.birthDate).toISOString(),
      gender: values.gender,
      language: Number(values.language),
      driversLicenseNumber: values.driverLicenseNumber,
      driversLicenseType: values.driverLicenseType,
      startDateDriversLicense: new Date(values.duration.startDate).toISOString(),
      endDateDriversLicense: new Date(values.duration.endDate).toISOString()
    };
  }

  mapToDriverModel(values: any, personId: number): any {
    return {
      personId,
      startDate: new Date(values.duration.startDate).toISOString(),
      endDate: new Date(values.duration.endDate).toISOString()
    };
  }

  navigateToListDriverComponent(): void {
    this.router.navigate(['/drivers']);
  }

  saveNewDriver(form: FormGroup): void {
    const personModel = this.mapToPersonModel(form.value);

    if (confirm('Bent u zeker dat u deze bestuurder wilt opslaan?')) {
      this.apiService.addPerson(personModel).subscribe((model: any) => {
        const personId = Number(model.id);
        const driverModel = this.mapToDriverModel(form.value, personId);

        this.apiService.addDriver(driverModel).subscribe(() => this.navigateToListDriverComponent());
      });
    }
  }
}
