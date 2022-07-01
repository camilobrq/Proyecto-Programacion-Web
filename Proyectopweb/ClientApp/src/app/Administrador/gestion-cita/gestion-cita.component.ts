import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertModalComponent } from 'src/app/@base/alert-modal/alert-modal.component';
import { AgendaService } from 'src/app/services/Agenda.service';
import { CitaService } from 'src/app/services/apartar-citas.service';

import { Agenda } from '../models/Agenda';
import { Cita } from '../models/Cita';
import { Paciente } from '../models/Paciente';


@Component({
  selector: 'app-gestion-cita',
  templateUrl: './gestion-cita.component.html',
  styleUrls: ['./gestion-cita.component.css']
})
export class GestionCitaComponent implements OnInit {
  [x: string]: any;
  cita: Cita;
  agendaHora: string[];
  agendaNombrePsicologo: string[];
  agendaNombrePaciente: string[];
  agendaTerapia: string[];
  age: Agenda[];
  agenda: Agenda;
  persona: Paciente;
  fecha: Date;
  hora:string;
  constructor(private apartarCitasService: CitaService, private agendaService: AgendaService,private router: Router) { 
    this.cita = new Cita;
  }

    ngOnInit() {
      
     // this.verificando();
     

    }
   /* getList(){
      this.agendaService.getList().subscribe(result=>{
        console.log(result);
          this.agendas = result;  
          
      });
    }*/
    verificarTerapia(){

     console.log("ok proooo");
     var nombre= this.cita.nombre.trim();
      this.agendaService.getTerapia(nombre).subscribe(result=>{console.log("lo hice");
        this.agendaTerapia = result;  
       
     });
    }
  /*  nombrePaciente(){
      this.apartarCitasService.(this.cita.idPaciente).subscribe(result=>{

        this.agendaNombrePaciente = result;  
       
    });
    }*/
    verificandoNombre(){
      console.log("ok");
        this.agendaService.getNombre(this.cita.horaCita).subscribe(result=>{

            this.agendaNombrePsicologo = result;  
           
        });
       
    }

   verificando(){
     if(this.cita.fechaDeseada){
      this.agendaService.getHora(this.cita.fechaDeseada).subscribe(result=>{
        console.log(result);
          this.agendaHora = result;  
          
      });
     }
   }
      
   Agenda() {
    this.router.navigate(["/menuPaciente/consultarAgendaPaciente"]);
  }
    add(){
     this.cita.estado="Activa";
      this.apartarCitasService.post(this.cita).subscribe(p=>{
        console.log(p);
        if(p!=null){
      
          const messageBox = this.modalService.open(AlertModalComponent)
          messageBox.componentInstance.title = "Resultado Operación";
          messageBox.componentInstance.message = 'Cita apartada!!! :-)';
          this.cita=p;
        }
      });
    }
}