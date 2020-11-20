import { Corporation } from './../models/corporation/corporation';
import { Record } from 'src/app/models/record/record';
import { Model } from './../models/model/model';
import {Injectable} from '@angular/core';
import {
  HttpClient,
  HttpErrorResponse,
  HttpHeaders,
  HttpParams,
} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import { Vehicle } from '../models/vehicle/vehicle';
import { Brand } from '../models/brand/brand';
import { Serie } from '../models/serie/serie';
import { EngineType } from '../models/engine-type/engine-type';
import { FuelType } from '../models/fuel-type/fuel-type';
import { FuelCard } from '../models/fuel-card/fuel-card';
import { DoorType } from '../models/door-type/door-type';
import { Category } from '../models/category/category';

const BASE_API_URL = 'https://localhost:44356/api/';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private http: HttpClient) {
  }

  // Generic CRUD methods
  private getFromAPI<T>(url) {
    return this.http
      .get<T>(BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private postToAPI(url, data) {
    return this.http
      .post(BASE_API_URL + url, data)
      .pipe(catchError(this.handleError));
  }

  private putToAPI(url, data, headers?: HttpHeaders) {
    return this.http
      .put(BASE_API_URL + url, data, {headers})
      .pipe(catchError(this.handleError));
  }

  private patchToAPI(url, data, headers?: HttpHeaders) {
    return this.http.patch(BASE_API_URL + url, data, {headers}).pipe(
      catchError((err, caught) => {
        console.error(err);
        console.error(caught);
        return throwError('Something bad happened; please try again later.');
      })
    );
  }

  private deleteFromAPI(url) {
    return this.http
      .delete(BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private deleteMultipleFromAPI(url, options) {
    return this.http
      .delete(BASE_API_URL + url, options)
      .pipe(catchError(this.handleError));
  }

  // Error handling

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
    window.alert('Er ging iets verkeerd!');
    return throwError(error);
  }

  // Vehicles

  getAllVehicles(): Observable<Vehicle[]> {
    return this.getFromAPI<Vehicle[]>('vehicle');
  }

  getVehicleById(id: number): Observable<Vehicle> {
    return this.getFromAPI<Vehicle>('vehicle/' + id);
  }

  updateVehicle(id: number, vehicleModel: any) {
    return this.putToAPI('vehicle/' + id, vehicleModel);
  }

  addVehicle(vehicleModel: any) {
    return this.postToAPI('vehicle/', vehicleModel);
  }

  deleteVehicle(id: number) {
    return this.deleteFromAPI('vehicle/' + id);
  }

  // Records

  getAllRecords(): Observable<Record[]> {
    return this.getFromAPI<Record[]>('record');
  }

  getRecordById(id: number): Observable<Record> {
    return this.getFromAPI<Record>('record/' + id);
  }

  updateRecord(id: number, RecordModel: any) {
    return this.putToAPI('record/' + id, RecordModel);
  }

  addRecord(RecordModel: any) {
    console.log(RecordModel);
    return this.postToAPI('record/', RecordModel);
  }

  deleteRecord(id: number) {
    return this.http.delete('record/' + id).pipe(
      catchError(this.handleError)
    );
  }

  getAllBrands(): Observable<Brand[]> {
    return this.getFromAPI<Brand[]>('brand/');
  }

  getAllModelsByBrandId(id: number): Observable<Model[]> {
    return this.getFromAPI<Model[]>('model/brand/' + id);
  }

  getAllSeriesByBrandId(id: number): Observable<Serie[]> {
    return this.getFromAPI<Serie[]>('serie/brand/' + id);
  }

  getAllEngineTypesByBrandId(id: number): Observable<EngineType[]> {
    return this.getFromAPI<EngineType[]>('enginetype/brand/' + id);
  }

  getAllFuelTypes(): Observable<FuelType[]> {
    return this.getFromAPI<FuelType[]>('fueltype/');
  }

  getAllFuelCards(): Observable<FuelCard[]> {
    return this.getFromAPI<FuelCard[]>('fuelcard/');
  }

  getAllDoorTypes(): Observable<DoorType[]> {
    return this.getFromAPI<DoorType[]>('doortype/');
  }

  getAllCategories(): Observable<Category[]> {
    return this.getFromAPI<Category[]>('category/');
  }

  getAllCorporatoins(): Observable<Corporation[]> {
    return this.getFromAPI<Corporation[]>('corporation/');
  }
}
