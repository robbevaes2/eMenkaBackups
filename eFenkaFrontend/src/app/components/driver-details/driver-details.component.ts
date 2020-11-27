import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Gender } from 'src/app/enums/gender/gender.enum';
import { Language } from 'src/app/enums/language/language.enum';
import { ApiService } from 'src/app/services/api.service';
import { Driver } from '../../models/driver/driver';

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

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    const driverId = this.route.snapshot.params.index;
    this.apiService.getDriverById(driverId).subscribe(data => {

      this.selectedDriver = data;
      console.log(this.selectedDriver);

      this.form = new FormGroup({
        title: new FormControl(null, [Validators.required]),
        firstName: new FormControl(null, [Validators.required]),
        lastName: new FormControl(null, [Validators.required]),
        birthDate: new FormControl(null, [Validators.required]),
        gender: new FormControl(null, [Validators.required]),
        language: new FormControl(null, [Validators.min(0)]),
        driverLicenseNumber: new FormControl(null, [Validators.required]),
        driverLicenseType: new FormControl(null, [Validators.required]),
        startDate: new FormControl(null, [Validators.required]),
        endDate: new FormControl(null, [Validators.required])
      });

      this.fillForm();
      this.disableForm();
    });
  }

  fillForm(): void {
    this.form.controls.title.setValue(this.selectedDriver.person.title);
    this.form.controls.firstName.setValue(this.selectedDriver.person.firstname);
    this.form.controls.lastName.setValue(this.selectedDriver.person.lastname);
    this.form.controls.birthDate.setValue(new Date(this.selectedDriver.person.birthDate).toISOString().substring(0, 10));
    this.form.controls.gender.setValue(this.selectedDriver.person.gender);
    this.form.controls.language.setValue(this.selectedDriver.person.language);
    this.form.controls.driverLicenseNumber.setValue(this.selectedDriver.person.driversLicenseNumber);
    this.form.controls.driverLicenseType.setValue(this.selectedDriver.person.driversLicenseType);
    this.form.controls.startDate.setValue(new Date(this.selectedDriver.startDate).toISOString().substring(0, 10));
    this.form.controls.endDate.setValue(new Date(this.selectedDriver.endDate).toISOString().substring(0, 10));
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
    this.form.controls.startDate.disable();
    this.form.controls.endDate.disable();
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
    this.form.controls.startDate.enable();
    this.form.controls.endDate.enable();
    this.isEditable = true;
  }

  navigateToListDriverComponent(): void {
    this.router.navigate(['/drivers']);
  }

  mapToPersonModel(values: any): any {
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
      startDateDriversLicense: values.startDate,
      endDateDriversLicense: values.endDate
    };
  }

  mapToDriverModel(values: any, personId: number): any {
    return {
      id: this.selectedDriver.id,
      personId,
      startDate:  values.startDate,
      endDate:  values.endDate
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
