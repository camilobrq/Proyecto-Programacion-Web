import { Component, OnInit } from '@angular/core';
import { PacienteService } from 'src/app/services/Pacienteservice';
import { Paciente } from '../models/Paciente';

@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {
  searchText:string;
  personas: Paciente[];
  constructor(private personaService: PacienteService) { }
  
  ngOnInit() {
    this.personaService.get().subscribe(result => {
      this.personas = result;
   });
  }
}

