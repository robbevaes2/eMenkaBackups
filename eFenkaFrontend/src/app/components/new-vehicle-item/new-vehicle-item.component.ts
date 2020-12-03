import { ExteriorColor } from './../../models/exterior-color/exterior-color';
import { Country } from 'src/app/models/country/country';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { Serie } from '../../models/serie/serie';
import { FuelType } from '../../models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { EngineType } from '../../models/engine-type/engine-type';
import { ApiService } from '../../services/api.service';
import { Category } from '../../models/category/category';
import { InteriorColor } from 'src/app/models/interior-color/interior-color';

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
  countries: Country[];
  interiorColors: InteriorColor[];
  exteriorColors: ExteriorColor[];

  constructor(private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    this.countries = this.getCountries();
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
      fuelType: new FormControl(null, [Validators.required, Validators.min(0)]),
      volume: new FormControl(null, [Validators.required, Validators.min(0)]),
      enginePower: new FormControl(null, [Validators.required, Validators.min(0)]),
      fiscalHP: new FormControl(null, [Validators.required, Validators.min(0)]),
      emission: new FormControl(null, [Validators.required, Validators.min(0)]),
      endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
      licensePlate: new FormControl(null, [Validators.required]),
      chassis: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required]),
      country: new FormControl(null, [Validators.required]),
      engineCapacity: new FormControl(null, [Validators.required, Validators.min(0)]),
      buildYear: new FormControl(null, [Validators.required, Validators.min(0)]),
      kilometers: new FormControl(null, [Validators.required, Validators.min(0)]),
      exteriorColor: new FormControl(null, [Validators.required]),
      interiorColor: new FormControl(null, [Validators.required])
    });
  }

  mapToModel(values: any): any {
    return {
      brandId: Number(values.brand),
      modelId: Number(values.model),
      fuelTypeId: Number(values.fuelType),
      engineTypeId: Number(values.engineType),
      doorTypeId: Number(values.doorType),
      fuelCardId: null,
      seriesId: Number(values.serie),
      volume: values.volume,
      fiscalHP: values.fiscalHP,
      emission: values.emission,
      enginePower: Number(values.enginePower),
      isActive: true,
      categoryId: Number(values.category),
      licensePlate: values.licensePlate,
      chassis: values.chassis,
      engineCapacity: values.engineCapacity,
      endDateDelivery: values.endDate,
      countryId: Number(values.country),
      buildYear: Number(values.buildYear),
      kilometers: Number(values.kilometers),
      exteriorColorId: Number(values.exteriorColor),
      interiorColorId: Number(values.interiorColor)
    };
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    console.log('changed with ' + brandId);

    this.setModels(brandId);
    this.setSeries(brandId);
    this.setEngineTypes(brandId);
    this.setSelectedBrand(brandId);

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

  setSelectedBrand(brandId: number): void {
    this.apiService.getBrandById(brandId).subscribe(data => {
      this.interiorColors = data.interiorColors;
      this.exteriorColors = data.exteriorColors;
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
}
