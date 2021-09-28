import { Component, OnInit } from '@angular/core';
import { ApartarCitasService } from 'src/app/services/apartar-citas.service';
import { PersonaService } from 'src/app/services/persona.service';
import { ApartarCitas } from '../models/apartar-citas';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-gestion-cita',
  templateUrl: './gestion-cita.component.html',
  styleUrls: ['./gestion-cita.component.css']
})
export class GestionCitaComponent implements OnInit {
  citas: ApartarCitas;
  personas: Persona[];
  constructor(private apartarCitasService: ApartarCitasService, private personaService: PersonaService) { }

  ngOnInit() {
    this.citas = new ApartarCitas;
    }
    teEncontre(){
      this.personas = this.personaService.get();
      if(this.citas != null){
        for(let persona of this.personas){
          if(persona.identificacion === this.citas.identifiacionPaciente){
            return true;
          }
        }
      }
      return false;
    }

    add(){
      if(!this.teEncontre()){
        alert('Paciente no encontrado, por favor verifique que la identifiacion este escrita correctamente, si no registre al paciente primero');
      }else if(this.teEncontre()){
        alert('Cita apartada correctamente' + JSON.stringify(this.citas));
         this.apartarCitasService.post(this.citas);
      }
    }
}
