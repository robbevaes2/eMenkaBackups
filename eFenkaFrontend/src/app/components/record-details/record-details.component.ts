import {ApiService} from 'src/app/services/api.service';
import {Corporation} from '../../models/corporation/corporation';
import {FuelType} from 'src/app/models/fuel-type/fuel-type';
import {Brand} from '../../models/brand/brand';
import {Model} from '../../models/model/model';
import {Vehicle} from '../../models/vehicle/vehicle';
import {Country} from '../../models/country/country';
import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {ActivatedRoute, Router} from '@angular/router';
import {Record} from 'src/app/models/record/record';
import {CostAllocation} from 'src/app/models/cost-allocatoin/cost-allocation';
import {DatePipe} from '@angular/common';
import {fromToDate} from 'src/app/services/from-to-date.validator';

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
  selectedVehicle: Vehicle;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private apiService: ApiService,
    private datepipe: DatePipe
  ) {
  }

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
    this.selectedVehicle = this.vehicles.find(v => v.id === this.selectedRecord.fuelCard.vehicle.id);
    
    console.log(this.selectedRecord);

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
      usage: new FormControl(null, [Validators.required]),
      brand: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      vehicle: new FormControl(null, [Validators.required]),
      buildYear: new FormControl(null, [Validators.required]),
      kilometers: new FormControl(null, [Validators.required]),
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

    if (this.selectedRecord.fuelCard?.vehicle.country === null) {
      this.form.controls.country.setValue('');
    } else {
      this.form.controls.country.setValue(this.selectedRecord.fuelCard.vehicle.country.id);
    }

    this.form.controls.duration.patchValue({
      startDate: this.datepipe.transform(new Date(this.selectedRecord.startDate), 'yyyy-MM-dd'),
      endDate: this.datepipe.transform(new Date(this.selectedRecord.endDate), 'yyyy-MM-dd')
    });

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
    this.form.controls.brand.setValue(this.selectedRecord.fuelCard.vehicle.brand.id);
    this.form.controls.fuelType.setValue(this.selectedRecord.fuelCard.vehicle.fuelType.id);
    this.form.controls.model.setValue(this.selectedRecord.fuelCard.vehicle.model.id);
    this.form.controls.vehicle.setValue(this.selectedRecord.fuelCard.vehicle.id);
    this.form.controls.buildYear.setValue(this.selectedRecord.fuelCard.vehicle.buildYear);
    this.form.controls.kilometers.setValue(this.selectedRecord.fuelCard.vehicle.kilometers);
  }

  disableForm(): void {
    this.form.controls.type.disable();
    this.form.controls.licensePlate.disable();
    this.form.controls.chassis.disable();
    this.form.controls.registrationDate.disable();
    this.form.controls.country.disable();
    this.form.controls.duration.get('startDate').disable();
    this.form.controls.duration.get('endDate').disable();
    this.form.controls.corporation.disable();
    this.form.controls.costAllocation.disable();
    this.form.controls.usage.disable();
    this.form.controls.brand.disable();
    this.form.controls.fuelType.disable();
    this.form.controls.model.disable();
    this.form.controls.vehicle.disable();
    this.form.controls.buildYear.disable();
    this.form.controls.kilometers.disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.type.enable();
    this.form.controls.registrationDate.enable();
    this.form.controls.country.enable();
    this.form.controls.duration.get('startDate').enable();
    this.form.controls.duration.get('endDate').enable();
    this.form.controls.corporation.enable();
    this.form.controls.costAllocation.enable();
    this.form.controls.usage.enable();
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
      this.form.controls.fuelType.setValue(data.fuelType.id);
    });
  }

  navigateToListRecordComponent(): void {
    this.router.navigate(['/records']);
  }

  saveEditRecord(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u dit dossier wilt opslaan?')) {
        this.apiService.updateRecord(this.selectedRecord.id, this.mapToModel(form.value)).subscribe(() => {
          this.apiService.updateVehicle(this.selectedVehicle.id, this.mapToVehicle(form.value)).subscribe(() => {
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
    if (confirm('Bent u zeker dat u dit dossier wilt opslaan?')) {
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
      startDate: values.duration.startDate,
      endDate: values.duration.endDate,
      usage: Number(values.usage) - 1,
    };
  }

  mapToVehicle(values: any): any {
    return {
      Id: this.selectedVehicle.id,
      brandId: this.selectedVehicle.brand?.id,
      modelId: this.selectedVehicle.model.id,
      fuelTypeId: this.selectedVehicle.fuelType.id,
      engineTypeId: this.selectedVehicle.engineType.id,
      doorTypeId: this.selectedVehicle.doorType.id,
      fuelCardId: this.selectedVehicle.fuelCard?.id,
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
      countryId: Number(values.country),
      buildYear: this.selectedVehicle.buildYear,
      kilometers: this.selectedVehicle.kilometers,
      exteriorColorId: this.selectedVehicle.exteriorColor.id,
      interiorColorId: this.selectedVehicle.interiorColor.id
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
