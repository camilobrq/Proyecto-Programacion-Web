import { Component, OnInit } from '@angular/core';
import { AgendaService } from 'src/app/services/Agenda.service';
import { CitaService } from 'src/app/services/apartar-citas.service';
import { PersonaService } from 'src/app/services/persona.service';
import { Agenda } from '../models/Agenda';
import { Cita } from '../models/Cita';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-gestion-cita',
  templateUrl: './gestion-cita.component.html',
  styleUrls: ['./gestion-cita.component.css']
})
export class GestionCitaComponent implements OnInit {
  cita: Cita;
  agendaHora: string[];
  agendaNombrePsicologo: string[];
  agendaNombrePaciente: string[];
  agendaTerapia: string[];
  age: Agenda[];
  agenda: Agenda;
  persona: Persona;
  fecha: Date;
  hora:string;
  constructor(private apartarCitasService: CitaService, private agendaService: AgendaService) { 
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
    nombrePaciente(){
      this.apartarCitasService.getNombre(this.cita.idPaciente).subscribe(result=>{

        this.agendaNombrePaciente = result;  
       
    });
    }
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
      
    
    add(){
     this.cita.estado="Activa";
      this.apartarCitasService.post(this.cita).subscribe(p=>{
        console.log(p);
        if(p!=null){
          alert('Cita Apartada!');
          this.cita=p;
        }
      });
    }
}
