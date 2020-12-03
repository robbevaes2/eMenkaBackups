import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Injectable} from '@angular/core';
import {Driver} from '../models/driver/driver';

const BASE_API_DRIVERS = 'https://localhost:44356/api/Driver';

@Injectable()
export class DriverService {

  constructor(private http: HttpClient) {
  }

  getAllDrivers(): Observable<Driver[]> {
    return this.http.get<Driver[]>(BASE_API_DRIVERS).pipe(
      catchError(this.handleError)
    );
  }

  getDriverById(id: number): Observable<Driver> {
    return this.http.get<Driver>(BASE_API_DRIVERS + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  updateDriver(id: number, updatedDriver: Driver): any {
    return this.http.put(BASE_API_DRIVERS + '/' + id, updatedDriver).pipe(
      catchError(this.handleError)
    );
  }

  addDriver(DriverModel: any): any {
    console.log(DriverModel);
    return this.http.post(BASE_API_DRIVERS, DriverModel).pipe(
      catchError(this.handleError)
    );
  }

  deleteDriver(id: string): any {
    return this.http.delete(BASE_API_DRIVERS + '/' + id).pipe(
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
