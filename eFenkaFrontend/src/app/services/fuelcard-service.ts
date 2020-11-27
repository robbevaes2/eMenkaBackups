import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {FuelCard} from '../models/fuel-card/fuel-card';
import {Injectable} from '@angular/core';

const BASE_API_FUELCARDS = 'https://localhost:44356/api/FuelCard';

@Injectable()
export class FuelCardService {

  constructor(private http: HttpClient) {
  }

  getAllFuelCards(): Observable<FuelCard[]> {
    return this.http.get<FuelCard[]>(BASE_API_FUELCARDS).pipe(
      catchError(this.handleError)
    );
  }

  getFuelCardById(id: number): Observable<FuelCard> {
    return this.http.get<FuelCard>(BASE_API_FUELCARDS + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  updateFuelCard(id: number, updatedFuelCard: FuelCard): any {
    return this.http.put(BASE_API_FUELCARDS + '/' + id, updatedFuelCard).pipe(
      catchError(this.handleError)
    );
  }

  addFuelCard(FuelCardModel: any): any {
    console.log(FuelCardModel);
    return this.http.post(BASE_API_FUELCARDS, FuelCardModel).pipe(
      catchError(this.handleError)
    );
  }

  deleteFuelCard(id: number): any {
    return this.http.delete(BASE_API_FUELCARDS + '/' + id).pipe(
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
