import {Model} from 'src/app/models/model/model';
import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Brand} from '../models/brand/brand';
import {Vehicle} from '../models/vehicle/vehicle';
import {EngineType} from '../models/engine-type/engine-type';
import {Serie} from '../models/serie/serie';
import {FuelType} from '../models/fuel-type/fuel-type';
import {FuelCard} from '../models/fuel-card/fuel-card';
import {DoorType} from '../models/door-type/door-type';
import {Injectable} from '@angular/core';

const BASE_API_VEHICLES = 'https://localhost:44356/api/vehicle';
const BASE_API_BRANDS = 'https://localhost:44356/api/brand';
const BASE_API_MODELS = 'https://localhost:44356/api/model';
const BASE_API_SERIES = 'https://localhost:44356/api/serie';
const BASE_API_ENGINE_TYPE = 'https://localhost:44356/api/enginetype';
const BASE_API_DOOR_TYPE = 'https://localhost:44356/api/doortype';
const BASE_API_FUEL_CARD = 'https://localhost:44356/api/fuelcard';
const BASE_API_FUEL_TYPE = 'https://localhost:44356/api/fueltype';

@Injectable()
export class VehicleService {
  constructor(private http: HttpClient) {
  }

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

  updateVehicle(id: number, updatedVehicle: Vehicle): any {
    return this.http.put(BASE_API_VEHICLES + '/' + id, updatedVehicle).pipe(
      catchError(this.handleError)
    );
  }

  addVehicle(vehicleModel: any): any {
    console.log(vehicleModel);
    return this.http.post(BASE_API_VEHICLES, vehicleModel).pipe(
      catchError(this.handleError)
    );
  }

  deleteVehicle(id: string): any {
    return this.http.delete(BASE_API_VEHICLES + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  getAllBrands(): Observable<Brand[]> {
    return this.http.get<Brand[]>(BASE_API_BRANDS).pipe(
      catchError(this.handleError)
    );
  }

  getAllModelsByBrandId(brandId: number): Observable<Model[]> {
    return this.http.get<Model[]>(BASE_API_MODELS + '/brand/' + brandId).pipe(
      catchError(this.handleError)
    );
  }

  getAllSeriesByBrandId(brandId: number): Observable<Serie[]> {
    return this.http.get<Serie[]>(BASE_API_SERIES + '/brand/' + brandId).pipe(
      catchError(this.handleError)
    );
  }

  getAllEngineTypesByBrandId(brandId: number): Observable<EngineType[]> {
    return this.http.get<EngineType[]>(BASE_API_ENGINE_TYPE + '/brand/' + brandId).pipe(
      catchError(this.handleError)
    );
  }

  getAllFuelTypesByBrandId(): Observable<FuelType[]> {
    return this.http.get<FuelType[]>(BASE_API_FUEL_TYPE).pipe(
      catchError(this.handleError)
    );
  }

  getAllFuelCardsByBrandId(): Observable<FuelCard[]> {
    return this.http.get<FuelCard[]>(BASE_API_FUEL_CARD).pipe(
      catchError(this.handleError)
    );
  }

  getAllDoorTypesByBrandId(): Observable<DoorType[]> {
    return this.http.get<DoorType[]>(BASE_API_DOOR_TYPE).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse): Observable<any> {
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
