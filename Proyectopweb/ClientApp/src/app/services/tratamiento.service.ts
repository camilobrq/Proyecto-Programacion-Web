import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Tratamiento } from '../Administrador/models/tratamiento';
import  { tap, catchError}  from  'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TratamientoService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Tratamiento[]> {
    return this.http.get<Tratamiento[]>(this.baseUrl + 'api/Tratamiento')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<Tratamiento[]>( null))
      );
  }
  post(tratamiento: Tratamiento): Observable<Tratamiento> {
    return this.http.post<Tratamiento>(this.baseUrl + 'api/Tratamiento', tratamiento)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Tratamiento>('Registrar Tratamiento', null))
      );
  }
 
}
