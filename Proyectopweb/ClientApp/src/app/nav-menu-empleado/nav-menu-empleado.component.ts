import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from '../Seguridad/usuario';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-nav-menu-empleado',
  templateUrl: './nav-menu-empleado.component.html',
  styleUrls: ['./nav-menu-empleado.component.css']
})
export class NavMenuEmpleadoComponent {
  isExpanded = false;

  currentUser: Usuario;
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService
  ) {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }
  collapse() {
    this.isExpanded = false;
  }
  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  logout() {
    this.authenticationService.logout();

  }


}
