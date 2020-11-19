import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Vehicle } from 'src/app/models/vehicle/vehicle';

@Component({
  selector: 'app-record-details',
  templateUrl: './record-details.component.html',
  styleUrls: ['./record-details.component.css']
})
export class RecordDetailsComponent implements OnInit {
  isEditable: boolean;
  form: FormGroup;
  selectedRecord: Vehicle;

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    const recordId = this.route.snapshot.params['index'];
    this.form = new FormGroup({

    });
  }

  fillForm(): void {
    this.form.controls['Type'].setValue(this.selectedRecord.brand.id);
    this.form.controls['licensePlate'].setValue(this.selectedRecord.model.id);
    this.form.controls['chassis'].setValue(this.selectedRecord.motorType.id);
    this.form.controls['registrationDate'].setValue(this.selectedRecord.fuelCard.id);
    this.form.controls['country'].setValue(this.selectedRecord.fuelType.id);
    this.form.controls['volume'].setValue(this.selectedRecord.volume);
    this.form.controls['power'].setValue(this.selectedRecord.power);
    this.form.controls['fiscalePk'].setValue(this.selectedRecord.fiscaleHp);
    this.form.controls['emission'].setValue(this.selectedRecord.emission);
    this.form.controls['endDate'].setValue(this.selectedRecord.endData.toISOString().split('T')[0]);
    this.form.controls['licensePlate'].setValue(this.selectedRecord.licensePlate);
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
}
