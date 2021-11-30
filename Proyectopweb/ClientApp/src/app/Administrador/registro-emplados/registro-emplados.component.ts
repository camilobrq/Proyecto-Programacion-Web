import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { Psicologo } from '../models/Psicologo';

@Component({
  selector: 'app-registro-emplados',
  templateUrl: './registro-emplados.component.html',
  styleUrls: ['./registro-emplados.component.css']
})
export class RegistroEmpladosComponent implements OnInit {
empleado:Psicologo;
empleados: Psicologo[];
  constructor(private empleadoService: EmpleadoService, private modalService: NgbModal) { }

  ngOnInit() {
    this.empleado= new Psicologo;
    this.empleado.sexo = "Sexo";
    this.empleado.tipoDocumento = "Tipo de Documento";
  }
  add(){
    this.empleado.tipoUsuario="Psicologo";
    this.empleado.estado="AC";
    this.empleadoService.post(this.empleado).subscribe(p=>{
      if(p!=null){
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Persona creada!!! :-)';
        this.empleado=p;
      }
    });
  }
}
