import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AgendaService } from 'src/app/services/Agenda.service';
import { Agenda } from '../models/Agenda';

@Component({
  selector: 'app-consulta-agenda-paciente',
  templateUrl: './consulta-agenda-paciente.component.html',
  styleUrls: ['./consulta-agenda-paciente.component.css']
})
export class ConsultaAgendaPacienteComponent implements OnInit {

  agendas: Agenda[];
  agenda: Agenda;
  constructor(private agendaService: AgendaService,private router: Router) { }

  ngOnInit() {
    this.agendaService.get().subscribe(result => {
      this.agendas = result;
    });
  }
  Atras() {
    this.router.navigate(["/menuPaciente/AgendarCita"]);
  }
}
