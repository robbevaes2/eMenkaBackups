import { FuelCard } from './../../models/fuel-card/fuel-card';
import { ApiService } from 'src/app/services/api.service';
import {Corporation} from '../../models/corporation/corporation';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { Brand } from './../../models/brand/brand';
import { Model } from './../../models/model/model';
import { Vehicle } from './../../models/vehicle/vehicle';
import { Usage } from './../../enums/usage/usage.enum';
import { Country } from './../../models/country/country';
import { Serie } from './../../models/serie/serie';
import { DoorType } from './../../models/door-type/door-type';
import { ExteriorColor } from './../../models/exterior-color/exterior-color';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Record } from 'src/app/models/record/record';
import { Term } from 'src/app/enums/term/term.enum';
import { CostAllocation } from 'src/app/models/cost-allocatoin/cost-allocation';
import { EngineType } from 'src/app/models/engine-type/engine-type';

@Component({
  selector: 'app-record-details',
  templateUrl: './record-details.component.html',
  styleUrls: ['./record-details.component.css']
})
export class RecordDetailsComponent implements OnInit {
  isEditable: boolean;
  form: FormGroup;
  selectedRecord: Record;

  countries: Country[];
  corporations: Corporation[];
  costAllocations: CostAllocation[];
  fuelCards: FuelCard[];
  brands: Brand[];
  fuelTypes: FuelType[];
  models: Model[];
  vehicles: Vehicle[];

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService) {

  }

  ngOnInit(): void {
    const recordId = this.route.snapshot.params['index'];

    this.apiService.getRecordById(recordId).subscribe(data => {
      this.countries = this.getCountries();

      this.selectedRecord = data;
      console.log(this.selectedRecord);

      this.setCorporatoin();
      this.setCostAllocation();
      this.setFuelCard();
      this.setBrand();
      this.setFuelType();
      this.setModels(this.selectedRecord.fuelCard.vehicle.brand.id);
      this.setVehicle(this.selectedRecord.fuelCard.vehicle.brand.id);

      this.form = new FormGroup({
        type: new FormControl(null, [Validators.required]),
        licensePlate: new FormControl(null, [Validators.required]),
        chassis: new FormControl(null, [Validators.required]),
        registrationDate: new FormControl(null, [Validators.required]),
        country: new FormControl(null, [Validators.required]),
        startDate: new FormControl(null, [Validators.required]),
        corporation: new FormControl(null, [Validators.required]),
        costAllocation: new FormControl(null, [Validators.required]),
        fuelCard: new FormControl(null, [Validators.required]),
        usage: new FormControl(null, [Validators.required]),
        driver: new FormControl(null, [Validators.required]),
        brand: new FormControl(null, [Validators.required]),
        fuelType: new FormControl(null, [Validators.required]),
        model: new FormControl(null, [Validators.required]),
        vehicle: new FormControl(null, [Validators.required]),
        buildYear: new FormControl(null, [Validators.required]),
        kilometers: new FormControl(null, [Validators.required]),
        exteriorColor: new FormControl(null, [Validators.required]),
        interiorColor: new FormControl(null, [Validators.required])
      });

      this.fillForm();
      this.disableForm();
    });
  }

  fillForm(): void {
    this.form.controls['type'].setValue(this.selectedRecord.term);
    this.form.controls['licensePlate'].setValue(this.selectedRecord.fuelCard.vehicle.licensePlate);
    this.form.controls['chassis'].setValue(this.selectedRecord.fuelCard.vehicle.chassis);
    this.form.controls['registrationDate'].setValue(this.selectedRecord.fuelCard.vehicle.registrationDate);
    if (this.selectedRecord.fuelCard.vehicle.country === null) {
      this.form.controls['country'].setValue('');
    } else {
      this.form.controls['country'].setValue(this.selectedRecord.fuelCard.vehicle.country.name);
    }
    this.form.controls['startDate'].setValue(new Date(this.selectedRecord.startDate).toISOString().substring(0, 10));
    if (this.selectedRecord.corporation === null) {
      this.form.controls['corporation'].setValue('');
    } else {
      this.form.controls['corporation'].setValue(this.selectedRecord.corporation.id);
    }
    if (this.selectedRecord.costAllocation === null) {
      this.form.controls['costAllocation'].setValue('');
    } else {
      this.form.controls['costAllocation'].setValue(this.selectedRecord.costAllocation.id);
    }
    this.form.controls['fuelCard'].setValue(this.selectedRecord.fuelCard.id);
    this.form.controls['usage'].setValue(this.selectedRecord.usage);
    this.form.controls['driver'].setValue(this.selectedRecord.fuelCard.driver);
    this.form.controls['brand'].setValue(this.selectedRecord.fuelCard.vehicle.brand.id);
    this.form.controls['fuelType'].setValue(this.selectedRecord.fuelCard.vehicle.fuelType.id);
    this.form.controls['model'].setValue(this.selectedRecord.fuelCard.vehicle.model.id);
    this.form.controls['vehicle'].setValue(this.selectedRecord.fuelCard.vehicle.id);
    this.form.controls['buildYear'].setValue(this.selectedRecord.fuelCard.vehicle.buildYear);
    this.form.controls['kilometers'].setValue(this.selectedRecord.fuelCard.vehicle.kilometers);
    this.form.controls['exteriorColor'].setValue(this.selectedRecord.fuelCard.vehicle.brand.exteriorColors);
    this.form.controls['interiorColor'].setValue(this.selectedRecord.fuelCard.vehicle.brand.interiorColors);
  }

  disableForm(): void {
    this.form.controls['type'].disable();
    this.form.controls['licensePlate'].disable();
    this.form.controls['chassis'].disable();
    this.form.controls['registrationDate'].disable();
    this.form.controls['country'].disable();
    this.form.controls['startDate'].disable();
    this.form.controls['corporation'].disable();
    this.form.controls['costAllocation'].disable();
    this.form.controls['fuelCard'].disable();
    this.form.controls['usage'].disable();
    this.form.controls['driver'].disable();
    this.form.controls['brand'].disable();
    this.form.controls['fuelType'].disable();
    this.form.controls['model'].disable();
    this.form.controls['vehicle'].disable();
    this.form.controls['buildYear'].disable();
    this.form.controls['kilometers'].disable();
    this.form.controls['exteriorColor'].disable();
    this.form.controls['interiorColor'].disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls['type'].enable();
    this.form.controls['registrationDate'].enable();
    this.form.controls['country'].enable();
    this.form.controls['startDate'].enable();
    this.form.controls['corporation'].enable();
    this.form.controls['costAllocation'].enable();
    this.form.controls['usage'].enable();
    this.form.controls['driver'].enable();
    this.form.controls['brand'].enable();
    this.form.controls['fuelType'].enable();
    this.form.controls['model'].enable();
    this.form.controls['vehicle'].enable();
    this.form.controls['buildYear'].enable();
    this.form.controls['kilometers'].enable();
    this.form.controls['exteriorColor'].enable();
    this.form.controls['interiorColor'].enable();
    this.isEditable = true;
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    this.setAllDropDownsByBrand(brandId);
  }

  setAllDropDownsByBrand(brandId: number): void {
    this.setModels(brandId);
    this.setVehicle(brandId);
  }

  onChangedVehicle(event): void {
    const vehicleId = event.target.value;
    console.log('changed with ' + vehicleId);

    this.apiService.getVehicleById(vehicleId).subscribe(data => {
      this.form.controls['licensePlate'].setValue(data.licensePlate);
      this.form.controls['chassis'].setValue(data.chassis);
      this.form.controls['fuelCard'].setValue(data.fuelCard.id);

    });
  }

  navigateToListRecordComponent(): void {
    this.router.navigate(['/records']);
  }

  saveEditRecord(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Are you sure you want to save this vehicle?')) {
        this.apiService.updateRecord(this.selectedRecord.id, this.mapToModel(form.value)).subscribe(() => {
          this.apiService.updateVehicle(form.value.vehicle, this.mapToVehicle(form.value)).subscribe(() => {
            this.apiService.getRecordById(this.selectedRecord.id).subscribe(data => {
              this.selectedRecord = data;
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

  deleteRecord(): void {
    if (confirm('Are you sure you want to delete this vehicle?')) {
      this.apiService.deleteRecord(this.selectedRecord.id).subscribe(() => this.navigateToListRecordComponent());
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
  }

  mapToModel(values: any): any {
    return {
      id: this.selectedRecord.id,
      fuelCardId: Number(values.fuelCard),
      corporationId: Number(values.corporation),
      costAllocationId: Number(values.costAllocation),
      term: values.type,
      startDate: values.startDate,
      endDate: values.endDate,
      usage: values.usage
    };
  }

  mapToFuelCard(values: any): any {
    return {
      id: Number(values.fuelCard),
      driverId: this.fuelCards[values.fuelCard].driver.id,
      startDate: this.fuelCards[values.fuelCard].startDate,
      endDate: this.fuelCards[values.fuelCard].endDate,
      isBlocked: false,
      blockingDate: new Date('10-10-2016'),
      blockingReason: '',
      pinCode: '1234',
      vehicleId: Number(values.vehicle),
      number: this.fuelCards[values.fuelCard].fuelCardNumber,
    };
  }

  mapToVehicle(values: any): any {
    return {
      Id: Number(values.vehicle),
      brandId: this.vehicles[values.vehicle - 1].brand.id,
      modelId:  this.vehicles[values.vehicle - 1].model.id,
      fuelTypeId:  this.vehicles[values.vehicle - 1].fuelType.id,
      engineTypeId:  this.vehicles[values.vehicle - 1].engineType.id,
      doorTypeId:  this.vehicles[values.vehicle - 1].doorType.id,
      fuelCardId:  this.vehicles[values.vehicle - 1].fuelCard.id,
      volume: this.vehicles[values.vehicle - 1].volume,
      fiscalHP: this.vehicles[values.vehicle - 1].fiscalHP,
      emission: this.vehicles[values.vehicle - 1].emission,
      enginePower: this.vehicles[values.vehicle - 1].enginePower,
      isActive: true,
      categoryId: this.vehicles[values.vehicle - 1].category.id,
      licensePlate: values.licensePlate,
      chassis: values.chassis,
      endDateDelivery: this.vehicles[values.vehicle - 1].endDateDelivery,
      seriesId: this.vehicles[values.vehicle - 1].serie.id,
      buildYear: values.buildYear,
    };
  }

  setCorporatoin(): void {
    this.apiService.getAllCorporatoins().subscribe(data => this.corporations = data);
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
    this.apiService.getAllVehiclesByBrandId(brandId).subscribe(data => this.vehicles = data);
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
}
