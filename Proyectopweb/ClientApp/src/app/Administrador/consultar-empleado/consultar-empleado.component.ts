import { Component, OnInit } from '@angular/core';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Psicologo } from '../models/Psicologo';

@Component({
  selector: 'app-consultar-empleado',
  templateUrl: './consultar-empleado.component.html',
  styleUrls: ['./consultar-empleado.component.css']
})
export class ConsultarEmpleadoComponent implements OnInit {
  empleados: Psicologo[];
  searchText:string;
  constructor(private empleadoService: EmpleadoService) { }

  ngOnInit() {
    this.empleadoService.get().subscribe(result => {
      this.empleados = result;
   });
  }
}
