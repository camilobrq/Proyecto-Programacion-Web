import { Component, OnInit } from '@angular/core';
import { ApartarCitasService } from 'src/app/services/apartar-citas.service';
import { ApartarCitas } from '../models/apartar-citas';

@Component({
  selector: 'app-consultar-citas',
  templateUrl: './consultar-citas.component.html',
  styleUrls: ['./consultar-citas.component.css']
})
export class ConsultarCitasComponent implements OnInit {
  citas:ApartarCitas[];
  searchText:string;
  constructor(private apartarCitasService: ApartarCitasService) { }

  ngOnInit() {
    this.get();
  }
  get(){
    this.citas=this.apartarCitasService.get();
  }

}
