import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';

import { Paciente } from '../models/Paciente';
import { Router } from '@angular/router';
import { PacienteService } from 'src/app/services/paciente.service';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EpsService } from 'src/app/services/Eps.service';
import { Eps } from '../models/Eps';


@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {
  epses: String[];
  paciente: Paciente;
  formGroup: FormGroup;

  constructor(private pacienteService: PacienteService,
     private modalService: NgbModal,
      private router: Router,
      private formBuilder: FormBuilder,
      private epsService:EpsService
      ) {}

  ngOnInit() {
   /* this.paciente = new Paciente();
    this.paciente.tipoDocumento = "Tipo de Documento";
    this.paciente.sexo = "Sexo";*/
    this.buildForm();
    this.epsService.get().subscribe(result => {
      this.epses = result;
   });
  }
 
  
  private buildForm() {
    this.paciente = new Paciente();
    this.paciente.nombreUsuario="";
    this.paciente.contrasena="";
    this.paciente.tipoDocumento="";
    this.paciente.identificacion = '';
    this.paciente.nombre = '';
    this.paciente.apellido="";
    this.paciente.sexo = '';
    this.paciente.fechaNacimiento;
    this.paciente.telefono="";
    this.paciente.direccion="";
    this.paciente.correo="";
    this.paciente.eps="";
    this.formGroup = this.formBuilder.group({
      identificacion: [this.paciente.identificacion, Validators.required],
      nombre: [this.paciente.nombre, Validators.required],
      sexo: [this.paciente.sexo, Validators.required],
      nombreUsuario:[this.paciente.nombreUsuario, Validators.required],
      contrasena:[this.paciente.contrasena, Validators.required],
      tipoDocumento:[this.paciente.tipoDocumento, Validators.required],
      apellido:[this.paciente.apellido, Validators.required],
      fechaNacimiento:[this.paciente.fechaNacimiento, Validators.required],
      telefono:[this.paciente.telefono, Validators.required],
      direccion:[this.paciente.direccion, Validators.required],
      correo:[this.paciente.correo, Validators.required],
      eps:[this.paciente.eps, Validators.required],
    });
   
  
  }
  private ValidaSexo(control: AbstractControl) {
    const sexo = control.value;
    if (sexo.toLocaleUpperCase() !== 'M' && sexo.toLocaleUpperCase() !== 'F') {
      return { validSexo: true, messageSexo: 'Sexo No Valido' };
    }
    return null;
  }

  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }


  add() {
    this.paciente.tipoUsuario="Paciente";
    this.paciente.estado="AC";
    this.paciente = this.formGroup.value;
    this.pacienteService.post(this.paciente).subscribe(p => {
      if (p != null) {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Persona creada!!! :-)';
        this.paciente = p;
      }

    });
  }
  get control() { return this.formGroup.controls;}
  Cancelar() {
    this.router.navigate(["/login"]);
  }
    

}
