import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Empleado } from '../Administrador/models/empleado';
import { Persona } from '../Administrador/models/persona';
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
  get(): Observable<Empleado[]> {
    return this.http.get<Empleado[]>(this.baseUrl + 'api/Psicologo')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Empleado[]>('Consulta cita', null))
      );
  }
  
  post(empleado: Empleado): Observable<Empleado> {
    return this.http.post<Empleado>(this.baseUrl + 'api/Psicologo', empleado)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Empleado>('Registrar cita', null))
      );
  }
}
