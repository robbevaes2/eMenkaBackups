import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Brand } from 'src/app/models/brand/brand';
import { Country } from 'src/app/models/country/country';
import { DoorType } from 'src/app/models/door-type/door-type';
import { EngineType } from 'src/app/models/engine-type/engine-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Model } from 'src/app/models/model/model';
import { Serie } from 'src/app/models/serie/serie';
import { Vehicle } from 'src/app/models/vehicle/vehicle';
import { VehicleService } from 'src/app/services/vehicle-service';
import { FuelType } from '../../models/fuel-type/fuel-type';
import { ApiService } from '../../services/api.service';
import { Category } from '../../models/category/category';

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
  engineTypes: EngineType[];
  doorTypes: DoorType[];
  fuelTypes: FuelType[];
  fuelCards: FuelCard[];
  categories: Category[];
  selectedVehicle: Vehicle;
  isEditable: boolean;

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    const vehicleId = this.route.snapshot.params['index'];
    //setVehicle(vehicleId);
    this.apiService.getVehicleById(vehicleId).subscribe(data => {

      this.selectedVehicle = data;
      console.log(this.selectedVehicle);

      this.setBrands();
      this.setDoorTypes();
      this.setFuelTypes();
      this.setFuelCards();
      this.setCategories();
      //this.setAllDropDownsByBrand(vehicleId);
      this.setModels(this.selectedVehicle.brand.id);
      this.setSeries(this.selectedVehicle.brand.id);
      this.setEngineTypes(this.selectedVehicle.brand.id);

      this.form = new FormGroup({
        brand: new FormControl(null, [Validators.required]),
        model: new FormControl(null, [Validators.required]),
        serie: new FormControl(null, [Validators.required]),
        engineType: new FormControl(null, [Validators.required]),
        doorType: new FormControl(null, [Validators.required]),
        fuelCard: new FormControl(null, [Validators.required, Validators.min(0)]),
        fuelType: new FormControl(null, [Validators.required, Validators.min(0)]),
        volume: new FormControl(null, [Validators.required, Validators.min(0)]),
        power: new FormControl(null, [Validators.required, Validators.min(0)]),
        fiscalHP: new FormControl(null, [Validators.required, Validators.min(0)]),
        emission: new FormControl(null, [Validators.required, Validators.min(0)]),
        endDate: new FormControl(null, [Validators.required, Validators.min(0)]),
        licensePlate: new FormControl(null, [Validators.required]),
        chassis: new FormControl(null, [Validators.required]),
        category: new FormControl(null, [Validators.required])
      });

      this.fillForm();
      this.disableForm();
    });
  }

  fillForm(): void {
    this.form.controls['brand'].setValue(this.selectedVehicle.brand?.id);
    this.form.controls['model'].setValue(this.selectedVehicle.model?.id);
    this.form.controls['serie'].setValue(this.selectedVehicle.serie?.id);
    this.form.controls['engineType'].setValue(this.selectedVehicle.engineType?.id);
    this.form.controls['doorType'].setValue(this.selectedVehicle.doorType?.id);
    this.form.controls['fuelCard'].setValue(this.selectedVehicle.fuelCard?.id);
    this.form.controls['fuelType'].setValue(this.selectedVehicle.fuelType?.id);
    this.form.controls['volume'].setValue(this.selectedVehicle.volume);
    this.form.controls['power'].setValue(this.selectedVehicle.power);
    this.form.controls['fiscalHP'].setValue(this.selectedVehicle.fiscalHP);
    this.form.controls['emission'].setValue(this.selectedVehicle.emission);
    this.form.controls['endDate'].setValue(new Date(this.selectedVehicle.endDateDelivery).toISOString().substring(0, 10));
    this.form.controls['licensePlate'].setValue(this.selectedVehicle.licensePlate);
    this.form.controls['chassis'].setValue(this.selectedVehicle.chassis);
    this.form.controls['category'].setValue(this.selectedVehicle.category?.id);
  }

  disableForm(): void {
    this.form.controls['brand'].disable();
    this.form.controls['model'].disable();
    this.form.controls['serie'].disable();
    this.form.controls['engineType'].disable();
    this.form.controls['doorType'].disable();
    this.form.controls['fuelCard'].disable();
    this.form.controls['fuelType'].disable();
    this.form.controls['volume'].disable();
    this.form.controls['power'].disable();
    this.form.controls['fiscalHP'].disable();
    this.form.controls['emission'].disable();
    this.form.controls['endDate'].disable();
    this.form.controls['licensePlate'].disable();
    this.form.controls['chassis'].disable();
    this.form.controls['category'].disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls['brand'].enable();
    this.form.controls['model'].enable();
    this.form.controls['serie'].enable();
    this.form.controls['engineType'].enable();
    this.form.controls['doorType'].enable();
    this.form.controls['fuelCard'].enable();
    this.form.controls['fuelType'].enable();
    this.form.controls['volume'].enable();
    this.form.controls['power'].enable();
    this.form.controls['fiscalHP'].enable();
    this.form.controls['emission'].enable();
    this.form.controls['endDate'].enable();
    this.form.controls['licensePlate'].enable();
    this.form.controls['chassis'].enable();
    this.form.controls['category'].enable();
    this.isEditable = true;
  }

  onChangedBrand(event): void {
    const brandId = event.target.value;
    console.log('changed with ' + brandId);
    this.setAllDropDownsByBrand(brandId);
  }

  setAllDropDownsByBrand(brandId: number): void {
    // Do get requests with brandId
    this.setModels(brandId);
    this.setSeries(brandId);
    this.setEngineTypes(brandId);
  }

  navigateToListVehicleComponent(): void {
    this.router.navigate(['/vehicles']);
  }

  saveEditVehicle(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u deze wagen wilt opslaan?')) {
        console.log(this.mapToModel(form.value));
        this.apiService.updateVehicle(this.selectedVehicle.id, this.mapToModel(form.value)).subscribe(() => {
          this.apiService.getVehicleById(this.selectedVehicle.id).subscribe(data => {
            this.selectedVehicle = data;
            this.fillForm();
            this.disableForm();
          });
        });
      }
    } else {
      this.enableForm();
    }
  }

  deleteVehicle(): void {
    if (confirm('Bent u zeker dat u deze wagen wilt verwijderen?')) {
      this.apiService.deleteVehicle(this.selectedVehicle.id).subscribe(() => this.navigateToListVehicleComponent());
    }
  }

  cancel(): void {
    this.setAllDropDownsByBrand(this.selectedVehicle.brand.id);
    this.fillForm();
    this.disableForm();
  }

  mapToModel(values: any): any {
    return {
      Id: this.selectedVehicle.id,
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

  setVehicle(id: number): void {
    this.apiService.getVehicleById(id).subscribe(data => this.selectedVehicle = data);
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
