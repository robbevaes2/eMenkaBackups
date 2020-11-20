import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { Serie } from '../../models/serie/serie';
import { Vehicle } from '../../models/vehicle/vehicle';
import { FuelType } from '../../models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { EngineType } from '../../models/engine-type/engine-type';
import { VehicleService } from '../../services/vehicle-service';
import { stringify } from 'querystring';

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
  engineTypes: EngineType[];
  doorTypes: DoorType[];
  fuelTypes: FuelType[];
  fuelCards: FuelCard[];

  constructor(private router: Router, private vehicleService: VehicleService) { }

  ngOnInit(): void {
    this.setBrands();
    this.setDoorTypes();
    this.setFuelTypes();
    this.setFuelCards();

    this.form = new FormGroup({
      brand: new FormControl(null, [Validators.required]),
      model: new FormControl(null, [Validators.required]),
      serie: new FormControl(null, [Validators.required]),
      engineType: new FormControl(null, [Validators.required]),
      doorType: new FormControl(null, [Validators.required]),
      fuelCard: new FormControl(null, [Validators.required]),
      fuelType: new FormControl(null, [Validators.required]),
      volume: new FormControl(null, [Validators.required, Validators.min(0)]),
      power: new FormControl(null, [Validators.required, Validators.min(0)]),
      fiscalHP: new FormControl(null, [Validators.required, Validators.min(0)]),
      emission: new FormControl(null, [Validators.required, Validators.min(0)]),
      endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      licensePlate: new FormControl(null, [Validators.required])
    });
  }

  mapToModel(values: any): any {
    return {
      brandId: Number(values.brand),
      modelId:  Number(values.model),
      fuelTypeId:  Number(values.fuelType),
      engineTypeId:  Number(values.engineType),
      doorTypeId:  Number(values.doorType),
      fuelCardId:  Number(values.fuelCard),
      volume: values.volume,
      fiscalHP: values.fiscalHP,
      emission: values.emission,
      power: values.power,
      isActive: true,
      categoryId: 1,
      licensePlate: values.licensePlate,
      chassis: null,
      endDateDelivery: values.endDate
    };
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    console.log('changed with ' + brandId);

    this.setModels(brandId);
    this.setSeries(brandId);
    this.setEngineTypes(brandId);
  }

  navigateToListVehicleComponent(): void {
    this.router.navigate(['/vehicles']);
  }

  saveNewVehicle(form: FormGroup): void {
    // Save vehicle
    this.vehicleService.addVehicle(this.mapToModel(form.value)).subscribe(
      (result) => {
        console.log(result);
      });

    if (confirm('Bent u zeker dat u deze wagen wilt opslaan?')) {
      this.router.navigate(['/vehicles']);
    }
  }

  setBrands(): void {
    this.vehicleService.getAllBrands().subscribe(data => this.brands = data);

    /*this.brands = [
      new Brand(1, 'BMW'),
      new Brand(2, 'Ford'),
      new Brand(3, 'Volkswagen')
    ];*/
  }

  setModels(brandId: number): void {
    this.vehicleService.getAllModelsByBrandId(brandId).subscribe(data => this.models = data);

    /*return [
      new Model(1, 'A4'),
      new Model(2, 'A5'),
      new Model(3, 'A6')
    ];*/
  }

  setSeries(brandId: number): void {
    this.vehicleService.getAllSeriesByBrandId(brandId).subscribe(data => this.series = data);

    /*return [
      new Serie(1, 'Sportback'),
      new Serie(2, 'Berline'),
      new Serie(3, 'SUV')
    ];*/
  }

  setEngineTypes(brandId: number): void {
    this.vehicleService.getAllEngineTypesByBrandId(brandId).subscribe(data => this.engineTypes = data);

    /*return [
      new EngineType(1, '1.9 TDI'),
      new EngineType(2, '2.0 TDI'),
      new EngineType(3, '2.0 TDI e')
    ];*/
  }

  setDoorTypes(): void {
    this.vehicleService.getAllDoorTypesByBrandId().subscribe(data => this.doorTypes = data);

    /*return [
      new DoorType(1, '2-deurs'),
      new DoorType(2, '3-deurs'),
      new DoorType(3, '5-deurs')
    ];*/
  }

  setFuelTypes(): void {
    this.vehicleService.getAllFuelTypesByBrandId().subscribe(data => this.fuelTypes = data);

    /*return [
      new FuelType(1, 'Benzine'),
      new FuelType(2, 'Diesel'),
      new FuelType(3, 'Elektrisch')
    ];*/
  }

  setFuelCards(): void {
    this.vehicleService.getAllFuelCardsByBrandId().subscribe(data => this.fuelCards = data);

    /*return [
      new FuelCard(1, null, null, null, null, null, true),
      new FuelCard(2, null, null, null, null, null, true)
    ];*/
  }
}
