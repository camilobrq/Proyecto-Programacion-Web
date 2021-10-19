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
  cita: ApartarCitas;
  persona: Persona;
  constructor(private apartarCitasService: ApartarCitasService, private personaService: PersonaService) { 
    this.cita = new ApartarCitas;
  }

  ngOnInit() {
  
    }
   

    add(){
      this.apartarCitasService.post(this.cita).subscribe(p=>{
        if(p!=null){
          alert('Cita Apartada!');
          this.cita=p;
        }
      });
    }
}
