import { Injectable } from '@angular/core';
import { ApartarCitas } from '../consultorio/models/apartar-citas';

@Injectable({
  providedIn: 'root'
})
export class ApartarCitasService {

  constructor() { }
  get(): ApartarCitas[] {
    return JSON.parse(localStorage.getItem('datos'));
    }
    post(apartarCita: ApartarCitas) {
    let apartarCitas: ApartarCitas[] = [];
    if (this.get() != null) {
      apartarCitas = this.get();
    }
    apartarCitas.push(apartarCita);
    localStorage.setItem('datos', JSON.stringify(apartarCitas));
    }
    
    
}
