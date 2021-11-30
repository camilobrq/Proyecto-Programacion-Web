import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from '../Seguridad/usuario';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-nav-menu-cliente',
  templateUrl: './nav-menu-cliente.component.html',
  styleUrls: ['./nav-menu-cliente.component.css']
})
export class NavMenuClienteComponent {

  isExpanded = false;
  currentUser:Usuario;
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService
  ) {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }
  collapse() {
    this.isExpanded = false;
  }
  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  logout() {
    this.authenticationService.logout();
    
  }


}
