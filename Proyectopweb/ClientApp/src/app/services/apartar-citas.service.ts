import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { of } from 'rxjs';
import  { tap, catchError}  from  'rxjs/operators';
import { ApartarCitas } from '../Administrador/models/apartar-citas';

@Injectable({
  providedIn: 'root'
})
export class ApartarCitasService {

  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }
  

  post(apartarCitas: ApartarCitas): Observable<ApartarCitas> {
    return this.http.post<ApartarCitas>(this.baseUrl + 'api/Persona', apartarCitas).pipe(
      tap(_ => console.log("Guardó")),
      catchError(err => { console.log("Error al Guardar"); return of(apartarCitas) })
    );
  }
    
    
}
