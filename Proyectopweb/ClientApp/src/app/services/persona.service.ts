import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import  { tap, catchError}  from  'rxjs/operators';
import { Persona } from '../Administrador/models/persona';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }
  

  post(persona: Persona): Observable<Persona> {
    return this.http.post<Persona>(this.baseUrl + 'api/Persona', persona).pipe(
      tap(_ => console.log("Guardó")),
      catchError(err => { console.log("Error al Guardar"); return of(persona) })
    );
  }
}
