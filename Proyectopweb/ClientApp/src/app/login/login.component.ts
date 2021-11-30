import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { first } from 'rxjs/operators';
import { AlertModalComponent } from '../@base/alert-modal/alert-modal.component';
import { Usuario } from '../Seguridad/usuario';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  tipousuario = "Tipo de usuario";
  usuario:Usuario;
  loginForm: FormGroup;
  returnUrl: String;
  submitted: boolean;
  loading: boolean;
  constructor(private router: Router,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private authenticationService: AuthenticationService,
    private modalService: NgbModal

  ) {
    // redirect to home if already logged in
    if (this.authenticationService.currentUserValue) {
      this.router.navigate(['/']);
    }
  }

  ngOnInit() {
 
    this.loginForm = this.formBuilder.group({
      nombreUsuario: ["", Validators.required],
      contrasena: ["", Validators.required]
    });
    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';

  }
  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }
  onSubmit() {
    console.log("aqui estoy");
    this.submitted = true;
    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }
    this.loading = true;
    this.authenticationService.login(this.f.nombreUsuario.value, this.f.contrasena.value)
      .pipe(first())
      .subscribe(
        data => {
          console.log("estoy dentro");
          //
          console.log(data.tipoUsuario);
          if(data.tipoUsuario=="Administrador")this.IngresarAdministrador();
          if(data.tipoUsuario=="Paciente")this.IngresarPaciente();
          if(data.tipoUsuario=="Psicologo")this.IngresarPsicologo();

        },
        error => {
          const modalRef = this.modalService.open(AlertModalComponent);
          modalRef.componentInstance.title = 'Acceso Denegado';
          modalRef.componentInstance.message = error.error;
          this.loading = false;
        });
  }

  IngresarAdministrador() {
    this.router.navigate(["/menuAdministrador/registroEmpleado"]);
  }

  IngresarPsicologo() {
    this.router.navigate(["/menuEmpleado"]);
  }

  IngresarPaciente() {
    this.router.navigate(["/menuPaciente/AgendarCita"]);
  }
/*
  Ingresar() {

    if (this.tipousuario === "Tipo de usuario") {
      alert("Seleccione un Usuario..");
    }

    else if (this.tipousuario === "1") {
      this.IngresarPaciente();
    }

    else if (this.tipousuario === "2") {
      this.IngresarAdministrador();
    }

    else if (this.tipousuario === "3") {
      this.IngresarPsicologo();
    }

  }*/

}
