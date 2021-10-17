import { Injectable } from '@angular/core';
import { Evaluacion } from '../Administrador/models/evaluacion';


@Injectable({
  providedIn: 'root'
})
export class EvaluacionService {

  constructor() { }
  get(): Evaluacion[] {
    return JSON.parse(localStorage.getItem('datos-evaluacion'));
    }
    post(evaluacion: Evaluacion) {
    let evaluaciones: Evaluacion[] = [];
    if (this.get() != null) {
      evaluaciones = this.get();
    }
    evaluaciones.push(evaluacion);
    localStorage.setItem('datos-evaluacion', JSON.stringify(evaluaciones));
    }
    
}
