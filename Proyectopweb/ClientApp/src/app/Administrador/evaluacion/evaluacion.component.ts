import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
  constructor(private evaluacionService: EvaluacionService, private router: Router) { }

  ngOnInit() {
    this.evaluacion= new Evaluacion;
  }
 
  Siguiente(){
    this.router.navigate(["/menuEmpleado/Registrartratamiento"]);
  }
 
  add(){
    this.evaluacionService.post(this.evaluacion).subscribe(p=>{
      console.log(p);
      if(p!=null){
        alert('Evaluacion Realizada!');
        this.evaluacion=p;
      }
      if(p==null){
        alert('Error al intentar guardar la evaluacion');
      }
    });
  }

}

