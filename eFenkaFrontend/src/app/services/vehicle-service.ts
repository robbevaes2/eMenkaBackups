import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Vehicle } from '../models/vehicle/vehicle';

const BASE_API_VEHICLES = 'https://localhost:44356/api/vehicle';

@Injectable()
export class VehicleService{
  constructor(private http: HttpClient) { }

  getAllVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>(BASE_API_VEHICLES).pipe(
      catchError(this.handleError)
    );
  }

  getVehicleById(id: number): Observable<Vehicle> {
    return this.http.get<Vehicle>(BASE_API_VEHICLES + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  updateVehicle(id: number, updatedVehicle: Vehicle) {
    return this.http.put(BASE_API_VEHICLES + '/' + id, updatedVehicle).pipe(
      catchError(this.handleError)
    );
  }

  addVehicle(vehicle: Vehicle) {
    return this.http.post(BASE_API_VEHICLES, vehicle).pipe(
      catchError(this.handleError)
    );
  }

  deleteVehicle(id: string) {
    return this.http.delete(BASE_API_VEHICLES + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {
      console.error(
        `Backend returned error code ${error.status}, ` +
        `body was: ${error.error}`
      );
    }
    console.log(error);
    return throwError(error);
  }
}
