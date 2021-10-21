import { Component, OnInit } from '@angular/core';

import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { Evaluacion } from '../models/evaluacion';


@Component({
  selector: 'app-evaluacion',
  templateUrl: './evaluacion.component.html',
  styleUrls: ['./evaluacion.component.css']
})
export class EvaluacionComponent implements OnInit {
evaluacion: Evaluacion;

evaluaciones: Evaluacion[];
  constructor(private evaluacionService: EvaluacionService) { }

  ngOnInit() {
    this.evaluacion= new Evaluacion;
  }
 

  add(){
 
    }

}

