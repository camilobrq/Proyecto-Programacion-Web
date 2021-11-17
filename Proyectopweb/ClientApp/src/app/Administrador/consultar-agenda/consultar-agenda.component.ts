import { Component, OnInit } from '@angular/core';
import { AgendaService } from 'src/app/services/Agenda.service';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Agenda } from '../models/Agenda';
import { Empleado } from '../models/empleado';

@Component({
  selector: 'app-consultar-agenda',
  templateUrl: './consultar-agenda.component.html',
  styleUrls: ['./consultar-agenda.component.css']
})
export class ConsultarAgendaComponent implements OnInit {
  agendas: Agenda[];
  agenda: Agenda;
  empleado: Empleado;
  empleados: Empleado[];
  constructor(private agendaService: AgendaService, private empleadoService: EmpleadoService) { }

  ngOnInit() {
 
      this.agendaService.get().subscribe(result => {
        this.agendas = result;
      });

  }

}
