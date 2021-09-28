import { Injectable } from '@angular/core';
import { Tratamiento } from '../consultorio/models/tratamiento';

@Injectable({
  providedIn: 'root'
})
export class TratamientoService {

  constructor() { }
  get(): Tratamiento[] {
    return JSON.parse(localStorage.getItem('datos-tratamiento'));
    }
    post(tratamiento: Tratamiento) {
    let tratamientos: Tratamiento[] = [];
    if (this.get() != null) {
      tratamientos = this.get();
    }
    tratamientos.push(tratamiento);
    localStorage.setItem('datos-tratamiento', JSON.stringify(tratamientos));
    }
}
