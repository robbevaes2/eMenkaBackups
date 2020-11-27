import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {FuelCard} from '../../models/fuel-card/fuel-card';
import {Vehicle} from '../../models/vehicle/vehicle';
import {Driver} from '../../models/driver/driver';
import {Company} from '../../models/company/company';
import {ApiService} from '../../services/api.service';

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
  blockingReason: string;
  blockingDate: Date;
  isActive: boolean;
  isEditable: boolean;
  selectedFuelCard: FuelCard;

  constructor(private route: ActivatedRoute,
              private router: Router,
              private apiService: ApiService) {
  }

  ngOnInit(): void {
    const fuelCardId = this.route.snapshot.params.index;
    this.apiService.getFuelCardById(fuelCardId).subscribe(fc => {
      this.selectedFuelCard = fc;
      this.apiService.getAllDrivers().subscribe(drivers => {
        this.drivers = drivers;
        this.apiService.getAllCompanies().subscribe(companies => {
          this.companies = companies;
          this.fillForm();
          this.disableForm();
        });
      });
    });


    // this.setAllDropDownsByBrand(this.selectedVehicle.brand.id);

    this.form = new FormGroup({
      licensePlate: new FormControl(null, [Validators.required]),
      driver: new FormControl(null, [Validators.required]),
      company: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required, Validators.min(0)]),
      startDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
    });
  }

  navigateToListComponent(): void {
    this.router.navigate(['/fuelcards']);
  }

  saveEditFuelCard(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u deze wijzigingen wil opslaan?')) {
        // Save vehicle and assign new vehicle (get request by vehicleId) to selectedVehicle
        // this.fillForm();
        this.disableForm();
      }
    } else {
      this.enableForm();
    }
  }

  /*

    deleteFuelCard(): void {
      if (confirm('Bent u zeker dat u deze tankkaart wil verwijderen?')) {
        this.apiService.deleteFuelCard(this.selectedFuelCard.id).subscribe(() => this.navigateToListComponent());
      }
    }

   */

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
    if (this.selectedFuelCard.company) {
      this.form.controls.company.setValue(this.selectedFuelCard?.company?.id);
    }
    if (this.selectedFuelCard.startDate) {
      const date = new Date(this.selectedFuelCard.startDate).toISOString().substring(0, 10);
      this.form.controls.startDate.setValue(date);
    }
    if (this.selectedFuelCard.endDate) {
      const date = new Date(this.selectedFuelCard.endDate).toISOString().substring(0, 10);
      this.form.controls.endDate.setValue(date);
    }
  }

  disableForm(): void {
    this.form.controls.licensePlate.disable();
    this.form.controls.driver.disable();
    this.form.controls.company.disable();
    this.form.controls.fuelType.disable();
    this.form.controls.startDate.disable();
    this.form.controls.endDate.disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.drivers.enable();
    this.form.controls.endDate.enable();
    this.isEditable = true;
  }

}
