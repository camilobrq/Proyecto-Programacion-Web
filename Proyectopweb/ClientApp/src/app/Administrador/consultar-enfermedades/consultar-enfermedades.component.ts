import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EnfermedadService } from 'src/app/services/Enfermedad.service';
import { Enfermedad } from '../models/Enfermedad';

@Component({
  selector: 'app-consultar-enfermedades',
  templateUrl: './consultar-enfermedades.component.html',
  styleUrls: ['./consultar-enfermedades.component.css']
})
export class ConsultarEnfermedadesComponent implements OnInit {
  enfermedades: Enfermedad[];
  searchText:string;
  constructor(private enfermedadService: EnfermedadService,private router: Router) { }

  ngOnInit() {
    this.enfermedadService.get().subscribe(result => {
      this.enfermedades = result;
   });
  }
  Atras() {
    this.router.navigate(["/menuEmpleado/RegistrarTratamiento"]);
  }

}
