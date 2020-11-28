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
import { VehicleDetailsComponent } from './components/vehicle-details/vehicle-details.component';
import { NewRecordItemComponent } from './components/new-record-item/new-record-item.component';
import { RecordDetailsComponent } from './components/record-details/record-details.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { ApiService } from './services/api.service';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    VehicleListComponent,
    NewVehicleItemComponent,
    RecordListComponent,
    VehicleDetailsComponent,
    NewRecordItemComponent,
    RecordDetailsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    FontAwesomeModule,
    NgxPaginationModule,
    ReactiveFormsModule,
    MDBBootstrapModule,
    HttpClientModule
  ],
  providers: [ApiService, DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
