import { Component, OnInit } from '@angular/core';
import { ApartarCitasService } from 'src/app/services/apartar-citas.service';
import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { PersonaService } from 'src/app/services/persona.service';
import { ApartarCitas } from '../models/apartar-citas';
import { Evaluacion } from '../models/evaluacion';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-evaluacion',
  templateUrl: './evaluacion.component.html',
  styleUrls: ['./evaluacion.component.css']
})
export class EvaluacionComponent implements OnInit {
evaluacion: Evaluacion;
citas: ApartarCitas[];
evaluaciones: Evaluacion[];
  constructor(private evaluacionService: EvaluacionService, private apartarcitasService: ApartarCitasService) { }

  ngOnInit() {
    this.evaluacion= new Evaluacion;
  }
  teEncontre(){
    this.citas = this.apartarcitasService.get();
    if(this.evaluacion != null){
      for(let cita of this.citas){
        if(cita.identifiacionPaciente === this.evaluacion.identifiacionPaciente){
          this.evaluacion.nombrePaciente=cita.nombrePaciente;
          this.evaluacion.tipoCita=cita.tipoCita;
      
          return true;
        }
      }
    }
    return false;
  }
 
  add(){
    if(this.teEncontre()){
      alert('Diagnostico realizado Correctamente.'+ JSON.stringify(this.evaluacion)); 
    this.evaluacionService.post(this.evaluacion);
    }else  if(!this.teEncontre()){
      alert('No ha apartado una cita debe apartar una cita para realizar el diagnostico');
    }

  }
}
