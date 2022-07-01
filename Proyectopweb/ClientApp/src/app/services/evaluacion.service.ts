import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Evaluacion } from '../Administrador/models/evaluacion';
import  { tap, catchError}  from  'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EvaluacionService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Evaluacion[]> {
    return this.http.get<Evaluacion[]>(this.baseUrl + 'api/Evaluacion')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<Evaluacion[]>( null))
      );
  }
  post(evaluacion: Evaluacion): Observable<Evaluacion> {
    return this.http.post<Evaluacion>(this.baseUrl + 'api/Evaluacion', evaluacion)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Evaluacion>('Registrar Evaluacion', null))
      );
  }
 
    
}
