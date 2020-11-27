import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Injectable} from '@angular/core';
import {Company} from '../models/company/company';

const BASE_API_COMPANIES = 'https://localhost:44356/api/Company';

@Injectable()
export class CompanyService {

  constructor(private http: HttpClient) {
  }

  getAllCompanies(): Observable<Company[]> {
    return this.http.get<Company[]>(BASE_API_COMPANIES).pipe(
      catchError(this.handleError)
    );
  }

  getDriverById(id: number): Observable<Company> {
    return this.http.get<Company>(BASE_API_COMPANIES + '/' + id).pipe(
      catchError(this.handleError)
    );
  }

  updateCompany(id: number, updatedCompany: Company): any {
    return this.http.put(BASE_API_COMPANIES + '/' + id, updatedCompany).pipe(
      catchError(this.handleError)
    );
  }

  addCompany(CompanyModel: any): any {
    console.log(CompanyModel);
    return this.http.post(BASE_API_COMPANIES, CompanyModel).pipe(
      catchError(this.handleError)
    );
  }

  deleteCompany(id: string): any {
    return this.http.delete(BASE_API_COMPANIES + '/' + id).pipe(
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
