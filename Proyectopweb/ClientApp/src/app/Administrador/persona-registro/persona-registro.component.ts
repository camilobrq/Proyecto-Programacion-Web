import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';
import { FormGroup, FormBuilder, Validators, AbstractControl } from '@angular/forms';


@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {

  persona: Persona;
  formGroup: FormGroup;

  constructor(private personaService: PersonaService, private formBuilder: FormBuilder, private modalService: NgbModal) {

  }

  ngOnInit() {
    this.buildForm();

  }

  private buildForm() {

    this.persona = new Persona();
    this.persona.tipoDocumento = "Tipo de Documento";
    this.persona.sexo = "Sexo";


    this.formGroup = this.formBuilder.group({
      sexo: [this.persona.sexo, [Validators.required], this.ValidaSexo],
    });
  }

  private ValidaSexo(control: AbstractControl) {
     const sexo = control.value;
     if (sexo.toLocaleUpperCase() !== 'Masculino' && sexo.toLocaleUpperCase() !== 'Femenino' ) {
      return { validSexo: true, messageSexo: 'Por favor seleccionar el tipo de Sexo.'};
     }
      return null;
    }
    
    onSubmit() {
          if (this.formGroup.invalid) {
            return;
          }
          this.add();
        }
      

  add() {

    this.persona = this.formGroup.value;
    this.personaService.post(this.persona).subscribe(p => {
      if (p != null) {
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Persona creada!!! :-)';
        this.persona = p;
      }

    });
  }

  get control() { 
    return this.formGroup.controls;
     }
    

}
