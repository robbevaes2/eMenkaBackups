import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './app.routes';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { VehicleService } from './services/vehicle-service';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { NgxPaginationModule } from 'ngx-pagination';
import { NewVehicleItemComponent } from './components/new-vehicle-item/new-vehicle-item.component';
import { RecordListComponent } from './components/record-list/record-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    VehicleListComponent,
    NewVehicleItemComponent,
    RecordListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    FontAwesomeModule,
    NgxPaginationModule,
    ReactiveFormsModule
  ],
  providers: [VehicleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
