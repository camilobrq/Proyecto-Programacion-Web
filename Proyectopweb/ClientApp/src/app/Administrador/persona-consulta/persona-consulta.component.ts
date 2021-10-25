import { Component, OnInit } from '@angular/core';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {
  searchText:string;
  personas: Persona[];
  constructor(private personaService: PersonaService) { }
  
  ngOnInit() {
    this.personaService.get().subscribe(result => {
      this.personas = result;
   });
  }
}

