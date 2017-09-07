import { Component, Input } from '@angular/core';
import { Http } from '@angular/http';

@Component({
   selector: 'app-header-bar',
   templateUrl: './header-bar.component.html',
   styleUrls: ['./header-bar.component.scss']
})

export class HeaderBarComponent {
  navbarCollapsed = true;
  theme = 'dark';
  navbarStyling = `navbar-${this.theme} bg-${this.theme}`;

  constructor() {
  }
}
