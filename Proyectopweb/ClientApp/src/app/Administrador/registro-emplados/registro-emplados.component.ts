import { Component, OnInit } from '@angular/core';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Empleado } from '../models/empleado';

@Component({
  selector: 'app-registro-emplados',
  templateUrl: './registro-emplados.component.html',
  styleUrls: ['./registro-emplados.component.css']
})
export class RegistroEmpladosComponent implements OnInit {
empleado:Empleado;
empleados: Empleado[];
  constructor(private empleadoService: EmpleadoService) { }

  ngOnInit() {
    this.empleado= new Empleado;
  }
  teEncontre(){
    this.empleados = this.empleadoService.get();
    if(this.empleado != null){
      for(let empleado of this.empleados){
        if(empleado.identificacion == this.empleado.identificacion){
          return true;
        }
      }
    }
    return false;
  }
add(){
    if(!this.teEncontre()){
      alert('Empleado registrado correctamente'+JSON.stringify(this.empleado));
      this.empleadoService.post(this.empleado);
    }else if(this.teEncontre()){
      alert('El empleado ya se encuentra registrado.');
    }
   

  
}
}
