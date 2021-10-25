import { Component, OnInit } from '@angular/core';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {
persona: Persona;
personas: Persona[];
  constructor(private personaService: PersonaService) { }

  ngOnInit() {
    this.persona= new Persona();
  }

  add(){
    this.personaService.post(this.persona).subscribe(p=>{
      if(p!=null){
        alert('Paciente Creada!');
        this.persona=p;
      }
      if(p==null){
        alert('Error al intentar guardar al paciente');
      }
    });
  }

}
