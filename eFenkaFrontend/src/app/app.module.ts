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
import { HttpClientModule } from '@angular/common/http';
import { FuelcardListComponent } from './components/fuelcard-list/fuelcard-list.component';
import { FuelcardDetailsComponent } from './components/fuelcard-details/fuelcard-details.component';
import {FuelCardService} from './services/fuelcard-service';
import {DriverService} from './services/driver-service';
import {CompanyService} from './services/company-service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    VehicleListComponent,
    NewVehicleItemComponent,
    RecordListComponent,
    VehicleDetailsComponent,
    NewRecordItemComponent,
    RecordDetailsComponent,
    FuelcardListComponent,
    FuelcardDetailsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    FontAwesomeModule,
    NgxPaginationModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [VehicleService, FuelCardService, DriverService, CompanyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
