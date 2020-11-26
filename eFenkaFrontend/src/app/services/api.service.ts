import { Corporation } from './../models/corporation/corporation';
import { Record } from 'src/app/models/record/record';
import { Model } from './../models/model/model';
import {Injectable} from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
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
import { CostAllocation } from '../models/cost-allocatoin/cost-allocation';
import { Driver } from '../models/driver/driver';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  BASE_API_URL = 'https://localhost:44356/api/';

  constructor(private http: HttpClient) {
  }

  // Generic CRUD methods
  private getFromAPI<T>(url) {
    return this.http
      .get<T>(this.BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private postToAPI(url, data) {
    return this.http
      .post(this.BASE_API_URL + url, data)
      .pipe(catchError(this.handleError));
  }

  private putToAPI(url, data, headers?: HttpHeaders) {
    return this.http
      .put(this.BASE_API_URL + url, data, {headers})
      .pipe(catchError(this.handleError));
  }

  private patchToAPI(url, data, headers?: HttpHeaders) {
    return this.http.patch(this.BASE_API_URL + url, data, {headers}).pipe(
      catchError((err, caught) => {
        console.error(err);
        console.error(caught);
        return throwError('Something bad happened; please try again later.');
      })
    );
  }

  private deleteFromAPI(url) {
    return this.http
      .delete(this.BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private deleteMultipleFromAPI(url, options) {
    return this.http
      .delete(this.BASE_API_URL + url, options)
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
    return this.getFromAPI<Vehicle[]>('vehicle/');
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
    return this.getFromAPI<Record[]>('record/');
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
    return this.deleteFromAPI('record/' + id);
  }

  // Brands

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

  getAllVehiclesByBrandId(id: number): Observable<Vehicle[]> {
    return this.getFromAPI<Vehicle[]>('vehicle/brand/' + id);
  }

  // FuelType

  getAllFuelTypes(): Observable<FuelType[]> {
    return this.getFromAPI<FuelType[]>('fueltype/');
  }

  // FuelCard

  getAllFuelCards(): Observable<FuelCard[]> {
    return this.getFromAPI<FuelCard[]>('fuelcard/');
  }

  getFuelCardById(id: number): Observable<FuelCard> {
    return this.getFromAPI<FuelCard>('fuelcard/' + id);
  }

  updateFuelCard(id: number, FuelCardModel: any) {
    return this.putToAPI('fuelcard/' + id, FuelCardModel);
  }

  // DoorType

  getAllDoorTypes(): Observable<DoorType[]> {
    return this.getFromAPI<DoorType[]>('doortype/');
  }

  // Categorie

  getAllCategories(): Observable<Category[]> {
    return this.getFromAPI<Category[]>('category/');
  }

  // Corporation

  getAllCorporatoins(): Observable<Corporation[]> {
    return this.getFromAPI<Corporation[]>('corporation/');
  }

  // CostAllocation

  getAllCostAllocations(): Observable<CostAllocation[]> {
    return this.getFromAPI<CostAllocation[]>('costallocation/');
  }

  // Driver

  getAllDrivers(): Observable<Driver[]> {
    return this.getFromAPI<Driver[]>('driver/');
  }

  getDriverById(id: number): Observable<Driver> {
    return this.getFromAPI<Driver>('driver/' + id);
  }

  updateDriver(id: number, driverModel: any) {
    return this.putToAPI('driver/' + id, driverModel);
  }

  addDriver(driverModel: any) {
    return this.postToAPI('driver/', driverModel);
  }

  deleteDriver(id: number) {
    return this.deleteFromAPI('driver/' + id);
  }
}
