import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HeaderBarComponent } from './header-bar/header-bar.component';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
   declarations: [
        HeaderBarComponent,
        AppComponent
   ],
   imports: [
      NgbModule.forRoot(),
      BrowserModule,
      FormsModule,
      HttpModule
   ],
   providers: [],
   bootstrap: [HeaderBarComponent, AppComponent]
})

export class AppModule { }
