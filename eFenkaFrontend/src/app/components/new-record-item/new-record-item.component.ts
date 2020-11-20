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
import { Corporation } from 'src/app/models/corporation/corporation';
import { CostAllocation } from 'src/app/models/cost-allocatoin/cost-allocation';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { EngineType } from 'src/app/models/engine-type/engine-type';

@Component({
  selector: 'app-new-record-item',
  templateUrl: './new-record-item.component.html',
  styleUrls: ['./new-record-item.component.css']
})
export class NewRecordItemComponent implements OnInit {
  form: FormGroup;
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

  navigateToListRecordComponent(): void {
    this.router.navigate(['/records']);
  }

  saveNewRecord(form: FormGroup): void {
    // Save vehicle
    console.log(form.value);
    //this.router.navigate(['/records']);
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
      engineType: new EngineType(1, '1.9 TDI'),
      engineCapacity: 12,
      enginePower: 12,
      doorType: new DoorType(3, '5-deurs'),
      fuelCard: new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
      volume: 2000,
      category: null,
      fiscalHP: 50,
      emission: 1,
      power: 300,
      licensePlate: '1-abc-123',
      endDateDelivery: new Date('2020-01-16'),
      isActive: true,
      chassis: 'feoipajfpoaezfjipio',
      registrationDate: new Date('2020-01-16'),
      country: new Country(1, 'België', 'BE', 'Belg', false, true),
      buildYear: 2012,
      kilometers: 5000,
      averageFuel: 50
    }]
  }


}
