import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Brand } from '../../models/brand/brand';
import { DoorType } from '../../models/door-type/door-type';
import { Model } from '../../models/model/model';
import { Vehicle } from '../../models/vehicle/vehicle';
import { from } from 'rxjs';
import { FuelType } from 'src/app/models/fuel-type/fuel-type';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { Country } from 'src/app/models/country/country';
import { VehicleService } from '../../services/vehicle-service';
import { EngineType } from 'src/app/models/engine-type/engine-type';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {
  vehicles: Vehicle[];
  pageAmounts = [5,10,25];

  ascDescBoolean: boolean;

  page = 1;
  selectedAmount = this.pageAmounts[0];

  constructor(private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    this.apiService.getAllVehicles().subscribe(data => this.vehicles = data);
  }

  navigateToNewVehicleComponent(): void {
    this.router.navigate(['/vehicles/new']);
  }

  navigateToVehicleDetailsComponent(index: number): void {
    this.router.navigate(['/vehicles', index]);
  }

  dateToStringConverter(date: string) {
    return new Date(date).toLocaleDateString();
  }

  switchPage(event): void {
    this.page = event;
  }

  isUndefined() {
    if (this.ascDescBoolean == undefined) {
      this.ascDescBoolean = true;
    }
  }

  sortByBrand() {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const name1 = t1.brand.name.toLowerCase();
        const name2 = t2.brand.name.toLowerCase();
        if (name2 > name1) { return 1; }
        if (name2 < name1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const name1 = t1.brand.name.toLowerCase();
        const name2 = t2.brand.name.toLowerCase();
        if (name1 > name2) { return 1; }
        if (name1 < name2) { return -1; }
        return 0;
      });
    }
  }

  /*
  sortByDate() {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const date1 = t1.endDateDelivery;
        const date2 = t2.endDateDelivery;

        if (date2 > date1) { return 1; }
        if (date2 < date1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const date1 = t1.endDateDelivery;
        const date2 = t2.endDateDelivery;
        if (date1 > date2) { return 1; }
        if (date1 < date2) { return -1; }
        return 0;
      });
    }
  }

  sortByVolume() {
    this.isUndefined();

    console.log(this.ascDescBoolean)

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const vol1 = t1.volume;
        const vol2 = t2.volume;

        if (vol2 > vol1) { return 1; }
        if (vol2 < vol1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const vol1 = t1.volume;
        const vol2 = t2.volume;

        if (vol2 < vol1) { return 1; }
        if (vol2 > vol1) { return -1; }
        return 0;
      });
    }
  }

  sortByFiscalHp() {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const hp1 = t1.fiscalePk;
        const hp2 = t2.fiscalePk;

        if (hp2 > hp1) { return 1; }
        if (hp2 < hp1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const hp1 = t1.fiscalePk;
        const hp2 = t2.fiscalePk;

        if (hp2 < hp1) { return 1; }
        if (hp2 > hp1) { return -1; }
        return 0;
      });
    }
  }

  sortByPower() {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const power1 = t1.power;
        const power2 = t2.power;

        if (power2 > power1) { return 1; }
        if (power2 < power1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const power1 = t1.power;
        const power2 = t2.power;

        if (power2 < power1) { return 1; }
        if (power2 > power1) { return -1; }
        return 0;
      });
    }
  }
  */

  sort(type: string) {
    this.isUndefined();

    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.vehicles.sort((t1, t2) => {
        const value1 = t1[type];
        const value2 = t2[type];

        if (value2 > value1) { return 1; }
        if (value2 < value1) { return -1; }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.vehicles.sort((t1, t2) => {
        const value1 = t1[type];
        const value2 = t2[type];

        if (value2 < value1) { return 1; }
        if (value2 > value1) { return -1; }
        return 0;
      });
    }
  }
}
