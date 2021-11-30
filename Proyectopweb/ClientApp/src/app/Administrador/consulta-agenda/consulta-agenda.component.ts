import { Component, OnInit } from '@angular/core';
import { AgendaService } from 'src/app/services/Agenda.service';
import { Agenda } from '../models/Agenda';

@Component({
  selector: 'app-consulta-agenda',
  templateUrl: './consulta-agenda.component.html',
  styleUrls: ['./consulta-agenda.component.css']
})
export class ConsultaAgendaComponent implements OnInit {
  agendas: Agenda[];
  agenda: Agenda;
  constructor(private agendaService: AgendaService) { }

  ngOnInit() {
    this.agendaService.get().subscribe(result => {
      this.agendas = result;
    });
  }

}
