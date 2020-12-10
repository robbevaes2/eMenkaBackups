import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { faVihara } from '@fortawesome/free-solid-svg-icons';
import { FuelCard } from 'src/app/models/fuel-card/fuel-card';
import { ApiService } from 'src/app/services/api.service';
import { Record } from '../../models/record/record';
import { Vehicle } from '../../models/vehicle/vehicle';

@Component({
  selector: 'app-notifications',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.css']
})
export class NotificationsComponent implements OnInit {
  recordsExpiredWithinTenDays: Record[];
  recordsExpiredWithinFiveDays: Record[];
  vehiclesExpiredWithinTenDays: Vehicle[];
  vehiclesExpiredWithinFiveDays: Vehicle[];
  fuelCardsExpiredWithinTenDays: FuelCard[];
  fuelCardsExpiredWithinFiveDays: FuelCard[];

  constructor(private apiService: ApiService, private datepipe: DatePipe, private router: Router) { }

  ngOnInit(): void {
    // nog tot max 10 dagen geldig -> oranje
    // nog tot max 5 dagen geldig -> rood
    const range = 10;
    this.setExpiredRecords(range);
    this.setExpiredVehicles(range);
  }

  setExpiredRecords(range: number): void {
    this.recordsExpiredWithinFiveDays = [];
    this.recordsExpiredWithinTenDays = [];

    this.apiService.getAllRecordsByEndDate(range).subscribe(data => {
      data.forEach(record => {
        const days = this.getDaysBetweenDates(record.endDate);

        if (days <= 5) {
          this.recordsExpiredWithinFiveDays.push(record);
        } else {
          this.recordsExpiredWithinTenDays.push(record);
        }
      })
    });
  }

  setExpiredVehicles(range: number): void {
    this.vehiclesExpiredWithinFiveDays = [];
    this.vehiclesExpiredWithinTenDays = [];

    this.apiService.getAllVehiclesByEndDate(range).subscribe(data => {
      data.forEach(vehicle => {
        const days = this.getDaysBetweenDates(vehicle.endDateDelivery);

        if (days <= 5) {
          this.vehiclesExpiredWithinFiveDays.push(vehicle);
        } else {
          this.vehiclesExpiredWithinTenDays.push(vehicle);
        }
      })
    });
  }

  getStringFormatOfRecord(record: Record): string {
    const days = this.getDaysBetweenDates(record.endDate);
    return "Dossier " + record.id + " vervalt binnen " + days + " dag(en)";
  }

  getStringFormatOfVehicle(vehicle: Vehicle): string {
    const days = this.getDaysBetweenDates(vehicle.endDateDelivery);
    return "Voertuig " + vehicle.id + " vervalt binnen " + days + " dag(en)";
  }

  getStringFormatOfFuelCard(fuelCard: FuelCard): string {
    const days = this.getDaysBetweenDates(fuelCard.endDate);
    return "Tankkaart " + fuelCard.id + " vervalt binnen " + days + " dag(en)";
  }

  getDaysBetweenDates(endDate: Date): number {
    return Math.ceil((new Date(endDate).getTime() - new Date().getTime()) / (1000 * 3600 * 24));
  }

  navigateToRecordDetailsComponent(index: number): void {
    this.router.navigate(['/records', index]);
  }

  navigateToVehicleDetailsComponent(index: number): void {
    this.router.navigate(['/vehicles', index]);
  }

  navigateToFuelCardDetailsComponent(index: number): void {
    this.router.navigate(['/fuelcards', index]);
  }
}
