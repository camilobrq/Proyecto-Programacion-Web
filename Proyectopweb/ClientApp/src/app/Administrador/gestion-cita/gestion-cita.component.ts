import { Component, OnInit } from '@angular/core';
import { CitaService } from 'src/app/services/apartar-citas.service';

import { Cita } from '../models/Cita';
import { Paciente } from '../models/Paciente';

@Component({
  selector: 'app-gestion-cita',
  templateUrl: './gestion-cita.component.html',
  styleUrls: ['./gestion-cita.component.css']
})
export class GestionCitaComponent implements OnInit {
  cita: Cita;
  persona: Paciente;
  constructor(private apartarCitasService: CitaService) { 
    this.cita = new Cita;
  }

  ngOnInit() {
  
    }
    add(){
  
      this.apartarCitasService.post(this.cita).subscribe(p=>{
        console.log(p);
        if(p!=null){
          alert('Cita Apartada!');
          this.cita=p;
        }
      });
    }
}
