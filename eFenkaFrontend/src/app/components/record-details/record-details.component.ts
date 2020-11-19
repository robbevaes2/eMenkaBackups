import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { Brand } from './../../models/brand/brand';
import { Model } from './../../models/model/model';
import { Vehicle } from './../../models/vehicle/vehicle';
import { Usage } from './../../enums/usage/usage.enum';
import { Country } from './../../models/country/country';
import { Serie } from './../../models/serie/serie';
import { MotorType } from './../../models/motor-type/motor-type';
import { DoorType } from './../../models/door-type/door-type';
import { ExteriorColor } from './../../models/exterior-color/exterior-color';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Record } from 'src/app/models/record/record';
import { Term } from 'src/app/enums/term/term.enum';
import { Corporation } from 'src/app/models/corporation/corporation';
import { CostAllocation } from 'src/app/models/cost-allocatoin/cost-allocation';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';

@Component({
  selector: 'app-record-details',
  templateUrl: './record-details.component.html',
  styleUrls: ['./record-details.component.css']
})
export class RecordDetailsComponent implements OnInit {
  isEditable: boolean;
  form: FormGroup;
  selectedRecord: Record;

  termKeys = [];
  terms = Term;
  usageKeys = [];
  usages = Usage;

  countries: Country[];
  corporations: Corporation[];
  costAllocations: CostAllocation[];
  fuelCards: FuelCard[];
  brands: Brand[];
  fuelTypes: FuelType[];
  models: Model[];
  vehicles: Vehicle[];

  constructor(private route: ActivatedRoute, private router: Router) {
    this.termKeys = Object.keys(this.terms).filter(f => !isNaN(Number(f)));
    this.usageKeys = Object.keys(this.usages).filter(f => !isNaN(Number(f)));
  }

  ngOnInit(): void {
    const recordId = this.route.snapshot.params['index'];

    this.countries = this.getCountries();
    this.corporations = this.getCorporations();
    this.costAllocations = this.getCostAllocations();
    this.fuelCards = this.getFuelCards();
    this.brands = this.getBrand();
    this.fuelTypes = this.getFuelTypes();
    this.models = this.getModels();
    this.vehicles = this.getVehicles();

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
  }

  fillForm(): void {
    this.form.controls['type'].setValue(this.selectedRecord.term);
    this.form.controls['licensePlate'].setValue(this.selectedRecord.fuelCard.vehicle.licensePlate);
    this.form.controls['chassis'].setValue(this.selectedRecord.fuelCard.vehicle.chassis);
    this.form.controls['registrationDate'].setValue(this.selectedRecord.fuelCard.vehicle.registrationDate);
    this.form.controls['country'].setValue(this.selectedRecord.fuelCard.vehicle.country.name);
    this.form.controls['startDate'].setValue(this.selectedRecord.startDate);
    this.form.controls['corporation'].setValue(this.selectedRecord.corporation.name);
    this.form.controls['costAllocation'].setValue(this.selectedRecord.costAllocatoin.name);
    this.form.controls['fuelCard'].setValue(this.selectedRecord.fuelCard);
    this.form.controls['usage'].setValue(this.selectedRecord.usage);
    this.form.controls['driver'].setValue(this.selectedRecord.fuelCard.driver);
    this.form.controls['brand'].setValue(this.selectedRecord.fuelCard.vehicle.brand);
    this.form.controls['fuelType'].setValue(this.selectedRecord.fuelCard.vehicle.fuelType.name);
    this.form.controls['model'].setValue(this.selectedRecord.fuelCard.vehicle.model.name);
    this.form.controls['vehicle'].setValue(this.selectedRecord.fuelCard.vehicle.serie.name + ' ' +
      this.selectedRecord.fuelCard.vehicle.doorType.name);
    this.form.controls['buildYear'].setValue(this.selectedRecord.fuelCard.vehicle.buildYear);
    this.form.controls['kilometers'].setValue(this.selectedRecord.fuelCard.vehicle.kilometers);
    this.form.controls['exteriorColor'].setValue(this.selectedRecord.fuelCard.vehicle.brand.exteriorColors);
    this.form.controls['interiorColor'].setValue(this.selectedRecord.fuelCard.vehicle.brand.interiorColors);
  }

  disableForm(): void {
    this.form.controls['Type'].disable();
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
    this.form.controls['Type'].enable();
    this.form.controls['licensePlate'].enable();
    this.form.controls['chassis'].enable();
    this.form.controls['registrationDate'].enable();
    this.form.controls['country'].enable();
    this.form.controls['startDate'].enable();
    this.form.controls['corporation'].enable();
    this.form.controls['costAllocation'].enable();
    this.form.controls['fuelCard'].enable();
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

  navigateToListRecordComponent(): void {
    this.router.navigate(['/records']);
  }

  saveEditVehicle(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Are you sure you want to save this vehicle?')) {
        // Save vehicle and assign new vehicle (get request by vehicleId) to selectedRecord
        //this.fillForm();
        this.disableForm();
      }
    } else {
      this.enableForm();
    }
  }

  deleteVehicle(): void {
    if (confirm('Are you sure you want to delete this vehicle?')) {
        // Delete vehicle
        this.navigateToListRecordComponent();
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
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
  getCorporations(): Corporation[] {
    return [
      new Corporation(1, 'eMenKa BV', null, null, null, null),
      new Corporation(1, 'eMenKa GmbH', null, null, null, null),
      new Corporation(1, 'eMenKa NV', null, null, null, null),
    ];
  }

  getCostAllocations(): CostAllocation[] {
    return [
      new CostAllocation(1, 'Antwerpen', null, null, null),
      new CostAllocation(1, 'Gent', null, null, null),
      new CostAllocation(1, 'Hasselt', null, null, null),
      new CostAllocation(1, 'Antwerpen', null, null, null),
    ];
  }

  getFuelCards(): FuelCard[] {
    return [
      new FuelCard(1, 'tankKaart1', null, null, null, null, null, null),
      new FuelCard(2, 'tankKaart2', null, null, null, null, null, null),
      new FuelCard(3, 'tankKaart3', null, null, null, null, null, null),
      new FuelCard(4, 'tankKaart4', null, null, null, null, null, null),
    ];
  }

  getBrand(): Brand[] {
    return [
      new Brand(1, 'Opel'),
      new Brand(2, 'Ford'),
      new Brand(3, 'Mini'),
      new Brand(4, 'Audi'),
    ];
  }

  getFuelTypes(): FuelType[] {
    return [
      new FuelType(1, 'Diezel'),
      new FuelType(2, 'Benzine')
    ];
  }

  getModels(): Model[] {
    return [
      new Model(1, 'gti'),
      new Model(2, 'gtd'),
      new Model(3, 'superNitroSpeed')
    ];
  }

  getVehicles(): Vehicle[] {
    return [{
      id: 1,
      brand: new Brand(1, 'Audi'),
      model: new Model(3, 'A6'),
      serie: new Serie(1, 'Sportback'),
      fuelType: new FuelType(1, 'Benzine'),
      motorType: new MotorType(1, '1.9 TDI'),
      doorType: new DoorType(3, '5-deurs'),
      fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
      volume: 2000,
      fiscaleHp: 50,
      emission: 1,
      power: 300,
      licensePlate: '1-abc-123',
      endData: new Date('2020-01-16'),
      isActive: true,
      chassis: 'feoipajfpoaezfjipio',
      registrationDate: new Date('2020-01-16'),
      country: new Country(1, 'België', 'BE', 'Belg', false, true),
      buildYear: 2012,
      kilometers: 5000
    }]
  }
}
