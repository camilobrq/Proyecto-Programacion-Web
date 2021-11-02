import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
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
import { NavMenuClienteComponent } from './nav-menu-Cliente/nav-menu-cliente.component';
import { InstructivoComponent } from './Administrador/instructivo/instructivo.component';
import { RegistrarHistoriaClinicaComponent } from './Administrador/registrar-historia-clinica/registrar-historia-clinica.component';
import { FiltroPacientePipe } from './pipe/filtro-paciente.pipe';
import { FiltroPsicologoPipe } from './pipe/filtro-psicologo.pipe';
import { FiltroCitaPipe } from './pipe/filtro-cita.pipe';




@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
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
    
 
  
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'personaRegistro', component: PersonaRegistroComponent},
      { path: 'personaConsulta', component: PersonaConsultaComponent },
      { path: 'registroEmpleado', component: RegistroEmpladosComponent },
      { path: 'gestionCitas', component: GestionCitaComponent },
      { path: 'evaluacion', component: EvaluacionComponent },
      { path: 'tratamiento', component: TratamientoComponent },
      { path: 'consultarEmpleado', component: ConsultarEmpleadoComponent },
      { path: 'consultarCitas', component: ConsultarCitasComponent },
      { path: 'consultarEvaluacion', component: ConsultaEvaluacionComponent },
      { path: 'consultarTratamiento', component: ConsultaTratamientoComponent },
      { path: 'instructivo', component: InstructivoComponent },
      { path: 'historiaClinica', component: RegistrarHistoriaClinicaComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
