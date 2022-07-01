import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import  { tap, catchError}  from  'rxjs/operators';
import { Agenda } from '../Administrador/models/Agenda';
import { stringify } from 'querystring';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
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
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<Agenda[]>( null))
      );
  }
  getList(): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Agenda/List')
      .pipe(
        tap(_ => this.handleErrorService.log('lista Consultado')),
        catchError(this.handleErrorService.handleError<string[]>('Consulta cita', null))
      );
  }
  getHora(fechaDeseada: Date): Observable<string[]> {
    
    return this.http.get<string[]>(this.baseUrl+'api/Agenda/horaAgenda?fecha='+fechaDeseada)
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>(null))
      );
  }
  getNombre(hora: string): Observable<string[]> {
    
    let horaN=hora.split(":");
  
    return  this.http.get<string[]>(this.baseUrl+'api/Agenda/nombrePsicologo?hora='+horaN[0]+"%3A"+horaN[1]+"%3A"+horaN[2])
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>(null))
      );
  }
  getTerapia(nombrePsicologo: string): Observable<string[]> {
   var nombre=nombrePsicologo.trim();
    return  this.http.get<string[]>(this.baseUrl+'api/Agenda/TipoTerapia?nombrePsicologo='+nombre)
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>(null))
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