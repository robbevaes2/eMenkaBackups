import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Gender } from 'src/app/enums/gender/gender.enum';
import { Language } from 'src/app/enums/language/language.enum';
import { ApiService } from 'src/app/services/api.service';
import { Driver } from '../../models/driver/driver';
import { DatePipe } from '@angular/common';
import { fromToDate } from 'src/app/services/from-to-date.validator';
import { birthDateValidator } from 'src/app/services/birthdate.validator';

@Component({
  selector: 'app-driver-details',
  templateUrl: './driver-details.component.html',
  styleUrls: ['./driver-details.component.css']
})
export class DriverDetailsComponent implements OnInit {
  form: FormGroup;
  genders = Object.values(Gender).filter(value => typeof value === 'string');
  languages = Object.values(Language).filter(value => typeof value === 'string');
  selectedDriver: Driver;
  isEditable: boolean;

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService, private datePipe: DatePipe) { }

  ngOnInit(): void {
    const driverId = this.route.snapshot.params.index;
    this.apiService.getDriverById(driverId).subscribe(data => {

      this.selectedDriver = data;
      console.log(this.selectedDriver);

      this.form = new FormGroup({
        title: new FormControl(null, [Validators.required]),
        firstName: new FormControl(null, [Validators.required]),
        lastName: new FormControl(null, [Validators.required]),
        birthDate: new FormControl(null, [Validators.required, birthDateValidator]),
        gender: new FormControl(null, [Validators.required]),
        language: new FormControl(null, [Validators.min(0)]),
        driverLicenseNumber: new FormControl(null, [Validators.required]),
        driverLicenseType: new FormControl(null, [Validators.required]),
        duration: new FormGroup({
          startDate: new FormControl(null, [Validators.required]),
          endDate: new FormControl(null, [Validators.required])
        }, {validators: fromToDate})
      });

      this.fillForm();
      this.disableForm();
    });
  }

  fillForm(): void {
    this.form.controls.title.setValue(this.selectedDriver.person.title);
    this.form.controls.firstName.setValue(this.selectedDriver.person.firstname);
    this.form.controls.lastName.setValue(this.selectedDriver.person.lastname);
    this.form.controls.birthDate.setValue(this.datePipe.transform(new Date(this.selectedDriver.person.birthDate), 'yyyy-MM-dd'));

    if (this.selectedDriver.person.gender === 'M') {
      this.form.controls.gender.setValue('Man');
    } else if (this.selectedDriver.person.gender === 'V') {
      this.form.controls.gender.setValue('Vrouw');
    } else if (this.selectedDriver.person.gender === 'A') {
      this.form.controls.gender.setValue('Ander');
    }

    this.form.controls.language.setValue(this.selectedDriver.person.language);
    this.form.controls.driverLicenseNumber.setValue(this.selectedDriver.person.driversLicenseNumber);
    this.form.controls.driverLicenseType.setValue(this.selectedDriver.person.driversLicenseType);
    this.form.controls.duration.patchValue({
      startDate: this.datePipe.transform(new Date(this.selectedDriver.startDate), 'yyyy-MM-dd'),
      endDate: this.datePipe.transform(new Date(this.selectedDriver.endDate), 'yyyy-MM-dd')
    });
  }

  disableForm(): void {
    this.form.controls.title.disable();
    this.form.controls.firstName.disable();
    this.form.controls.lastName.disable();
    this.form.controls.birthDate.disable();
    this.form.controls.gender.disable();
    this.form.controls.language.disable();
    this.form.controls.driverLicenseNumber.disable();
    this.form.controls.driverLicenseType.disable();
    this.form.controls.duration.get('startDate').disable();
    this.form.controls.duration.get('endDate').disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.title.enable();
    this.form.controls.firstName.enable();
    this.form.controls.lastName.enable();
    this.form.controls.birthDate.enable();
    this.form.controls.gender.enable();
    this.form.controls.language.enable();
    this.form.controls.driverLicenseNumber.enable();
    this.form.controls.driverLicenseType.enable();
    this.form.controls.duration.get('startDate').enable();
    this.form.controls.duration.get('endDate').enable();
    this.isEditable = true;
  }

  navigateToListDriverComponent(): void {
    this.router.navigate(['/drivers']);
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
      id: this.selectedDriver.person.id,
      title: values.title,
      firstName:  values.firstName,
      lastName:  values.lastName,
      birthDate:  values.birthDate,
      gender:  values.gender,
      language:  Number(values.language),
      driversLicenseNumber: values.driverLicenseNumber,
      driversLicenseType: values.driverLicenseType,
      startDateDriversLicense: values.duration.startDate,
      endDateDriversLicense: values.duration.endDate
    };
  }

  mapToDriverModel(values: any, personId: number): any {
    return {
      id: this.selectedDriver.id,
      personId,
      startDate:  values.duration.startDate,
      endDate:  values.duration.endDate
    };
  }

  saveEditDriver(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u deze bestuurder wilt opslaan?')) {
        this.apiService.updatePerson(this.selectedDriver.person.id, this.mapToPersonModel(form.value)).subscribe(() => {
          const driverModel = this.mapToDriverModel(form.value, this.selectedDriver.person.id);

          this.apiService.updateDriver(this.selectedDriver.id, driverModel).subscribe(() => {
            this.apiService.getDriverById(this.selectedDriver.id).subscribe(data => {
              this.selectedDriver = data;
              this.fillForm();
              this.disableForm();
            });
          });
        });
      }
    } else {
      this.enableForm();
    }
  }

  deleteDriver(): void {
    if (confirm('Bent u zeker dat u deze bestuurder wilt verwijderen?')) {
      this.apiService.deleteDriver(this.selectedDriver.id).subscribe(() => this.navigateToListDriverComponent());
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
  }
}
