import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Injectable} from '@angular/core';
import {FuelType} from '../models/fuel-type/fuel-type';

const BASE_API_FUELTYPES = 'https://localhost:44356/api/Fueltype';

@Injectable()
export class FueltypeService {

  constructor(private http: HttpClient) {
  }

  getAllFuelTypes(): Observable<FuelType[]> {
    return this.http.get<FuelType[]>(BASE_API_FUELTYPES).pipe(
      catchError(this.handleError)
    );
  }

  getDriverById(id: number): Observable<FuelType> {
    return this.http.get<FuelType>(BASE_API_FUELTYPES + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  addFuelType(FuelTypeModel: any): any {
    console.log(FuelTypeModel);
    return this.http.post(BASE_API_FUELTYPES, FuelTypeModel).pipe(
      catchError(this.handleError)
    );
  }

  deleteFuelType(id: string): any {
    return this.http.delete(BASE_API_FUELTYPES + '/' + id).pipe(
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
