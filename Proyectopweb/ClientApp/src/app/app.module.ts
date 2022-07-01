
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
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
import { RegistrarHistoriaClinicaComponent } from './Administrador/registrar-historia-clinica/registrar-historia-clinica.component';
import { FiltroPacientePipe } from './pipe/filtro-paciente.pipe';
import { FiltroPsicologoPipe } from './pipe/filtro-psicologo.pipe';
import { FiltroCitaPipe } from './pipe/filtro-cita.pipe';
import { LoginComponent } from './login/login.component';
import { FooterComponent } from './footer/footer.component';
import { ExamenMentalComponent } from './examen-mental/examen-mental.component';
import { AlertModalComponent } from './@base/alert-modal/alert-modal.component';
import { AgendaComponent } from './Administrador/agenda/agenda.component';
import {JwtInterceptor} from './services/jwt.interceptor';
import { AuthGuard } from './services/auth.guard';
import { ConsultaAgendaComponent } from './Administrador/consulta-agenda/consulta-agenda.component';
import { ConsultarEnfermedadesComponent } from './Administrador/consultar-enfermedades/consultar-enfermedades.component';
import { FiltroPersonaPipe } from './pipe/filtro-persona.pipe';
import { FiltroEnfermedadPipe } from './pipe/filtro-enfermedad.pipe';
import { ConsultarHistoriaClinicaComponent } from './Administrador/consultar-historia-clinica/consultar-historia-clinica.component';
import { ConsultaAgendaPacienteComponent } from './Administrador/consulta-agenda-paciente/consulta-agenda-paciente.component';


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
    RegistrarHistoriaClinicaComponent,
    FiltroPacientePipe,
    FiltroPsicologoPipe,
    FiltroCitaPipe,
    LoginComponent,
    FooterComponent,
    ExamenMentalComponent,
    AlertModalComponent,
    AgendaComponent,
    ConsultaAgendaComponent,
    ConsultarEnfermedadesComponent,
    FiltroPersonaPipe,
    FiltroEnfermedadPipe,
    ConsultarHistoriaClinicaComponent,
    ConsultaAgendaPacienteComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: 'personaRegistro', component: PersonaRegistroComponent },
      

      {
        path: 'menuAdministrador', component: NavMenuComponent,canActivate: [AuthGuard],
        children: [
          { path: 'Registrartratamiento', component: TratamientoComponent },
          { path: 'personaConsulta', component: PersonaConsultaComponent },
          { path: 'registroEmpleado', component: RegistroEmpladosComponent },
          { path: 'consultarEmpleado', component: ConsultarEmpleadoComponent },

        ]
      },


      { path: 'login', component: LoginComponent },

      {
        path: 'menuEmpleado', component: NavMenuEmpleadoComponent,
        children: [
          { path: 'Realizarevaluacion', component: EvaluacionComponent },
          { path: 'RegistrarhistoriaClinica', component: RegistrarHistoriaClinicaComponent },
          { path: 'RegistrarAgenda', component: AgendaComponent },
          { path: 'ConsultarEvaluacion', component: ConsultaEvaluacionComponent },
          { path: 'RegistrarTratamiento', component: TratamientoComponent },
          { path: 'ConsultarTratamiento', component: ConsultaTratamientoComponent },
          { path: 'ConsultarAgenda', component: ConsultaAgendaComponent },
          { path: 'consultarEnfermedad', component: ConsultarEnfermedadesComponent },
          
        ]
      },

      {
        path: 'menuPaciente', component: NavMenuClienteComponent,
        children: [
          { path: 'AgendarCita', component: GestionCitaComponent },
          { path: 'consultarCitas', component: ConsultarCitasComponent },
          { path: 'consultarEvaluacion', component: ConsultaEvaluacionComponent },
          { path: 'consultarTratamiento', component: ConsultaTratamientoComponent },
          { path: 'consultarAgendaPaciente', component: ConsultaAgendaPacienteComponent },
          { path: 'consultarHistoriaClinica', component: ConsultarHistoriaClinicaComponent },
        ]
        
      },
      { path: '', redirectTo: '/login', pathMatch: 'full' }
    ])
  ],
  entryComponents:[AlertModalComponent],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },],
  bootstrap: [AppComponent]
})
export class AppModule { }
