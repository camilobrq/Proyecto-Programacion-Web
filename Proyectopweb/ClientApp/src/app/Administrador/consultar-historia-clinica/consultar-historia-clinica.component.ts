import { Component, OnInit } from '@angular/core';
import { EvaluacionService } from 'src/app/services/evaluacion.service';
import { PacienteService } from 'src/app/services/paciente.service';
import { TratamientoService } from 'src/app/services/tratamiento.service';
import { Evaluacion } from '../models/evaluacion';
import { Paciente } from '../models/Paciente';
import { Tratamiento } from '../models/tratamiento';

@Component({
  selector: 'app-consultar-historia-clinica',
  templateUrl: './consultar-historia-clinica.component.html',
  styleUrls: ['./consultar-historia-clinica.component.css']
})
export class ConsultarHistoriaClinicaComponent implements OnInit {
  personas: Paciente[];
  evaluaciones: Evaluacion [];
  tratamientos: Tratamiento[];
  searchText: string;
  constructor(private evaluacionService: EvaluacionService, private tratamientoService: TratamientoService, private pacienteService: PacienteService) { }

  ngOnInit() {

    this.pacientes();
    this.evalua();
    this.trata();
  }

  pacientes(){
    this.pacienteService.get().subscribe(result => {
      this.personas = result;
   });
  }
  evalua(){
    this.evaluacionService.get().subscribe(result => {
      this.evaluaciones = result;
   });
  }
  trata(){
    this.tratamientoService.get().subscribe(result => {
      this.tratamientos = result;
   });
  }
}
