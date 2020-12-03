import { ApiService } from 'src/app/services/api.service';
import { Corporation } from '../../models/corporation/corporation';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { Brand } from './../../models/brand/brand';
import { Model } from './../../models/model/model';
import { Vehicle } from './../../models/vehicle/vehicle';
import { Country } from './../../models/country/country';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Record } from 'src/app/models/record/record';
import { CostAllocation } from 'src/app/models/cost-allocatoin/cost-allocation';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-record-details',
  templateUrl: './record-details.component.html',
  styleUrls: ['./record-details.component.css'],
})
export class RecordDetailsComponent implements OnInit {
  isEditable: boolean;
  form: FormGroup;
  selectedRecord: Record;
  isLoaded = false;
  countries: Country[];
  corporations: Corporation[];
  costAllocations: CostAllocation[];
  brands: Brand[];
  fuelTypes: FuelType[];
  models: Model[];
  vehicles: Vehicle[];
  selectedBrand: Brand;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private apiService: ApiService,
    public datepipe: DatePipe
  ) { }

  async ngOnInit(): Promise<any> {
    const recordId = this.route.snapshot.params.index;

    this.selectedRecord = await this.apiService.getRecordById(recordId).toPromise();
    this.countries = this.getCountries();
    this.corporations = await this.setCorporation();
    this.costAllocations = await this.setCostAllocation();
    this.brands = await this.setBrand();
    this.fuelTypes = await this.setFuelType();
    this.models = await this.setModels(this.selectedRecord.fuelCard.vehicle.brand.id);
    this.vehicles = await this.setVehicle(this.selectedRecord.fuelCard.vehicle.brand.id);
    this.selectedBrand = await this.setSelectedBrand(this.selectedRecord.fuelCard.vehicle.brand.id);
    console.log(this.selectedRecord);

    this.form = new FormGroup({
      type: new FormControl(null, [Validators.required]),
      licensePlate: new FormControl(null, [Validators.required]),
      chassis: new FormControl(null, [Validators.required]),
      registrationDate: new FormControl(null, [Validators.required]),
      country: new FormControl(null, [Validators.required]),
      startDate: new FormControl(null, [Validators.required]),
      corporation: new FormControl(null, [Validators.required]),
      costAllocation: new FormControl(null, [Validators.required]),
      usage: new FormControl(null, [Validators.required]),
      driver: new FormControl(null, [Validators.required]),
      brand: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      vehicle: new FormControl(null, [Validators.required]),
      buildYear: new FormControl(null, [Validators.required]),
      kilometers: new FormControl(null, [Validators.required]),
      exteriorColor: new FormControl(null, [Validators.required]),
      interiorColor: new FormControl(null, [Validators.required]),
    });
    this.isLoaded = true;
    this.fillForm();
    this.disableForm();
  }

  fillForm(): void {
    this.form.controls.type.setValue(this.selectedRecord.term + 1);
    this.form.controls.licensePlate.setValue(this.selectedRecord.fuelCard.vehicle.licensePlate);
    this.form.controls.chassis.setValue(this.selectedRecord.fuelCard.vehicle.chassis);
    this.form.controls.registrationDate.setValue(this.datepipe.transform(new Date(this.selectedRecord.fuelCard.vehicle.registrationDate), 'yyyy-MM-dd'));

    if (this.selectedRecord.fuelCard.vehicle.country === null) {
      this.form.controls.country.setValue('');
    } else {
      this.form.controls.country.setValue(this.selectedRecord.fuelCard.vehicle.country.id);
    }

    this.form.controls.startDate.setValue(this.datepipe.transform(new Date(this.selectedRecord.startDate), 'yyyy-MM-dd'));

    if (this.selectedRecord.corporation === null) {
      this.form.controls.corporation.setValue('');
    } else {
      this.form.controls.corporation.setValue(this.selectedRecord.corporation.id);
    }

    if (this.selectedRecord.costAllocation === null) {
      this.form.controls.costAllocation.setValue('');
    } else {
      this.form.controls.costAllocation.setValue(this.selectedRecord.costAllocation.id);
    }

    this.form.controls.usage.setValue(this.selectedRecord.usage + 1);
    this.form.controls.driver.setValue(this.selectedRecord.fuelCard.driver);
    this.form.controls.brand.setValue(this.selectedRecord.fuelCard.vehicle.brand.id);
    this.form.controls.fuelType.setValue(this.selectedRecord.fuelCard.vehicle.fuelType.id);
    this.form.controls.model.setValue(this.selectedRecord.fuelCard.vehicle.model.id);
    this.form.controls.vehicle.setValue(this.selectedRecord.fuelCard.vehicle.id);
    this.form.controls.buildYear.setValue(this.selectedRecord.fuelCard.vehicle.buildYear);
    this.form.controls.kilometers.setValue(this.selectedRecord.fuelCard.vehicle.kilometers);

    if (this.selectedRecord.fuelCard.vehicle.exteriorColor == null) {
      this.form.controls.exteriorColor.setValue('');
    } else {
      this.form.controls.exteriorColor.setValue(this.selectedRecord.fuelCard.vehicle.exteriorColor.id);
    }

    if (this.selectedRecord.fuelCard.vehicle.interiorColor == null) {
      this.form.controls.interiorColor.setValue('');
    } else {
      this.form.controls.interiorColor.setValue(this.selectedRecord.fuelCard.vehicle.interiorColor.id);
    }

  }

  disableForm(): void {
    this.form.controls.type.disable();
    this.form.controls.licensePlate.disable();
    this.form.controls.chassis.disable();
    this.form.controls.registrationDate.disable();
    this.form.controls.country.disable();
    this.form.controls.startDate.disable();
    this.form.controls.corporation.disable();
    this.form.controls.costAllocation.disable();
    this.form.controls.usage.disable();
    this.form.controls.driver.disable();
    this.form.controls.brand.disable();
    this.form.controls.fuelType.disable();
    this.form.controls.model.disable();
    this.form.controls.vehicle.disable();
    this.form.controls.buildYear.disable();
    this.form.controls.kilometers.disable();
    this.form.controls.exteriorColor.disable();
    this.form.controls.interiorColor.disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.type.enable();
    this.form.controls.registrationDate.enable();
    this.form.controls.country.enable();
    this.form.controls.startDate.enable();
    this.form.controls.corporation.enable();
    this.form.controls.costAllocation.enable();
    this.form.controls.usage.enable();
    this.form.controls.driver.enable();
    this.form.controls.brand.enable();
    this.form.controls.fuelType.enable();
    this.form.controls.model.enable();
    this.form.controls.vehicle.enable();
    this.isEditable = true;
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    this.setAllDropDownsByBrand(brandId);
  }

  setAllDropDownsByBrand(brandId: number): void {
    this.setModels(brandId);
    this.setVehicle(brandId);
    this.setSelectedBrand(brandId);
  }

  onChangedVehicle(event): void {
    const vehicleId = event.target.value;
    console.log('changed with ' + vehicleId);

    this.apiService.getVehicleById(vehicleId).subscribe((data) => {
      this.form.controls.licensePlate.setValue(data.licensePlate);
      this.form.controls.chassis.setValue(data.chassis);
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
            this.apiService.getRecordById(this.selectedRecord.id).subscribe((data) => {
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
      fuelCardId: this.selectedRecord.fuelCard.id,
      corporationId: Number(values.corporation),
      costAllocationId: Number(values.costAllocation),
      term: Number(values.type) - 1,
      startDate: values.startDate,
      endDate: values.endDate,
      usage: Number(values.usage) - 1,
    };
  }

  mapToVehicle(values: any): any {
    console.log(values.vehicle);
    return {
      Id: Number(values.vehicle),
      brandId: this.vehicles.find(v => v.id === Number(values.vehicle)).brand?.id,
      modelId: this.vehicles.find(v => v.id === Number(values.vehicle)).model.id,
      fuelTypeId: this.vehicles.find(v => v.id === Number(values.vehicle)).fuelType.id,
      engineTypeId: this.vehicles.find(v => v.id === Number(values.vehicle)).engineType.id,
      doorTypeId: this.vehicles.find(v => v.id === Number(values.vehicle)).doorType.id,
      fuelCardId: this.vehicles.find(v => v.id === Number(values.vehicle)).fuelCard?.id,
      seriesId: this.vehicles.find(v => v.id === Number(values.vehicle)).serie.id,
      volume: this.vehicles.find(v => v.id === Number(values.vehicle)).volume,
      fiscalHP: this.vehicles.find(v => v.id === Number(values.vehicle)).fiscalHP,
      emission: this.vehicles.find(v => v.id === Number(values.vehicle)).emission,
      enginePower: this.vehicles.find(v => v.id === Number(values.vehicle)).enginePower,
      registrationDate: new Date(values.registrationDate).toISOString(),
      isActive: true,
      categoryId: this.vehicles.find(v => v.id === Number(values.vehicle)).category.id,
      licensePlate: this.vehicles.find(v => v.id === Number(values.vehicle)).licensePlate,
      chassis: this.vehicles.find(v => v.id === Number(values.vehicle)).chassis,
      engineCapacity: this.vehicles.find(v => v.id === Number(values.vehicle)).engineCapacity,
      endDateDelivery: this.vehicles.find(v => v.id === Number(values.vehicle)).endDateDelivery,
      countryId: Number(values.country),
      buildYear: this.vehicles.find(v => v.id === Number(values.vehicle)).buildYear,
      kilometers: this.vehicles.find(v => v.id === Number(values.vehicle)).kilometers,
      exteriorColorId: this.vehicles.find(v => v.id === Number(values.vehicle)).exteriorColor.id,
      interiorColorId: this.vehicles.find(v => v.id === Number(values.vehicle)).interiorColor.id
    };
  }

  async setCorporation(): Promise<Corporation[]> {
    return await this.apiService.getAllCorporations().toPromise();
  }

  async setCostAllocation(): Promise<CostAllocation[]> {
    return this.apiService.getAllCostAllocations().toPromise();
  }

  async setBrand(): Promise<Brand[]> {
    return this.apiService.getAllBrands().toPromise();
  }

  async setFuelType(): Promise<FuelType[]> {
    return this.apiService.getAllFuelTypes().toPromise();
  }

  async setModels(brandId: number): Promise<Model[]> {
    return this.apiService.getAllModelsByBrandId(brandId).toPromise();
  }

  async setVehicle(brandId: number): Promise<Vehicle[]> {
    return this.apiService.getAllVehiclesByBrandId(brandId).toPromise();
  }

  async setSelectedBrand(brandId: number): Promise<Brand> {
    return this.apiService.getBrandById(brandId).toPromise();
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
