import { Component, OnInit } from '@angular/core';
//import { EvaluacionService } from 'src/app/services/evaluacion.service';
//import { TratamientoService } from 'src/app/services/tratamiento.service';
//import { Evaluacion } from '../models/evaluacion';
//import { Tratamiento } from '../models/tratamiento';

@Component({
  selector: 'app-tratamiento',
  templateUrl: './tratamiento.component.html',
  styleUrls: ['./tratamiento.component.css']
})
export class TratamientoComponent implements OnInit {
//tratamiento: Tratamiento;
//tratamientos: Tratamiento[];
  constructor(/*private tratamientoService: TratamientoService*/) { }

  ngOnInit() {
    //this.tratamiento= new Tratamiento;
  }
   
  /*
  add(){
    this.tratamientoService.post(this.tratamiento).subscribe(p=>{
      if(p!=null){
        alert('Tratamiento registrado!');
        this.tratamiento=p;
      }
      
      if(p==null){
        alert('Error al intentar guardar el tratamiento');
      }
    });
  }
*/
  
}
