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
    this.empleado.sexo = "Sexo";
    this.empleado.tipoDocumento = "Tipo de Documento";
  }
  add(){
    this.empleadoService.post(this.empleado).subscribe(p=>{
      if(p!=null){
        alert('psicologo Creado!');
        this.empleado=p;
      }
      
      if(p==null){
        alert('Error al intentar guardar al paciente');
      }
    });
  }
}
