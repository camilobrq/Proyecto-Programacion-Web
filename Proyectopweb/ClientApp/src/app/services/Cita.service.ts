import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { of } from 'rxjs';
import  { tap, catchError}  from  'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Agenda } from '../Administrador/models/Agenda';
import { Cita } from '../Administrador/models/Cita';

@Injectable({
  providedIn: 'root'
})
export class CitaService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Cita[]> {
    return this.http.get<Cita[]>(this.baseUrl + 'api/Cita')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<Cita[]>(null))
      );
  }
  getNombre(nombre: string): Observable<string[]> {
    var nombreP=nombre.toString();
    return this.http.get<string[]>(this.baseUrl + 'api/Cita/nombrePaciente?id='+nombreP)
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Registrar cita', null))
      );
  }
  post(apartarCitas: Cita): Observable<Cita> {
    return this.http.post<Cita>(this.baseUrl + 'api/Cita', apartarCitas)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Cita>('Registrar cita', null))
      );
  }
}