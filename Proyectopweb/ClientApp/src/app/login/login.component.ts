import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  tipousuario = "Tipo de usuario";

  constructor(private router: Router) { }

  ngOnInit() {
  }

  IngresarAdministrador(){
    this.router.navigate(["/menuAdministrador/registroEmpleado"]);
  }

  IngresarPsicologo(){
    this.router.navigate(["/menuEmpleado"]);
  }

  IngresarPaciente(){
    this.router.navigate(["/menuPaciente/AgendarCita"]);
  }

  Ingresar(){
    
    if (this.tipousuario === "Tipo de usuario"){
      alert("Seleccione un Usuario..");
   }
    
    else if (this.tipousuario === "1"){
      this.IngresarPaciente();
    }

    else if (this.tipousuario === "2"){
      this.IngresarAdministrador();
    }

    else if (this.tipousuario === "3"){
      this.IngresarPsicologo();
    }

  }

}
