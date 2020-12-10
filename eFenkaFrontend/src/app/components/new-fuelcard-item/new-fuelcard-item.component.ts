import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Vehicle} from '../../models/vehicle/vehicle';
import {Router} from '@angular/router';
import {ApiService} from '../../services/api.service';
import {DatePipe} from '@angular/common';
import {Driver} from '../../models/driver/driver';
import {Company} from '../../models/company/company';
import { pincodeValidator } from 'src/app/services/pincode.validator';
import { fromToDate } from 'src/app/services/from-to-date.validator';

@Component({
  selector: 'app-new-fuelcard-item',
  templateUrl: './new-fuelcard-item.component.html',
  styleUrls: ['./new-fuelcard-item.component.css']
})
export class NewFuelcardItemComponent implements OnInit {
  form: FormGroup;
  drivers: Driver[];
  vehicles: Vehicle[];
  companies: Company[];

  constructor(private router: Router, private apiService: ApiService, private datepipe: DatePipe) {
  }

  ngOnInit(): void {
    this.apiService.getAllAvailableDrivers().subscribe(drivers => {
      this.drivers = drivers;
      this.apiService.getAllCompanies().subscribe(companies => {
        this.companies = companies;
        this.apiService.getAllAvailableVehicles().subscribe((vehicles) => {
          // Alleen de vehicles zonder tankkaart gekoppeld en ze zijn alfabetisch gesorteerd.
          this.vehicles = vehicles.filter(v => v.fuelCard === null).sort((v, v2) => {
            const licensePlate1 = v.licensePlate.toLowerCase();
            const licensePlate2 = v2.licensePlate.toLowerCase();
            if (licensePlate1 < licensePlate2) {
              return -1;
            }
            if (licensePlate1 > licensePlate2) {
              return 1;
            }
            return 0;
          });
        });
      });
    });

    this.form = new FormGroup({
      driver: new FormControl(null, [Validators.required]),
      vehicle: new FormControl(null, [Validators.required]),
      company: new FormControl(null, [Validators.required]),
      duration: new FormGroup({
        startDate: new FormControl(null, [Validators.required, Validators.min(0)]),
        endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      }, {validators: fromToDate}),
      pinCode: new FormControl(null, [Validators.required, pincodeValidator]),
      number: new FormControl(null, [Validators.required])
    });
    this.fillForm();
  }

  navigateToFuelListComponent(): void {
    this.router.navigate(['/fuelcards']);
  }

  saveNewFuelcard(form: FormGroup): void {
    const model = this.mapToModel(form.value);
    console.log(model);
    this.apiService.addFuelcard(model).subscribe(() => {
      this.navigateToFuelListComponent();
    });
  }

  private mapToModel(values: any): any {
    return {
      DriverId: Number(values.driver),
      VehicleId: Number(values.vehicle),
      CompanyId: Number(values.company),
      StartDate: values.duration.startDate,
      EndDate: values.duration.endDate,
      PinCode: values.pinCode,
      Number: values.number
    };
  }

  fillForm(): void {
    this.form.controls.duration.patchValue({
      startDate: this.datepipe.transform(new Date(), 'yyyy-MM-dd'),
      endDate: this.datepipe.transform(new Date(), 'yyyy-MM-dd')
    });
  }
}
