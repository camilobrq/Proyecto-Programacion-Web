import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Psicologo } from '../Administrador/models/Psicologo';
import { Paciente } from '../Administrador/models/Paciente';
import { tap, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmpleadoService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Psicologo[]> {
    return this.http.get<Psicologo[]>(this.baseUrl + 'api/Psicologo')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Psicologo[]>('Consulta cita', null))
      );
  }
  post(empleado: Psicologo): Observable<Psicologo> {
    return this.http.post<Psicologo>(this.baseUrl + 'api/Psicologo', empleado)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Psicologo>('Registrar cita', null))
      );
  }
}
