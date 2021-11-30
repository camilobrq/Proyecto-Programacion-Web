
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PersonaConsultaComponent } from './Administrador/persona-consulta/persona-consulta.component';
import { PersonaRegistroComponent } from './Administrador/persona-registro/persona-registro.component';
import { RegistroEmpladosComponent } from './Administrador/registro-emplados/registro-emplados.component';
import { GestionCitaComponent } from './Administrador/gestion-cita/gestion-cita.component';
import { EvaluacionComponent } from './Administrador/evaluacion/evaluacion.component';
import { TratamientoComponent } from './Administrador/tratamiento/tratamiento.component';
import { ConsultarEmpleadoComponent } from './Administrador/consultar-empleado/consultar-empleado.component';
import { ConsultarCitasComponent } from './Administrador/consultar-citas/consultar-citas.component';
import { ConsultaEvaluacionComponent } from './Administrador/consulta-evaluacion/consulta-evaluacion.component';
import { ConsultaTratamientoComponent } from './Administrador/consulta-tratamiento/consulta-tratamiento.component';
import { NavMenuEmpleadoComponent } from './nav-menu-empleado/nav-menu-empleado.component';
import { NavMenuClienteComponent } from './nav-menu-cliente/nav-menu-cliente.component';
import { InstructivoComponent } from './Administrador/instructivo/instructivo.component';
import { RegistrarHistoriaClinicaComponent } from './Administrador/registrar-historia-clinica/registrar-historia-clinica.component';
import { FiltroPacientePipe } from './pipe/filtro-paciente.pipe';
import { FiltroPsicologoPipe } from './pipe/filtro-psicologo.pipe';
import { FiltroCitaPipe } from './pipe/filtro-cita.pipe';
import { LoginComponent } from './login/login.component';
import { FooterComponent } from './footer/footer.component';
import { ExamenMentalComponent } from './examen-mental/examen-mental.component';
import { AlertModalComponent } from './@base/alert-modal/alert-modal.component';
import { AgendaComponent } from './Administrador/agenda/agenda.component';
import { ConsultarAgendaComponent } from './Administrador/consultar-agenda/consultar-agenda.component';




@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    PersonaConsultaComponent,
    PersonaRegistroComponent,
    RegistroEmpladosComponent,
    GestionCitaComponent,
    EvaluacionComponent,
    TratamientoComponent,
    ConsultarEmpleadoComponent,
    ConsultarCitasComponent,
    ConsultaEvaluacionComponent,
    ConsultaTratamientoComponent,
    NavMenuEmpleadoComponent,
    NavMenuClienteComponent,
    InstructivoComponent,
    RegistrarHistoriaClinicaComponent,
    FiltroPacientePipe,
    FiltroPsicologoPipe,
    FiltroCitaPipe,
    LoginComponent,
    FooterComponent,
    ExamenMentalComponent,
    AlertModalComponent,
    AgendaComponent,
    ConsultarAgendaComponent,

  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: 'personaRegistro', component: PersonaRegistroComponent },


      {
        path: 'menuAdministrador', component: NavMenuComponent,
        children: [
          { path: 'personaConsulta', component: PersonaConsultaComponent },
          { path: 'registroEmpleado', component: RegistroEmpladosComponent },
          { path: 'consultarEmpleado', component: ConsultarEmpleadoComponent },

        ]
      },

      { path: 'instructivo', component: InstructivoComponent },

      { path: 'login', component: LoginComponent },

      {
        path: 'menuEmpleado', component: NavMenuEmpleadoComponent,
        children: [
          { path: 'Realizarevaluacion', component: EvaluacionComponent },
          { path: 'Registrartratamiento', component: TratamientoComponent },
          { path: 'RegistrarhistoriaClinica', component: RegistrarHistoriaClinicaComponent },
          { path: 'RegistrarAgenda', component: AgendaComponent },
          { path: 'ConsultarAgenda', component: ConsultarAgendaComponent },
        ]
      },

      {
        path: 'menuPaciente', component: NavMenuClienteComponent,
        children: [
          { path: 'AgendarCita', component: GestionCitaComponent },
          { path: 'consultarCitas', component: ConsultarCitasComponent },
          { path: 'consultarEvaluacion', component: ConsultaEvaluacionComponent },
          { path: 'consultarTratamiento', component: ConsultaTratamientoComponent },
          
        ]
        
      },
      { path: '', redirectTo: '/login', pathMatch: 'full' }
    ])
  ],
  entryComponents:[AlertModalComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
