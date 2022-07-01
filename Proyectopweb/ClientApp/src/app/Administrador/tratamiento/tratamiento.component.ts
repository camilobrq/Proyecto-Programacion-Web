import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EnfermedadService } from 'src/app/services/Enfermedad.service';
import { TratamientoService } from 'src/app/services/tratamiento.service';
import { Tratamiento } from '../models/tratamiento';

@Component({
  selector: 'app-tratamiento',
  templateUrl: './tratamiento.component.html',
  styleUrls: ['./tratamiento.component.css']
})
export class TratamientoComponent implements OnInit {
tratamiento:Tratamiento;
codigos_3:String[];
descripciones_3:String[];
codigos_4:string[];
descripciones_4:String[];
formGroup: FormGroup;
codi:string;
  constructor(private tratamientoService: TratamientoService, private router: Router,private formBuilder: FormBuilder, private enfermedadService: EnfermedadService) { }

  ngOnInit() {
    this.enfermedadService.getListCodigo().subscribe(result => {
      this.codigos_3 = result;
   });
    this.buildForm();

  }
  Enfermedad() {
    this.router.navigate(["/menuEmpleado/consultarEnfermedad"]);
  }
  listDescripcion(){
    this.tratamiento = this.formGroup.value;
    this.enfermedadService.getListDescripcion4(this.tratamiento.codigo_4).subscribe(result => {
      this.descripciones_4 = result;
    });
  }
  listDescripcion3(){
    this.tratamiento = this.formGroup.value;
    this.enfermedadService.getListDescripcion3(this.tratamiento.codigo_3).subscribe(result => {
      this.descripciones_3 = result;
    });
  }
  listCodigo4(){
    this.tratamiento = this.formGroup.value;
    this.enfermedadService.getListCodigo4(this.tratamiento.codigo_3).subscribe(result => {
      this.codigos_4 = result;
    });
  }
  
  private buildForm() {
    this.tratamiento = new Tratamiento();
    this.tratamiento.codigo_3="";
    this.tratamiento.codigo_4="";
    this.tratamiento.descripcion_3="";
    this.tratamiento.identificacionPaciente = '';
    this.tratamiento.descripcion_4 = '';
    this.tratamiento.identificacionPsicologo="";
    this.tratamiento.medicacion = '';
    this.tratamiento.tratamientoPaso="";
    
    this.formGroup = this.formBuilder.group({
      codigo_3: [this.tratamiento.codigo_3, Validators.required],
      codigo_4: [this.tratamiento.codigo_4, Validators.required],
      descripcion_3: [this.tratamiento.descripcion_3, Validators.required],
      descripcion_4:[this.tratamiento.descripcion_4, Validators.required],
      identificacionPaciente:[this.tratamiento.identificacionPaciente, Validators.required],
      identificacionPsicologo:[this.tratamiento.identificacionPsicologo, Validators.required],
      tratamientoPaso:[this.tratamiento.tratamientoPaso, Validators.required],
      medicacion:[this.tratamiento.medicacion, Validators.required],
      
    });
   
  
  }
  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }
  add(){
    this.tratamiento = this.formGroup.value;
    this.tratamientoService.post(this.tratamiento).subscribe(p=>{
      console.log(p);
      if(p!=null){
        alert('Evaluacion Realizada!');
        this.tratamiento=p;
      }
      if(p==null){
        alert('Error al intentar guardar la evaluacion');
      }
    });
  }
  get control() { return this.formGroup.controls;}
}
