import { Component, OnInit } from '@angular/core';
import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { TratamientoService } from 'src/app/services/tratamiento.service';
import { Evaluacion } from '../models/evaluacion';
import { Tratamiento } from '../models/tratamiento';

@Component({
  selector: 'app-tratamiento',
  templateUrl: './tratamiento.component.html',
  styleUrls: ['./tratamiento.component.css']
})
export class TratamientoComponent implements OnInit {
tratamiento: Tratamiento;
evaluaciones: Evaluacion[];
  constructor(private tratamientoService: TratamientoService, private evaluacionService: EvaluacionService) { }

  ngOnInit() {
    this.tratamiento= new Tratamiento;
  }
  teEncontre(){
    this.evaluaciones = this.evaluacionService.get();
    if(this.evaluaciones != null){
      for(let evaluacion of this.evaluaciones){
        if(evaluacion.identifiacionPaciente === this.tratamiento.idEvaluacion){
          this.tratamiento.evaluacion=evaluacion.diagnostico;
          return true;
        }
      }
    }
    return false;
  }
  add(){
    if(!this.teEncontre()){
      alert('no se puede resetar un tratamiento sin una previa evaluacion, por favor aparte su cita.');
    }else if(this.teEncontre()){
    alert('Tratamiento asignado Correctamente' + JSON.stringify(this.tratamiento));
    this.tratamientoService.post(this.tratamiento);
    }
  }
}
