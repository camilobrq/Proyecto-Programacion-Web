import { Component, OnInit } from '@angular/core';
import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { TratamientoService } from 'src/app/services/tratamiento.service';
import { Evaluacion } from '../models/evaluacion';
import { Tratamiento } from '../models/tratamiento';
import { Router } from '@angular/router';
import { EnfermedadService } from 'src/app/services/EnfermedadService';

@Component({
  selector: 'app-tratamiento',
  templateUrl: './tratamiento.component.html',
  styleUrls: ['./tratamiento.component.css']
})
export class TratamientoComponent implements OnInit {
  tratamiento: Tratamiento;
  tratamientos: Tratamiento[];
  enfermedades: string[];
  descripciones3: string[];
  descripciones4: string[];
  codigos4: string[];
  constructor(private tratamientoService: TratamientoService, private router: Router, private enfermedadService: EnfermedadService) { }

  ngOnInit() {
    //this.tratamiento= new Tratamiento;
    this.listaCod3();
  }
  listaCod3() {
    this.enfermedadService.getListCodigo().subscribe(result => {
      this.enfermedades = result;
    });
  }
  listaCod4(){
    this.enfermedadService.getListCodigo4(this.tratamiento.codigo_3).subscribe(result => {
      this.codigos4 = result;
    });
  }
  listDescripcion3(){
    this.enfermedadService.getListDescripcion3(this.tratamiento.codigo_3).subscribe(result => {
      this.descripciones3 = result;
    });
  }
  listDescripcion4(){
    this.enfermedadService.getListDescripcion4(this.tratamiento.codigo_4).subscribe(result => {
      this.descripciones4 = result;
    });
  }
  Siguiente() {
    this.router.navigate(["/menuEmpleado/RegistrarhistoriaClinica"]);
  }

  Anterior() {
    this.router.navigate(["/menuEmpleado/Realizarevaluacion"]);
  }


  add() {
    this.tratamientoService.post(this.tratamiento).subscribe(p => {
      if (p != null) {
        alert('Tratamiento registrado!');
        this.tratamiento = p;
      }

      if (p == null) {
        alert('Error al intentar guardar el tratamiento');
      }
    });
  }


}
