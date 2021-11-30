import { Component, OnInit } from '@angular/core';
import { PacienteService } from 'src/app/services/paciente.service';

import { SignalRService } from 'src/app/services/signal-r.service';
import { Paciente } from '../models/Paciente';

@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {
  searchText:string;
  personas: Paciente[];
  constructor(private personaService: PacienteService, private signalService: SignalRService) { }
  
  ngOnInit() {
    this.personaService.get().subscribe(result => {
      this.personas = result;
   });
   if(this.personas!=null)
    this.signalService.signalReceived.subscribe((paciente:Paciente)=>this.personas.push(paciente))
  }

}

