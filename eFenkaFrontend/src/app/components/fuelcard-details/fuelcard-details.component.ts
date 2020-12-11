import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {FuelCard} from '../../models/fuel-card/fuel-card';
import {Vehicle} from '../../models/vehicle/vehicle';
import {Driver} from '../../models/driver/driver';
import {Company} from '../../models/company/company';
import {ApiService} from '../../services/api.service';
import {DatePipe} from '@angular/common';
import {fromToDate} from 'src/app/services/from-to-date.validator';

@Component({
  selector: 'app-fuelcard-details',
  templateUrl: './fuelcard-details.component.html',
  styleUrls: ['./fuelcard-details.component.css']
})
export class FuelcardDetailsComponent implements OnInit {
  form: FormGroup;
  vehicle: Vehicle;
  drivers: Driver[];
  companies: Company[];
  startDate: Date;
  endDate: Date;
  isBlocked: boolean;
  isEditable: boolean;
  selectedFuelCard: FuelCard;

  constructor(private route: ActivatedRoute,
              private router: Router,
              private apiService: ApiService,
              private datepipe: DatePipe) {
  }

  ngOnInit(): void {
    const fuelCardId = this.route.snapshot.params.index;
    this.apiService.getFuelCardById(fuelCardId).subscribe(fc => {
      this.selectedFuelCard = fc;
      this.isBlocked = this.selectedFuelCard.isBlocked;
      this.apiService.getAllAvailableDrivers().subscribe(drivers => {
        this.drivers = drivers;
        this.drivers.push(this.selectedFuelCard.driver);
        this.apiService.getAllCompanies().subscribe(companies => {
          this.companies = companies;
          this.fillForm();
          this.disableForm();
        });
      });
    });

    this.form = new FormGroup({
      licensePlate: new FormControl(null, [Validators.required]),
      driver: new FormControl(null, [Validators.required]),
      company: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required, Validators.min(0)]),
      duration: new FormGroup({
        startDate: new FormControl(null, [Validators.required, Validators.min(0)]),
        endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      }, {validators: fromToDate}),
      blockedDate: new FormControl(null, null),
      blockedReason: new FormControl(null, null)

    });
  }

  navigateToListComponent(): void {
    this.router.navigate(['/fuelcards']);
  }

  saveEditFuelCard(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u deze wijzigingen wil opslaan?')) {
        const model = this.mapToModel(form.value);
        console.log(model);
        this.apiService.updateFuelCard(this.selectedFuelCard.id, model).subscribe(() => {
          this.apiService.getFuelCardById(this.selectedFuelCard.id).subscribe(fc => {
            this.selectedFuelCard = fc;
            this.isBlocked = this.selectedFuelCard.isBlocked;
            this.fillForm();
            this.disableForm();
          });
        });
      }
    } else {
      this.enableForm();
    }
  }

  deleteFuelCard(): void {
    if (confirm('Bent u zeker dat u deze tankkaart wil verwijderen?')) {
      this.apiService.deleteFuelCard(this.selectedFuelCard.id).subscribe(() => this.navigateToListComponent());
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
  }

  fillForm(): void {
    if (this.selectedFuelCard.vehicle) {
      this.form.controls.licensePlate.setValue(this.selectedFuelCard.vehicle.licensePlate);
      this.form.controls.fuelType.setValue(this.selectedFuelCard.vehicle.fuelType.name);
    }
    if (this.selectedFuelCard.driver) {
      this.form.controls.driver.setValue(this.selectedFuelCard?.driver?.id);
    }
    console.log(this.selectedFuelCard);
    if (this.selectedFuelCard.company) {
      this.form.controls.company.setValue(this.selectedFuelCard?.company?.id);
    }
    this.form.controls.duration.patchValue({
      startDate: this.datepipe.transform(new Date(this.selectedFuelCard.startDate), 'yyyy-MM-dd'),
      endDate: this.datepipe.transform(new Date(this.selectedFuelCard.endDate), 'yyyy-MM-dd')
    });

    if (this.isBlocked) {
      const date = this.datepipe.transform(new Date(this.selectedFuelCard.blockingDate), 'yyyy-MM-dd');
      this.form.controls.blockedDate.setValue(date);
      this.form.controls.blockedReason.setValue(this.selectedFuelCard.blockingReason);
    } else {
      const date = this.datepipe.transform(new Date(), 'yyyy-MM-dd');
      this.form.controls.blockedDate.setValue(date);
      this.form.controls.blockedReason.setValue('');
    }
  }

  disableForm(): void {
    this.form.controls.licensePlate.disable();
    this.form.controls.driver.disable();
    this.form.controls.company.disable();
    this.form.controls.fuelType.disable();
    this.form.controls.duration.get('startDate').disable();
    this.form.controls.duration.get('endDate').disable();
    this.form.controls.blockedReason.disable();
    this.form.controls.blockedDate.disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.driver.enable();
    this.form.controls.duration.get('startDate').enable();
    this.form.controls.duration.get('endDate').enable();
    this.form.controls.blockedReason.enable();
    this.form.controls.blockedDate.enable();
    this.isEditable = true;
  }

  private mapToModel(values: any): any {
    return {
      DriverId: values.driver,
      VehicleId: this.selectedFuelCard.vehicle.id,
      StartDate: values.duration.startDate,
      EndDate: values.duration.endDate,
      IsBlocked: this.isBlocked,
      BlockingDate: this.isBlocked ? values.blockedDate : null,
      BlockingReason: this.isBlocked ? values.blockedReason : null,
      PinCode: this.selectedFuelCard.pinCode,
      Number: this.selectedFuelCard.fuelCardNumber,
      Id: this.selectedFuelCard.id,
      companyId: this.selectedFuelCard.company.id,
    };
  }

  changeBlocked(): void {
    this.isBlocked = !this.isBlocked;
  }
}
