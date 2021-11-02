import { Component, OnInit } from '@angular/core';
import { TratamientoService } from 'src/app/services/tratamiento.service';
import { Tratamiento } from '../models/tratamiento';

@Component({
  selector: 'app-consulta-tratamiento',
  templateUrl: './consulta-tratamiento.component.html',
  styleUrls: ['./consulta-tratamiento.component.css']
})
export class ConsultaTratamientoComponent implements OnInit {
tratamientos:Tratamiento[];
searchText:string;
  constructor(private tratamientoService: TratamientoService) { }

  ngOnInit() {
    this.tratamientoService.get().subscribe(result => {
      this.tratamientos = result;
   });
  }
}
