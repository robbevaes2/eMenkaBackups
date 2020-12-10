import {Corporation} from '../models/corporation/corporation';
import {Record} from 'src/app/models/record/record';
import {Model} from '../models/model/model';
import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Vehicle} from '../models/vehicle/vehicle';
import {Brand} from '../models/brand/brand';
import {Serie} from '../models/serie/serie';
import {EngineType} from '../models/engine-type/engine-type';
import {FuelType} from '../models/fuel-type/fuel-type';
import {FuelCard} from '../models/fuel-card/fuel-card';
import {DoorType} from '../models/door-type/door-type';
import {Category} from '../models/category/category';
import {CostAllocation} from '../models/cost-allocatoin/cost-allocation';
import {Driver} from '../models/driver/driver';
import {Person} from '../models/person/person';
import {Company} from '../models/company/company';
import { Supplier } from '../models/supplier/supplier';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  BASE_API_URL = 'https://localhost:44356/api/';

  constructor(private http: HttpClient) {
  }

  // Generic CRUD methods
  private getFromAPI<T>(url): any {
    return this.http
      .get<T>(this.BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private postToAPI(url, data): any {
    return this.http
      .post(this.BASE_API_URL + url, data)
      .pipe(catchError(this.handleError));
  }

  private putToAPI(url, data, headers?: HttpHeaders): any {
    return this.http
      .put(this.BASE_API_URL + url, data, {headers})
      .pipe(catchError(this.handleError));
  }

  private patchToAPI(url, data, headers?: HttpHeaders): any {
    return this.http.patch(this.BASE_API_URL + url, data, {headers}).pipe(
      catchError((err, caught) => {
        console.error(err);
        console.error(caught);
        return throwError('Something bad happened; please try again later.');
      })
    );
  }

  private deleteFromAPI(url): any {
    return this.http
      .delete(this.BASE_API_URL + url)
      .pipe(catchError(this.handleError));
  }

  private deleteMultipleFromAPI(url, options): any {
    return this.http
      .delete(this.BASE_API_URL + url, options)
      .pipe(catchError(this.handleError));
  }

  // Error handling

  private handleError(error: HttpErrorResponse): any {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {
      console.error(
        `Backend returned error code ${error.status}, ` +
        `body was: ${error.error}`
      );
    }
    console.log(error);
    window.alert(`${error.error}`);
    return throwError(error);
  }

  // Vehicles

  getAllVehicles(): Observable<Vehicle[]> {
    return this.getFromAPI<Vehicle[]>('vehicle/');
  }

  getAllAvailableVehicles(): Observable<Vehicle[]> {
    return this.getFromAPI<Vehicle[]>('vehicle/available');
  }

  getVehicleById(id: number): Observable<Vehicle> {
    return this.getFromAPI<Vehicle>('vehicle/' + id);
  }

  updateVehicle(id: number, vehicleModel: any): any {
    return this.putToAPI('vehicle/' + id, vehicleModel);
  }

  addVehicle(vehicleModel: any): any {
    return this.postToAPI('vehicle/', vehicleModel);
  }

  deleteVehicle(id: number): any {
    return this.deleteFromAPI('vehicle/' + id);
  }

  // Records

  getAllRecords(): Observable<Record[]> {
    return this.getFromAPI<Record[]>('record/');
  }

  getRecordById(id: number): Observable<Record> {
    return this.getFromAPI<Record>('record/' + id);
  }

  updateRecord(id: number, RecordModel: any): any {
    return this.putToAPI('record/' + id, RecordModel);
  }

  addRecord(RecordModel: any): any {
    console.log(RecordModel);
    return this.postToAPI('record/', RecordModel);
  }

  deleteRecord(id: number): any {
    return this.deleteFromAPI('record/' + id);
  }

  // Brands

  getAllBrands(): Observable<Brand[]> {
    return this.getFromAPI<Brand[]>('brand/');
  }

  getBrandById(id: number): Observable<Brand> {
    return this.getFromAPI<Brand>('brand/' + id);
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

  getAllAvailableVehiclesByBrandId(id: number): Observable<Vehicle[]> {
    return this.getFromAPI<Vehicle[]>('vehicle/available/brand/' + id);
  }

  // FuelCard

  getAllFuelCards(): Observable<FuelCard[]> {
    return this.getFromAPI<FuelCard[]>('fuelcard/');
  }

  getFuelCardById(id: number): Observable<FuelCard> {
    return this.getFromAPI<FuelCard>('fuelcard/' + id);
  }

  addFuelcard(fuelCardModel: any): any {
    return this.postToAPI('fuelcard/', fuelCardModel);
  }

  updateFuelCard(id: number, FuelCardModel: any): any {
    return this.putToAPI('fuelcard/' + id, FuelCardModel);
  }

  deleteFuelCard(id: number): any {
    return this.deleteFromAPI('fuelcard/' + id);
  }

  // FuelType

  getAllFuelTypes(): Observable<FuelType[]> {
    return this.getFromAPI<FuelType[]>('fueltype/');
  }

  // DoorType

  getAllDoorTypes(): Observable<DoorType[]> {
    return this.getFromAPI<DoorType[]>('doortype/');
  }

  // Categorie

  getAllCategories(): Observable<Category[]> {
    return this.getFromAPI<Category[]>('category/');
  }

  // Company

  getAllCompanies(): any {
    return this.getFromAPI<Company[]>('company/').pipe(
      catchError(this.handleError)
    );
  }

  // Corporation

  getAllCorporations(): Observable<Corporation[]> {
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

  getAllAvailableDrivers(): Observable<Driver[]> {
    return this.getFromAPI<Driver[]>('driver/available');
  }

  getDriverById(id: number): Observable<Driver> {
    return this.getFromAPI<Driver>('driver/' + id);
  }

  updateDriver(id: number, driverModel: any): any {
    return this.putToAPI('driver/' + id, driverModel);
  }

  addDriver(driverModel: any): any {
    return this.postToAPI('driver/', driverModel);
  }

  deleteDriver(id: number): any {
    return this.deleteFromAPI('driver/' + id);
  }

  // Person

  getPersonById(id: number): Observable<Person> {
    return this.getFromAPI<Person>('person/' + id);
  }

  updatePerson(id: number, personModel: any): any {
    return this.putToAPI('person/' + id, personModel);
  }

  addPerson(personModel: any): any {
    return this.postToAPI('person/', personModel);
  }

  // Supplier

  getAllSuppliers(): Observable<Supplier[]> {
    return this.getFromAPI<Supplier[]>('supplier/');
  }

  getSupplierById(id: number): Observable<Supplier> {
    return this.getFromAPI<Supplier>('supplier/' + id);
  }

  addSupplier(supplierModel: any): any {
    return this.postToAPI('supplier/', supplierModel);
  }

  updateSupplier(id: number, supplierModel: any): any {
    return this.putToAPI('supplier/' + id, supplierModel);
  }

  deleteSupplier(id: number): any {
    return this.deleteFromAPI('supplier/' + id);
  }
}
