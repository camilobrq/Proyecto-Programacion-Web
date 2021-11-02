import { Component, OnInit } from '@angular/core';
import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { Evaluacion } from '../models/evaluacion';

@Component({
  selector: 'app-consulta-evaluacion',
  templateUrl: './consulta-evaluacion.component.html',
  styleUrls: ['./consulta-evaluacion.component.css']
})
export class ConsultaEvaluacionComponent implements OnInit {
evaluaciones: Evaluacion [];
searchText:string;
  constructor(private evaluacionService: EvaluacionService) { }

  ngOnInit() {
    this.evaluacionService.get().subscribe(result => {
      this.evaluaciones = result;
   });
  }
  
}
