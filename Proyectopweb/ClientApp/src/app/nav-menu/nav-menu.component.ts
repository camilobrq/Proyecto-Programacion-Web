import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from '../Seguridad/usuario';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  currentUser:Usuario;
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService
  ) {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }

  collapse() {
    this.isExpanded = false;
  }
   logout() {
        this.authenticationService.logout();
       
      }
    
  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
