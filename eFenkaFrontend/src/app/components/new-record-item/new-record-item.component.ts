import {ApiService} from '../../services/api.service';
import {FuelType} from 'src/app/models/fuel-type/fuel-type';
import {Brand} from '../../models/brand/brand';
import {Model} from '../../models/model/model';
import {Vehicle} from '../../models/vehicle/vehicle';
import {Country} from '../../models/country/country';
import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {Corporation} from 'src/app/models/corporation/corporation';
import {CostAllocation} from 'src/app/models/cost-allocatoin/cost-allocation';
import {FuelCard} from 'src/app/models/fuel-card/fuel-card';
import {DatePipe} from '@angular/common';
import {fromToDate} from 'src/app/services/from-to-date.validator';

@Component({
  selector: 'app-new-record-item',
  templateUrl: './new-record-item.component.html',
  styleUrls: ['./new-record-item.component.css']
})
export class NewRecordItemComponent implements OnInit {
  form: FormGroup;

  countries: Country[];
  corporations: Corporation[];
  costAllocations: CostAllocation[];
  fuelCards: FuelCard[];
  brands: Brand[];
  fuelTypes: FuelType[];
  models: Model[];
  vehicles: Vehicle[];
  selectedVehicle: Vehicle;

  constructor(private router: Router, private apiService: ApiService, public datepipe: DatePipe) {
  }

  ngOnInit(): void {
    this.countries = this.getCountries();

    this.setCorporation();
    this.setCostAllocation();
    this.setFuelCard();
    this.setBrand();
    this.setFuelType();

    this.form = new FormGroup({
      type: new FormControl(null, [Validators.required]),
      licensePlate: new FormControl(null, [Validators.required]),
      chassis: new FormControl(null, [Validators.required]),
      registrationDate: new FormControl(null, [Validators.required]),
      country: new FormControl(null, [Validators.required]),
      duration: new FormGroup({
        startDate: new FormControl(null, [Validators.required]),
        endDate: new FormControl(null, [Validators.required]),
      }, {validators: fromToDate}),
      corporation: new FormControl(null, [Validators.required]),
      costAllocation: new FormControl(null, [Validators.required]),
      fuelCard: new FormControl(null, [Validators.required]),
      usage: new FormControl(null, [Validators.required]),
      brand: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      vehicle: new FormControl(null, [Validators.required]),
    });
  }

  navigateToListRecordComponent(): void {
    this.router.navigate(['/records']);
  }

  saveNewRecord(form: FormGroup): void {
    if (confirm('Bent u zeker dat u dit dossier wilt opslaan?')) {
      this.apiService.addRecord(this.mapToModel(form.value)).subscribe(() => {
        this.apiService.updateVehicle(Number(form.value.vehicle), this.mapToVehicle(form.value)).subscribe(() =>
          this.navigateToListRecordComponent()
        );
      });
    }
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    console.log('changed with ' + brandId);

    this.setModels(brandId);
    this.setVehicle(brandId);
  }

  onChangedVehicle(event): void {
    const vehicleId = event.target.value;
    console.log('changed with ' + vehicleId);

    this.apiService.getVehicleById(vehicleId).subscribe(data => {
      this.form.controls.licensePlate.setValue(data.licensePlate);
      this.form.controls.chassis.setValue(data.chassis);
      this.form.controls.fuelCard.setValue(data.fuelCard.id);
      this.form.controls.fuelType.setValue(data.fuelType.id);
    });
  }

  setCorporation(): void {
    this.apiService.getAllCorporations().subscribe(data => this.corporations = data);
  }

  setCostAllocation(): void {
    this.apiService.getAllCostAllocations().subscribe(data => this.costAllocations = data);
  }

  setFuelCard(): void {
    this.apiService.getAllFuelCards().subscribe(data => this.fuelCards = data);
  }

  setBrand(): void {
    this.apiService.getAllBrands().subscribe(data => this.brands = data);
  }

  setFuelType(): void {
    this.apiService.getAllFuelTypes().subscribe(data => this.fuelTypes = data);
  }

  setModels(brandId: number): void {
    this.apiService.getAllModelsByBrandId(brandId).subscribe(data => this.models = data);
  }

  setVehicle(brandId: number): void {
    this.apiService.getAllAvailableVehiclesByBrandId(brandId).subscribe(data => {
      this.vehicles = data;
      console.log(this.vehicles);
    });
  }

  getCountries(): Country[] {
    return [
      new Country(1, 'België', 'BE', 'Belg', false, true),
      new Country(2, 'Nederland', 'NL', 'Nederlandse', true, true),
      new Country(3, 'Duitsland', 'DE', 'Duitse', false, true),
      new Country(4, 'Frankrijk', 'FR', 'Franse', false, true),
      new Country(5, 'Spanje', 'ES', 'Spaanse', false, false),
    ];
  }

  mapToModel(values: any): any {
    return {
      fuelCardId: Number(values.fuelCard),
      corporationId: Number(values.corporation),
      costAllocationId: Number(values.costAllocation),
      term: Number(values.type) - 1,
      startDate: new Date(values.duration.startDate).toISOString(),
      endDate: new Date(values.duration.endDate).toISOString(),
      usage: Number(values.usage) - 1
    };
  }

  mapToVehicle(values: any): any {
    this.selectedVehicle = this.vehicles.find(v => v.id === Number(values.vehicle));
    return {
      Id: Number(values.vehicle),
      brandId: this.selectedVehicle.brand.id,
      modelId: this.selectedVehicle.model.id,
      fuelTypeId: this.selectedVehicle.fuelType.id,
      engineTypeId: this.selectedVehicle.engineType.id,
      doorTypeId: this.selectedVehicle.doorType.id,
      fuelCardId: this.selectedVehicle.fuelCard.id,
      seriesId: this.selectedVehicle.series.id,
      volume: this.selectedVehicle.volume,
      fiscalHP: this.selectedVehicle.fiscalHP,
      emission: this.selectedVehicle.emission,
      enginePower: this.selectedVehicle.enginePower,
      registrationDate: new Date(values.registrationDate).toISOString(),
      isActive: true,
      categoryId: this.selectedVehicle.category.id,
      licensePlate: this.selectedVehicle.licensePlate,
      chassis: this.selectedVehicle.chassis,
      engineCapacity: this.selectedVehicle.engineCapacity,
      endDateDelivery: this.selectedVehicle.endDateDelivery,
      countryId: this.selectedVehicle.country.id,
      buildYear: this.selectedVehicle.buildYear,
      kilometers: this.selectedVehicle.kilometers,
      exteriorColorId: this.selectedVehicle.exteriorColor.id,
      interiorColorId: this.selectedVehicle.interiorColor.id
    };
  }
}
