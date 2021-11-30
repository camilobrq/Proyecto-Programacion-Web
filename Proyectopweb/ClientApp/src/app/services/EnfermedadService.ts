import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { Persona } from '../Administrador/models/persona';
import { of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';

@Injectable({
  providedIn: 'root'
})
export class EnfermedadService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  getListCodigo(): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Enfermedad/codigo3')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Consulta Enfermedad', null))
      );
  }
  getListCodigo4(codigo3: string): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Enfermedad/codigo4?='+codigo3+'%2A')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Consulta Enfermedad', null))
      );
  }
  getListDescripcion3(codigo3: string): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Enfermedad/listaDescripcion3?='+codigo3+'%2A')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Consulta Enfermedad', null))
      );
  }
  getListDescripcion4(codigo4: string): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Enfermedad/listaDescripcion4?='+codigo4+'%2A')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Consulta Enfermedad', null))
      );
  }
  
  
}
