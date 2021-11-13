import { Component, OnInit } from '@angular/core';
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
  constructor(private agendaService: AgendaService,private modalService: NgbModal) { }

  ngOnInit() {
    this.agenda= new Agenda;
  }
  add(){
    this.agendaService.post(this.agenda).subscribe(p=>{
      if(p!=null){
        const messageBox = this.modalService.open(AlertModalComponent)
        messageBox.componentInstance.title = "Resultado Operación";
        messageBox.componentInstance.message = 'Agenda creada!!! :-)';

        this.agenda=p;
      }
      
    });
  }
}
