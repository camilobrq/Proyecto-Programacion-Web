import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { Paciente } from '../Administrador/models/Paciente';
import { of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';

@Injectable({
  providedIn: 'root'
})
export class PacienteService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Paciente[]> {
    return this.http.get<Paciente[]>(this.baseUrl + 'api/Paciente')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<Paciente[]>(null))
      );
  }
  post(paciente: Paciente): Observable<Paciente> {
    return this.http.post<Paciente>(this.baseUrl + 'api/Paciente', paciente)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Paciente>('Registrar Paciente', null))
      );
  }
}
