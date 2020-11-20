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
import { ApiService } from '../../services/api.service';
import { Category } from '../../models/category/category';

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
  categories: Category[];

  constructor(private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    this.setBrands();
    this.setDoorTypes();
    this.setFuelTypes();
    this.setFuelCards();
    this.setCategories();

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
      licensePlate: new FormControl(null, [Validators.required]),
      chassis: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required])
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
      categoryId: Number(values.category),
      licensePlate: values.licensePlate,
      chassis: values.chassis,
      endDateDelivery: values.endDate,
      seriesId: Number(values.serie)
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
    if (confirm('Bent u zeker dat u deze wagen wilt opslaan?')) {
      this.apiService.addVehicle(this.mapToModel(form.value)).subscribe(() => this.router.navigate(['/vehicles']));
    }
  }

  setBrands(): void {
    this.apiService.getAllBrands().subscribe(data => this.brands = data);
  }

  setModels(brandId: number): void {
    this.apiService.getAllModelsByBrandId(brandId).subscribe(data => this.models = data);
  }

  setSeries(brandId: number): void {
    this.apiService.getAllSeriesByBrandId(brandId).subscribe(data => this.series = data);
  }

  setEngineTypes(brandId: number): void {
    this.apiService.getAllEngineTypesByBrandId(brandId).subscribe(data => this.engineTypes = data);
  }

  setDoorTypes(): void {
    this.apiService.getAllDoorTypes().subscribe(data => this.doorTypes = data);
  }

  setFuelTypes(): void {
    this.apiService.getAllFuelTypes().subscribe(data => this.fuelTypes = data);
  }

  setFuelCards(): void {
    this.apiService.getAllFuelCards().subscribe(data => this.fuelCards = data);
  }

  setCategories(): void {
    this.apiService.getAllCategories().subscribe(data => this.categories = data);
  }
}
