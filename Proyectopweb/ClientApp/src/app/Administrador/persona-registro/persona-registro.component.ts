import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { PacienteService } from 'src/app/services/PacienteService';
import { Paciente } from '../models/Paciente';
import { Router } from '@angular/router';


@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {

  paciente: Paciente;
   

  constructor(private pacienteService: PacienteService, private modalService: NgbModal, private router: Router) {

  }

  ngOnInit() {
    this.paciente = new Paciente();
    this.paciente.tipoDocumento = "Tipo de Documento";
    this.paciente.sexo = "Sexo";
  }



  add() {
    this.pacienteService.post(this.paciente).subscribe(p => {
      if (p != null) {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Persona creada!!! :-)';
        this.paciente = p;
      }

    });
  }

  Cancelar() {
    this.router.navigate(["/login"]);
  }
    

}
