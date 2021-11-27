import { Component, OnInit } from '@angular/core';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Psicologo } from '../models/Psicologo';

@Component({
  selector: 'app-registro-emplados',
  templateUrl: './registro-emplados.component.html',
  styleUrls: ['./registro-emplados.component.css']
})
export class RegistroEmpladosComponent implements OnInit {
empleado:Psicologo;
empleados: Psicologo[];
  constructor(private empleadoService: EmpleadoService) { }

  ngOnInit() {
    this.empleado= new Psicologo;
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
