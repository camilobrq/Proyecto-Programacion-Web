import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import  { tap, catchError}  from  'rxjs/operators';
import { Agenda } from '../Administrador/models/Agenda';

@Injectable({
  providedIn: 'root'
})
export class AgendaService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Agenda[]> {
    return this.http.get<Agenda[]>(this.baseUrl + 'api/Agenda')
      .pipe(
        tap(_ => this.handleErrorService.log('Agenda Consultado')),
        catchError(this.handleErrorService.handleError<Agenda[]>('Consulta Agenda', null))
      );
  }
  post(agenda: Agenda): Observable<Agenda> {
    return this.http.post<Agenda>(this.baseUrl + 'api/Agenda', agenda)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Agenda>('Registrar Agenda', null))
      );
  }
 
}
