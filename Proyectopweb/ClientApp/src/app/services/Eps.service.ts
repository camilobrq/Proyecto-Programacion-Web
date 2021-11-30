import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { Paciente } from '../Administrador/models/Paciente';
import { of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Eps } from '../Administrador/models/Eps';

@Injectable({
  providedIn: 'root'
})
export class EpsService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<string[]> {
    return this.http.get<string[]>(this.baseUrl + 'api/Eps')
      .pipe(
        tap(_ => this.handleErrorService),
        catchError(this.handleErrorService.handleError<string[]>('Consulta Eps', null))
      );
  }
  
}
