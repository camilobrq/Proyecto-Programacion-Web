import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { PersonaConsultaComponent } from './consultorio/persona-consulta/persona-consulta.component';
import { PersonaRegistroComponent } from './consultorio/persona-registro/persona-registro.component';
import { RegistroEmpladosComponent } from './consultorio/registro-emplados/registro-emplados.component';
import { GestionCitaComponent } from './consultorio/gestion-cita/gestion-cita.component';
import { EvaluacionComponent } from './consultorio/evaluacion/evaluacion.component';
import { TratamientoComponent } from './consultorio/tratamiento/tratamiento.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    PersonaConsultaComponent,
    PersonaRegistroComponent,
    RegistroEmpladosComponent,
    GestionCitaComponent,
    EvaluacionComponent,
    TratamientoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'personaRegistro', component: PersonaRegistroComponent},
      { path: 'personaConsulta', component: PersonaConsultaComponent },
      { path: 'registroEmpleado', component: RegistroEmpladosComponent },
      { path: 'gestionCitas', component: GestionCitaComponent },
      { path: 'evaluacion', component: EvaluacionComponent },
      { path: 'tratamiento', component: TratamientoComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
