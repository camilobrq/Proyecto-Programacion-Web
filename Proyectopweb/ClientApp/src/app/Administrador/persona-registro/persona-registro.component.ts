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
    this.persona=new Persona;
  }
  teEncontre(){
    this.personas = this.personaService.get();
    if(this.persona != null){
      for(let persona of this.personas){
        if(persona.identificacion === this.persona.identificacion){
          return true;
        }
      }
    }
    
    return false;
  }
add(){
  if(this.teEncontre()){
    alert('ya existe un paciente con esta identifiacion.');
  }else{
    alert('El paciente ha sido registrado correctamente.' + JSON.stringify(this.persona));
    this.personaService.post(this.persona);
  }
 
 
}

}
