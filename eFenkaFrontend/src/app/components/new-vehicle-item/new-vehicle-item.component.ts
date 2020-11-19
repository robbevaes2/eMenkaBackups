import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { MotorType } from '../../models/motor-type/motor-type';
import { Serie } from '../../models/serie/serie';
import { Vehicle } from '../../models/vehicle/vehicle';
import { FuelType } from '../../models/FuelType/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';

@Component({
  selector: 'app-new-vehicle-item',
  templateUrl: './new-vehicle-item.component.html',
  styleUrls: ['./new-vehicle-item.component.css']
})
export class NewVehicleItemComponent implements OnInit {
  form: FormGroup;
  brands: Brand[];
  models: Model[];
  series: Serie[];
  motorTypes: MotorType[];
  doorTypes: DoorType[];
  fuelTypes: FuelType[];
  fuelCards: FuelCard[];

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.brands = this.getBrands();
    this.doorTypes = this.getDoorTypes();
    this.fuelTypes = this.getFuelTypes();
    this.fuelCards = this.getFuelCards();

    this.form = new FormGroup({
      brand: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      serie: new FormControl(null, [Validators.required]),
      motorType: new FormControl(null, [Validators.required]),
      doorType: new FormControl(null, [Validators.required]),
      fuelCard: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required]),
      volume: new FormControl(null, [Validators.required, Validators.min(0)]),
      power: new FormControl(null, [Validators.required, Validators.min(0)]),
      fiscalePk: new FormControl(null, [Validators.required, Validators.min(0)]),
      emission: new FormControl(null, [Validators.required, Validators.min(0)]),
      endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      licensePlate: new FormControl(null, [Validators.required])
    });
  }

  onChangedBrand(event): void {
    // Do get requests with brandId
    const brandId = event.target.value;
    console.log('changed with ' + brandId);

    this.models = this.getModels();
    this.series = this.getSeries();
    this.motorTypes = this.getMotorTypes();
  }

  navigateToListVehicleComponent(): void {
    this.router.navigate(['/vehicles']);
  }

  saveNewVehicle(form: FormGroup): void {
    // Save vehicle
    console.log(form.value);
    //this.router.navigate(['/vehicles']);
  }

  getBrands(): Brand[] {
    return [
      new Brand(1, 'Audi'),
      new Brand(2, 'Ferrari'),
      new Brand(3, 'Bugatti')
    ];
  }

  getModels(): Model[] {
    return [
      new Model(1, 'A4'),
      new Model(2, 'A5'),
      new Model(3, 'A6')
    ];
  }

  getSeries(): Serie[] {
    return [
      new Serie(1, 'Sportback'),
      new Serie(2, 'Berline'),
      new Serie(3, 'SUV')
    ];
  }

  getMotorTypes(): MotorType[] {
    return [
      new MotorType(1, '1.9 TDI'),
      new MotorType(2, '2.0 TDI'),
      new MotorType(3, '2.0 TDI e')
    ];
  }

  getDoorTypes(): DoorType[] {
    return [
      new DoorType(1, '2-deurs'),
      new DoorType(2, '3-deurs'),
      new DoorType(3, '5-deurs')
    ];
  }

  getFuelTypes(): FuelType[] {
    return [
      new FuelType(1, 'Benzine'),
      new FuelType(2, 'Diesel'),
      new FuelType(3, 'Elektrisch')
    ];
  }

  getFuelCards(): FuelCard[] {
    return [
      new FuelCard(1, null, null, null, null, null, true),
      new FuelCard(2, null, null, null, null, null, true)
    ];
  }
}
