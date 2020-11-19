import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Brand } from 'src/app/models/brand/brand';
import { Country } from 'src/app/models/country/country';
import { DoorType } from 'src/app/models/door-type/door-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Model } from 'src/app/models/model/model';
import { MotorType } from 'src/app/models/motor-type/motor-type';
import { Serie } from 'src/app/models/serie/serie';
import { Vehicle } from 'src/app/models/vehicle/vehicle';
import { FuelType } from '../../models/fuel-type/fuel-type';

@Component({
  selector: 'app-vehicle-details',
  templateUrl: './vehicle-details.component.html',
  styleUrls: ['./vehicle-details.component.css']
})
export class VehicleDetailsComponent implements OnInit {
  form: FormGroup;
  brands: Brand[];
  models: Model[];
  series: Serie[];
  motorTypes: MotorType[];
  doorTypes: DoorType[];
  fuelTypes: FuelType[];
  fuelCards: FuelCard[];
  selectedVehicle: Vehicle;
  isEditable: boolean;

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    const vehicleId = this.route.snapshot.params['index'];
    this.selectedVehicle = this.getVehicle(vehicleId);

    this.brands = this.getBrands();
    this.doorTypes = this.getDoorTypes();
    this.fuelTypes = this.getFuelTypes();
    this.fuelCards = this.getFuelCards();
    this.setAllDropDownsByBrand(this.selectedVehicle.brand.id);

    this.form = new FormGroup({
      brand: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      serie: new FormControl(null, [Validators.required]),
      motorType: new FormControl(null, [Validators.required]),
      doorType: new FormControl(null, [Validators.required]),
      fuelCard: new FormControl(null, [Validators.required, Validators.min(0)]),
      fuelType: new FormControl(null, [Validators.required, Validators.min(0)]),
      volume: new FormControl(null, [Validators.required, Validators.min(0)]),
      power: new FormControl(null, [Validators.required, Validators.min(0)]),
      fiscalePk: new FormControl(null, [Validators.required, Validators.min(0)]),
      emission: new FormControl(null, [Validators.required, Validators.min(0)]),
      endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      licensePlate: new FormControl(null, [Validators.required])
    });

    this.fillForm();
    this.disableForm();
  }

  fillForm(): void {
    this.form.controls['brand'].setValue(this.selectedVehicle.brand.id);
    this.form.controls['model'].setValue(this.selectedVehicle.model.id);
    this.form.controls['serie'].setValue(this.selectedVehicle.serie.id);
    this.form.controls['motorType'].setValue(this.selectedVehicle.motorType.id);
    this.form.controls['doorType'].setValue(this.selectedVehicle.doorType.id);
    this.form.controls['fuelCard'].setValue(this.selectedVehicle.fuelCard.id);
    this.form.controls['fuelType'].setValue(this.selectedVehicle.fuelType.id);
    this.form.controls['volume'].setValue(this.selectedVehicle.volume);
    this.form.controls['power'].setValue(this.selectedVehicle.power);
    this.form.controls['fiscalePk'].setValue(this.selectedVehicle.fiscaleHp);
    this.form.controls['emission'].setValue(this.selectedVehicle.emission);
    this.form.controls['endDate'].setValue(this.selectedVehicle.endData.toISOString().split('T')[0]);
    this.form.controls['licensePlate'].setValue(this.selectedVehicle.licensePlate);
  }

  disableForm(): void {
    this.form.controls['brand'].disable();
    this.form.controls['model'].disable();
    this.form.controls['serie'].disable();
    this.form.controls['motorType'].disable();
    this.form.controls['doorType'].disable();
    this.form.controls['fuelCard'].disable();
    this.form.controls['fuelType'].disable();
    this.form.controls['volume'].disable();
    this.form.controls['power'].disable();
    this.form.controls['fiscalePk'].disable();
    this.form.controls['emission'].disable();
    this.form.controls['endDate'].disable();
    this.form.controls['licensePlate'].disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls['brand'].enable();
    this.form.controls['model'].enable();
    this.form.controls['serie'].enable();
    this.form.controls['motorType'].enable();
    this.form.controls['doorType'].enable();
    this.form.controls['fuelCard'].enable();
    this.form.controls['fuelType'].enable();
    this.form.controls['volume'].enable();
    this.form.controls['power'].enable();
    this.form.controls['fiscalePk'].enable();
    this.form.controls['emission'].enable();
    this.form.controls['endDate'].enable();
    this.form.controls['licensePlate'].enable();
    this.isEditable = true;
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    console.log('changed with ' + brandId);
    this.setAllDropDownsByBrand(brandId);
  }

  setAllDropDownsByBrand(brandId: number): void {
    // Do get requests with brandId
    this.models = this.getModels();
    this.series = this.getSeries();
    this.motorTypes = this.getMotorTypes();
  }

  navigateToListVehicleComponent(): void {
    this.router.navigate(['/vehicles']);
  }

  saveEditVehicle(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Are you sure you want to save this vehicle?')) {
        // Save vehicle and assign new vehicle (get request by vehicleId) to selectedVehicle
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
        this.navigateToListVehicleComponent();
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
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

  getVehicle(id: number): Vehicle {
    return {
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
    }
  }

  getFuelCards(): FuelCard[] {
    return [
      new FuelCard(1, 'feazfazefazefazef', null, null, null, null, null, true),
      new FuelCard(2, 'feazfazefazefazef', null, null, null, null, null, true)
    ]
  }
}
