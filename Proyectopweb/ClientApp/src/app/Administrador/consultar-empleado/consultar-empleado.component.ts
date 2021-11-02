import { Component, OnInit } from '@angular/core';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Empleado } from '../models/empleado';

@Component({
  selector: 'app-consultar-empleado',
  templateUrl: './consultar-empleado.component.html',
  styleUrls: ['./consultar-empleado.component.css']
})
export class ConsultarEmpleadoComponent implements OnInit {
  empleados:Empleado[];
  searchText:string;
  constructor(private empleadoService: EmpleadoService) { }

  ngOnInit() {
    this.empleadoService.get().subscribe(result => {
      this.empleados = result;
   });
  }
}
