import { Component, OnInit } from '@angular/core';
import { CitaService } from 'src/app/services/apartar-citas.service';
import {Cita } from '../models/Cita';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-consultar-citas',
  templateUrl: './consultar-citas.component.html',
  styleUrls: ['./consultar-citas.component.css']
})
export class ConsultarCitasComponent implements OnInit {
  citas:Cita[];
  searchText:string;
 
  constructor(private apartarCitasService: CitaService) { }

  ngOnInit() {
    this.apartarCitasService.get().subscribe(result => {
      this.citas = result;
   });
  } 
}
