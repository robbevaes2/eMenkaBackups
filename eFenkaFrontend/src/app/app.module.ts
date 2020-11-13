import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './app.routes';
import { FormsModule } from '@angular/forms';
import { VehicleListComponent } from './vehicle-list/vehicle-list.component';
import { VehicleService } from './services/vehicle-service';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {NgxPaginationModule} from 'ngx-pagination';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    VehicleListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    FontAwesomeModule,
    NgxPaginationModule
  ],
  providers: [VehicleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
