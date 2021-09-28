import { Injectable } from '@angular/core';
import { Empleado } from '../consultorio/models/empleado';

@Injectable({
  providedIn: 'root'
})
export class EmpleadoService {

  constructor() { }
  get(): Empleado[] {
    return JSON.parse(localStorage.getItem('datosEmpleados'));
    }
    post(empleado: Empleado) {
    let empleados: Empleado[] = [];
    if (this.get() != null) {
      empleados = this.get();
    }
    empleados.push(empleado);
    localStorage.setItem('datosEmpleados', JSON.stringify(empleados));
    }
    
}
