import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { AgendaService } from 'src/app/services/Agenda.service';
import { Agenda } from '../models/Agenda';

@Component({
  selector: 'app-agenda',
  templateUrl: './agenda.component.html',
  styleUrls: ['./agenda.component.css']
})
export class AgendaComponent implements OnInit {
  agenda: Agenda;
  formGroup: FormGroup;
  constructor(private agendaService: AgendaService,private modalService: NgbModal, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
  }
  private buildForm() {

    this.agenda = new Agenda();
    this.agenda.idPsicologo = '';
    this.agenda.fechaDeseada ;
    this.agenda.horaCita = '';

    this.formGroup = this.formBuilder.group({
      idPsicologo: [this.agenda.idPsicologo, Validators.required],
      fechaDeseada: [this.agenda.fechaDeseada, Validators.required],
      horaCita: [this.agenda.horaCita, Validators.required],
    });
  }
  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }
  add(){
    this.agenda = this.formGroup.value;
    this.agendaService.post(this.agenda).subscribe(p=>{
      if(p!=null){
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Agenda creada!!! :-)';

        this.agenda=p;
      }
      
    });
  }
  get control() { return this.formGroup.controls;}
}
