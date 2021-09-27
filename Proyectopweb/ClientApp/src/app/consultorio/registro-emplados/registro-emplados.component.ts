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
  constructor(private empleadoService: EmpleadoService) { }

  ngOnInit() {
    this.empleado= new Empleado;
  }
add(){
  alert('Empleado registrado correctamente'+JSON.stringify(this.empleado));
  this.empleadoService.post(this.empleado);
}
}
